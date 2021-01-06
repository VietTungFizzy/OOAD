using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private string MaNhanVien;
        private string CMND;
        private string Ho;
        private string Ten;
        private string DiaChi;

        public string MANHANVIEN { get => MaNhanVien; set => MaNhanVien = value; }
        public string cmnd { get => CMND; set => CMND = value; }
        public string HO { get => Ho; set => Ho = value; }
        public string TEN { get => Ten; set => Ten = value; }
        public string DIACHI { get => DiaChi; set => DiaChi = value; }
    }
}
