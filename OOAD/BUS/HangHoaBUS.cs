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
        private HangHoaDAL hhdal;
        public HangHoaBUS()
        {
            hhdal = new HangHoaDAL();
        }

        public List<HangHoaDTO> select()
        {
            return hhdal.select();
        }
    }
}
