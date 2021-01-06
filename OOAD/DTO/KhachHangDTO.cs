using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        private string ID;
        private string MST;
        private string CMND;
        private string DiaChi;
        private string SDT;
        private string MaThanhToan;
        private string MaHangHoaDat;
        private string Email;
        private string MaTinh;
        private string MaHuyen;
        private string MaXa;
        private string Duong;
        private string SoNha;
        private string Phong;
        private string Website;
        private string SDTBan1;
        private string SDTBan2;
        private string TenCoQuan;
        private string HoVaTen;

        public string id { get => ID; set => ID = value; }
        public string cmnd { get => CMND; set => CMND = value; }
        public string mst { get => MST; set => MST = value; }
        public string DIACHI { get => DiaChi; set => DiaChi = value; }
        public string sdt { get => SDT; set => SDT = value; }
        public string MATHANHTHOAN { get => MaThanhToan; set => MaThanhToan = value; }
        public string MAHANGHOADAT { get => MaHangHoaDat; set => MaHangHoaDat = value; }
        public string EMAIL { get => Email; set => Email = value; }
        public string MATINH { get => MaTinh; set => MaTinh = value; }
        public string MAHUYEN { get => MaHuyen; set => MaHuyen = value; }
        public string MAXA { get => MaXa; set => MaXa = value; }
        public string DUONG { get => Duong; set => Duong = value; }
        public string SONHA { get => SoNha; set => SoNha = value; }
        public string PHONG { get => Phong; set => Phong = value; }
        public string WEBSITE { get => Website; set => Website = value; }
        public string SDTBAN1 { get => SDTBan1; set => SDTBan1 = value; }
        public string SDTBAN2 { get => SDTBan2; set => SDTBan2 = value; }
        public string TENCOQUAN { get => TenCoQuan; set => TenCoQuan = value; }
        public string HOVATEN { get => HoVaTen; set => HoVaTen = value; }
    }
}
