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
using System.Text.RegularExpressions;

namespace OOAD
{
    public partial class THYCKH_3T : Form
    {
        public THYCKH_3T()
        {
            InitializeComponent();
            btLuu_Sua.Hide();

        }
        int IDtemp;
        public THYCKH_3T(THYCDTO thuchien)
        {
            InitializeComponent();
            btLuu.Hide();
            IDtemp = thuchien.MATHUCHIENYEUCAU;
            txtCoQuan.Text = thuchien.TENCOQUAN;
            txtMST.Text = thuchien.mst;
            txtNguoiLienHe.Text = thuchien.HOVATEN;
            txtPhongBan.Text = thuchien.PHONGBAN;
            txtEmail.Text = thuchien.EMAIL;
            txtWebsite.Text = thuchien.WEBSITE;
            txtGhiChu.Text = thuchien.GHICHU;
            txtLau.Text = thuchien.LAU.ToString();
            txtSoNha.Text = thuchien.SONHA;
            txtTel1.Text = thuchien.SDTBAN1;
            txtTel2.Text = thuchien.SDTBAN2;
            txtMobile.Text = thuchien.sdt;
            txtKhuCaoOc.Text = thuchien.KHUCAOOC;
            txtPhong.Text = thuchien.PHONG;
            txtDuong.Text = thuchien.DUONG;
            cbTinh.Text = thuchien.TINH;
            cbHuyen.Text = thuchien.HUYEN;
            cbXa.Text = thuchien.XA;
            dateTimePicker1.Value = thuchien.THOIGIANKHDAPUNG;
            txtYeuCau.Text = thuchien.YEUCAU;
            txtGiaTriPO.Text = thuchien.GIATRIPO.ToString();
            cbKetQua.Text = thuchien.KETQUA;
            txtNhanDinh.Text = thuchien.NHANDINHTHUCTRANG;
            txtGhiNhan.Text = thuchien.QUATRINHXULY;

            string temp = thuchien.MANHANVIENGHINHAN;
            if (temp.Trim() == "001")
            {
                cbNVGhiNhan.SelectedIndex = 0;
            }
            else if (temp.Trim() == "002")
            {
                cbNVGhiNhan.Text = "Long";
            }
            else if (temp.Trim() == "003")
            {
                //cbNVGhiNhan.SelectedIndex = 3;
                cbNVGhiNhan.SelectedItem = "Tuấn";
            }
            else if (temp.Trim() == "004")
            {
                cbNVGhiNhan.Text = "Văn";
            }

            string temp2 = thuchien.MANHANVIENTHUCHIEN;
            if (temp2.Trim() == "001")
            {
                cbNVThucHien.Text = "Anh";
            }
            else if (temp2.Trim() == "002")
            {
                cbNVThucHien.Text = "Long";
            }
            else if (temp2.Trim() == "003")
            {
                cbNVThucHien.Text = "Tuấn";
            }
            else if (temp2.Trim() == "004")
            {
                cbNVThucHien.Text = "Văn";
            }

            if (thuchien.MAPTGUIHANG.Trim() == "001")
            {
                rdFax.Checked = true;
            }
            else if (thuchien.MAPTGUIHANG.Trim() == "002")
            {
                rdEmail.Checked = true;
            }
            else if (thuchien.MAPTGUIHANG.Trim() == "003")
            {
                rdMail.Checked = true;
            }
            else if (thuchien.MAPTGUIHANG.Trim() == "004")
            {
                rdTrucTiep.Checked = true;
            }
        }

        private NhanVienBUS nvbus;
        private NhanVienBUS nvbus2;
        private THYCBUS thbus;
        

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (txtMST.Text.Length<10 || txtMST.Text.Length == 11 || txtMST.Text.Length == 12)
            {
                MessageBox.Show("Mã số thuế phải gồm 10 chữ số hoặc 13 chữ số", "thông báo", MessageBoxButtons.OK);
                txtMST.Focus();
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }


        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            var checkedButton = tabPage2.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            THYCDTO thuchien = new THYCDTO();

            thuchien.mst = txtMST.Text;
            thuchien.sdt = txtMobile.Text;
            thuchien.TENCOQUAN = txtCoQuan.Text;
            thuchien.LAU = int.Parse(txtLau.Text);
            thuchien.HOVATEN = txtNguoiLienHe.Text;
            thuchien.SONHA = txtSoNha.Text;
            thuchien.PHONGBAN = txtPhongBan.Text;
            thuchien.SDTBAN1 = txtTel1.Text;
            thuchien.SDTBAN2 = txtTel2.Text;
            thuchien.EMAIL = txtEmail.Text;
            thuchien.WEBSITE = txtWebsite.Text;
            thuchien.GHICHU = txtGhiChu.Text;
            thuchien.KHUCAOOC = txtKhuCaoOc.Text;
            thuchien.PHONG = txtPhong.Text;
            thuchien.DUONG = txtDuong.Text;
            thuchien.XA = cbXa.Text;
            thuchien.HUYEN = cbHuyen.Text;
            thuchien.TINH = cbTinh.Text;
            if (checkedButton.Text == "Fax")
            {
                thuchien.MAPTGUIHANG = "001";
            }
            else if (checkedButton.Text == "Email")
            {
                thuchien.MAPTGUIHANG = "002";
            }else if (checkedButton.Text == "Mail")
            {
                thuchien.MAPTGUIHANG = "003";
            }else if (checkedButton.Text == "Trực tiếp")
            {
                thuchien.MAPTGUIHANG = "004";
            }

            thuchien.MANHANVIENGHINHAN = this.cbNVGhiNhan.GetItemText(this.cbNVGhiNhan.SelectedItem);
            if (thuchien.MANHANVIENGHINHAN == "Anh")
            {
                thuchien.MANHANVIENGHINHAN = "001";
            }
            if (thuchien.MANHANVIENGHINHAN == "Long")
            {
                thuchien.MANHANVIENGHINHAN = "002";
            }
            if (thuchien.MANHANVIENGHINHAN == "Tuấn")
            {
                thuchien.MANHANVIENGHINHAN = "003";
            }
            if (thuchien.MANHANVIENGHINHAN == "Văn")
            {
                thuchien.MANHANVIENGHINHAN = "004";
            }

            thuchien.YEUCAU = txtYeuCau.Text;
            thuchien.THOIGIANKHDAPUNG = dateTimePicker1.Value;

            thuchien.MANHANVIENTHUCHIEN = this.cbNVThucHien.GetItemText(this.cbNVThucHien.SelectedItem);
            if (thuchien.MANHANVIENTHUCHIEN == "Anh")
            {
                thuchien.MANHANVIENTHUCHIEN = "001";
            }
            if (thuchien.MANHANVIENTHUCHIEN == "Long")
            {
                thuchien.MANHANVIENTHUCHIEN = "002";
            }
            if (thuchien.MANHANVIENTHUCHIEN == "Tuấn")
            {
                thuchien.MANHANVIENTHUCHIEN = "003";
            }
            if (thuchien.MANHANVIENTHUCHIEN == "Văn")
            {
                thuchien.MANHANVIENTHUCHIEN = "004";
            }

            thuchien.KETQUA = this.cbKetQua.GetItemText(this.cbKetQua.SelectedItem);
            thuchien.QUATRINHXULY = txtGhiNhan.Text;
            thuchien.NHANDINHTHUCTRANG = txtNhanDinh.Text;
            thuchien.GIATRIPO = int.Parse(txtGiaTriPO.Text);

            THYCBUS thbus = new THYCBUS();
            thbus.luu(thuchien);

            this.Close();

        }

        private void THYCKH_3T_Load(object sender, EventArgs e)
        {
            nvbus = new NhanVienBUS();
            nvbus2 = new NhanVienBUS();

            List<NhanVienDTO> lsnv = nvbus.select();
            cbNVGhiNhan.DataSource = lsnv;
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cbNVGhiNhan.DataSource];
            myCurrencyManager.Refresh();
            cbNVGhiNhan.DisplayMember = "Ten";

            List<NhanVienDTO> lsnv2 = nvbus2.select();
            cbNVThucHien.DataSource = lsnv2;
            CurrencyManager myCurrencyManager2 = (CurrencyManager)this.BindingContext[cbNVThucHien.DataSource];
            myCurrencyManager2.Refresh();
            cbNVThucHien.DisplayMember = "Ten";

        }

        private void THYCKH_3T_FormClosed(object sender, FormClosedEventArgs e)
        {
           /* THYCKH frtHYCKH = new THYCKH();
            frtHYCKH.ShowDialog();*/
        }

        private void btLuu_Sua_Click(object sender, EventArgs e)
        {
            THYCDTO thuchien = new THYCDTO();

            var checkedButton = tabPage2.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            thuchien.MATHUCHIENYEUCAU = IDtemp;
            thuchien.mst = txtMST.Text;
            thuchien.sdt = txtMobile.Text;
            thuchien.TENCOQUAN = txtCoQuan.Text;
            thuchien.LAU = int.Parse(txtLau.Text);
            thuchien.HOVATEN = txtNguoiLienHe.Text;
            thuchien.SONHA = txtSoNha.Text;
            thuchien.PHONGBAN = txtPhongBan.Text;
            thuchien.SDTBAN1 = txtTel1.Text;
            thuchien.SDTBAN2 = txtTel2.Text;
            thuchien.EMAIL = txtEmail.Text;
            thuchien.WEBSITE = txtWebsite.Text;
            thuchien.GHICHU = txtGhiChu.Text;
            thuchien.KHUCAOOC = txtKhuCaoOc.Text;
            thuchien.PHONG = txtPhong.Text;
            thuchien.DUONG = txtDuong.Text;
            thuchien.XA = cbXa.Text;
            thuchien.HUYEN = cbHuyen.Text;
            thuchien.TINH = cbTinh.Text;
            if (checkedButton.Text == "Fax")
            {
                thuchien.MAPTGUIHANG = "001";
            }
            else if (checkedButton.Text == "Email")
            {
                thuchien.MAPTGUIHANG = "002";
            }
            else if (checkedButton.Text == "Mail")
            {
                thuchien.MAPTGUIHANG = "003";
            }
            else if (checkedButton.Text == "Trực tiếp")
            {
                thuchien.MAPTGUIHANG = "004";
            }

            thuchien.MANHANVIENGHINHAN = this.cbNVGhiNhan.GetItemText(this.cbNVGhiNhan.SelectedItem);
            if (thuchien.MANHANVIENGHINHAN == "Anh")
            {
                thuchien.MANHANVIENGHINHAN = "001";
            }
            if (thuchien.MANHANVIENGHINHAN == "Long")
            {
                thuchien.MANHANVIENGHINHAN = "002";
            }
            if (thuchien.MANHANVIENGHINHAN == "Tuấn")
            {
                thuchien.MANHANVIENGHINHAN = "003";
            }
            if (thuchien.MANHANVIENGHINHAN == "Văn")
            {
                thuchien.MANHANVIENGHINHAN = "004";
            }

            thuchien.YEUCAU = txtYeuCau.Text;
            thuchien.THOIGIANKHDAPUNG = dateTimePicker1.Value;

            thuchien.MANHANVIENTHUCHIEN = this.cbNVThucHien.GetItemText(this.cbNVThucHien.SelectedItem);
            if (thuchien.MANHANVIENTHUCHIEN == "Anh")
            {
                thuchien.MANHANVIENTHUCHIEN = "001";
            }
            if (thuchien.MANHANVIENTHUCHIEN == "Long")
            {
                thuchien.MANHANVIENTHUCHIEN = "002";
            }
            if (thuchien.MANHANVIENTHUCHIEN == "Tuấn")
            {
                thuchien.MANHANVIENTHUCHIEN = "003";
            }
            if (thuchien.MANHANVIENTHUCHIEN == "Văn")
            {
                thuchien.MANHANVIENTHUCHIEN = "004";
            }

            thuchien.KETQUA = this.cbKetQua.GetItemText(this.cbKetQua.SelectedItem);
            thuchien.QUATRINHXULY = txtGhiNhan.Text;
            thuchien.NHANDINHTHUCTRANG = txtNhanDinh.Text;
            thuchien.GIATRIPO = int.Parse(txtGiaTriPO.Text);

            THYCBUS thbus = new THYCBUS();
            thbus.luu_sua(thuchien);

            this.Close();
        }
        

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.txtEmail.Text, @"[a-zA-Z]@"))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email hợp lệ", "thông báo", MessageBoxButtons.OK);
                txtEmail.Focus();
            }
        }
    }
}
