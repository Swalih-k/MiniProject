using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace miniprojectmaster
{
    public partial class Loging : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = "select * from s_registration where f_name='" + TextBox1.Text + "' and password='" + TextBox2.Text + "' ";
            dboperation db = new dboperation();
            DataTable dt = new DataTable();
            dt = db.exetables(query);
            if (dt.Rows.Count > 0)
            {
                Session["stud_id"] = dt.Rows[0][0].ToString();
                Response.Redirect("S_home.aspx");

            }
            string query1 = "select * from A_registration where h_name='" + TextBox1.Text + "' and warden_name='" + TextBox2.Text + "' ";
            dboperation db1 = new dboperation();
            DataTable dt1 = new DataTable();
            dt1 = db1.exetables(query1);
            if (dt1.Rows.Count > 0)
            {
                Session["hstl_id"] = dt1.Rows[0][0].ToString();
                Response.Redirect("A_home.aspx");
            }
        }
    }
}