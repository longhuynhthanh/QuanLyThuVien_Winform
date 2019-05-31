using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_CSDL
{
    class DataProvider
    {
        // Tạo kết nối với DataBase
        static SqlConnection Connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True");

        static public DataTable LoadCSDL(string sql)
        {
            DataTable dt = new DataTable();

            SqlCommand Command = new SqlCommand(sql, Connection);

            SqlDataAdapter da = new SqlDataAdapter(Command);
            da.Fill(dt);
            Connection.Close();
            return dt;
        }

        static public int Change(string sql)
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }

            SqlCommand Command = new SqlCommand(sql, Connection);
            int Result = Command.ExecuteNonQuery();

            Connection.Close();
            return Result;
        }
    }
}
