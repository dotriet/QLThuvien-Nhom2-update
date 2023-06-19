﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoDesign;

namespace LibraryManagement
{
    public partial class formTrangChu : Form
    {
        #region Init Objects
        Button currentBtn;

        public static Panel pnlDesktop;
        public static Form childForm;
        #endregion

        #region Declare Necessary Functions
        #region Rounded Form Function
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
        );
        #endregion

        #region Check Internet Connection
        //Creating the extern function...  
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        //Creating a function that uses the API function...  
        public static bool IsConnectedToInternet()
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }
        #endregion

        #region Form Shadow
        //Add Shadow for App
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        #endregion

        #region Dragging Form
        //Drag Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region Fix Lag
        private void fHome_Load(object sender, EventArgs e)
        {
            CustomeMenuStyle();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            UpdateDateTime();
            clock.Start();
            thẻĐộcGiảToolStripMenuItem_Click(new object(), new EventArgs());
        }
        private void CustomeMenuStyle()
        {
            menuReader.BackColor = Color.FromArgb(96, 135, 176);
            menuLendReturn.BackColor = Color.FromArgb(96, 135, 176);
            menuBook.BackColor = Color.FromArgb(96, 135, 176);

            menuReader.Font = new System.Drawing.Font("Tahoma", 12F);
            menuLendReturn.Font = new System.Drawing.Font("Tahoma", 12F);
            menuBook.Font = new System.Drawing.Font("Tahoma", 12F);

            menuReader.PrimaryColor = Color.Thistle;
            menuLendReturn.PrimaryColor = Color.Thistle;
            menuBook.PrimaryColor = Color.Thistle;

            menuReader.MenuItemTextColor = SystemColors.ControlText;
            menuLendReturn.MenuItemTextColor = SystemColors.ControlText;
            menuBook.MenuItemTextColor = SystemColors.ControlText;

            menuReader.MenuItemHeight = 50;
            menuLendReturn.MenuItemHeight = 50;
            menuBook.MenuItemHeight = 50;
        }
        #endregion

        #endregion

        #region InitComponent & Add Menu Button Event 
        public formTrangChu()
        {
            Init();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }
        private void Init()
        {
            AddMainPanel();
            InitializeComponent();
            currentBtn = new Button();
            AddMenuButtonsEvent();
            ActiveButton(btnAddReader);
        }

        private void AddMainPanel()
        {
            pnlDesktop = new Panel();
            //pnlDesktop.Size = new System.Drawing.Size(1260, 724);
            pnlDesktop.Location = new System.Drawing.Point(200, 80);
            pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlDesktop.Name = "pnlDesktop";
            pnlDesktop.TabIndex = 2;
            pnlDesktop.BackColor = SystemColors.ActiveCaption;
            Controls.Add(pnlDesktop);
        }

        private void AddMenuButtonsEvent()
        {
            foreach(Control btn in pnlMenu.Controls)
            {
                if(btn.GetType() == typeof(Button))
                {
                    btn.Click += btnMenuClick_Event;
                    btn.MouseDown += btnMenu_MouseDown;
                    btn.MouseUp += btnMenu_MouseUp;
                }
            }
        }

        private void btnMenuClick_Event(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        #region Menu Click Zoom Animation
        private void btnMenu_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            Single sg = (btn.Name.ToString() == "btnSetting") ? 13.5F : 11.25F;
            btn.Font = new System.Drawing.Font("Tahoma", sg);
        }

        private void btnMenu_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            Single sg = (btn.Name.ToString() == "btnSetting") ? 14.25F : 12F;
            btn.Font = new System.Drawing.Font("Tahoma", sg);

        }
        #endregion

        #region Selected Menu Button Changed Animation
        private void ActiveButton(Object btnSender)
        {
            if (currentBtn != (Button)btnSender)
            {
                DeactiveButton();
                currentBtn = (Button)btnSender;
                currentBtn.BackColor = Color.Thistle;
                pnlSlideMenu.Location = new Point(0, currentBtn.Location.Y);
                pnlSlideMenu.BringToFront();

                switch (currentBtn.Name)
                {
                    case "btnLendBook":
                        {

                            break;
                        }
                    case "btnRecvBook":
                        {

                            break;
                        }
                    case "btnReport":
                        {
                            SwitchForm(new formBaoCao());
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }

        private void DeactiveButton()
        {
            foreach (Control btn in pnlMenu.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    btn.BackColor = Color.FromArgb(96, 135, 176);
                }
            }
        }
        #endregion

        #endregion

        #region Add Control Button Event
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Functions
        public static void SwitchForm(Form f)
        {
            if (childForm != null)
            {
                childForm.Close();
                pnlDesktop.Controls.Clear();
            }
            childForm = f;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            pnlDesktop.Controls.Add(childForm);
            childForm.Show();
        }

        #endregion

        private void clock_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }
        private void UpdateDateTime()
        {
            string dayOfWeek = Translate(DateTime.Now.DayOfWeek.ToString());
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            string time = DateTime.Now.ToString("HH:mm:ss");

            lbClock.Text = dayOfWeek + ", " + date + " - " + time;
        }
        private string Translate(string dayOfWeek)
        {
            string trans = "";
            string[] dayOfWeeks = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            int index = 0;
            foreach(string day in dayOfWeeks)
            {
                if(dayOfWeek == day)
                {
                    break;
                }
                index++;
            }

            switch (index)
            {
                case 0:
                    {
                        trans = "Thứ 2";
                        break;
                    }
                case 1:
                    {
                        trans = "Thứ 3";
                        break;
                    }
                case 2:
                    {
                        trans = "Thứ 4";
                        break;
                    }
                case 3:
                    {
                        trans = "Thứ 5";
                        break;
                    }
                case 4:
                    {
                        trans = "Thứ 6";
                        break;
                    }
                case 5:
                    {
                        trans = "Thứ 7";
                        break;
                    }
                case 6:
                    {
                        trans = "Chủ Nhật";
                        break;
                    }
            }

            return trans;
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            SwitchForm(new TraCuuSach.formTraCuu());
        }

        private void btnChangeRule_Click(object sender, EventArgs e)
        {
            SwitchForm(new ThayDoiQuyDinh.formThayDoiQuyDinh());
        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            menuReader.Show(btnAddReader, btnAddReader.Width, 0);
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            menuBook.Show(btnAddNewBook, btnAddNewBook.Width, 0);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            menuLendReturn.Show(btnSearch, btnSearch.Width, 0);
        }

        private void thẻĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchForm(new LibraryManage.Form1());
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchForm(new DemoDesign.formChoMuonSach());
        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchForm(new DemoDesign.formNhanTraSach());
        }

        private void đầuSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchForm(new formdausach.Form1());
        }

        private void loạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchForm(new FormLoaiSach.Form1());
        }

        private void phiếuNhậpSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchForm(new FormNhapSach.Form1());
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchForm(new FormSach.Form1());
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchForm(new FormTacGia.Form1());
        }

        private void loạiĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchForm(new FormLoaiDocGia.Form1());
        }

        private void phiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchForm(new PhieuThuTien.formThuTien());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            
        }

        private void pnlUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
