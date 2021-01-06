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
    public class LoaiHangDAL
    {
       
            private string connectionString;

            public string ConnectionString { get => connectionString; set => connectionString = value; }
            public LoaiHangDAL()
            {
                connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            }

            public List<LoaiHangDTO> select()
            {
                string query = string.Empty;
                query += "SELECT [TenLoaiHang]";
                query += "FROM [dbo].[LOAIHANG]";

                List<LoaiHangDTO> lsLoaiHang = new List<LoaiHangDTO>();

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
                                    LoaiHangDTO loaihang = new LoaiHangDTO();
                                    loaihang.TENLOAIHANG = reader["TenLoaiHang"].ToString();
                                    lsLoaiHang.Add(loaihang);
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
                return lsLoaiHang;
            }
        }
    
}
