using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD
{
    public partial class BaoGia : Form
    {
        public BaoGia()
        {
            InitializeComponent();
        }

        private void bt_BGTT_Click(object sender, EventArgs e)
        {
            BaoGiaTrucTiep bgtt = new BaoGiaTrucTiep();
            bgtt.Show();
        }

        private void BaoGia_Load(object sender, EventArgs e)
        {

        }

        private void bt_BGTYC_Click(object sender, EventArgs e)
        {
            BaoGiaTheoYC bgtyc = new BaoGiaTheoYC();
            bgtyc.Show();
        }
    }
}
