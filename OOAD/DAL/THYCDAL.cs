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
    public class THYCDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public THYCDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool luu(THYCDTO thuchien)
        {
            string query = string.Empty;
            query += "INSERT INTO [dbo].[PHIEUTHUCHIENYEUCAU] ([MST],[GhiChu],[SDT],[Email],[Tinh],[Huyen],[Xa],[Duong], [SoNha], [Lau], [Phong], [Website],[SDTBan1], [SDTBan2], [TenCoQuan], [HoVaTen],[KhuCaoOc],[PhongBan],[MaPTGuiHang],[MaNhanVienGhiNhan],[YeuCau],[ThoiGianDapUng],[NhanDinhThucTrang], [QuaTrinhXuLy],[KetQua],[MaNhanVienThucHien],[GiaTriPO]) ";
            query += "VALUES (@MST, @GhiChu,@SDT,@Email,@Tinh,@Huyen,@Xa,@Duong, @SoNha, @Lau, @Phong, @Website, @SDTBan1, @SDTBan2, @TenCoQuan, @HoVaTen,@KhuCaoOc,@PhongBan,@MaPTGuiHang,@MaNhanVienGhiNhan, @YeuCau,@ThoiGianDapUng,@NhanDinhThucTrang, @QuaTrinhXuLy, @KetQua,@MaNhanVienThucHien, @GiaTriPO)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                   // cmd.Parameters.AddWithValue("@ID", thuchien.id);
                    cmd.Parameters.AddWithValue("@MST", thuchien.mst);
                    cmd.Parameters.AddWithValue("@GhiChu", thuchien.GHICHU);
                    cmd.Parameters.AddWithValue("@SDT", thuchien.sdt);
                    cmd.Parameters.AddWithValue("@Email", thuchien.EMAIL);
                    cmd.Parameters.AddWithValue("@Tinh", thuchien.TINH);
                    cmd.Parameters.AddWithValue("@Huyen", thuchien.HUYEN);
                    cmd.Parameters.AddWithValue("@Xa", thuchien.XA);
                    cmd.Parameters.AddWithValue("@Duong", thuchien.DUONG);
                    cmd.Parameters.AddWithValue("@SoNha", thuchien.SONHA);
                    cmd.Parameters.AddWithValue("@Lau", thuchien.LAU);
                    cmd.Parameters.AddWithValue("@Phong", thuchien.PHONG);
                    cmd.Parameters.AddWithValue("@Website", thuchien.WEBSITE);
                    cmd.Parameters.AddWithValue("@SDTBan1", thuchien.SDTBAN1);
                    cmd.Parameters.AddWithValue("@SDTBan2", thuchien.SDTBAN2);
                    cmd.Parameters.AddWithValue("@TenCoQuan", thuchien.TENCOQUAN);
                    cmd.Parameters.AddWithValue("@HoVaTen", thuchien.HOVATEN);
                    cmd.Parameters.AddWithValue("@KhuCaoOc", thuchien.KHUCAOOC);
                    cmd.Parameters.AddWithValue("@PhongBan", thuchien.PHONGBAN);
                    cmd.Parameters.AddWithValue("@MaPTGuiHang", thuchien.MAPTGUIHANG);
                    cmd.Parameters.AddWithValue("@MaNhanVienGhiNhan", thuchien.MANHANVIENGHINHAN);
                    cmd.Parameters.AddWithValue("@YeuCau", thuchien.YEUCAU);
                    cmd.Parameters.AddWithValue("@ThoiGianDapUng", thuchien.THOIGIANKHDAPUNG);
                    cmd.Parameters.AddWithValue("@NhanDinhThucTrang", thuchien.NHANDINHTHUCTRANG);
                    cmd.Parameters.AddWithValue("@QuaTrinhXuLy", thuchien.QUATRINHXULY);
                    cmd.Parameters.AddWithValue("@KetQua", thuchien.KETQUA);
                    cmd.Parameters.AddWithValue("@MaNhanVienThucHien", thuchien.MANHANVIENTHUCHIEN);
                    cmd.Parameters.AddWithValue("@GiaTriPO", thuchien.GIATRIPO);
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
                        MessageBox.Show("thêm phiếu thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }

            MessageBox.Show("thêm phiếu thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }

        public THYCDTO collect_update(string key)
        {
            string query = string.Empty;
            query += "SELECT *";
            query += "FROM [dbo].[PHIEUTHUCHIENYEUCAU]";
            query += "WHERE [dbo].[PHIEUTHUCHIENYEUCAU].[MaThucHienYeuCau] = @key";


            THYCDTO thuchien_collect = new THYCDTO();

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

                                thuchien_collect.MATHUCHIENYEUCAU = int.Parse(reader["MaThucHienYeuCau"].ToString());
                                thuchien_collect.LAU = int.Parse(reader["Lau"].ToString());
                                thuchien_collect.GIATRIPO = int.Parse(reader["GiaTriPO"].ToString());
                                thuchien_collect.sdt = reader["SDT"].ToString();
                                thuchien_collect.mst = reader["MST"].ToString();
                                thuchien_collect.DUONG = reader["Duong"].ToString();
                                thuchien_collect.SONHA = reader["SoNha"].ToString();
                                thuchien_collect.GHICHU = reader["GhiChu"].ToString();
                                thuchien_collect.EMAIL = reader["Email"].ToString();
                                thuchien_collect.TINH = reader["Tinh"].ToString();
                                thuchien_collect.HUYEN = reader["Huyen"].ToString();
                                thuchien_collect.XA = reader["Xa"].ToString();
                                thuchien_collect.PHONG = reader["Phong"].ToString();
                                thuchien_collect.WEBSITE = reader["Website"].ToString();
                                thuchien_collect.SDTBAN1 = reader["SDTBan1"].ToString();
                                thuchien_collect.SDTBAN2 = reader["SDTBan2"].ToString();
                                thuchien_collect.KHUCAOOC = reader["KhuCaoOc"].ToString();
                                thuchien_collect.PHONGBAN = reader["PhongBan"].ToString();
                                thuchien_collect.MAPTGUIHANG = reader["MaPTGuiHang"].ToString();
                                thuchien_collect.THOIGIANKHDAPUNG = DateTime.Parse(reader["ThoiGianDapUng"].ToString());
                                thuchien_collect.NHANDINHTHUCTRANG = reader["NhanDinhThucTrang"].ToString();
                                thuchien_collect.QUATRINHXULY = reader["QuaTrinhXuLy"].ToString();
                                thuchien_collect.YEUCAU = reader["YeuCau"].ToString();
                                thuchien_collect.TENCOQUAN = reader["TenCoQuan"].ToString();
                                thuchien_collect.HOVATEN = reader["HoVaTen"].ToString();
                                thuchien_collect.MANHANVIENGHINHAN = reader["MaNhanVienGhiNhan"].ToString();
                                thuchien_collect.MANHANVIENTHUCHIEN = reader["MaNhanVienThucHien"].ToString();
                                thuchien_collect.KETQUA = reader["KETQUA"].ToString();
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
            return thuchien_collect;
    }


        public List<THYCDTO> select_THYC()
        {
            string query = string.Empty;
            query += "SELECT [dbo].[PHIEUTHUCHIENYEUCAU].[TenCoQuan], [dbo].[PHIEUTHUCHIENYEUCAU].[HoVaTen], [dbo].[PHIEUTHUCHIENYEUCAU].[MaNhanVienGhiNhan], [dbo].[PHIEUTHUCHIENYEUCAU].[MaNhanVienThucHien], [dbo].[PHIEUTHUCHIENYEUCAU].[KetQua],[dbo].[PHIEUTHUCHIENYEUCAU].[MaThucHienYeuCau]";
            query += "FROM [dbo].[PHIEUTHUCHIENYEUCAU]";



            List<THYCDTO> lsTHYC = new List<THYCDTO>();

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
                                THYCDTO thuchien = new THYCDTO();
                                thuchien.MATHUCHIENYEUCAU = int.Parse(reader["MaThucHienYeuCau"].ToString());
                                thuchien.TENCOQUAN = reader["TenCoQuan"].ToString();
                                thuchien.HOVATEN = reader["HoVaTen"].ToString();
                                thuchien.MANHANVIENGHINHAN = reader["MaNhanVienGhiNhan"].ToString();
                                thuchien.MANHANVIENTHUCHIEN = reader["MaNhanVienThucHien"].ToString();
                                thuchien.KETQUA = reader["KETQUA"].ToString();
                                lsTHYC.Add(thuchien);

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
            return lsTHYC;
        }
        
        public List<THYCDTO> select_THYC_search(string key)
        {
            string query = string.Empty;
            query += "SELECT [dbo].[PHIEUTHUCHIENYEUCAU].[TenCoQuan], [dbo].[PHIEUTHUCHIENYEUCAU].[HoVaTen], [dbo].[PHIEUTHUCHIENYEUCAU].[MaNhanVienGhiNhan], [dbo].[PHIEUTHUCHIENYEUCAU].[MaNhanVienThucHien], [dbo].[PHIEUTHUCHIENYEUCAU].[KetQua],[dbo].[PHIEUTHUCHIENYEUCAU].[MaThucHienYeuCau]";
            query += "FROM [dbo].[PHIEUTHUCHIENYEUCAU]";
            query += "WHERE [KetQua] = @key";



            List<THYCDTO> lsTHYC = new List<THYCDTO>();

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
                                THYCDTO thuchien = new THYCDTO();
                                thuchien.MATHUCHIENYEUCAU = int.Parse(reader["MaThucHienYeuCau"].ToString());
                                thuchien.TENCOQUAN = reader["TenCoQuan"].ToString();
                                thuchien.HOVATEN = reader["HoVaTen"].ToString();
                                thuchien.MANHANVIENGHINHAN = reader["MaNhanVienGhiNhan"].ToString();
                                thuchien.MANHANVIENTHUCHIEN = reader["MaNhanVienThucHien"].ToString();
                                thuchien.KETQUA = reader["KETQUA"].ToString();
                                lsTHYC.Add(thuchien);

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
            return lsTHYC;
        }

        public bool luu_sua(THYCDTO thuchien)
        {
            string query = string.Empty;
            query += "UPDATE [PHIEUTHUCHIENYEUCAU] SET [SDT] = @SDT, [Duong]= @Duong,[SoNha]=@SoNha,[Lau]=@Lau,[Phong]=@Phong,[Website]=@Website,[SDTBan1]=@SDTBan1,[SDTBan2]=@SDTBan2,[TenCoQuan]=@TenCoQuan,[HoVaTen]=@HoVaTen,[MaPTGuiHang]=@MaPTGuiHang,[MST]=@MST,[GhiChu]=@GhiChu,[KhuCaoOc]=@KhuCaoOc,[PhongBan]=@PhongBan,[Tinh]=@Tinh,[Huyen]=@Huyen,[Xa]=@Xa,[Email]=@Email,[YeuCau]=@YeuCau,[ThoiGianDapUng]=@ThoiGianDapUng,[NhanDinhThucTrang]=@NhanDinhThucTrang,[QuaTrinhXuLy]=@QuaTrinhXuLy,[KetQua]=@KetQua,[GiaTriPO]=@GiaTriPO,[MaNhanVienGhiNhan]=@MaNhanVienGhiNhan,[MaNhanVienThucHien]=@MaNhanVienThucHien WHERE [MaThucHienYeuCau] = @MaThucHienYeuCau";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MST", thuchien.mst);
                    cmd.Parameters.AddWithValue("@GhiChu", thuchien.GHICHU);
                    cmd.Parameters.AddWithValue("@SDT", thuchien.sdt);
                    cmd.Parameters.AddWithValue("@Email", thuchien.EMAIL);
                    cmd.Parameters.AddWithValue("@Tinh", thuchien.TINH);
                    cmd.Parameters.AddWithValue("@Huyen", thuchien.HUYEN);
                    cmd.Parameters.AddWithValue("@Xa", thuchien.XA);
                    cmd.Parameters.AddWithValue("@Duong", thuchien.DUONG);
                    cmd.Parameters.AddWithValue("@SoNha", thuchien.SONHA);
                    cmd.Parameters.AddWithValue("@Lau", thuchien.LAU);
                    cmd.Parameters.AddWithValue("@Phong", thuchien.PHONG);
                    cmd.Parameters.AddWithValue("@Website", thuchien.WEBSITE);
                    cmd.Parameters.AddWithValue("@SDTBan1", thuchien.SDTBAN1);
                    cmd.Parameters.AddWithValue("@SDTBan2", thuchien.SDTBAN2);
                    cmd.Parameters.AddWithValue("@TenCoQuan", thuchien.TENCOQUAN);
                    cmd.Parameters.AddWithValue("@HoVaTen", thuchien.HOVATEN);
                    cmd.Parameters.AddWithValue("@KhuCaoOc", thuchien.KHUCAOOC);
                    cmd.Parameters.AddWithValue("@PhongBan", thuchien.PHONGBAN);
                    cmd.Parameters.AddWithValue("@MaPTGuiHang", thuchien.MAPTGUIHANG);
                    cmd.Parameters.AddWithValue("@MaNhanVienGhiNhan", thuchien.MANHANVIENGHINHAN);
                    cmd.Parameters.AddWithValue("@YeuCau", thuchien.YEUCAU);
                    cmd.Parameters.AddWithValue("@ThoiGianDapUng", thuchien.THOIGIANKHDAPUNG);
                    cmd.Parameters.AddWithValue("@NhanDinhThucTrang", thuchien.NHANDINHTHUCTRANG);
                    cmd.Parameters.AddWithValue("@QuaTrinhXuLy", thuchien.QUATRINHXULY);
                    cmd.Parameters.AddWithValue("@KetQua", thuchien.KETQUA);
                    cmd.Parameters.AddWithValue("@MaNhanVienThucHien", thuchien.MANHANVIENTHUCHIEN);
                    cmd.Parameters.AddWithValue("@GiaTriPO", thuchien.GIATRIPO);
                    cmd.Parameters.AddWithValue("@MaThucHienYeuCau", thuchien.MATHUCHIENYEUCAU);
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
                        MessageBox.Show("cập nhật phiếu thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("cập nhật phiếu thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }

        public bool xoa(string key)
        {
            string query = string.Empty;
            query += "DELETE FROM [PHIEUTHUCHIENYEUCAU] WHERE [MaThucHienYeuCau] = @MaThucHienYeuCau";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaThucHienYeuCau", key);
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
                        MessageBox.Show("xóa phiếu thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("xóa phiếu thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }
    }
}
