using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangHoaDatDTO
    {
        string mahanghoadat;
        int soluong;
        string mahanghoa;
        string mathuctrang;

        public string MAHANGHOADAT { get => mahanghoadat; set => mahanghoadat = value; }
        public int SOLUONG { get => soluong; set => soluong = value; }
        public string MADONHANG { get => mahanghoa; set => mahanghoa = value; }
        public string MATHUCTRANG { get => mathuctrang; set => mathuctrang = value; }
    }
}
