using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonHangDTO
    {
        string madonhang;
        string macanhan;
        string mahopdong;


        public string MADONHANG { get => madonhang; set => madonhang = value; }
        public string MACANHAN { get => macanhan; set => macanhan = value; }
        public string MAHOPDONG { get => mahopdong; set => mahopdong = value; }
    }
}
