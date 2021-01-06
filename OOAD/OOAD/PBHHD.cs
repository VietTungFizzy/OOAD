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
    public partial class PBHHD : Form
    {
        int stt = 1;
        public delegate void SendMessage(HangHoaDTO hang);
        public SendMessage Sender;
        KhachHangDTO dtoKhachHang = new KhachHangDTO();
        KhachHangBUS busKhachHang = new KhachHangBUS();
        HangHoaBUS bushangHoa = new HangHoaBUS();
        HopDongDTO dtoHopDong = new HopDongDTO();
        DonHangDTO dtoDonHang = new DonHangDTO();
        HangHoaDatDTO dtoHangHoaDat = new HangHoaDatDTO();
        private static Random random = new Random();
        QuanLyDonHang qldh;
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public PBHHD(QuanLyDonHang QLHD)
        {
            qldh = QLHD;
            InitializeComponent();
            Sender = new SendMessage(UpdateGridView);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private NhanVienBUS nvbus;
        private void PBHHD_Load(object sender, EventArgs e)
        {
            nvbus = new NhanVienBUS();

            List<NhanVienDTO> lsnv = nvbus.select();
            nvgd_cbbox.DataSource = lsnv;
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[nvgd_cbbox.DataSource];
            myCurrencyManager.Refresh();
            nvgd_cbbox.DisplayMember = "Ten";
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        private void UpdateGridView(HangHoaDTO hang)
        {
            this.dataGridView1.Rows.Add(stt, hang.MAHANGHOA, hang.TEN,hang.SOLUONG, hang.GIA, int.Parse(hang.GIA)*int.Parse(hang.SOLUONG), hang.Mota);
            stt = stt + 1;
        }
        public void loadEdit(HopDongDTO hopdong)
        {
            Tochuc2_txt.Text = hopdong.TENTOCHUC;
            Mst2_txt.Text = hopdong.MST;
            Nguoilh2_txt.Text = hopdong.TENNGUOILIENHE;
            Phongban2_txt.Text = hopdong.PHONGBAN;
            Cuxa2_txt.Text = hopdong.KHUCAOOC;
            Lau2_txt.Text = hopdong.LAU;
            Phong2_txt.Text = hopdong.PHONG;
            Sonha2_txt.Text = hopdong.SONHA;
            Duong2_txt.Text = hopdong.DUONG;
            Phuongxa2_cbbox.Text = hopdong.MAXA;
            Quanhuyen2_cbbox.Text = hopdong.MAHUYEN;
            Tinhtp2_cbbox.Text = hopdong.MATINH;
            Fax2_txt.Text = hopdong.FAX;
            Tel2_txt.Text = hopdong.sdt;
            nvgd_cbbox.Text = hopdong.MANHANVIEN;
            tggh_cbbox.Text = hopdong.THOIGIANGIAODICH;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string n = RandomString(10);
            string m = RandomString(10);
            dtoKhachHang.id = n;
            dtoKhachHang.HOVATEN = Nguoilh_txt.Text;
            dtoKhachHang.sdt = tel_txt.Text;
            dtoKhachHang.EMAIL = email_txt.Text;
            dtoKhachHang.SONHA = Sonha_txt.Text;
            dtoKhachHang.DUONG = Duong_txt.Text;
            dtoKhachHang.MAHUYEN = Quanhuyen_txt.Text;
            dtoKhachHang.MATINH = TinhTp_cbbox.Text;
            dtoKhachHang.MAXA = Phuongxa_cbbox.Text;
            dtoKhachHang.PHONG = Phong_txt.Text;
            dtoKhachHang.TENCOQUAN = Tochuc_txt.Text;
            dtoKhachHang.mst = Mst_txt.Text;
            busKhachHang.themKhachHang_HopDong(dtoKhachHang);

            dtoHopDong.id = m;
            dtoHopDong.EMAIL = Email2_txt.Text;
            dtoHopDong.TENNGUOILIENHE = Nguoilh2_txt.Text;
            dtoHopDong.sdt = Tel2_txt.Text;
            dtoHopDong.DIACHI = Cuxa2_txt.Text;
            dtoHopDong.FAX = Fax2_txt.Text;
            dtoHopDong.MST = Mst2_txt.Text;
            dtoHopDong.TENTOCHUC = Tochuc2_txt.Text;
            dtoHopDong.SONHA = Sonha2_txt.Text;
            dtoHopDong.DUONG = Duong2_txt.Text;
            dtoHopDong.MAHUYEN = Quanhuyen2_cbbox.Text;
            dtoHopDong.PHONG = Phong2_txt.Text;
            dtoHopDong.MAXA = Phuongxa2_cbbox.Text;
            dtoHopDong.MATINH = Tinhtp2_cbbox.Text;
            dtoHopDong.THOIGIANGIAODICH = tggh_cbbox.Text;
            dtoHopDong.KHUCAOOC = Cuxa2_txt.Text;
            dtoHopDong.MANHANVIEN = nvgd_cbbox.Text;
            dtoHopDong.LAU = Lau2_txt.Text;
            dtoHopDong.PHONGBAN = Phongban2_txt.Text;
            
            busKhachHang.themHopDong_HopDong(dtoHopDong);
            string id = RandomString(10);
            dtoDonHang.MADONHANG = id;
            dtoDonHang.MAHOPDONG = dtoHopDong.id;
            bushangHoa.themdonhang_hopdong(dtoDonHang);

            dtoHangHoaDat.MADONHANG = dtoDonHang.MADONHANG;
            dtoHangHoaDat.MAHANGHOADAT = RandomString(10);
            dtoHangHoaDat.SOLUONG = dataGridView1.Rows.Count - 1;
            bushangHoa.themhangdat(dtoHangHoaDat);
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                LoaiHangHoaDatDTO hang = new LoaiHangHoaDatDTO();
                DataGridViewRow row = this.dataGridView1.Rows[i];
                hang.MALOAIHANGHOADAT = RandomString(10);
                hang.MAHANHOADAT = dtoHangHoaDat.MAHANGHOADAT;
                hang.MAHANGHOA = row.Cells[1].Value.ToString();
                hang.SOLUONG = row.Cells[3].Value.ToString();
                bushangHoa.themloaihanghoadat(hang);
            }
            qldh.QuanLyDonHang_Load( sender,  e);
            this.Hide();
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            AddProductHD add = new AddProductHD(this);
            add.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
