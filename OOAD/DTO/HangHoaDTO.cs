using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangHoaDTO
    {
        private string maHH;
        private string ten;
        private int soluong;
        private string gia;
        private string tgbh;
        private string maNSX;
        private string mota;
        private string maLH;

        public string MaHH { get => maHH; set => maHH = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Gia { get => gia; set => gia = value; }
        public string TGBH { get => tgbh; set => tgbh = value; }
        public string MaNSX { get => maNSX; set => maNSX = value; }
        public string Mota { get => mota; set => mota = value; }
        public string MaLH { get => maLH; set => maLH = value; }
    }
}
