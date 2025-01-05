using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace miniprojectmaster
{
    public class dboperation
    {
        public SqlConnection con;
        public SqlCommand cmd;

        public dboperation()
        {
            con = new SqlConnection("Data Source=DESKTOP-SJUFSR2\\SQLEXPRESS;Initial Catalog=Hostel_management_system;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public SqlConnection getcon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();

            }
            return con;
        }
        public void dbclose()


        {
            con.Close();

        }

        public int exenonquery(string sql)
        {
            getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
            return i;
        }

        public DataTable exetables(string sql)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }

}