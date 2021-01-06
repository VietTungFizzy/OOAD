using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CaNhanDTO
    {
        private string Macanhan;
        private string Tennguoilienhe;
        private string Sdt;
        private string Email;
        private string Diachi;
        private string MaHuyen;
        private string Duong;
        private string SoNha;

        public string MACANHAN { get => Macanhan; set => Macanhan = value; }
        public string TENNGUOILIENHE { get => Tennguoilienhe; set => Tennguoilienhe = value; }
        public string EMAIL { get => Email; set => Email = value; }
        public string SDT { get => Sdt; set => Sdt = value; }
        public string DIACHI { get => Diachi; set => Diachi = value; }
        public string MAHUYEN { get => MaHuyen; set => MaHuyen = value; }
        public string DUONG { get => Duong; set => Duong = value; }
        public string SONHA { get => SoNha; set => SoNha = value; }
    }
}
