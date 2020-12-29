using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace OOAD
{
    public partial class BaoGiaTrucTiep : Form
    {
        public BaoGiaTrucTiep()
        {
            InitializeComponent();
        }
        private HangHoaBUS hhbus;
        private void BaoGiaTrucTiep_Load(object sender, EventArgs e)
        {
            hhbus = new HangHoaBUS();
           /* List<HangHoaDTO> lshh = hhbus.select();
            Load_Datagridview(lshh);*/
        }

        public void Load_Datagridview(List<HangHoaDTO> lshh)
        {
            if (lshh == null)
            {
                MessageBox.Show("Có lỗi xảy ra khi tìm kiếm hàng hóa");
                return;
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lshh;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
            myCurrencyManager.Refresh();
        }
    }
}
