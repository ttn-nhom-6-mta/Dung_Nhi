namespace QLTV.GUI
{
    partial class FormPhieuMuonTra
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
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaPMT = new System.Windows.Forms.Button();
            this.btnSuaPMT = new System.Windows.Forms.Button();
            this.btnThemPMT = new System.Windows.Forms.Button();
            this.txtIDNV = new System.Windows.Forms.TextBox();
            this.cboTNV = new System.Windows.Forms.ComboBox();
            this.dateNT = new System.Windows.Forms.DateTimePicker();
            this.dateNHT = new System.Windows.Forms.DateTimePicker();
            this.dateNM = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDDG = new System.Windows.Forms.TextBox();
            this.txtIDP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTKPMT = new System.Windows.Forms.Button();
            this.txtTKPMT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(674, 90);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(87, 23);
            this.btnChiTiet.TabIndex = 46;
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.Color.Navy;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(635, 173);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 23);
            this.btnThoat.TabIndex = 45;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 213);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkBlue;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(794, 261);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaPhieuMuonTra";
            this.Column1.HeaderText = "Mã Phiếu Mượn Trả";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayMuon";
            this.Column2.HeaderText = "Ngày Mượn";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayHenTra";
            this.Column3.HeaderText = "Ngày Hẹn Trả";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayTra";
            this.Column4.HeaderText = "Ngày Trả";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SoThe";
            this.Column5.HeaderText = "Số Thẻ Độc Giả";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MaNhanVien";
            this.Column6.HeaderText = "Mã Nhân Viên";
            this.Column6.Name = "Column6";
            this.Column6.Width = 120;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TenNhanVien";
            this.Column7.HeaderText = "Tên Nhân Viên";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "HoTen";
            this.Column8.HeaderText = "Tên Độc Giả";
            this.Column8.Name = "Column8";
            // 
            // btnXoaPMT
            // 
            this.btnXoaPMT.ForeColor = System.Drawing.Color.Navy;
            this.btnXoaPMT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPMT.Location = new System.Drawing.Point(555, 137);
            this.btnXoaPMT.Name = "btnXoaPMT";
            this.btnXoaPMT.Size = new System.Drawing.Size(91, 23);
            this.btnXoaPMT.TabIndex = 18;
            this.btnXoaPMT.Text = "Xóa PMT";
            this.btnXoaPMT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaPMT.UseVisualStyleBackColor = true;
            this.btnXoaPMT.Click += new System.EventHandler(this.btnXoaPMT_Click);
            // 
            // btnSuaPMT
            // 
            this.btnSuaPMT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaPMT.Location = new System.Drawing.Point(481, 100);
            this.btnSuaPMT.Name = "btnSuaPMT";
            this.btnSuaPMT.Size = new System.Drawing.Size(91, 23);
            this.btnSuaPMT.TabIndex = 17;
            this.btnSuaPMT.Text = "Sửa PMT";
            this.btnSuaPMT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaPMT.UseVisualStyleBackColor = true;
            this.btnSuaPMT.Click += new System.EventHandler(this.btnSuaPMT_Click);
            // 
            // btnThemPMT
            // 
            this.btnThemPMT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemPMT.Location = new System.Drawing.Point(405, 63);
            this.btnThemPMT.Name = "btnThemPMT";
            this.btnThemPMT.Size = new System.Drawing.Size(91, 23);
            this.btnThemPMT.TabIndex = 16;
            this.btnThemPMT.Text = "Thêm PMT";
            this.btnThemPMT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemPMT.UseVisualStyleBackColor = true;
            this.btnThemPMT.Click += new System.EventHandler(this.btnThemPMT_Click);
            // 
            // txtIDNV
            // 
            this.txtIDNV.Enabled = false;
            this.txtIDNV.Location = new System.Drawing.Point(190, 184);
            this.txtIDNV.Name = "txtIDNV";
            this.txtIDNV.Size = new System.Drawing.Size(180, 22);
            this.txtIDNV.TabIndex = 15;
            // 
            // cboTNV
            // 
            this.cboTNV.FormattingEnabled = true;
            this.cboTNV.Location = new System.Drawing.Point(190, 160);
            this.cboTNV.Name = "cboTNV";
            this.cboTNV.Size = new System.Drawing.Size(180, 23);
            this.cboTNV.TabIndex = 14;
            this.cboTNV.SelectedIndexChanged += new System.EventHandler(this.cboTNV_SelectedIndexChanged);
            // 
            // dateNT
            // 
            this.dateNT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNT.Location = new System.Drawing.Point(190, 114);
            this.dateNT.Name = "dateNT";
            this.dateNT.Size = new System.Drawing.Size(180, 22);
            this.dateNT.TabIndex = 13;
            // 
            // dateNHT
            // 
            this.dateNHT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNHT.Location = new System.Drawing.Point(190, 91);
            this.dateNHT.Name = "dateNHT";
            this.dateNHT.Size = new System.Drawing.Size(180, 22);
            this.dateNHT.TabIndex = 12;
            // 
            // dateNM
            // 
            this.dateNM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNM.Location = new System.Drawing.Point(190, 68);
            this.dateNM.Name = "dateNM";
            this.dateNM.Size = new System.Drawing.Size(180, 22);
            this.dateNM.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mã Nhân Viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tên Nhân Viên";
            // 
            // txtIDDG
            // 
            this.txtIDDG.Location = new System.Drawing.Point(190, 137);
            this.txtIDDG.Name = "txtIDDG";
            this.txtIDDG.Size = new System.Drawing.Size(180, 22);
            this.txtIDDG.TabIndex = 8;
            // 
            // txtIDP
            // 
            this.txtIDP.Location = new System.Drawing.Point(190, 45);
            this.txtIDP.Name = "txtIDP";
            this.txtIDP.Size = new System.Drawing.Size(180, 22);
            this.txtIDP.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số Thẻ Độc Giả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày Trả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Hẹn Trả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Phiếu Mượn Trả";
            // 
            // btnTKPMT
            // 
            this.btnTKPMT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKPMT.Location = new System.Drawing.Point(674, 14);
            this.btnTKPMT.Name = "btnTKPMT";
            this.btnTKPMT.Size = new System.Drawing.Size(87, 23);
            this.btnTKPMT.TabIndex = 1;
            this.btnTKPMT.Text = "Tìm kiếm";
            this.btnTKPMT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTKPMT.UseVisualStyleBackColor = true;
            this.btnTKPMT.Click += new System.EventHandler(this.btnTKPMT_Click);
            // 
            // txtTKPMT
            // 
            this.txtTKPMT.Location = new System.Drawing.Point(256, 15);
            this.txtTKPMT.Name = "txtTKPMT";
            this.txtTKPMT.Size = new System.Drawing.Size(419, 22);
            this.txtTKPMT.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChiTiet);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnXoaPMT);
            this.groupBox1.Controls.Add(this.btnSuaPMT);
            this.groupBox1.Controls.Add(this.btnThemPMT);
            this.groupBox1.Controls.Add(this.txtIDNV);
            this.groupBox1.Controls.Add(this.cboTNV);
            this.groupBox1.Controls.Add(this.dateNT);
            this.groupBox1.Controls.Add(this.dateNHT);
            this.groupBox1.Controls.Add(this.dateNM);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIDDG);
            this.groupBox1.Controls.Add(this.txtIDP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTKPMT);
            this.groupBox1.Controls.Add(this.txtTKPMT);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 477);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu mượn trả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ PHIẾU MƯỢN TRẢ SÁCH THƯ VIỆN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 31);
            this.panel1.TabIndex = 2;
            // 
            // FormPhieuMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FormPhieuMuonTra";
            this.Text = "FormPhieuMuonTra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnXoaPMT;
        private System.Windows.Forms.Button btnSuaPMT;
        private System.Windows.Forms.Button btnThemPMT;
        private System.Windows.Forms.TextBox txtIDNV;
        private System.Windows.Forms.ComboBox cboTNV;
        private System.Windows.Forms.DateTimePicker dateNT;
        private System.Windows.Forms.DateTimePicker dateNHT;
        private System.Windows.Forms.DateTimePicker dateNM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDDG;
        private System.Windows.Forms.TextBox txtIDP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTKPMT;
        private System.Windows.Forms.TextBox txtTKPMT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}