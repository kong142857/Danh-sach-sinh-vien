using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Danh_sach_sinh_vien
{

    internal class QuanLySinhVien
    {
        public List<SinhVien> DanhSachSinhVien { get; set; } = new List<SinhVien>();

        public void ThemSinhVien(SinhVien sv)
        {
            DanhSachSinhVien.Add(sv);
        }

        public void XoaSinhVien(SinhVien sv)
        {
            DanhSachSinhVien.Remove(sv);
        }
    }
}
