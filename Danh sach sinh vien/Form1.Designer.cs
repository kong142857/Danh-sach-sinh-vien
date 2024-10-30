namespace Danh_sach_sinh_vien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblQuanlythongtinsv = new Label();
            gbThongtinsv = new GroupBox();
            cboKhoa = new ComboBox();
            lblKhoa = new Label();
            cboGioiTinh = new ComboBox();
            lblGioitinh = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblNgaysinh = new Label();
            txtDienThoai = new TextBox();
            lblDt = new Label();
            txtDiaChi = new TextBox();
            lblDiachi = new Label();
            txtNgaySinh = new DateTimePicker();
            txtMaSV = new TextBox();
            lblMasv = new Label();
            txtHoTen = new TextBox();
            lblHoten = new Label();
            btnLammoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            gbThongtinsv.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblQuanlythongtinsv);
            panel1.Location = new Point(21, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 57);
            panel1.TabIndex = 0;
            // 
            // lblQuanlythongtinsv
            // 
            lblQuanlythongtinsv.AutoSize = true;
            lblQuanlythongtinsv.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuanlythongtinsv.Location = new Point(175, 9);
            lblQuanlythongtinsv.Name = "lblQuanlythongtinsv";
            lblQuanlythongtinsv.Size = new Size(360, 37);
            lblQuanlythongtinsv.TabIndex = 0;
            lblQuanlythongtinsv.Text = "Quan ly thong tin sinh vien";
            lblQuanlythongtinsv.Click += lblQuanlythongtinsv_Click;
            // 
            // gbThongtinsv
            // 
            gbThongtinsv.Controls.Add(cboKhoa);
            gbThongtinsv.Controls.Add(lblKhoa);
            gbThongtinsv.Controls.Add(cboGioiTinh);
            gbThongtinsv.Controls.Add(lblGioitinh);
            gbThongtinsv.Controls.Add(txtEmail);
            gbThongtinsv.Controls.Add(lblEmail);
            gbThongtinsv.Controls.Add(lblNgaysinh);
            gbThongtinsv.Controls.Add(txtDienThoai);
            gbThongtinsv.Controls.Add(lblDt);
            gbThongtinsv.Controls.Add(txtDiaChi);
            gbThongtinsv.Controls.Add(lblDiachi);
            gbThongtinsv.Controls.Add(txtNgaySinh);
            gbThongtinsv.Controls.Add(txtMaSV);
            gbThongtinsv.Controls.Add(lblMasv);
            gbThongtinsv.Controls.Add(txtHoTen);
            gbThongtinsv.Controls.Add(lblHoten);
            gbThongtinsv.Location = new Point(21, 78);
            gbThongtinsv.Name = "gbThongtinsv";
            gbThongtinsv.Size = new Size(303, 330);
            gbThongtinsv.TabIndex = 1;
            gbThongtinsv.TabStop = false;
            gbThongtinsv.Text = "Thong tin sinh vien";
            // 
            // cboKhoa
            // 
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(89, 283);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(191, 23);
            cboKhoa.TabIndex = 16;
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Location = new Point(46, 286);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(37, 15);
            lblKhoa.TabIndex = 15;
            lblKhoa.Text = "Khoa:";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Male", "Female", "LGBT" });
            cboGioiTinh.Location = new Point(89, 248);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(191, 23);
            cboGioiTinh.TabIndex = 14;
            // 
            // lblGioitinh
            // 
            lblGioitinh.AutoSize = true;
            lblGioitinh.Location = new Point(28, 251);
            lblGioitinh.Name = "lblGioitinh";
            lblGioitinh.Size = new Size(55, 15);
            lblGioitinh.TabIndex = 13;
            lblGioitinh.Text = "Gioi tinh:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(89, 177);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(191, 23);
            txtEmail.TabIndex = 12;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(44, 180);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email:";
            // 
            // lblNgaysinh
            // 
            lblNgaysinh.AutoSize = true;
            lblNgaysinh.Location = new Point(20, 111);
            lblNgaysinh.Name = "lblNgaysinh";
            lblNgaysinh.Size = new Size(63, 15);
            lblNgaysinh.TabIndex = 10;
            lblNgaysinh.Text = "Ngay sinh:";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(89, 212);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(191, 23);
            txtDienThoai.TabIndex = 9;
            // 
            // lblDt
            // 
            lblDt.AutoSize = true;
            lblDt.Location = new Point(19, 215);
            lblDt.Name = "lblDt";
            lblDt.Size = new Size(64, 15);
            lblDt.TabIndex = 8;
            lblDt.Text = "Dien thoai:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(89, 142);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(191, 23);
            txtDiaChi.TabIndex = 7;
            // 
            // lblDiachi
            // 
            lblDiachi.AutoSize = true;
            lblDiachi.Location = new Point(37, 145);
            lblDiachi.Name = "lblDiachi";
            lblDiachi.Size = new Size(46, 15);
            lblDiachi.TabIndex = 6;
            lblDiachi.Text = "Dia chi:";
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(89, 105);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(191, 23);
            txtNgaySinh.TabIndex = 5;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(89, 29);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(191, 23);
            txtMaSV.TabIndex = 3;
            // 
            // lblMasv
            // 
            lblMasv.AutoSize = true;
            lblMasv.Location = new Point(6, 32);
            lblMasv.Name = "lblMasv";
            lblMasv.Size = new Size(77, 15);
            lblMasv.TabIndex = 2;
            lblMasv.Text = "Ma sinh vien:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(89, 66);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(191, 23);
            txtHoTen.TabIndex = 1;
            txtHoTen.TextChanged += txtHoten_TextChanged;
            // 
            // lblHoten
            // 
            lblHoten.AutoSize = true;
            lblHoten.Location = new Point(37, 69);
            lblHoten.Name = "lblHoten";
            lblHoten.Size = new Size(46, 15);
            lblHoten.TabIndex = 0;
            lblHoten.Text = "Ho ten:";
            // 
            // btnLammoi
            // 
            btnLammoi.Location = new Point(318, 271);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(75, 23);
            btnLammoi.TabIndex = 3;
            btnLammoi.Text = "Lam moi";
            btnLammoi.UseVisualStyleBackColor = true;
            btnLammoi.Click += btnLammoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(224, 271);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(60, 23);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(121, 271);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(64, 23);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(23, 271);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(63, 23);
            btnThem.TabIndex = 0;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnLammoi);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Location = new Point(342, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 330);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sach sinh vien";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(370, 150);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 425);
            Controls.Add(groupBox1);
            Controls.Add(gbThongtinsv);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gbThongtinsv.ResumeLayout(false);
            gbThongtinsv.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblQuanlythongtinsv;
        private GroupBox gbThongtinsv;
        private TextBox txtHoTen;
        private Label lblHoten;
        private DateTimePicker txtNgaySinh;
        private TextBox txtMaSV;
        private Label lblMasv;
        private Label lblDiachi;
        private TextBox txtDiaChi;
        private TextBox txtDienThoai;
        private Label lblDt;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblNgaysinh;
        private ComboBox cboGioiTinh;
        private Label lblGioitinh;
        private ComboBox cboKhoa;
        private Label lblKhoa;
        private Button btnLammoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
    }
}
