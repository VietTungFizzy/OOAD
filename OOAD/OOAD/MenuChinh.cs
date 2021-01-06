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
    public partial class MenuChinh : Form
    {
        public MenuChinh()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuanLyDonHang qldh = new QuanLyDonHang();
            qldh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaoGia baogia = new BaoGia();
            baogia.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            THYCKH thyc = new THYCKH();
            thyc.Show();
        }
    }
}
