namespace QLTV.GUI
{
    partial class FormCTPhieuMuonTra
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTVP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaTT = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSuaTT = new System.Windows.Forms.Button();
            this.btnThemTT = new System.Windows.Forms.Button();
            this.txtTTT = new System.Windows.Forms.TextBox();
            this.cboTVP = new System.Windows.Forms.ComboBox();
            this.cboTCS = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboIDTT = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDVP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnTKTT = new System.Windows.Forms.Button();
            this.txtCT = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTVP);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.btnXoaTT);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnSuaTT);
            this.groupBox2.Controls.Add(this.btnThemTT);
            this.groupBox2.Controls.Add(this.txtTTT);
            this.groupBox2.Controls.Add(this.cboTVP);
            this.groupBox2.Controls.Add(this.cboTCS);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cboIDTT);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtIDVP);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btnTKTT);
            this.groupBox2.Controls.Add(this.txtCT);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(801, 485);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu mượn trả";
            // 
            // txtTVP
            // 
            this.txtTVP.Enabled = false;
            this.txtTVP.Location = new System.Drawing.Point(175, 140);
            this.txtTVP.Name = "txtTVP";
            this.txtTVP.Size = new System.Drawing.Size(180, 22);
            this.txtTVP.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tiền Vi Phạm";
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.Color.Navy;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(645, 163);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 23);
            this.btnThoat.TabIndex = 44;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(3, 226);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Size = new System.Drawing.Size(795, 256);
            this.dataGridView2.TabIndex = 41;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MaPhieuMuonTra";
            this.Column7.HeaderText = "Mã Phiếu Mượn Trả";
            this.Column7.Name = "Column7";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MaCuonSach";
            this.Column9.HeaderText = "Mã Cuốn Sách";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "TenVP";
            this.Column10.HeaderText = "Tên Vi Phạm";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "MaVP";
            this.Column11.HeaderText = "Mã Vi Phạm";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "TinhTrangTra";
            this.Column12.HeaderText = "Tình Trạng Trả";
            this.Column12.Name = "Column12";
            // 
            // btnXoaTT
            // 
            this.btnXoaTT.ForeColor = System.Drawing.Color.Navy;
            this.btnXoaTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTT.Location = new System.Drawing.Point(567, 127);
            this.btnXoaTT.Name = "btnXoaTT";
            this.btnXoaTT.Size = new System.Drawing.Size(91, 23);
            this.btnXoaTT.TabIndex = 22;
            this.btnXoaTT.Text = "Xóa PMT";
            this.btnXoaTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaTT.UseVisualStyleBackColor = true;
            this.btnXoaTT.Click += new System.EventHandler(this.btnXoaTT_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 15);
            this.label12.TabIndex = 40;
            this.label12.Text = "Tên Vi Phạm";
            // 
            // btnSuaTT
            // 
            this.btnSuaTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaTT.Location = new System.Drawing.Point(487, 89);
            this.btnSuaTT.Name = "btnSuaTT";
            this.btnSuaTT.Size = new System.Drawing.Size(91, 23);
            this.btnSuaTT.TabIndex = 21;
            this.btnSuaTT.Text = "Sửa PMT";
            this.btnSuaTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaTT.UseVisualStyleBackColor = true;
            this.btnSuaTT.Click += new System.EventHandler(this.btnSuaTT_Click);
            // 
            // btnThemTT
            // 
            this.btnThemTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemTT.Location = new System.Drawing.Point(413, 50);
            this.btnThemTT.Name = "btnThemTT";
            this.btnThemTT.Size = new System.Drawing.Size(91, 23);
            this.btnThemTT.TabIndex = 20;
            this.btnThemTT.Text = "Thêm PMT";
            this.btnThemTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemTT.UseVisualStyleBackColor = true;
            this.btnThemTT.Click += new System.EventHandler(this.btnThemTT_Click);
            // 
            // txtTTT
            // 
            this.txtTTT.Location = new System.Drawing.Point(175, 163);
            this.txtTTT.Name = "txtTTT";
            this.txtTTT.Size = new System.Drawing.Size(180, 22);
            this.txtTTT.TabIndex = 39;
            // 
            // cboTVP
            // 
            this.cboTVP.FormattingEnabled = true;
            this.cboTVP.Items.AddRange(new object[] {
            "Không vi phạm",
            "Trả sách muộn 1 tháng",
            "Trả sách muộn 1 kỳ",
            "Trả sách muộn từ 1 năm trở lên",
            "Làm rách sách",
            "Làm mất sách"});
            this.cboTVP.Location = new System.Drawing.Point(175, 93);
            this.cboTVP.Name = "cboTVP";
            this.cboTVP.Size = new System.Drawing.Size(180, 23);
            this.cboTVP.TabIndex = 38;
            this.cboTVP.SelectedIndexChanged += new System.EventHandler(this.cboTVP_SelectedIndexChanged);
            // 
            // cboTCS
            // 
            this.cboTCS.FormattingEnabled = true;
            this.cboTCS.Location = new System.Drawing.Point(175, 69);
            this.cboTCS.Name = "cboTCS";
            this.cboTCS.Size = new System.Drawing.Size(180, 23);
            this.cboTCS.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 15);
            this.label11.TabIndex = 36;
            this.label11.Text = "Tình Trạng Trả";
            // 
            // cboIDTT
            // 
            this.cboIDTT.FormattingEnabled = true;
            this.cboIDTT.Items.AddRange(new object[] {
            "P1"});
            this.cboIDTT.Location = new System.Drawing.Point(175, 45);
            this.cboIDTT.Name = "cboIDTT";
            this.cboIDTT.Size = new System.Drawing.Size(180, 23);
            this.cboIDTT.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Mã Vi Phạm";
            // 
            // txtIDVP
            // 
            this.txtIDVP.Enabled = false;
            this.txtIDVP.Location = new System.Drawing.Point(175, 117);
            this.txtIDVP.Name = "txtIDVP";
            this.txtIDVP.Size = new System.Drawing.Size(180, 22);
            this.txtIDVP.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Mã Cuốn Sách";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 15);
            this.label14.TabIndex = 21;
            this.label14.Text = "Mã Phiếu Mượn Trả";
            // 
            // btnTKTT
            // 
            this.btnTKTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKTT.Location = new System.Drawing.Point(664, 14);
            this.btnTKTT.Name = "btnTKTT";
            this.btnTKTT.Size = new System.Drawing.Size(87, 23);
            this.btnTKTT.TabIndex = 20;
            this.btnTKTT.Text = "Tìm kiếm";
            this.btnTKTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTKTT.UseVisualStyleBackColor = true;
            this.btnTKTT.Click += new System.EventHandler(this.btnTKTT_Click);
            // 
            // txtCT
            // 
            this.txtCT.Location = new System.Drawing.Point(261, 15);
            this.txtCT.Name = "txtCT";
            this.txtCT.Size = new System.Drawing.Size(404, 22);
            this.txtCT.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 30);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ CHI TIẾT PHIẾU MƯỢN TRẢ SÁCH THƯ VIỆN";
            // 
            // FormCTPhieuMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 515);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "FormCTPhieuMuonTra";
            this.Text = "FormCTPhieuMuonTra";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTVP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnXoaTT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSuaTT;
        private System.Windows.Forms.Button btnThemTT;
        private System.Windows.Forms.TextBox txtTTT;
        private System.Windows.Forms.ComboBox cboTVP;
        private System.Windows.Forms.ComboBox cboTCS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboIDTT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDVP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnTKTT;
        private System.Windows.Forms.TextBox txtCT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}