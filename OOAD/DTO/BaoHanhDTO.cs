using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoHanhDTO
    {
        private string maBH;
        private string id;
        private string maHH;
        private DateTime ngay;
        private string trangthai;

        public string MaBH { get => maBH; set => maBH = value; }
        public string Id { get => id; set => id = value; }
        public string MaHH { get => maHH; set => maHH = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
    }
}
