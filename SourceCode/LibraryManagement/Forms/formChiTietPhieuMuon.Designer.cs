﻿namespace LibraryManagement.Forms
{
    partial class formChiTietPhieuMuon
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSpecCode = new System.Windows.Forms.Panel();
            this.lbSpecCode = new System.Windows.Forms.Label();
            this.lbBookCode = new System.Windows.Forms.Label();
            this.pnlBookCode = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lbSlipCode = new System.Windows.Forms.Label();
            this.pnlSlipCode = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new LibraryManagement.nButton();
            this.btnDelete = new LibraryManagement.nButton();
            this.btnUpdate = new LibraryManagement.nButton();
            this.nButton1 = new LibraryManagement.nButton();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1333, 31);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(84)))), ((int)(((byte)(131)))));
            this.btnMinimize.BackgroundImage = global::LibraryManagement.Properties.Resources.minimize_btn;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.Location = new System.Drawing.Point(1809, 2);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 25);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(84)))), ((int)(((byte)(131)))));
            this.btnClose.BackgroundImage = global::LibraryManagement.Properties.Resources.close_btn;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1849, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(123, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã CTPM:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(512, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã cuốn sách:";
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToResizeRows = false;
            this.dtgv.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.readerName,
            this.dataGridViewTextBoxColumn9});
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.Location = new System.Drawing.Point(16, 372);
            this.dtgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgv.MultiSelect = false;
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 40;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv.RowTemplate.Height = 26;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(1301, 318);
            this.dtgv.TabIndex = 27;
            this.dtgv.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgv_CellMouseDown);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "stt";
            this.dataGridViewTextBoxColumn6.HeaderText = "STT";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "specSlipCode";
            this.dataGridViewTextBoxColumn7.HeaderText = "Mã chi tiết phiếu mượn";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 360;
            // 
            // readerName
            // 
            this.readerName.DataPropertyName = "bookCode";
            this.readerName.HeaderText = "Mã cuốn sách";
            this.readerName.MinimumWidth = 6;
            this.readerName.Name = "readerName";
            this.readerName.ReadOnly = true;
            this.readerName.Width = 360;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn9.HeaderText = "Tình trạng";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // pnlSpecCode
            // 
            this.pnlSpecCode.BackColor = System.Drawing.Color.Black;
            this.pnlSpecCode.Location = new System.Drawing.Point(260, 300);
            this.pnlSpecCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSpecCode.Name = "pnlSpecCode";
            this.pnlSpecCode.Size = new System.Drawing.Size(80, 1);
            this.pnlSpecCode.TabIndex = 30;
            // 
            // lbSpecCode
            // 
            this.lbSpecCode.AutoSize = true;
            this.lbSpecCode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpecCode.Location = new System.Drawing.Point(255, 271);
            this.lbSpecCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSpecCode.Name = "lbSpecCode";
            this.lbSpecCode.Size = new System.Drawing.Size(0, 29);
            this.lbSpecCode.TabIndex = 31;
            // 
            // lbBookCode
            // 
            this.lbBookCode.AutoSize = true;
            this.lbBookCode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookCode.Location = new System.Drawing.Point(684, 209);
            this.lbBookCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBookCode.Name = "lbBookCode";
            this.lbBookCode.Size = new System.Drawing.Size(0, 29);
            this.lbBookCode.TabIndex = 33;
            // 
            // pnlBookCode
            // 
            this.pnlBookCode.BackColor = System.Drawing.Color.Black;
            this.pnlBookCode.Location = new System.Drawing.Point(689, 239);
            this.pnlBookCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBookCode.Name = "pnlBookCode";
            this.pnlBookCode.Size = new System.Drawing.Size(240, 1);
            this.pnlBookCode.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Brown;
            this.label9.Location = new System.Drawing.Point(472, 59);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(378, 50);
            this.label9.TabIndex = 41;
            this.label9.Text = "Chi Tiết Phiếu Mượn";
            // 
            // lbSlipCode
            // 
            this.lbSlipCode.AutoSize = true;
            this.lbSlipCode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSlipCode.Location = new System.Drawing.Point(255, 208);
            this.lbSlipCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSlipCode.Name = "lbSlipCode";
            this.lbSlipCode.Size = new System.Drawing.Size(0, 29);
            this.lbSlipCode.TabIndex = 45;
            // 
            // pnlSlipCode
            // 
            this.pnlSlipCode.BackColor = System.Drawing.Color.Black;
            this.pnlSlipCode.Location = new System.Drawing.Point(260, 238);
            this.pnlSlipCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSlipCode.Name = "pnlSlipCode";
            this.pnlSlipCode.Size = new System.Drawing.Size(112, 1);
            this.pnlSlipCode.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(64, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 29);
            this.label7.TabIndex = 43;
            this.label7.Text = "Mã phiếu mượn:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(684, 273);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 29);
            this.lbStatus.TabIndex = 56;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.Black;
            this.pnlStatus.Location = new System.Drawing.Point(689, 303);
            this.pnlStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(240, 1);
            this.pnlStatus.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(547, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 29);
            this.label4.TabIndex = 54;
            this.label4.Text = "Tình Trạng:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 12;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1132, 242);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 49);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Chocolate;
            this.btnDelete.BackgroundColor = System.Drawing.Color.Chocolate;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 12;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(964, 169);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 49);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdate.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdate.BorderRadius = 12;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1132, 169);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 49);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // nButton1
            // 
            this.nButton1.BackColor = System.Drawing.Color.LightCoral;
            this.nButton1.BackgroundColor = System.Drawing.Color.LightCoral;
            this.nButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.nButton1.BorderRadius = 20;
            this.nButton1.BorderSize = 0;
            this.nButton1.FlatAppearance.BorderSize = 0;
            this.nButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nButton1.ForeColor = System.Drawing.Color.White;
            this.nButton1.Location = new System.Drawing.Point(584, 710);
            this.nButton1.Margin = new System.Windows.Forms.Padding(4);
            this.nButton1.Name = "nButton1";
            this.nButton1.Size = new System.Drawing.Size(160, 49);
            this.nButton1.TabIndex = 46;
            this.nButton1.Text = "Thoát";
            this.nButton1.TextColor = System.Drawing.Color.White;
            this.nButton1.UseVisualStyleBackColor = false;
            this.nButton1.Click += new System.EventHandler(this.nButton1_Click);
            // 
            // ViewDetailBorrowSlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1333, 778);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.nButton1);
            this.Controls.Add(this.lbSlipCode);
            this.Controls.Add(this.pnlSlipCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbBookCode);
            this.Controls.Add(this.pnlBookCode);
            this.Controls.Add(this.lbSpecCode);
            this.Controls.Add(this.pnlSpecCode);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewDetailBorrowSlip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfirmLendBook";
            this.Load += new System.EventHandler(this.ConfirmLendBook_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Panel pnlSpecCode;
        private System.Windows.Forms.Label lbSpecCode;
        private System.Windows.Forms.Label lbBookCode;
        private System.Windows.Forms.Panel pnlBookCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbSlipCode;
        private System.Windows.Forms.Panel pnlSlipCode;
        private System.Windows.Forms.Label label7;
        private nButton nButton1;
        private nButton btnUpdate;
        private nButton btnDelete;
        private nButton btnCancel;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn readerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}