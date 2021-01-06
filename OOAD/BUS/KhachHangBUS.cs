using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class KhachHangBUS
    {
        public KhachHangBUS()
        {
            dalKhachHang = new KhachHangDAL();

        }
        KhachHangDAL dalKhachHang = new KhachHangDAL();

        public bool them(CaNhanDTO kh)
        {
            bool kq = dalKhachHang.them(kh);
            return kq;
        }

        public bool themKhachHang_HopDong(KhachHangDTO kh)
        {
            bool kq = dalKhachHang.themKhachHang_HopDong(kh);
            return kq;
        }
        public bool themHopDong_HopDong(HopDongDTO hd)
        {
            bool kq = dalKhachHang.themHopDong_HopDong(hd);
            return kq;
        }
    }
}
