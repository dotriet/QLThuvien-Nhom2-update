namespace DemoDesign
{
    partial class formNhanTraSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.border = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbFineThisPeriod = new System.Windows.Forms.TextBox();
            this.txbTotalFine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbReaderName = new System.Windows.Forms.TextBox();
            this.lbSlipCode = new System.Windows.Forms.Label();
            this.cbbSlipCode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbLateDays = new System.Windows.Forms.Label();
            this.dtgvReturnBook = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fine1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvChosen = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbReaderCode = new System.Windows.Forms.ComboBox();
            this.btnCan = new LibraryManagement.nButton();
            this.tgBtnPrint = new CustomControls.RJControls.ToggleButton();
            this.btnUnchooseBook = new LibraryManagement.nButton();
            this.btnChooseBook = new LibraryManagement.nButton();
            this.btnViewReturnSlip = new LibraryManagement.nButton();
            this.btnReturn = new LibraryManagement.nButton();
            this.vbButton2 = new CustomButton.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReturnBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChosen)).BeginInit();
            this.SuspendLayout();
            // 
            // returnDate
            // 
            this.returnDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDate.CustomFormat = "dd/MM/yyyy";
            this.returnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.returnDate.Location = new System.Drawing.Point(868, 219);
            this.returnDate.Margin = new System.Windows.Forms.Padding(4);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(164, 30);
            this.returnDate.TabIndex = 38;
            this.returnDate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.returnDate_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(764, 225);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "Ngày trả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(92, 277);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tên độc giả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(99, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mã độc giả:";
            // 
            // border
            // 
            this.border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.border.Location = new System.Drawing.Point(16, 111);
            this.border.Margin = new System.Windows.Forms.Padding(4);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(1647, 268);
            this.border.TabIndex = 21;
            this.border.TabStop = false;
            this.border.Click += new System.EventHandler(this.border_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.Brown;
            this.label9.Location = new System.Drawing.Point(1167, 218);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 25);
            this.label9.TabIndex = 42;
            this.label9.Text = "Tiền phạt kỳ này:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.Color.Brown;
            this.label10.Location = new System.Drawing.Point(1241, 277);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 25);
            this.label10.TabIndex = 43;
            this.label10.Text = "Tổng nợ:";
            // 
            // txbFineThisPeriod
            // 
            this.txbFineThisPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbFineThisPeriod.Location = new System.Drawing.Point(1372, 218);
            this.txbFineThisPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.txbFineThisPeriod.Name = "txbFineThisPeriod";
            this.txbFineThisPeriod.Size = new System.Drawing.Size(159, 30);
            this.txbFineThisPeriod.TabIndex = 44;
            this.txbFineThisPeriod.Text = "0";
            // 
            // txbTotalFine
            // 
            this.txbTotalFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbTotalFine.Location = new System.Drawing.Point(1372, 273);
            this.txbTotalFine.Margin = new System.Windows.Forms.Padding(4);
            this.txbTotalFine.Name = "txbTotalFine";
            this.txbTotalFine.Size = new System.Drawing.Size(159, 30);
            this.txbTotalFine.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(296, 412);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 36);
            this.label3.TabIndex = 46;
            this.label3.Text = "Sách đã mượn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(28, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 50);
            this.label4.TabIndex = 47;
            this.label4.Text = "Nhận trả sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(79, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nhập thông tin";
            // 
            // txbReaderName
            // 
            this.txbReaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbReaderName.Location = new System.Drawing.Point(272, 273);
            this.txbReaderName.Margin = new System.Windows.Forms.Padding(4);
            this.txbReaderName.Name = "txbReaderName";
            this.txbReaderName.Size = new System.Drawing.Size(299, 30);
            this.txbReaderName.TabIndex = 52;
            this.txbReaderName.TextChanged += new System.EventHandler(this.txbReaderName_TextChanged);
            // 
            // lbSlipCode
            // 
            this.lbSlipCode.AutoSize = true;
            this.lbSlipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbSlipCode.ForeColor = System.Drawing.Color.Brown;
            this.lbSlipCode.Location = new System.Drawing.Point(56, 167);
            this.lbSlipCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSlipCode.Name = "lbSlipCode";
            this.lbSlipCode.Size = new System.Drawing.Size(153, 25);
            this.lbSlipCode.TabIndex = 53;
            this.lbSlipCode.Text = "Mã phiếu mượn:";
            this.lbSlipCode.Visible = false;
            // 
            // cbbSlipCode
            // 
            this.cbbSlipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbSlipCode.FormattingEnabled = true;
            this.cbbSlipCode.Location = new System.Drawing.Point(272, 164);
            this.cbbSlipCode.Margin = new System.Windows.Forms.Padding(4);
            this.cbbSlipCode.Name = "cbbSlipCode";
            this.cbbSlipCode.Size = new System.Drawing.Size(160, 33);
            this.cbbSlipCode.TabIndex = 54;
            this.cbbSlipCode.Visible = false;
            this.cbbSlipCode.SelectedIndexChanged += new System.EventHandler(this.cbbSlipCode_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(655, 277);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 25);
            this.label7.TabIndex = 55;
            this.label7.Text = "Tổng số ngày trả trễ:";
            // 
            // lbLateDays
            // 
            this.lbLateDays.AutoSize = true;
            this.lbLateDays.BackColor = System.Drawing.Color.Transparent;
            this.lbLateDays.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLateDays.ForeColor = System.Drawing.Color.Black;
            this.lbLateDays.Location = new System.Drawing.Point(868, 273);
            this.lbLateDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLateDays.Name = "lbLateDays";
            this.lbLateDays.Size = new System.Drawing.Size(26, 29);
            this.lbLateDays.TabIndex = 56;
            this.lbLateDays.Text = "0";
            // 
            // dtgvReturnBook
            // 
            this.dtgvReturnBook.AllowUserToAddRows = false;
            this.dtgvReturnBook.AllowUserToDeleteRows = false;
            this.dtgvReturnBook.AllowUserToResizeRows = false;
            this.dtgvReturnBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvReturnBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvReturnBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReturnBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.fine1});
            this.dtgvReturnBook.EnableHeadersVisualStyles = false;
            this.dtgvReturnBook.Location = new System.Drawing.Point(37, 469);
            this.dtgvReturnBook.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvReturnBook.MultiSelect = false;
            this.dtgvReturnBook.Name = "dtgvReturnBook";
            this.dtgvReturnBook.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvReturnBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvReturnBook.RowHeadersVisible = false;
            this.dtgvReturnBook.RowHeadersWidth = 40;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvReturnBook.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvReturnBook.RowTemplate.Height = 26;
            this.dtgvReturnBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvReturnBook.Size = new System.Drawing.Size(745, 379);
            this.dtgvReturnBook.TabIndex = 57;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "stt";
            this.dataGridViewTextBoxColumn6.HeaderText = "STT";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 40;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "bookCode";
            this.dataGridViewTextBoxColumn7.HeaderText = "Mã sách";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "bookName";
            this.dataGridViewTextBoxColumn8.HeaderText = "Tên sách";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 120;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "borrowDate";
            this.dataGridViewTextBoxColumn9.HeaderText = "Ngày mượn";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 120;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "borrowedDays";
            this.dataGridViewTextBoxColumn10.HeaderText = "Số ngày mượn";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // fine1
            // 
            this.fine1.DataPropertyName = "fine";
            this.fine1.HeaderText = "Tiền phạt";
            this.fine1.MinimumWidth = 6;
            this.fine1.Name = "fine1";
            this.fine1.ReadOnly = true;
            this.fine1.Width = 76;
            // 
            // dtgvChosen
            // 
            this.dtgvChosen.AllowUserToAddRows = false;
            this.dtgvChosen.AllowUserToDeleteRows = false;
            this.dtgvChosen.AllowUserToResizeRows = false;
            this.dtgvChosen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvChosen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvChosen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChosen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn11});
            this.dtgvChosen.EnableHeadersVisualStyles = false;
            this.dtgvChosen.Location = new System.Drawing.Point(901, 469);
            this.dtgvChosen.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvChosen.MultiSelect = false;
            this.dtgvChosen.Name = "dtgvChosen";
            this.dtgvChosen.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvChosen.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvChosen.RowHeadersVisible = false;
            this.dtgvChosen.RowHeadersWidth = 40;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvChosen.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvChosen.RowTemplate.Height = 26;
            this.dtgvChosen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChosen.Size = new System.Drawing.Size(745, 379);
            this.dtgvChosen.TabIndex = 58;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "stt";
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "bookCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã sách";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "bookName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên sách";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "borrowDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ngày mượn";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "borrowedDays";
            this.dataGridViewTextBoxColumn5.HeaderText = "Số ngày mượn";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "fine";
            this.dataGridViewTextBoxColumn11.HeaderText = "Tiền phạt";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 76;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(1173, 412);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 36);
            this.label11.TabIndex = 62;
            this.label11.Text = "Sách đã chọn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Brown;
            this.label12.Location = new System.Drawing.Point(1429, 337);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 25);
            this.label12.TabIndex = 64;
            this.label12.Text = "In phiếu mượn";
            // 
            // cbbReaderCode
            // 
            this.cbbReaderCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbReaderCode.FormattingEnabled = true;
            this.cbbReaderCode.Location = new System.Drawing.Point(272, 214);
            this.cbbReaderCode.Margin = new System.Windows.Forms.Padding(4);
            this.cbbReaderCode.Name = "cbbReaderCode";
            this.cbbReaderCode.Size = new System.Drawing.Size(208, 33);
            this.cbbReaderCode.TabIndex = 69;
            this.cbbReaderCode.SelectedIndexChanged += new System.EventHandler(this.cbbReaderCode_SelectedIndexChanged);
            // 
            // btnCan
            // 
            this.btnCan.BackColor = System.Drawing.Color.LightCoral;
            this.btnCan.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btnCan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCan.BorderRadius = 12;
            this.btnCan.BorderSize = 0;
            this.btnCan.FlatAppearance.BorderSize = 0;
            this.btnCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCan.ForeColor = System.Drawing.Color.White;
            this.btnCan.Location = new System.Drawing.Point(1488, 33);
            this.btnCan.Margin = new System.Windows.Forms.Padding(4);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(164, 49);
            this.btnCan.TabIndex = 65;
            this.btnCan.Text = "Làm mới";
            this.btnCan.TextColor = System.Drawing.Color.White;
            this.btnCan.UseVisualStyleBackColor = false;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // tgBtnPrint
            // 
            this.tgBtnPrint.AutoSize = true;
            this.tgBtnPrint.Checked = true;
            this.tgBtnPrint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tgBtnPrint.Location = new System.Drawing.Point(1577, 336);
            this.tgBtnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.tgBtnPrint.MinimumSize = new System.Drawing.Size(60, 27);
            this.tgBtnPrint.Name = "tgBtnPrint";
            this.tgBtnPrint.OffBackColor = System.Drawing.Color.Gray;
            this.tgBtnPrint.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgBtnPrint.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tgBtnPrint.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgBtnPrint.Size = new System.Drawing.Size(60, 27);
            this.tgBtnPrint.TabIndex = 63;
            this.tgBtnPrint.UseVisualStyleBackColor = true;
            this.tgBtnPrint.CheckedChanged += new System.EventHandler(this.tgBtnPrint_CheckedChanged);
            // 
            // btnUnchooseBook
            // 
            this.btnUnchooseBook.BackColor = System.Drawing.Color.LightCoral;
            this.btnUnchooseBook.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btnUnchooseBook.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUnchooseBook.BorderRadius = 20;
            this.btnUnchooseBook.BorderSize = 0;
            this.btnUnchooseBook.FlatAppearance.BorderSize = 0;
            this.btnUnchooseBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnchooseBook.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnUnchooseBook.ForeColor = System.Drawing.Color.White;
            this.btnUnchooseBook.Location = new System.Drawing.Point(789, 673);
            this.btnUnchooseBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUnchooseBook.Name = "btnUnchooseBook";
            this.btnUnchooseBook.Size = new System.Drawing.Size(107, 52);
            this.btnUnchooseBook.TabIndex = 61;
            this.btnUnchooseBook.Text = "<- Bỏ";
            this.btnUnchooseBook.TextColor = System.Drawing.Color.White;
            this.btnUnchooseBook.UseVisualStyleBackColor = false;
            this.btnUnchooseBook.Click += new System.EventHandler(this.btnUnchooseBook_Click);
            // 
            // btnChooseBook
            // 
            this.btnChooseBook.BackColor = System.Drawing.Color.YellowGreen;
            this.btnChooseBook.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btnChooseBook.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChooseBook.BorderRadius = 20;
            this.btnChooseBook.BorderSize = 0;
            this.btnChooseBook.FlatAppearance.BorderSize = 0;
            this.btnChooseBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseBook.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnChooseBook.ForeColor = System.Drawing.Color.White;
            this.btnChooseBook.Location = new System.Drawing.Point(789, 609);
            this.btnChooseBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChooseBook.Name = "btnChooseBook";
            this.btnChooseBook.Size = new System.Drawing.Size(107, 52);
            this.btnChooseBook.TabIndex = 60;
            this.btnChooseBook.Text = "Thêm ->";
            this.btnChooseBook.TextColor = System.Drawing.Color.White;
            this.btnChooseBook.UseVisualStyleBackColor = false;
            this.btnChooseBook.Click += new System.EventHandler(this.btnChooseBook_Click);
            // 
            // btnViewReturnSlip
            // 
            this.btnViewReturnSlip.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnViewReturnSlip.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.btnViewReturnSlip.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnViewReturnSlip.BorderRadius = 12;
            this.btnViewReturnSlip.BorderSize = 0;
            this.btnViewReturnSlip.FlatAppearance.BorderSize = 0;
            this.btnViewReturnSlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReturnSlip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewReturnSlip.ForeColor = System.Drawing.Color.White;
            this.btnViewReturnSlip.Location = new System.Drawing.Point(1112, 33);
            this.btnViewReturnSlip.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewReturnSlip.Name = "btnViewReturnSlip";
            this.btnViewReturnSlip.Size = new System.Drawing.Size(176, 49);
            this.btnViewReturnSlip.TabIndex = 59;
            this.btnViewReturnSlip.Text = "Xem phiếu trả";
            this.btnViewReturnSlip.TextColor = System.Drawing.Color.White;
            this.btnViewReturnSlip.UseVisualStyleBackColor = false;
            this.btnViewReturnSlip.Click += new System.EventHandler(this.btnViewReturnSlip_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.YellowGreen;
            this.btnReturn.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btnReturn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReturn.BorderRadius = 12;
            this.btnReturn.BorderSize = 0;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(1307, 33);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(164, 49);
            this.btnReturn.TabIndex = 49;
            this.btnReturn.Text = "Trả sách";
            this.btnReturn.TextColor = System.Drawing.Color.White;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // vbButton2
            // 
            this.vbButton2.AccessibleName = "BtThemmoi";
            this.vbButton2.BackColor = System.Drawing.Color.Navy;
            this.vbButton2.BackgroundColor = System.Drawing.Color.Navy;
            this.vbButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton2.BorderRadius = 20;
            this.vbButton2.BorderSize = 0;
            this.vbButton2.FlatAppearance.BorderSize = 0;
            this.vbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.vbButton2.ForeColor = System.Drawing.Color.White;
            this.vbButton2.Location = new System.Drawing.Point(901, 44);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(175, 38);
            this.vbButton2.TabIndex = 70;
            this.vbButton2.Text = "Trang chủ";
            this.vbButton2.TextColor = System.Drawing.Color.White;
            this.vbButton2.UseVisualStyleBackColor = false;
            this.vbButton2.Click += new System.EventHandler(this.vbButton2_Click);
            // 
            // RecvBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1680, 891);
            this.Controls.Add(this.vbButton2);
            this.Controls.Add(this.cbbReaderCode);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tgBtnPrint);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnUnchooseBook);
            this.Controls.Add(this.btnChooseBook);
            this.Controls.Add(this.btnViewReturnSlip);
            this.Controls.Add(this.dtgvChosen);
            this.Controls.Add(this.dtgvReturnBook);
            this.Controls.Add(this.lbLateDays);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbSlipCode);
            this.Controls.Add(this.lbSlipCode);
            this.Controls.Add(this.txbReaderName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbTotalFine);
            this.Controls.Add(this.txbFineThisPeriod);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.border);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RecvBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.RecvBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReturnBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChosen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox border;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbFineThisPeriod;
        private System.Windows.Forms.TextBox txbTotalFine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private LibraryManagement.nButton btnReturn;
        private System.Windows.Forms.TextBox txbReaderName;
        private System.Windows.Forms.Label lbSlipCode;
        private System.Windows.Forms.ComboBox cbbSlipCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbLateDays;
        private System.Windows.Forms.DataGridView dtgvReturnBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn fine1;
        private System.Windows.Forms.DataGridView dtgvChosen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private LibraryManagement.nButton btnViewReturnSlip;
        private LibraryManagement.nButton btnUnchooseBook;
        private LibraryManagement.nButton btnChooseBook;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private CustomControls.RJControls.ToggleButton tgBtnPrint;
        private LibraryManagement.nButton btnCan;
        private System.Windows.Forms.ComboBox cbbReaderCode;
        private CustomButton.VBButton vbButton2;
    }
}