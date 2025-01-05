using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace miniprojectmaster
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dboperation db = new dboperation();
                int h_id = Convert.ToInt32(Session["hstl_id"].ToString());
                string query = "select * from A_registration where h_id=" + h_id + "";
                DataTable dt = new DataTable();
                dt = db.exetables(query);
                if (dt.Rows.Count > 0)
                {
                    TextBox1.Text = dt.Rows[0][0].ToString();
                    TextBox2.Text = dt.Rows[0][1].ToString();
                    TextBox3.Text = dt.Rows[0][2].ToString();
                    TextBox4.Text = dt.Rows[0][3].ToString();

                }
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int h_id = Convert.ToInt32(Session["hstl_id"].ToString());
            string query = "delete from A_registration where h_id=" + h_id + "";
            dboperation db = new dboperation();
            db.exenonquery(query);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = "update A_registration set h_name='" + TextBox2.Text + "',location='" + TextBox3.Text + "',warden_name='" + TextBox4.Text + "'";
            dboperation db = new dboperation();
            db.exenonquery(query);

        }
    }
}