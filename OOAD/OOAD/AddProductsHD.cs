using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace OOAD
{
    public partial class AddProductHD : Form
    {
        private HangHoaBUS hhbus;
        PBHHD Pbhtt;
        public AddProductHD(PBHHD pbhtt)
        {
            InitializeComponent();
            Pbhtt = pbhtt;
        }

    
        public void Load_Datagridview1(List<HangHoaDTO> lshh)
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

   

 

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            HangHoaDTO hang = new HangHoaDTO();
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            hang.MAHANGHOA = row.Cells[0].Value.ToString();
            hang.TEN = row.Cells[1].Value.ToString();
            hang.SOLUONG = row.Cells[2].Value.ToString();
            hang.GIA = row.Cells[3].Value.ToString();
            /* hang.Mota = row.Cells[4].Value.ToString();*/
            Pbhtt.Sender(hang);
            this.Hide();
            Pbhtt.Show();
        }

        private void AddProductHD_Load(object sender, EventArgs e)
        {
            hhbus = new HangHoaBUS();
            List<HangHoaDTO> lshh = hhbus.selectAvailable();
            Load_Datagridview1(lshh);
            dataGridView1.Columns["MANHASANXUAT"].Visible = false;
            dataGridView1.Columns["MALOAIHANG"].Visible = false;
            dataGridView1.Columns["THOIGIANBAOHANH"].Visible = false;
        }
    }
}
