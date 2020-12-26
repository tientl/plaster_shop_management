using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLi_CuaHangThachCao
{
    class ConnectionDB
    {
        public static string conString = @"Data Source=DESKTOP-1A6GVM6;Initial Catalog=QL-ThachCao;Integrated Security=True";
        public SqlConnection con;
        public DataTable dt;
        public SqlCommand command;
        public string Path()
        {
            return conString;
        }
        public void connect()
        {            
            con = new SqlConnection(conString);
            con.Open();
        }
        public void disconnect()
        {
            con.Close();
            con.Dispose();
            con = null;
        }
        public void ExecuteNonQuery(string sql)

        {

            connect();

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.ExecuteNonQuery();

            disconnect();

        }
        public DataTable getDataTable(string sql)
        {
            connect();
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            disconnect();
            return dt;
        }
        public void ExcuteQuery(string nonsql)
        {
            connect();
            SqlCommand cmd = new SqlCommand(nonsql, con);
            cmd.ExecuteNonQuery();
            disconnect();
        }
        public SqlDataReader getDataReader(string readsql)
        {
            connect();
            SqlCommand com = new SqlCommand(readsql, con);
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }
        //public static string connectionString = @"Data Source = TRANTIEN\SQLEXPRESS; Initial Catalog = QLSV; Integrated Security = True";

    }
}
