using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using LibraryManagement.Forms;
using LibraryManagement.Models;
using LibraryManagement;

namespace DemoDesign
{
    public partial class formNhanTraSach : Form
    {
        public List<DSPhieuTra> returnSlips;
        public List<TraSach> returnBooks;
        public List<TraSach> returnView;
        public List<TraSach> chosenBooks;
        BindingSource bindingReturn;
        BindingSource bindingChosen;

        List<int> selectedIndex = new List<int>();

        public static string recvState = "";
        public static bool needPrint = true;

        Thread tdGetNewSlipCode;

        string newReturnSlipCode = "";
        long fineThisPeriod = 0;
        long totalFine = 0;

        public static List<string> slipCodes;
        public static List<string> bookCodes;
        public formNhanTraSach()
        {
            InitializeComponent();
        }

        private void RecvBook_Load(object sender, EventArgs e)
        {
            returnSlips = new List<DSPhieuTra>();
            returnBooks = new List<TraSach>();
            returnView = new List<TraSach>();
            chosenBooks = new List<TraSach>();
            bindingReturn = new BindingSource();
            bindingChosen = new BindingSource();
            selectedIndex = new List<int>();
            slipCodes = new List<string>();

            returnDate.Value = DateTime.Now;

            tdGetNewSlipCode= new Thread(new ThreadStart(GetNewReturnSlipCode));

            tdGetNewSlipCode.Start();
            LoadBorrowSlip();
        }

        private void LoadBorrowSlip()
        {
            returnSlips.Clear();
            cbbSlipCode.Items.Clear();
            returnBooks.Clear();

            ThamSo.LoadParam();
            SqlConnection conn = new SqlConnection(DatabaseInfo.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(DatabaseInfo.borrowSlipQuery, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    DateTime dt = reader.GetDateTime(3);
                    string returnDate = dt.ToString("dd/MM/yyyy");
                    DSPhieuTra slip = new DSPhieuTra(reader.GetString(0), reader.GetString(1), reader.GetString(2), returnDate, ((long)reader.GetSqlMoney(4).Value).ToString());
                    slip.lateReturnDays = DateTime.Now.Subtract(dt).Days;
                    slip.fineThisPeriod = CalFineThisPeriod(slip.lateReturnDays);

                    returnSlips.Add(slip);
                    cbbSlipCode.Items.Add(slip.borrowSlipCode);
                    bool found = false;
                    foreach(string item in cbbReaderCode.Items)
                    {
                        if(slip.readerCode == item)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        cbbReaderCode.Items.Add(slip.readerCode);
                    }
                }
            }

            cmd.CommandText = DatabaseInfo.borrowedBooksQuery;
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    TraSach returnBook = new TraSach();
                    returnBook.borrowSlipCode = reader.GetString(0);
                    returnBook.bookCode = reader.GetString(1);
                    returnBook.bookName = reader.GetString(2);
                    DateTime dt = reader.GetDateTime(3);
                    returnBook.borrowDate = dt.ToString("dd/MM/yyyy");
                    returnBook.borrowedDays = Math.Abs(dt.Subtract(DateTime.Now).Days).ToString();
                    returnBook.specBookCode = reader.GetString(4);
                    returnBook.detailSlipCode = reader.GetString(5);
                    if(int.Parse(returnBook.borrowedDays) > ThamSo.maxLendDay)
                    {
                        int lateReturnDays = int.Parse(returnBook.borrowedDays) - ThamSo.maxLendDay;
                        returnBook.lateReturnDays = lateReturnDays;
                        returnBook.fine = CalFineThisPeriod(lateReturnDays);
                    }
                    returnBooks.Add(returnBook);
                }
            }

            conn.Close();

        }

        private long CalFineThisPeriod(int lateReturnDays)
        {
            long fine = ThamSo.finePerDay * lateReturnDays;
            return fine;
        }

        string readerCode = "";
        string readerName = "";
        private void cbbSlipCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            readerCode = returnSlips[cbbSlipCode.SelectedIndex].readerCode;
            readerName = returnSlips[cbbSlipCode.SelectedIndex].readerName;
            //txbReaderCode.Text = readerCode;
            txbReaderName.Text = readerName;
            txbFineThisPeriod.Text = "0";

            returnDate.Value = DateTime.ParseExact(returnSlips[cbbSlipCode.SelectedIndex].returnDate, "dd/MM/yyyy", null);
            txbTotalFine.Text = returnSlips[cbbSlipCode.SelectedIndex].totalFine;

            fineThisPeriod = 0;
            chosenBooks.Clear();

            UpdateData();
        }

        private void UpdateData()
        {
            int stt = 1;
            returnView.Clear();
            foreach(TraSach returnBook in returnBooks)
            {
                foreach(string slipCode in slipCodes)
                {
                    if (returnBook.borrowSlipCode == slipCode)
                    {
                        TraSach data = new TraSach(returnBook);
                        data.specBookCode = returnBook.specBookCode;
                        data.detailSlipCode = returnBook.detailSlipCode;
                        data.lateReturnDays = returnBook.lateReturnDays;
                        returnView.Add(data);
                        break;
                    }
                }
            }
            returnView = returnView.OrderBy(o => o.bookCode).ThenBy(o => o.bookName).ToList();

            foreach (TraSach book in returnView)
            {
                book.stt = stt;
                stt++;
            }

            bindingReturn = new BindingSource();
            bindingReturn.DataSource = returnView;
            dtgvReturnBook.DataSource = bindingReturn;

            bindingChosen = new BindingSource();
            bindingChosen.DataSource = chosenBooks;
            dtgvChosen.DataSource = bindingChosen;

            if (dtgvReturnBook.Rows.Count != 0)
            {
                dtgvReturnBook.Rows[0].Selected = false;
            }

        }

        private void txbReaderName_TextChanged(object sender, EventArgs e)
        {
            if (txbReaderName.Text != readerName)
            {
                txbReaderName.Text = readerName;
            }
        }

        private void returnDate_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void dtgvReturnBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtgvReturnBook.Rows[e.RowIndex].Selected == true)
            {
                dtgvReturnBook.Rows[e.RowIndex].Selected = false;
            }
            else
            {
                //Add just selected row to selectedIndex list if not existed
                if (e.RowIndex != -1)
                {
                    bool isExisted = false;
                    foreach (int index in selectedIndex)
                    {
                        if (index == e.RowIndex)
                        {
                            isExisted = true;
                            break;
                        }
                    }
                    if (!isExisted)
                    {
                        selectedIndex.Add(e.RowIndex);
                    }
                }
                //Hightlight the selected rows
                foreach (int index in selectedIndex)
                {
                    dtgvReturnBook.Rows[index].Selected = true;
                }
            }
        }

        private void btnChooseBook_Click(object sender, EventArgs e)
        {
            try
            {
                TraSach returnBook = new TraSach();
                returnBook.bookCode = dtgvReturnBook.SelectedRows[0].Cells[1].Value.ToString();
                returnBook.bookName =   dtgvReturnBook.SelectedRows[0].Cells[2].Value.ToString();
                returnBook.borrowDate = dtgvReturnBook.SelectedRows[0].Cells[3].Value.ToString();
                returnBook.borrowedDays = dtgvReturnBook.SelectedRows[0].Cells[4].Value.ToString();
                returnBook.fine = long.Parse(dtgvReturnBook.SelectedRows[0].Cells[5].Value.ToString());
                returnBook.specBookCode = returnView[dtgvReturnBook.SelectedRows[0].Index].specBookCode;
                returnBook.detailSlipCode = returnView[dtgvReturnBook.SelectedRows[0].Index].detailSlipCode;
                returnBook.lateReturnDays = returnView[dtgvReturnBook.SelectedRows[0].Index].lateReturnDays;

                chosenBooks.Add(returnBook);
                returnView.RemoveAt(dtgvReturnBook.SelectedRows[0].Index);

                chosenBooks = chosenBooks.OrderBy(o => o.bookCode).ThenBy(o => o.bookName).ToList();
                returnView = returnView.OrderBy(o => o.bookCode).ThenBy(o => o.bookName).ToList();

                int stt = 1;
                int totalLateReturnDays = 0;
                foreach(TraSach book in chosenBooks)
                {
                    totalLateReturnDays += book.lateReturnDays;
                    book.stt = stt;
                    stt++;
                }

                lbLateDays.Text = totalLateReturnDays.ToString();

                stt = 1;
                foreach (TraSach book in returnView)
                {
                    book.stt = stt;
                    stt++;
                }

                bindingReturn = new BindingSource();
                bindingReturn.DataSource = returnView;
                dtgvReturnBook.DataSource = bindingReturn;

                bindingChosen = new BindingSource();
                bindingChosen.DataSource = chosenBooks;
                dtgvChosen.DataSource = bindingChosen;

                if(dtgvReturnBook.Rows.Count != 0)
                {
                    dtgvReturnBook.Rows[0].Selected = false;
                }
                foreach(DataGridViewRow row in dtgvChosen.Rows)
                {
                    if (row.Cells[1].Value.ToString() == returnBook.bookCode)
                    {
                        dtgvChosen.Rows[row.Index].Selected = true;
                        break;
                    }
                }

                fineThisPeriod += returnBook.fine;
                txbFineThisPeriod.Text = fineThisPeriod.ToString();
                txbTotalFine.Text = (totalFine + fineThisPeriod).ToString();
            }
            catch
            {
                MessageBox.Show($"Vui lòng chọn 1 quyển sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUnchooseBook_Click(object sender, EventArgs e)
        {
            try
            {
                TraSach returnBook = new TraSach();
                returnBook.bookCode = dtgvChosen.SelectedRows[0].Cells[1].Value.ToString();
                returnBook.bookName = dtgvChosen.SelectedRows[0].Cells[2].Value.ToString();
                returnBook.borrowDate = dtgvChosen.SelectedRows[0].Cells[3].Value.ToString();
                returnBook.borrowedDays = dtgvChosen.SelectedRows[0].Cells[4].Value.ToString();
                returnBook.fine = long.Parse(dtgvChosen.SelectedRows[0].Cells[5].Value.ToString());
                returnBook.specBookCode = chosenBooks[dtgvChosen.SelectedRows[0].Index].specBookCode;
                returnBook.detailSlipCode = chosenBooks[dtgvChosen.SelectedRows[0].Index].detailSlipCode;
                returnBook.lateReturnDays = chosenBooks[dtgvChosen.SelectedRows[0].Index].lateReturnDays;

                returnView.Add(returnBook);
                chosenBooks.RemoveAt(dtgvChosen.SelectedRows[0].Index);

                chosenBooks = chosenBooks.OrderBy(o => o.bookCode).ThenBy(o => o.bookName).ToList();
                returnView = returnView.OrderBy(o => o.bookCode).ThenBy(o => o.bookName).ToList();

                int stt = 1;
                int totalLateReturnDays = 0;
                foreach (TraSach book in chosenBooks)
                {
                    book.stt = stt;
                    totalLateReturnDays += book.lateReturnDays;
                    stt++;
                }

                lbLateDays.Text = totalLateReturnDays.ToString();

                stt = 1;
                foreach (TraSach book in returnView)
                {
                    book.stt = stt;
                    stt++;
                }

                bindingReturn = new BindingSource();
                bindingReturn.DataSource = returnView;
                dtgvReturnBook.DataSource = bindingReturn;

                bindingChosen = new BindingSource();
                bindingChosen.DataSource = chosenBooks;
                dtgvChosen.DataSource = bindingChosen;

                if (dtgvChosen.Rows.Count != 0)
                {
                    dtgvChosen.Rows[0].Selected = false;
                }
                foreach (DataGridViewRow row in dtgvReturnBook.Rows)
                {
                    if (row.Cells[1].Value.ToString() == returnBook.bookCode)
                    {
                        dtgvReturnBook.Rows[row.Index].Selected = true;
                        break;
                    }
                }

                fineThisPeriod -= returnBook.fine;
                txbFineThisPeriod.Text = fineThisPeriod.ToString();
                txbTotalFine.Text = (totalFine + fineThisPeriod).ToString();
            }
            catch
            {
                MessageBox.Show($"Vui lòng chọn 1 quyển sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public enum Valid
        {
            MissingInfo,
            MissingBook,
            Success
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            switch (isValid())
            {
                case Valid.MissingInfo:
                    {
                        MessageBox.Show($"Vui lòng nhập mã độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                case Valid.MissingBook:
                    {
                            MessageBox.Show($"Vui lòng chọn 1 quyển sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                case Valid.Success:
                    {
                        ShowConfirmForm();
                        break;
                    }
            }
        }
        private Valid isValid()
        {
            if(cbbReaderCode.SelectedIndex == -1)
            {
                return Valid.MissingInfo;
            }
            else if(dtgvChosen.Rows.Count == 0)
            {
                return Valid.MissingBook;
            }
            return Valid.Success;
        }
        private void CreateReturnSlip()
        {
            string createReturnSlip = $@"INSERT INTO PHIEUTRASACH(MaDocGia, NgTra, TienPhatKyNay) VALUES('{cbbReaderCode.Text}', '{returnDate.Value.ToString("yyyy-MM-dd")}', {txbFineThisPeriod.Text})";
            string createReturnSlipDetail = @"";
            string setBookAndSlipDetailStatus = @"";

            foreach(TraSach book in chosenBooks)
            {
                createReturnSlipDetail += $@"INSERT INTO CTPT(MaPhieuTraSach, MaCuonSach, MaPhieuMuonSach, SoNgayMuon, TienPhat) VALUES('{newReturnSlipCode}','{book.specBookCode}','{cbbSlipCode.Text}','{book.borrowedDays}','{book.fine}')" + "\n";
                setBookAndSlipDetailStatus += $@"UPDATE CTPHIEUMUON SET TinhTrangPM = 1  WHERE MaChiTietPhieuMuon = '{book.detailSlipCode}'" + "\n" + $@"UPDATE CUONSACH SET TinhTrang = 1 WHERE MaCuonSach = '{book.specBookCode}'";
            }

            SqlConnection conn = new SqlConnection(DatabaseInfo.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(createReturnSlip, conn);
            cmd.ExecuteNonQuery();
            cmd.CommandText = createReturnSlipDetail;
            cmd.ExecuteNonQuery();
            cmd.CommandText = setBookAndSlipDetailStatus;
            cmd.ExecuteNonQuery();

        }
        private void GetNewReturnSlipCode()
        {
            string currCode = "";
            SqlConnection conn = new SqlConnection(DatabaseInfo.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(DatabaseInfo.getNewReturnSlipCode, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    currCode = reader.GetString(0);
                }
            }
            int stt = int.Parse(currCode.Substring(4, 3)) + 1;
            newReturnSlipCode = $"MPTS{stt:000}";
        }
        private void ShowConfirmForm()
        {
            tdGetNewSlipCode.Join();
            formThongTinPhieuTraSach.returnSlip = new DSPhieuTra(cbbSlipCode.Text, cbbReaderCode.Text, txbReaderName.Text, returnDate.Value.ToString("yyyy-MM-dd"), txbTotalFine.Text, txbFineThisPeriod.Text, chosenBooks);
            formThongTinPhieuTraSach.returnSlip.recvSlipCode = newReturnSlipCode;
            formThongTinPhieuTraSach.returnSlip.email = "";
            formThongTinPhieuTraSach.returnSlip.fineThisPeriod = long.Parse(txbFineThisPeriod.Text);
            

            new formThongTinPhieuTraSach().ShowDialog();
            if (recvState == "Success")
            {
                MessageBox.Show("Trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LibraryManagement.formTrangChu.SwitchForm(new formNhanTraSach());
                chosenBooks.Clear();

                btnReturn.Enabled = false;

                //bindingChosen = new BindingSource();
                //bindingChosen.DataSource = chosenBooks;
                //dtgvChosen.DataSource = bindingChosen;

                recvState = "";
                tdGetNewSlipCode = new Thread(new ThreadStart(GetNewReturnSlipCode));
                tdGetNewSlipCode.Start();

                btnCan.Enabled = false;
                txbReaderName.Text = "";
                cbbReaderCode.SelectedIndex = -1;
                cbbSlipCode.Text = "";
                LoadBorrowSlip();

                bindingReturn = new BindingSource();
                bindingReturn.DataSource = returnView;
                dtgvReturnBook.DataSource = bindingReturn;

                bindingChosen = new BindingSource();
                bindingChosen.DataSource = chosenBooks;
                dtgvChosen.DataSource = bindingChosen;
            }
        }

        private void tgBtnPrint_CheckedChanged(object sender, EventArgs e)
        {
            needPrint = (tgBtnPrint.Checked == true) ? true : false;
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            LibraryManagement.formTrangChu.SwitchForm(new formNhanTraSach());
        }

        private void LoadReaderCode()
        {

        }

        private void btnViewReturnSlip_Click(object sender, EventArgs e)
        {
            new formDanhSachPhieuTra().ShowDialog();
        }

        private void cbbReaderCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(DSPhieuTra slip in returnSlips)
            {
                if(slip.readerCode == cbbReaderCode.Text)
                {
                    readerName = slip.readerName;
                    txbReaderName.Text = slip.readerName;
                    txbFineThisPeriod.Text = "0";
                    returnDate.Value = DateTime.Now;
                    txbTotalFine.Text = slip.totalFine;
                    totalFine = long.Parse(slip.totalFine);

                    fineThisPeriod = 0;
                    chosenBooks.Clear();
                    UpdateData();
                    break;
                }
            }

            slipCodes.Clear();
            foreach (DSPhieuTra slip in returnSlips)
            {
                if(slip.readerCode == cbbReaderCode.Text)
                {
                    slipCodes.Add(slip.borrowSlipCode);
                }
            }
            UpdateData();
        }

        private void border_Click(object sender, EventArgs e)
        {

        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            formTrangChu homePage = new formTrangChu();
            homePage.Show();
        }
    }
}
