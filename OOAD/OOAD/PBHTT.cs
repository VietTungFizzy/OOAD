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
    public partial class PBHTT : Form
    {
        QuanLyDonHang qldh;
        int stt = 1;
        public bool edit;
        public delegate void SendMessage(HangHoaDTO hang);
        public SendMessage Sender;
        KhachHangDTO dtoKhachHang = new KhachHangDTO();
        KhachHangBUS busKhachHang = new KhachHangBUS();
        HangHoaBUS bushangHoa = new HangHoaBUS();
        CaNhanDTO dtoCaNhan = new CaNhanDTO();
        DonHangDTO dtoDonHang = new DonHangDTO();
        HangHoaDatDTO dtoHangHoaDat = new HangHoaDatDTO();
        LoaiHangHoaDatDTO dtoLoaiHangHoaDat = new LoaiHangHoaDatDTO();
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public PBHTT(QuanLyDonHang QLHD)
        {
            qldh = QLHD;
            InitializeComponent();
            Sender = new SendMessage(UpdateGridView);
        }
        private void UpdateGridView(HangHoaDTO hang)
        {
            this.dataGridView1.Rows.Add(stt,hang.MAHANGHOA,hang.TEN,hang.SOLUONG,hang.GIA);
            stt=stt + 1;
        }

        private void PBHTT_Load(object sender, EventArgs e)
        {

        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            
                dtoCaNhan.MACANHAN = RandomString(10);
                dtoCaNhan.TENNGUOILIENHE = hoten_txt.Text;
                dtoCaNhan.SDT = sdt_txt.Text;
                dtoCaNhan.EMAIL = email_txt.Text;
                dtoCaNhan.DIACHI = SoNha_txt.Text + " Đường " + Duong_txt.Text + " Quận " + QuanHuyen_txt.Text;

                busKhachHang.them(dtoCaNhan);

                dtoDonHang.MADONHANG = RandomString(10);
                dtoDonHang.MACANHAN = dtoCaNhan.MACANHAN;
                bushangHoa.themdonhang_canhan(dtoDonHang);

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
            
          
            qldh.QuanLyDonHang_Load(sender, e);
            this.Hide();
        }
        public void loadEdit(CaNhanDTO hopdong)
        {
            hoten_txt.Text = hopdong.TENNGUOILIENHE;
           
            sdt_txt.Text = hopdong.SDT;
            email_txt.Text = hopdong.EMAIL;
            SoNha_txt.Text = hopdong.SONHA;
            Duong_txt.Text = hopdong.DUONG;
            QuanHuyen_txt.Text = hopdong.MAHUYEN;
          

        }
        private void select_btn_Click(object sender, EventArgs e)
        {
            AddProduct add = new AddProduct(this);
            add.Show();
        }
    }
}
