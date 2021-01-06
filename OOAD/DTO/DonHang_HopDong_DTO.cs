using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonHang_HopDong_DTO
    {
        private string id;
        private string TenKhachHang;
        private string ThongTinLienHe;
        private string NhanVienLamViec;
        private string Loai;
        private string TrangThai;
        private string MaDonHang;
        public string ID { get => id; set => id = value; }

        public string TENKHACHHANG { get => TenKhachHang; set => TenKhachHang = value; }

        public string THONGTINLIENHE { get => ThongTinLienHe; set => ThongTinLienHe = value; }
        public string LOAI { get => Loai; set => Loai = value; }
        public string TRANGTHAI { get => TrangThai; set => TrangThai = value; }
        public string MADDONHANG { get => MaDonHang; set => MaDonHang = value; }
    }
}
