using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class LoaiHangBUS
    {
       
            private LoaiHangDAL lhdal;
            public LoaiHangBUS()
            {
            lhdal = new LoaiHangDAL();
            }

            public List<LoaiHangDTO> select()
            {
                return lhdal.select();
            }
        
    }
}
