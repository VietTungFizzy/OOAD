using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        private string id;
        private string cmnd;
        private string ho;
        private string ten;
        private string diachi;
        private string sdt;
        private string mathanhtoan;
        private string maHHD;

        public string Id { get => id; set => id = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Mathanhtoan { get => mathanhtoan; set => mathanhtoan = value; }
        public string MaHHD { get => maHHD; set => maHHD = value; }
    }
}
