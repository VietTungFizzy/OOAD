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
    public partial class QuanLyDonHang : Form
    {
        DonHangDTO dtoDonHang;
        HangHoaBUS busHangHoa;
        HangHoaDatDTO dtoHangHoaDat;
        string loai;
        public QuanLyDonHang()
        {
            InitializeComponent();

        }

        private void them_btn_Click(object sender, EventArgs e)
        {
            PBHTT pbhtt = new PBHTT(this);
            pbhtt.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PBHHD pbhhd = new PBHHD(this);
            pbhhd.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void QuanLyDonHang_Load(object sender, EventArgs e)
        {
            busHangHoa = new HangHoaBUS();
            List<DonHang_HopDong_DTO> lshh = busHangHoa.selectDonHang();
            List<DonHang_HopDong_DTO> lshh2 = busHangHoa.selectDonHang_CaNhan();
            lshh.AddRange(lshh2);
            Load_Datagridview1(lshh);
        }
        public void Load_Datagridview1(List<DonHang_HopDong_DTO> lshh)
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

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "  Trực tiếp")
            {
                busHangHoa = new HangHoaBUS();
                List<DonHang_HopDong_DTO> lshh2 = busHangHoa.selectDonHang_CaNhan();
                Load_Datagridview1(lshh2);
                dataGridView1.Columns["TRANGTHAI"].Visible = false;
            }
            else if (listBox1.SelectedItem.ToString() == "  Hợp đồng")
            {
                busHangHoa = new HangHoaBUS();
                List<DonHang_HopDong_DTO> lshh2 = busHangHoa.selectDonHang();
                Load_Datagridview1(lshh2);
                dataGridView1.Columns["TRANGTHAI"].Visible = false;
            }
            else
            {
                busHangHoa = new HangHoaBUS();
                List<DonHang_HopDong_DTO> lshh = busHangHoa.selectDonHang();
                List<DonHang_HopDong_DTO> lshh2 = busHangHoa.selectDonHang_CaNhan();
                lshh.AddRange(lshh2);

                Load_Datagridview1(lshh);
                dataGridView1.Columns["TRANGTHAI"].Visible = false;
            }
        }

        private void xoa_btn_Click(object sender, EventArgs e)
        {
            dtoHangHoaDat.MAHANGHOADAT = busHangHoa.selectMaHangHoaDat(dtoDonHang);
            busHangHoa.xoaDonHang(dtoHangHoaDat);
            xoa_btn.Enabled = false;

            busHangHoa = new HangHoaBUS();
            List<DonHang_HopDong_DTO> lshh = busHangHoa.selectDonHang();
            List<DonHang_HopDong_DTO> lshh2 = busHangHoa.selectDonHang_CaNhan();
            lshh.AddRange(lshh2);
            Load_Datagridview1(lshh);
            dataGridView1.Columns["TRANGTHAI"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtoDonHang = new DonHangDTO();
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            dtoDonHang.MADONHANG = row.Cells[5].Value.ToString();
            dtoHangHoaDat = new HangHoaDatDTO();
            dtoHangHoaDat.MADONHANG = row.Cells[5].Value.ToString();
            loai = row.Cells[3].Value.ToString();
            if (loai == "Hợp đồng")
            {
                dtoDonHang.MAHOPDONG = row.Cells[1].Value.ToString();
            }
            else dtoDonHang.MACANHAN = row.Cells[1].Value.ToString();
            xoa_btn.Enabled = true;
            sua_btn.Enabled = true;
        }

        private void sua_btn_Click(object sender, EventArgs e)
        {
            if (loai == "Hợp đồng")
            {
                PBHHD pbhhd = new PBHHD(this);
                pbhhd.loadEdit(busHangHoa.selectHopDong(dtoDonHang));
                pbhhd.Show();
            }
            else if (loai == "Cá Nhân")
            {
                PBHTT pbhhd = new PBHTT(this);
                pbhhd.loadEdit(busHangHoa.selectCaNhan(dtoDonHang));
                pbhhd.Show();
            }
        }
    }
}
