
namespace LibraryManagement
{
    partial class formTrangChu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTrangChu));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lbClock = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.pnlSlideMenu = new System.Windows.Forms.Panel();
            this.btnChangeRule = new System.Windows.Forms.Button();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.menuReader = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.thẻĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBook = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.đầuSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuNhậpSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLendReturn = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.mượnSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop.SuspendLayout();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.menuReader.SuspendLayout();
            this.menuBook.SuspendLayout();
            this.menuLendReturn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlTop.Controls.Add(this.pnlUser);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.picLogo);
            this.pnlTop.Controls.Add(this.pnlMenu);
            this.pnlTop.Controls.Add(this.lbTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1887, 219);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.pnlUser.Controls.Add(this.lbClock);
            this.pnlUser.Location = new System.Drawing.Point(4, 255);
            this.pnlUser.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(1680, 62);
            this.pnlUser.TabIndex = 2;
            this.pnlUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUser_Paint);
            // 
            // lbClock
            // 
            this.lbClock.AutoSize = true;
            this.lbClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClock.Location = new System.Drawing.Point(21, 17);
            this.lbClock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(64, 25);
            this.lbClock.TabIndex = 4;
            this.lbClock.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(982, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = global::LibraryManagement.Properties.Resources.minimize_btn;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.Location = new System.Drawing.Point(1466, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 25);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::LibraryManagement.Properties.Resources.close_btn;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1506, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(378, 13);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(125, 112);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlMenu.Controls.Add(this.btnReport);
            this.pnlMenu.Controls.Add(this.pnlSlideMenu);
            this.pnlMenu.Controls.Add(this.btnChangeRule);
            this.pnlMenu.Controls.Add(this.btnAddReader);
            this.pnlMenu.Controls.Add(this.btnSearch);
            this.pnlMenu.Controls.Add(this.btnFind);
            this.pnlMenu.Controls.Add(this.btnAddNewBook);
            this.pnlMenu.Location = new System.Drawing.Point(4, 147);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1383, 72);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnReport.Image = global::LibraryManagement.Properties.Resources.notebook;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(1197, 4);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(207, 62);
            this.btnReport.TabIndex = 14;
            this.btnReport.Text = "Lập báo cáo";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // pnlSlideMenu
            // 
            this.pnlSlideMenu.BackColor = System.Drawing.Color.White;
            this.pnlSlideMenu.Location = new System.Drawing.Point(0, 316);
            this.pnlSlideMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSlideMenu.Name = "pnlSlideMenu";
            this.pnlSlideMenu.Size = new System.Drawing.Size(5, 62);
            this.pnlSlideMenu.TabIndex = 0;
            // 
            // btnChangeRule
            // 
            this.btnChangeRule.FlatAppearance.BorderSize = 0;
            this.btnChangeRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeRule.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnChangeRule.Image = global::LibraryManagement.Properties.Resources.key;
            this.btnChangeRule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeRule.Location = new System.Drawing.Point(961, 4);
            this.btnChangeRule.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeRule.Name = "btnChangeRule";
            this.btnChangeRule.Size = new System.Drawing.Size(209, 62);
            this.btnChangeRule.TabIndex = 13;
            this.btnChangeRule.Text = "Thay đổi quy định";
            this.btnChangeRule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeRule.UseVisualStyleBackColor = true;
            this.btnChangeRule.Click += new System.EventHandler(this.btnChangeRule_Click);
            // 
            // btnAddReader
            // 
            this.btnAddReader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddReader.FlatAppearance.BorderSize = 0;
            this.btnAddReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReader.Image = global::LibraryManagement.Properties.Resources.user_icon;
            this.btnAddReader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddReader.Location = new System.Drawing.Point(26, 4);
            this.btnAddReader.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(270, 62);
            this.btnAddReader.TabIndex = 9;
            this.btnAddReader.Text = "Quản lý độc giả";
            this.btnAddReader.UseVisualStyleBackColor = false;
            this.btnAddReader.Click += new System.EventHandler(this.btnAddReader_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Image = global::LibraryManagement.Properties.Resources.exchange;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(528, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(203, 62);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Quản lí mượn trả";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFind
            // 
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnFind.Image = global::LibraryManagement.Properties.Resources.search__1_;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(758, 4);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(176, 62);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.FlatAppearance.BorderSize = 0;
            this.btnAddNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewBook.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddNewBook.Image = global::LibraryManagement.Properties.Resources.book_alt;
            this.btnAddNewBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewBook.Location = new System.Drawing.Point(323, 4);
            this.btnAddNewBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(178, 62);
            this.btnAddNewBook.TabIndex = 10;
            this.btnAddNewBook.Text = "Quản lý sách";
            this.btnAddNewBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.BackColorChanged += new System.EventHandler(this.btnReport_Click);
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Brown;
            this.lbTitle.Location = new System.Drawing.Point(449, 39);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(596, 73);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "QUẢN LÝ THƯ VIỆN";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // menuReader
            // 
            this.menuReader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuReader.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuReader.IsMainMenu = false;
            this.menuReader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thẻĐộcGiảToolStripMenuItem,
            this.loạiĐộcGiảToolStripMenuItem,
            this.phiếuToolStripMenuItem});
            this.menuReader.MenuItemHeight = 25;
            this.menuReader.MenuItemTextColor = System.Drawing.Color.Empty;
            this.menuReader.Name = "menuReader";
            this.menuReader.PrimaryColor = System.Drawing.Color.Empty;
            this.menuReader.Size = new System.Drawing.Size(169, 76);
            // 
            // thẻĐộcGiảToolStripMenuItem
            // 
            this.thẻĐộcGiảToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.thẻĐộcGiảToolStripMenuItem.Name = "thẻĐộcGiảToolStripMenuItem";
            this.thẻĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.thẻĐộcGiảToolStripMenuItem.Text = "Thẻ độc giả";
            this.thẻĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.thẻĐộcGiảToolStripMenuItem_Click);
            // 
            // loạiĐộcGiảToolStripMenuItem
            // 
            this.loạiĐộcGiảToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.loạiĐộcGiảToolStripMenuItem.Name = "loạiĐộcGiảToolStripMenuItem";
            this.loạiĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.loạiĐộcGiảToolStripMenuItem.Text = "Loại độc giả";
            this.loạiĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.loạiĐộcGiảToolStripMenuItem_Click);
            // 
            // phiếuToolStripMenuItem
            // 
            this.phiếuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.phiếuToolStripMenuItem.Name = "phiếuToolStripMenuItem";
            this.phiếuToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.phiếuToolStripMenuItem.Text = "Phiếu thu tiền";
            this.phiếuToolStripMenuItem.Click += new System.EventHandler(this.phiếuToolStripMenuItem_Click);
            // 
            // menuBook
            // 
            this.menuBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuBook.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBook.IsMainMenu = false;
            this.menuBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đầuSáchToolStripMenuItem,
            this.tácGiảToolStripMenuItem,
            this.sáchToolStripMenuItem,
            this.phiếuNhậpSáchToolStripMenuItem,
            this.loạiSáchToolStripMenuItem});
            this.menuBook.MenuItemHeight = 25;
            this.menuBook.MenuItemTextColor = System.Drawing.Color.Empty;
            this.menuBook.Name = "menuBook";
            this.menuBook.PrimaryColor = System.Drawing.Color.Empty;
            this.menuBook.Size = new System.Drawing.Size(185, 124);
            // 
            // đầuSáchToolStripMenuItem
            // 
            this.đầuSáchToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.đầuSáchToolStripMenuItem.Name = "đầuSáchToolStripMenuItem";
            this.đầuSáchToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.đầuSáchToolStripMenuItem.Text = "Đầu sách";
            this.đầuSáchToolStripMenuItem.Click += new System.EventHandler(this.đầuSáchToolStripMenuItem_Click);
            // 
            // tácGiảToolStripMenuItem
            // 
            this.tácGiảToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tácGiảToolStripMenuItem.Name = "tácGiảToolStripMenuItem";
            this.tácGiảToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.tácGiảToolStripMenuItem.Text = "Tác giả";
            this.tácGiảToolStripMenuItem.Click += new System.EventHandler(this.tácGiảToolStripMenuItem_Click);
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.sáchToolStripMenuItem.Text = "Sách";
            this.sáchToolStripMenuItem.Click += new System.EventHandler(this.sáchToolStripMenuItem_Click);
            // 
            // phiếuNhậpSáchToolStripMenuItem
            // 
            this.phiếuNhậpSáchToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.phiếuNhậpSáchToolStripMenuItem.Name = "phiếuNhậpSáchToolStripMenuItem";
            this.phiếuNhậpSáchToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.phiếuNhậpSáchToolStripMenuItem.Text = "Phiếu nhập sách";
            this.phiếuNhậpSáchToolStripMenuItem.Click += new System.EventHandler(this.phiếuNhậpSáchToolStripMenuItem_Click);
            // 
            // loạiSáchToolStripMenuItem
            // 
            this.loạiSáchToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.loạiSáchToolStripMenuItem.Name = "loạiSáchToolStripMenuItem";
            this.loạiSáchToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.loạiSáchToolStripMenuItem.Text = "Loại Sách";
            this.loạiSáchToolStripMenuItem.Click += new System.EventHandler(this.loạiSáchToolStripMenuItem_Click);
            // 
            // menuLendReturn
            // 
            this.menuLendReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuLendReturn.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuLendReturn.IsMainMenu = false;
            this.menuLendReturn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mượnSáchToolStripMenuItem,
            this.trảSáchToolStripMenuItem});
            this.menuLendReturn.MenuItemHeight = 25;
            this.menuLendReturn.MenuItemTextColor = System.Drawing.Color.Empty;
            this.menuLendReturn.Name = "menuLendReturn";
            this.menuLendReturn.PrimaryColor = System.Drawing.Color.Empty;
            this.menuLendReturn.Size = new System.Drawing.Size(151, 52);
            // 
            // mượnSáchToolStripMenuItem
            // 
            this.mượnSáchToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mượnSáchToolStripMenuItem.Name = "mượnSáchToolStripMenuItem";
            this.mượnSáchToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.mượnSáchToolStripMenuItem.Text = "Mượn sách";
            this.mượnSáchToolStripMenuItem.Click += new System.EventHandler(this.mượnSáchToolStripMenuItem_Click);
            // 
            // trảSáchToolStripMenuItem
            // 
            this.trảSáchToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.trảSáchToolStripMenuItem.Name = "trảSáchToolStripMenuItem";
            this.trảSáchToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.trảSáchToolStripMenuItem.Text = "Trả sách";
            this.trảSáchToolStripMenuItem.Click += new System.EventHandler(this.trảSáchToolStripMenuItem_Click);
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1887, 980);
            this.ControlBox = false;
            this.Controls.Add(this.pnlTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fHome_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.menuReader.ResumeLayout(false);
            this.menuBook.ResumeLayout(false);
            this.menuLendReturn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnChangeRule;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbClock;
        private System.Windows.Forms.Timer clock;
        private CustomControls.RJControls.RJDropdownMenu menuReader;
        private CustomControls.RJControls.RJDropdownMenu menuBook;
        private CustomControls.RJControls.RJDropdownMenu menuLendReturn;
        private System.Windows.Forms.ToolStripMenuItem thẻĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đầuSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mượnSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trảSáchToolStripMenuItem;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel pnlSlideMenu;
    }
}

