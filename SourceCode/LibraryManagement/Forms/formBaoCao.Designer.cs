namespace DemoDesign
{
    partial class formBaoCao
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
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbTotalBorrowTitle = new System.Windows.Forms.Label();
            this.lbTitleName = new System.Windows.Forms.Label();
            this.lbTotalBorrow = new System.Windows.Forms.Label();
            this.cbbReportType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExport = new LibraryManagement.nButton();
            this.lbInform = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.AllowUserToResizeRows = false;
            this.dtgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.kind,
            this.lendCount,
            this.rate});
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.Location = new System.Drawing.Point(52, 290);
            this.dtgv.Margin = new System.Windows.Forms.Padding(4);
            this.dtgv.MultiSelect = false;
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 40;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv.RowTemplate.Height = 32;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(1583, 513);
            this.dtgv.TabIndex = 58;
            // 
            // col1
            // 
            this.col1.DataPropertyName = "stt";
            this.col1.HeaderText = "STT";
            this.col1.MinimumWidth = 6;
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            this.col1.Width = 80;
            // 
            // kind
            // 
            this.kind.HeaderText = "Tên thể loại";
            this.kind.MinimumWidth = 6;
            this.kind.Name = "kind";
            this.kind.ReadOnly = true;
            this.kind.Width = 650;
            // 
            // lendCount
            // 
            this.lendCount.HeaderText = "Số lượt mượn";
            this.lendCount.MinimumWidth = 6;
            this.lendCount.Name = "lendCount";
            this.lendCount.ReadOnly = true;
            this.lendCount.Width = 224;
            // 
            // rate
            // 
            this.rate.HeaderText = "Tỷ lệ";
            this.rate.MinimumWidth = 6;
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            this.rate.Width = 230;
            // 
            // dtp
            // 
            this.dtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.CustomFormat = "MM/yyyy";
            this.dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(247, 165);
            this.dtp.Margin = new System.Windows.Forms.Padding(4);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(187, 37);
            this.dtp.TabIndex = 57;
            this.dtp.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 36);
            this.label2.TabIndex = 52;
            this.label2.Text = "Thời gian:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.Brown;
            this.lbTitle.Location = new System.Drawing.Point(660, 30);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(341, 50);
            this.lbTitle.TabIndex = 49;
            this.lbTitle.Text = "Báo Cáo Thống Kê\r\n";
            // 
            // lbTotalBorrowTitle
            // 
            this.lbTotalBorrowTitle.AutoSize = true;
            this.lbTotalBorrowTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalBorrowTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lbTotalBorrowTitle.Location = new System.Drawing.Point(1159, 827);
            this.lbTotalBorrowTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalBorrowTitle.Name = "lbTotalBorrowTitle";
            this.lbTotalBorrowTitle.Size = new System.Drawing.Size(352, 41);
            this.lbTotalBorrowTitle.TabIndex = 59;
            this.lbTotalBorrowTitle.Text = "Tổng số lượt mượn:";
            // 
            // lbTitleName
            // 
            this.lbTitleName.AutoSize = true;
            this.lbTitleName.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold);
            this.lbTitleName.ForeColor = System.Drawing.Color.Brown;
            this.lbTitleName.Location = new System.Drawing.Point(380, 226);
            this.lbTitleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitleName.Name = "lbTitleName";
            this.lbTitleName.Size = new System.Drawing.Size(850, 45);
            this.lbTitleName.TabIndex = 60;
            this.lbTitleName.Text = "Tình Hình Mượn Sách Theo Thể Loại Tháng 6";
            // 
            // lbTotalBorrow
            // 
            this.lbTotalBorrow.AutoSize = true;
            this.lbTotalBorrow.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalBorrow.ForeColor = System.Drawing.Color.Indigo;
            this.lbTotalBorrow.Location = new System.Drawing.Point(1520, 827);
            this.lbTotalBorrow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalBorrow.Name = "lbTotalBorrow";
            this.lbTotalBorrow.Size = new System.Drawing.Size(62, 41);
            this.lbTotalBorrow.TabIndex = 61;
            this.lbTotalBorrow.Text = "12";
            // 
            // cbbReportType
            // 
            this.cbbReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbReportType.FormattingEnabled = true;
            this.cbbReportType.Items.AddRange(new object[] {
            "Tình Hình Mượn Sách Theo Thể Loại",
            "Sách Trả Trễ"});
            this.cbbReportType.Location = new System.Drawing.Point(247, 103);
            this.cbbReportType.Margin = new System.Windows.Forms.Padding(4);
            this.cbbReportType.Name = "cbbReportType";
            this.cbbReportType.Size = new System.Drawing.Size(380, 33);
            this.cbbReportType.TabIndex = 62;
            this.cbbReportType.SelectedIndexChanged += new System.EventHandler(this.cbbReportType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 36);
            this.label6.TabIndex = 63;
            this.label6.Text = "Loại báo cáo:\r\n";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExport.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.btnExport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExport.BorderRadius = 20;
            this.btnExport.BorderSize = 0;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1423, 59);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(179, 60);
            this.btnExport.TabIndex = 64;
            this.btnExport.Text = "Xuất báo cáo";
            this.btnExport.TextColor = System.Drawing.Color.White;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lbInform
            // 
            this.lbInform.AutoSize = true;
            this.lbInform.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInform.Location = new System.Drawing.Point(747, 522);
            this.lbInform.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInform.Name = "lbInform";
            this.lbInform.Size = new System.Drawing.Size(220, 54);
            this.lbInform.TabIndex = 65;
            this.lbInform.Text = "Không có";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1680, 891);
            this.Controls.Add(this.lbInform);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.cbbReportType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbTotalBorrow);
            this.Controls.Add(this.lbTitleName);
            this.Controls.Add(this.lbTotalBorrowTitle);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbTotalBorrowTitle;
        private System.Windows.Forms.Label lbTitleName;
        private System.Windows.Forms.Label lbTotalBorrow;
        private System.Windows.Forms.ComboBox cbbReportType;
        private System.Windows.Forms.Label label6;
        private LibraryManagement.nButton btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kind;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.Label lbInform;
    }
}