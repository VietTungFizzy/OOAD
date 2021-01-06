using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiHangHoaDatDTO
    {
        string maloaihanghoadat;
        string soluong;
        string mahanghoa;
        string mahanghoadat;


        public string MALOAIHANGHOADAT { get => maloaihanghoadat; set => maloaihanghoadat = value; }
        public string SOLUONG { get => soluong; set => soluong = value; }
        public string MAHANGHOA { get => mahanghoa; set => mahanghoa = value; }
        public string MAHANHOADAT { get => mahanghoadat; set => mahanghoadat = value; }
    }
}
