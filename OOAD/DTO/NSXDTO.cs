using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NSXDTO
    {
        private string MaNhaSanXuat;
        private string TenNhaSanXuat;

        public string MANHASANXUAT { get => MaNhaSanXuat; set => MaNhaSanXuat = value; }
        public string TENNHASANXUAT { get => TenNhaSanXuat; set => TenNhaSanXuat = value; }
    }
}
