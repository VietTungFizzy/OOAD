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
    public class HangHoaDAL
    {
        private string connectionString;
        private string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }

        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public HangHoaDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public List<HangHoaDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [dbo].[LOAIHANG].[TenLoaiHang], [dbo].[NHASANXUAT].[TenNhaSanXuat], [dbo].[HANGHOA].[MaHangHoa], [dbo].[HANGHOA].[MoTa], [dbo].[HANGHOA].[Gia], [dbo].[HANGHOA].[ThoiGianBaoHanh], [dbo].[HANGHOA].[Ten]";
            query += "FROM [dbo].[HANGHOA], [dbo].[LOAIHANG], [dbo].[NHASANXUAT]";
            query += "WHERE ([dbo].[HANGHOA].[MaNhaSanXuat] = [dbo].[NHASANXUAT].[MaNhaSanXuat])";
            query += "AND ([dbo].[HANGHOA].[MaLoaiHang] = [dbo].[LOAIHANG].[MaLoaiHang])";

           /* query += "SELECT [MaHangHoa], [Gia], [MoTa], [ThoiGianBaoHanh]";
            query += "FROM [dbo].[HANGHOA]";*/
           
            List<HangHoaDTO> lsHangHoa = new List<HangHoaDTO>();
            List<LoaiHangDTO> lsLoaiHang = new List<LoaiHangDTO>();
            List<NSXDTO> lsNSX = new List<NSXDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
      
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                HangHoaDTO hanghoa = new HangHoaDTO();
                                hanghoa.MAHANGHOA = reader["MaHangHoa"].ToString();
                                hanghoa.Mota = reader["MoTa"].ToString();   
                                hanghoa.GIA = reader["Gia"].ToString();
                                hanghoa.THOIGIANBAOHANH = reader["ThoiGianBaoHanh"].ToString();
                                hanghoa.MANHASANXUAT = reader["TenNhaSanXuat"].ToString();
                                hanghoa.MALOAIHANG = reader["TenLoaiHang"].ToString();
                                hanghoa.TEN = reader["Ten"].ToString();
                                lsHangHoa.Add(hanghoa);

                               /* LoaiHangDTO loaihang = new LoaiHangDTO();
                                loaihang.TENLOAIHANG = reader["TenLoaiHang"].ToString();
                                lsLoaiHang.Add(loaihang);*/


                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lsHangHoa;
        }

        public List<HangHoaDTO> timkiem(string key)
        {
            string query = string.Empty;
            query += " SELECT [dbo].[HANGHOA].[MaHangHoa], [dbo].[HANGHOA].[Ten], [dbo].[HANGHOA].[Gia], [dbo].[HANGHOA].[ThoiGianBaoHanh]";
            query += " FROM [dbo].[HANGHOA], [dbo].[LOAIHANG]";
            query += " WHERE ([dbo].[HANGHOA].[MaLoaiHang] = [dbo].[LOAIHANG].[MaLoaiHang])";
            query += " AND ([dbo].[LOAIHANG].[TenLoaiHang] LIKE CONCAT('%',@key,'%'))";

            List<HangHoaDTO> lshanghoa = new List<HangHoaDTO>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@key", key);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();

                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                HangHoaDTO hh = new HangHoaDTO();
                                hh.MAHANGHOA = reader["MaHangHoa"].ToString();
                                hh.TEN = reader["Ten"].ToString();
                                hh.GIA = reader["Gia"].ToString();
                                hh.THOIGIANBAOHANH = reader["ThoiGianBaoHanh"].ToString();
                                lshanghoa.Add(hh);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }

                    catch (Exception)

                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lshanghoa;
        }

        public bool themdonhang_hopdong(DonHangDTO hang)
        {
            string query = string.Empty;
            query += "INSERT INTO DONHANG(MaDonHang,MaHopDong)";
            query += "VALUES(@Madonhang,@Mahopdong)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Madonhang", hang.MADONHANG);
                    cmd.Parameters.AddWithValue("@Mahopdong", hang.MAHOPDONG);


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
                        MessageBox.Show("thêm đơn hàng thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("thêm đơn hàng thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }
        public bool xoaDonHang(HangHoaDatDTO hang)
        {
            string query = string.Empty;
            query += "delete from LOAIHANGHOADAT where MaHangHoaDat = @MaHangHoaDat delete from HANGHOADAT where MaHangHoaDat = @MaHangHoaDat delete from DONHANG where MaDonHang = @MaDonHang";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Madonhang", hang.MADONHANG);
                    cmd.Parameters.AddWithValue("@MaHangHoaDat", hang.MAHANGHOADAT);


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
                        MessageBox.Show("xóa đơn hàng thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("xóa đơn hàng thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }


        public bool themdonhang_canhan(DonHangDTO hang)
        {
            string query = string.Empty;
            query += "INSERT INTO DONHANG(MaDonHang,MaCaNhan)";
            query += "VALUES(@Madonhang,@MaCaNhan)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Madonhang", hang.MADONHANG);
                    cmd.Parameters.AddWithValue("@Macanhan", hang.MACANHAN);


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
                        MessageBox.Show("thêm đơn hàng thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("thêm đơn hàng thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }

        public string selectMaHangHoaDat(DonHangDTO hang)
        {
            string query = string.Empty;
            query += "select MaHangHoaDat from  HangHoaDat";
            query += " where MaDonHang = @MaDonHang ";

            /* query += "SELECT [MaHangHoa], [Gia], [MoTa], [ThoiGianBaoHanh]";
             query += "FROM [dbo].[HANGHOA]";*/


            HangHoaDatDTO hanghoa = new HangHoaDatDTO();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaDonHang", hang.MADONHANG);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {

                                hanghoa.MAHANGHOADAT = reader["MaHangHoaDat"].ToString();




                                /* LoaiHangDTO loaihang = new LoaiHangDTO();
                                 loaihang.TENLOAIHANG = reader["TenLoaiHang"].ToString();
                                 lsLoaiHang.Add(loaihang);*/


                            }
                        }


                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return hanghoa.MAHANGHOADAT;
        }


        public bool themhangdat(HangHoaDatDTO hang)
        {
            string query = string.Empty;
            query += " insert into HANGHOADAT (MaHangHoaDat,MaDonHang,SoLuong) values (@mahanghoadat, @madonhang, @soluong)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;


                    cmd.Parameters.AddWithValue("@mahanghoadat", hang.MAHANGHOADAT);
                    cmd.Parameters.AddWithValue("@madonhang", hang.MADONHANG);
                    cmd.Parameters.AddWithValue("@soluong", hang.SOLUONG);
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
                        MessageBox.Show("thêm hàng hóa đặt thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("thêm hàng hóa đặt thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }
        public bool themloaihanghoadat(LoaiHangHoaDatDTO hang)
        {
            string query = string.Empty;
            query += " insert into LOAIHANGHOADAT (MaLoaiHangHoaDat,MaHangHoaDat,MaHangHoa,SoLuong) values (@maloaihanghoadat, @mahanghoadat, @mahanghoa,@soluong)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;


                    cmd.Parameters.AddWithValue("@maloaihanghoadat", hang.MALOAIHANGHOADAT);
                    cmd.Parameters.AddWithValue("@mahanghoadat", hang.MAHANHOADAT);
                    cmd.Parameters.AddWithValue("@mahanghoa", hang.MAHANGHOA);
                    cmd.Parameters.AddWithValue("@soluong", hang.SOLUONG);
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
                        MessageBox.Show("thêm loại hàng hóa đặt thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("thêm loại hàng hóa đặt thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }

        public List<HangHoaDTO> selectAvailable()
        {
            string query = string.Empty;
            query += "SELECT [dbo].[HANGHOA].[MaHangHoa], [dbo].[HANGHOA].[MoTa], [dbo].[HANGHOA].[Gia],[dbo].[HANGHOA].[SoLuong], [dbo].[HANGHOA].[Ten]";
            query += "FROM [dbo].[HANGHOA]";

            /* query += "SELECT [MaHangHoa], [Gia], [MoTa], [ThoiGianBaoHanh]";
             query += "FROM [dbo].[HANGHOA]";*/

            List<HangHoaDTO> lsHangHoa = new List<HangHoaDTO>();


            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                HangHoaDTO hanghoa = new HangHoaDTO();
                                hanghoa.MAHANGHOA = reader["MaHangHoa"].ToString();
                                hanghoa.Mota = reader["MoTa"].ToString();
                                hanghoa.GIA = reader["Gia"].ToString();
                                hanghoa.TEN = reader["Ten"].ToString();
                                hanghoa.SOLUONG = reader["SoLuong"].ToString();
                                lsHangHoa.Add(hanghoa);

                                /* LoaiHangDTO loaihang = new LoaiHangDTO();
                                 loaihang.TENLOAIHANG = reader["TenLoaiHang"].ToString();
                                 lsLoaiHang.Add(loaihang);*/


                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lsHangHoa;
        }
        public List<DonHang_HopDong_DTO> selectDonHang_HopDong()
        {
            string query = string.Empty;
            query += "select HOPDONG.MaHopDong,TenNguoiLienHe,DiaChi,MaDonHang from DONHANG , HOPDONG";
            query += " where DONHANG.MaHopDong = HOPDONG.MaHopDong ";

            /* query += "SELECT [MaHangHoa], [Gia], [MoTa], [ThoiGianBaoHanh]";
             query += "FROM [dbo].[HANGHOA]";*/

            List<DonHang_HopDong_DTO> lsHangHoa = new List<DonHang_HopDong_DTO>();


            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                DonHang_HopDong_DTO hanghoa = new DonHang_HopDong_DTO();
                                hanghoa.ID = reader["MaHopDong"].ToString();
                                hanghoa.TENKHACHHANG = reader["TenNguoiLienHe"].ToString();
                                hanghoa.THONGTINLIENHE = reader["DiaChi"].ToString();
                                hanghoa.MADDONHANG = reader["MaDonHang"].ToString();
                                hanghoa.LOAI = "Hợp đồng";

                                lsHangHoa.Add(hanghoa);

                                /* LoaiHangDTO loaihang = new LoaiHangDTO();
                                 loaihang.TENLOAIHANG = reader["TenLoaiHang"].ToString();
                                 lsLoaiHang.Add(loaihang);*/


                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lsHangHoa;
        }
        public HopDongDTO selectHopDong(DonHangDTO hang)
        {
            string query = string.Empty;
            query += "select * from  HOPDONG";
            query += " where HOPDONG.MaHopDong = @MaHopDong ";

            /* query += "SELECT [MaHangHoa], [Gia], [MoTa], [ThoiGianBaoHanh]";
             query += "FROM [dbo].[HANGHOA]";*/


            HopDongDTO hanghoa = new HopDongDTO();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHopDong", hang.MAHOPDONG);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {

                                hanghoa.id = reader["MaHopDong"].ToString();
                                hanghoa.TENTOCHUC = reader["TenToChuc"].ToString();
                                hanghoa.MST = reader["MST"].ToString();
                                hanghoa.TENNGUOILIENHE = reader["TenNguoiLienHe"].ToString();
                                hanghoa.DIACHI = reader["DiaChi"].ToString();
                                hanghoa.sdt = reader["SDT"].ToString();
                                hanghoa.EMAIL = reader["Email"].ToString();
                                hanghoa.DUONG = reader["Duong"].ToString();
                                hanghoa.SONHA = reader["SoNha"].ToString();
                                hanghoa.LAU = reader["Lau"].ToString();
                                hanghoa.PHONG = reader["Phong"].ToString();
                                hanghoa.KHUCAOOC = reader["KhuCaoOc"].ToString();
                                hanghoa.PHONGBAN = reader["PhongBan"].ToString();
                                hanghoa.MATINH = reader["Tinh"].ToString();
                                hanghoa.MAHUYEN = reader["Huyen"].ToString();
                                hanghoa.MAXA = reader["Xa"].ToString();
                                hanghoa.THOIGIANGIAODICH = reader["ThoiGianGiaoDich"].ToString();
                                hanghoa.MANHANVIEN = reader["MaNhanVien"].ToString();



                                /* LoaiHangDTO loaihang = new LoaiHangDTO();
                                 loaihang.TENLOAIHANG = reader["TenLoaiHang"].ToString();
                                 lsLoaiHang.Add(loaihang);*/


                            }
                        }


                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return hanghoa;
        }
        public CaNhanDTO selectCaNhan(DonHangDTO hang)
        {
            string query = string.Empty;
            query += "select * from  CaNhan";
            query += " where CANHAN.MaCaNhan = @MaCaNhan ";

            /* query += "SELECT [MaHangHoa], [Gia], [MoTa], [ThoiGianBaoHanh]";
             query += "FROM [dbo].[HANGHOA]";*/


            CaNhanDTO hanghoa = new CaNhanDTO();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHopDong", hang.MACANHAN);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {

                                hanghoa.MACANHAN = reader["MaCaNhan"].ToString();
                                hanghoa.TENNGUOILIENHE = reader["TenNguoiLienHe"].ToString();
                                hanghoa.DIACHI = reader["DiaChi"].ToString();
                                hanghoa.SDT = reader["SDT"].ToString();
                                hanghoa.EMAIL = reader["Email"].ToString();
                                hanghoa.DUONG = reader["Duong"].ToString();
                                hanghoa.SONHA = reader["SoNha"].ToString();
                                hanghoa.MAHUYEN = reader["Huyen"].ToString();



                                /* LoaiHangDTO loaihang = new LoaiHangDTO();
                                 loaihang.TENLOAIHANG = reader["TenLoaiHang"].ToString();
                                 lsLoaiHang.Add(loaihang);*/


                            }
                        }


                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return hanghoa;
        }
        public List<DonHang_HopDong_DTO> selectDonHang_CaNhan()
        {
            string query = string.Empty;
            query += "select CANHAN.MaCaNhan,TenNguoiLienHe,DiaChi,MaDonHang from DONHANG, CANHAN ";
            query += " where DONHANG.MaCaNhan = CANHAN.MaCaNhan ";

            /* query += "SELECT [MaHangHoa], [Gia], [MoTa], [ThoiGianBaoHanh]";
             query += "FROM [dbo].[HANGHOA]";*/

            List<DonHang_HopDong_DTO> lsHangHoa = new List<DonHang_HopDong_DTO>();


            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                DonHang_HopDong_DTO hanghoa = new DonHang_HopDong_DTO();
                                hanghoa.ID = reader["MaCaNhan"].ToString();
                                hanghoa.TENKHACHHANG = reader["TenNguoiLienHe"].ToString();
                                hanghoa.THONGTINLIENHE = reader["DiaChi"].ToString();
                                hanghoa.MADDONHANG = reader["MaDonHang"].ToString();
                                hanghoa.LOAI = "Cá nhân";

                                lsHangHoa.Add(hanghoa);

                                /* LoaiHangDTO loaihang = new LoaiHangDTO();
                                 loaihang.TENLOAIHANG = reader["TenLoaiHang"].ToString();
                                 lsLoaiHang.Add(loaihang);*/


                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lsHangHoa;
        }
    }
}
