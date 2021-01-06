using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace DAL
{
    public class KhachHangDAL
    {
        private string connectionString;
        private string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public KhachHangDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool them(CaNhanDTO kh)
        {
            string query = string.Empty;
            query += "INSERT INTO CANHAN ( MaCaNhan, Email, TenNguoiLienHe, SDT,DiaChi) ";
            query += "VALUES (@macanhan,@email,@tennguoilienhe,@SDT,@diachi)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@macanhan", kh.MACANHAN);
                    cmd.Parameters.AddWithValue("@email", kh.EMAIL);
                    cmd.Parameters.AddWithValue("@tennguoilienhe", kh.TENNGUOILIENHE);
                    cmd.Parameters.AddWithValue("@SDT", kh.SDT);
                    cmd.Parameters.AddWithValue("@DiaChi", kh.DIACHI);
                    /*  cmd.Parameters.AddWithValue("@mahanghoadat", kh.MAHANGHOADAT);*/
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception)
                    {
                        con.Close();
                        MessageBox.Show("thêm thông tin khách hàng thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("thêm thông tin khách hàng thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }
        public bool themKhachHang_HopDong(KhachHangDTO kh)
        {
            string query = string.Empty;
            query += "IF NOT EXISTS (SELECT HoVaTen FROM KHACHHANG WHERE HoVaTen = @ten)";
            query += "BEGIN INSERT INTO KHACHHANG (ID,HoVaTen,SDT,Email,SoNha,Duong,Huyen,Tinh,Xa,Phong,TenCoQuan,MST) VALUES(@id,@ten,@sdt,@email,@sonha,@duong,@quanhuyen,@tinhtp,@xahuyen,@phong,@tencoquan,@mst) END";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@id", kh.id);
                    cmd.Parameters.AddWithValue("@ten", kh.HOVATEN);
                    cmd.Parameters.AddWithValue("@sdt", kh.sdt);
                    cmd.Parameters.AddWithValue("@email", kh.EMAIL);
                    cmd.Parameters.AddWithValue("@sonha", kh.SONHA);
                    cmd.Parameters.AddWithValue("@duong", kh.DUONG);
                    cmd.Parameters.AddWithValue("@quanhuyen", kh.MAHUYEN);
                    cmd.Parameters.AddWithValue("@tinhtp", kh.MATINH);
                    cmd.Parameters.AddWithValue("@xahuyen", kh.MAXA);
                    cmd.Parameters.AddWithValue("@phong", kh.PHONG);
                    cmd.Parameters.AddWithValue("@tencoquan", kh.TENCOQUAN);
                    cmd.Parameters.AddWithValue("@mst", kh.mst);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception)
                    {
                        con.Close();
                        MessageBox.Show("thêm thông tin khách hàng thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("thêm thông tin khách hàng thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }
        public bool themHopDong_HopDong(HopDongDTO hd)
        {
            string query = string.Empty;
            query += "INSERT INTO HOPDONG ( MaHopDong, Email, TenNguoiLienHe, SDT, DiaChi, Fax, MST, TenToChuc, SoNha, Duong, Huyen, Phong, Xa, Tinh, ThoiGianGiaoDich, KhuCaoOc,Lau,PhongBan) ";
            query += "VALUES (@MaHopDong,@Email,@TenNguoiLH,@sdtHD,@DiaChi,@Fax,@MST,@tentochuc,@sonha,@duong,@mahuyen,@phong,@maxa,@matinh,@thoigiangiaodich,@khucaooc,@lau,@phongban)";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;


                    cmd.Parameters.AddWithValue("@MaHopDong", hd.id);
                    cmd.Parameters.AddWithValue("@Email", hd.EMAIL);
                    cmd.Parameters.AddWithValue("@TenNguoiLH", hd.TENNGUOILIENHE);
                    cmd.Parameters.AddWithValue("@sdtHD", hd.sdt);
                    cmd.Parameters.AddWithValue("@DiaChi", hd.DIACHI);
                    cmd.Parameters.AddWithValue("@Fax", hd.FAX);
                    cmd.Parameters.AddWithValue("@MST", hd.MST);
                    cmd.Parameters.AddWithValue("@tentochuc", hd.TENTOCHUC);
                    cmd.Parameters.AddWithValue("@sonha", hd.SONHA);
                    cmd.Parameters.AddWithValue("@duong", hd.DUONG);
                    cmd.Parameters.AddWithValue("@mahuyen", hd.MAHUYEN);
                    cmd.Parameters.AddWithValue("@phong", hd.PHONG);
                    cmd.Parameters.AddWithValue("@maxa", hd.MAXA);
                    cmd.Parameters.AddWithValue("@matinh", hd.MATINH);
                    cmd.Parameters.AddWithValue("@thoigiangiaodich", hd.THOIGIANGIAODICH);
                    cmd.Parameters.AddWithValue("@khucaooc", hd.KHUCAOOC);
                    cmd.Parameters.AddWithValue("@lau", hd.LAU);
                    cmd.Parameters.AddWithValue("@phongban", hd.PHONGBAN);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception)
                    {
                        con.Close();
                        MessageBox.Show("thêm thông tin hợp đồng thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("thêm thông tin hợp đồng thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }
    }
}
