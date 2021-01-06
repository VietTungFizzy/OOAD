using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class HangHoaBUS
    {
        private HangHoaDAL dalHangHoa = new HangHoaDAL();
        private HangHoaDAL hhdal;
        public HangHoaBUS()
        {
            hhdal = new HangHoaDAL();
        }

        public List<HangHoaDTO> select()
        {
            return hhdal.select();
        }

        public List<HangHoaDTO> timkiem(string key)
        {
            return hhdal.timkiem(key);
        }

        public List<HangHoaDTO> selectAvailable()
        {
            return hhdal.selectAvailable();
        }
        public List<DonHang_HopDong_DTO> selectDonHang()
        {
            return hhdal.selectDonHang_HopDong();
        }
        public List<DonHang_HopDong_DTO> selectDonHang_CaNhan()
        {
            return hhdal.selectDonHang_CaNhan();
        }
        public string selectMaHangHoaDat(DonHangDTO hang)
        {
            return hhdal.selectMaHangHoaDat(hang);
        }
        public HopDongDTO selectHopDong(DonHangDTO hang)
        {
            return hhdal.selectHopDong(hang);
        }
        public CaNhanDTO selectCaNhan(DonHangDTO hang)
        {
            return hhdal.selectCaNhan(hang);
        }
        public bool themhangdat(HangHoaDatDTO hang)
        {
            bool kq = dalHangHoa.themhangdat(hang);
            return kq;
        }
        public bool themloaihanghoadat(LoaiHangHoaDatDTO hang)
        {
            bool kq = dalHangHoa.themloaihanghoadat(hang);
            return kq;
        }

        public bool themdonhang_hopdong(DonHangDTO hang)
        {
            bool kq = dalHangHoa.themdonhang_hopdong(hang);
            return kq;
        }
        public bool xoaDonHang(HangHoaDatDTO hang)
        {
            bool kq = dalHangHoa.xoaDonHang(hang);
            return kq;
        }
        public bool themdonhang_canhan(DonHangDTO hang)
        {
            bool kq = dalHangHoa.themdonhang_canhan(hang);
            return kq;
        }
    }
}
