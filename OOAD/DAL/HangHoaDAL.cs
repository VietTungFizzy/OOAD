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

        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public HangHoaDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public List<HangHoaDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [LOAIHANG].[TenLoaiHang], [NHASANXUAT].[TenNhaSanXuat], [HANGHOA].[MaHangHoa], [HANGHOA].[MoTa], [HANGHOA].[Gia], [HANGHOA].[ThongGianBaoHanh]";
            query += "FROM [HANGHOA], [LOAIHANG], [NHASANXUAT]";
            query += "WHERE ([HANGHOA].[MaNhaSanXuat] = [NHASANXUAT].[MaNhaSanXuat])";
            query += "AND ([HANGHOA].[MaLoaiHang] = [LOAIHANG].[MaLoaiHang])";

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
                                hanghoa.MaHH = reader["MaHangHoa"].ToString();
                                hanghoa.Mota = reader["MoTa"].ToString();   
                                hanghoa.Gia = reader["Gia"].ToString();
                                hanghoa.TGBH = reader["ThongGianBaoHanh"].ToString();
                                
                                lsHangHoa.Add(hanghoa);
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
