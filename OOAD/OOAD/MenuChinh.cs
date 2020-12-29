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

        private void bt_BaoGia_Click(object sender, EventArgs e)
        {
            BaoGia bg = new BaoGia();
            bg.Show();
        }

        private void bt_KTKNCC_Click(object sender, EventArgs e)
        {

        }

        private void bt_QLTTDH_Click(object sender, EventArgs e)
        {

        }
    }
}
