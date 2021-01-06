using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class THYCBUS
    {
        private THYCDAL thdal;
        public THYCBUS()
        {
            thdal = new THYCDAL();
        }

        public List<THYCDTO> select_THYC()
        {
            return thdal.select_THYC();
        }
        
        public List<THYCDTO> select_THYC_search(string key)
        {
            return thdal.select_THYC_search(key);
        }

        public bool luu(THYCDTO thyc)
        {
            bool kq = thdal.luu(thyc);
            return kq;
        }

        public THYCDTO collect_update(string key)
        {
            return thdal.collect_update(key);
        }

        public bool luu_sua(THYCDTO thuchien)
        {
            bool kq = thdal.luu_sua(thuchien);
            return kq;
        }

        public bool xoa(string key)
        {
            bool kq = thdal.xoa(key);
            return kq;
        }

    }
}
