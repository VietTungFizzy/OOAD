using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangHoaDTO
    {
        private string MaHangHoa;
        private string Ten;
        private string SoLuong;
        private string Gia;
        private string MaNhaSanXuat;
        private string MoTa;
        private string MaLoaiHang;
        private string ThoiGianBaoHanh;

        public string MAHANGHOA { get => MaHangHoa; set => MaHangHoa = value; }
        public string TEN { get => Ten; set => Ten = value; }
        public string SOLUONG { get => SoLuong; set => SoLuong = value; }
        public string GIA { get => Gia; set => Gia = value; }
        public string THOIGIANBAOHANH { get => ThoiGianBaoHanh; set => ThoiGianBaoHanh = value; }
        public string MANHASANXUAT { get => MaNhaSanXuat; set => MaNhaSanXuat = value; }
        public string Mota { get => MoTa; set => MoTa = value; }
        public string MALOAIHANG { get => MaLoaiHang; set => MaLoaiHang = value; }
    }
}
