using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAL nvdal;
        public NhanVienBUS()
        {
            nvdal = new NhanVienDAL();
        }

        public List<NhanVienDTO> select()
        {
            return nvdal.select();
        }
    }
}
