namespace Danh_sach_sinh_vien
{
    public partial class Form1 : Form
    {
        private QuanLySinhVien quanLySinhVien = new QuanLySinhVien();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = quanLySinhVien.DanhSachSinhVien;
        }

        private void CapNhatDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = quanLySinhVien.DanhSachSinhVien;
            dataGridView1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblQuanlythongtinsv_Click(object sender, EventArgs e)
        {

        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien
            {
                MaSV = txtMaSV.Text,
                HoTen = txtHoTen.Text,
                NgaySinh = DateTime.Parse(txtNgaySinh.Text),
                DiaChi = txtDiaChi.Text,
                Email = txtEmail.Text,
                DienThoai = txtDienThoai.Text,
                GioiTinh = cboGioiTinh.SelectedItem?.ToString(),
                Khoa = cboKhoa.SelectedItem?.ToString()
            };

            quanLySinhVien.ThemSinhVien(sv);
            CapNhatDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index; // Lấy chỉ mục của sinh viên đã chọn trong DataGridView

                if (index >= 0 && index < quanLySinhVien.DanhSachSinhVien.Count) // Kiểm tra chỉ mục hợp lệ
                {
                    // Cập nhật thông tin sinh viên tại vị trí đã chọn
                    var sv = quanLySinhVien.DanhSachSinhVien[index];

                    sv.MaSV = txtMaSV.Text;
                    sv.HoTen = txtHoTen.Text;
                    sv.NgaySinh = DateTime.TryParse(txtNgaySinh.Text, out DateTime ngaySinh) ? ngaySinh : sv.NgaySinh;
                    sv.DiaChi = txtDiaChi.Text;
                    sv.Email = txtEmail.Text;
                    sv.DienThoai = txtDienThoai.Text;
                    sv.GioiTinh = cboGioiTinh.SelectedItem?.ToString();
                    sv.Khoa = cboKhoa.SelectedItem?.ToString();

                    // Cập nhật lại DataGridView để hiển thị thông tin mới
                    CapNhatDataGridView();
                }
                else
                {
                    MessageBox.Show("Không thể sửa sinh viên này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                quanLySinhVien.XoaSinhVien(quanLySinhVien.DanhSachSinhVien[index]);
                CapNhatDataGridView();
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtDienThoai.Clear();
            cboGioiTinh.SelectedIndex = -1;
            cboKhoa.SelectedIndex = -1;
        }
    }
}
