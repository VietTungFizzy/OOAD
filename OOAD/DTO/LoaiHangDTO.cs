using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiHangDTO
    {
        private string MaLoaiHang;
        private string TenLoaiHang;

        public string MALOAIHANG { get => MaLoaiHang; set => MaLoaiHang = value; }
        public string TENLOAIHANG { get => TenLoaiHang; set => TenLoaiHang = value; }
    }
}
