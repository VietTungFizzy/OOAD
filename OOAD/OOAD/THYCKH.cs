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
    public partial class THYCKH : Form
    {
        public THYCKH()
        {

            InitializeComponent();
        }
        private KhachHangBUS khbus;
        private THYCBUS thbus;

        private void button1_Click(object sender, EventArgs e)
        {
            THYCKH_3T fthyc = new THYCKH_3T();
            
            fthyc.ShowDialog();
            dataGridView1.Refresh();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            List<THYCDTO> lsth = thbus.select_THYC();
            Load_Datagridview1(lsth);

            dataGridView1.Columns["TINH"].Visible = false;
            dataGridView1.Columns["HUYEN"].Visible = false;
            dataGridView1.Columns["XA"].Visible = false;
            dataGridView1.Columns["EMAIL"].Visible = false;
            dataGridView1.Columns["DUONG"].Visible = false;
            dataGridView1.Columns["SONHA"].Visible = false;
            dataGridView1.Columns["LAU"].Visible = false;
            dataGridView1.Columns["PHONG"].Visible = false;
            dataGridView1.Columns["WEBSITE"].Visible = false;
            dataGridView1.Columns["SDTBAN1"].Visible = false;
            dataGridView1.Columns["SDTBAN2"].Visible = false;
            dataGridView1.Columns["PHONGBAN"].Visible = false;
            dataGridView1.Columns["GHICHU"].Visible = false;
            dataGridView1.Columns["MAPTGUIHANG"].Visible = false;
            dataGridView1.Columns["KHUCAOOC"].Visible = false;
            dataGridView1.Columns["THOIGIANKHDAPUNG"].Visible = false;
            dataGridView1.Columns["YEUCAU"].Visible = false;
            dataGridView1.Columns["GIATRIPO"].Visible = false;
            dataGridView1.Columns["NHANDINHTHUCTRANG"].Visible = false;
            dataGridView1.Columns["QUATRINHXULY"].Visible = false;
            dataGridView1.Columns["MATHUCHIENYEUCAU"].Visible = false;
            dataGridView1.Columns["mst"].Visible = false;
            dataGridView1.Columns["sdt"].Visible = false;
        }

        private void THYCKH_Load(object sender, EventArgs e)
        {
            thbus = new THYCBUS();

            List<THYCDTO> lsth = thbus.select_THYC();
            Load_Datagridview1(lsth);

            dataGridView1.Columns["TINH"].Visible = false;
            dataGridView1.Columns["HUYEN"].Visible = false;
            dataGridView1.Columns["XA"].Visible = false;
            dataGridView1.Columns["EMAIL"].Visible = false;
            dataGridView1.Columns["DUONG"].Visible = false;
            dataGridView1.Columns["SONHA"].Visible = false;
            dataGridView1.Columns["LAU"].Visible = false;
            dataGridView1.Columns["PHONG"].Visible = false;
            dataGridView1.Columns["WEBSITE"].Visible = false;
            dataGridView1.Columns["SDTBAN1"].Visible = false;
            dataGridView1.Columns["SDTBAN2"].Visible = false;
            dataGridView1.Columns["PHONGBAN"].Visible = false;
            dataGridView1.Columns["GHICHU"].Visible = false;
            dataGridView1.Columns["MAPTGUIHANG"].Visible = false;
            dataGridView1.Columns["KHUCAOOC"].Visible = false;
            dataGridView1.Columns["THOIGIANKHDAPUNG"].Visible = false;
            dataGridView1.Columns["YEUCAU"].Visible = false;
            dataGridView1.Columns["GIATRIPO"].Visible = false;
            dataGridView1.Columns["NHANDINHTHUCTRANG"].Visible = false;
            dataGridView1.Columns["QUATRINHXULY"].Visible = false;
            dataGridView1.Columns["MATHUCHIENYEUCAU"].Visible = false;
            dataGridView1.Columns["mst"].Visible = false;
            dataGridView1.Columns["sdt"].Visible = false;
            
        }
        public void Load_Datagridview1(List<THYCDTO> lsth)
        {
            if (lsth == null)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải phiếu");
                return;
            }

          //  dataGridView1.DataSource = null;
            dataGridView1.DataSource = lsth;

         

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
            myCurrencyManager.Refresh();

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            dataGridView1.Columns["MATHUCHIENYEUCAU"].Visible = true;

            string key;
            key = dataGridView1.Rows[index].Cells[9].Value.ToString();
            dataGridView1.Columns["MATHUCHIENYEUCAU"].Visible = false;

            THYCDTO thdto = new THYCDTO();

            THYCBUS thbus = new THYCBUS();

            thdto = thbus.collect_update(key);

            THYCKH_3T frthyc = new THYCKH_3T(thdto);
            frthyc.ShowDialog();
            dataGridView1.Refresh();


            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            List<THYCDTO> lsth = thbus.select_THYC();
            Load_Datagridview1(lsth);

            dataGridView1.Columns["TINH"].Visible = false;
            dataGridView1.Columns["HUYEN"].Visible = false;
            dataGridView1.Columns["XA"].Visible = false;
            dataGridView1.Columns["EMAIL"].Visible = false;
            dataGridView1.Columns["DUONG"].Visible = false;
            dataGridView1.Columns["SONHA"].Visible = false;
            dataGridView1.Columns["LAU"].Visible = false;
            dataGridView1.Columns["PHONG"].Visible = false;
            dataGridView1.Columns["WEBSITE"].Visible = false;
            dataGridView1.Columns["SDTBAN1"].Visible = false;
            dataGridView1.Columns["SDTBAN2"].Visible = false;
            dataGridView1.Columns["PHONGBAN"].Visible = false;
            dataGridView1.Columns["GHICHU"].Visible = false;
            dataGridView1.Columns["MAPTGUIHANG"].Visible = false;
            dataGridView1.Columns["KHUCAOOC"].Visible = false;
            dataGridView1.Columns["THOIGIANKHDAPUNG"].Visible = false;
            dataGridView1.Columns["YEUCAU"].Visible = false;
            dataGridView1.Columns["GIATRIPO"].Visible = false;
            dataGridView1.Columns["NHANDINHTHUCTRANG"].Visible = false;
            dataGridView1.Columns["QUATRINHXULY"].Visible = false;
            dataGridView1.Columns["MATHUCHIENYEUCAU"].Visible = false;
            dataGridView1.Columns["mst"].Visible = false;
            dataGridView1.Columns["sdt"].Visible = false;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            dataGridView1.Columns["MATHUCHIENYEUCAU"].Visible = true;

            string key;
            key = dataGridView1.Rows[index].Cells[9].Value.ToString();
            dataGridView1.Columns["MATHUCHIENYEUCAU"].Visible = false;

            THYCBUS thbus = new THYCBUS();
            thbus.xoa(key);

            dataGridView1.Refresh();


            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            List<THYCDTO> lsth = thbus.select_THYC();
            Load_Datagridview1(lsth);

            dataGridView1.Columns["TINH"].Visible = false;
            dataGridView1.Columns["HUYEN"].Visible = false;
            dataGridView1.Columns["XA"].Visible = false;
            dataGridView1.Columns["EMAIL"].Visible = false;
            dataGridView1.Columns["DUONG"].Visible = false;
            dataGridView1.Columns["SONHA"].Visible = false;
            dataGridView1.Columns["LAU"].Visible = false;
            dataGridView1.Columns["PHONG"].Visible = false;
            dataGridView1.Columns["WEBSITE"].Visible = false;
            dataGridView1.Columns["SDTBAN1"].Visible = false;
            dataGridView1.Columns["SDTBAN2"].Visible = false;
            dataGridView1.Columns["PHONGBAN"].Visible = false;
            dataGridView1.Columns["GHICHU"].Visible = false;
            dataGridView1.Columns["MAPTGUIHANG"].Visible = false;
            dataGridView1.Columns["KHUCAOOC"].Visible = false;
            dataGridView1.Columns["THOIGIANKHDAPUNG"].Visible = false;
            dataGridView1.Columns["YEUCAU"].Visible = false;
            dataGridView1.Columns["GIATRIPO"].Visible = false;
            dataGridView1.Columns["NHANDINHTHUCTRANG"].Visible = false;
            dataGridView1.Columns["QUATRINHXULY"].Visible = false;
            dataGridView1.Columns["MATHUCHIENYEUCAU"].Visible = false;
            dataGridView1.Columns["mst"].Visible = false;
            dataGridView1.Columns["sdt"].Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curitem = listBox1.SelectedItem.ToString();

            if (curitem == null || curitem == string.Empty || curitem.Length == 0)
            {
                List<THYCDTO> lsth = thbus.select_THYC();
                Load_Datagridview1(lsth);
            }
            else
            {
                List<THYCDTO> lsth = thbus.select_THYC_search(curitem);
                Load_Datagridview1(lsth);
            }

            dataGridView1.Columns["TINH"].Visible = false;
            dataGridView1.Columns["HUYEN"].Visible = false;
            dataGridView1.Columns["XA"].Visible = false;
            dataGridView1.Columns["EMAIL"].Visible = false;
            dataGridView1.Columns["DUONG"].Visible = false;
            dataGridView1.Columns["SONHA"].Visible = false;
            dataGridView1.Columns["LAU"].Visible = false;
            dataGridView1.Columns["PHONG"].Visible = false;
            dataGridView1.Columns["WEBSITE"].Visible = false;
            dataGridView1.Columns["SDTBAN1"].Visible = false;
            dataGridView1.Columns["SDTBAN2"].Visible = false;
            dataGridView1.Columns["PHONGBAN"].Visible = false;
            dataGridView1.Columns["GHICHU"].Visible = false;
            dataGridView1.Columns["MAPTGUIHANG"].Visible = false;
            dataGridView1.Columns["KHUCAOOC"].Visible = false;
            dataGridView1.Columns["THOIGIANKHDAPUNG"].Visible = false;
            dataGridView1.Columns["YEUCAU"].Visible = false;
            dataGridView1.Columns["GIATRIPO"].Visible = false;
            dataGridView1.Columns["NHANDINHTHUCTRANG"].Visible = false;
            dataGridView1.Columns["QUATRINHXULY"].Visible = false;
            dataGridView1.Columns["MATHUCHIENYEUCAU"].Visible = false;
            dataGridView1.Columns["mst"].Visible = false;
            dataGridView1.Columns["sdt"].Visible = false;
        }
    }
}
