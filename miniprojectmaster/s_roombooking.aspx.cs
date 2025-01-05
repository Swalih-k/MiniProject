using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace miniprojectmaster
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                DropDownList4.Items.Add(i.ToString());
            }
            for (int j = 1; j <= 12; j++)
            {
                DropDownList5.Items.Add(j.ToString());
            }
            for (int k = 2024; k <= 2025; k++)
            {
                DropDownList6.Items.Add(k.ToString());
            }
            if (!IsPostBack)
            {
                dboperation db = new dboperation();
                string query = "select * from A_registration";
                DataTable dt = db.exetables(query);

                DropDownList2.DataSource = dt;
                DropDownList2.DataTextField = "h_id";
                DropDownList2.DataValueField = "h_name";
                DropDownList2.DataBind();
            }
            joint();
        }

        public void joint()
        {
            string query = "select * from s_roombooking inner join A_registration on s_roombooking.r_id=A_registration.h_id";

            dboperation db = new dboperation();
            DataTable dt = db.exetables(query);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string date1 = "";
            date1 = DropDownList4.Text + "/" + DropDownList5.Text + "/" + DropDownList6.Text;

            dboperation db = new dboperation();
            int r_id = Convert.ToInt32(Session["stud_id"].ToString());
            string query = "insert into s_roombooking values('" + r_id + "','" + DropDownList2.SelectedValue + "','" + date1 + "','" + TextBox1.Text + "')";
            db.exenonquery(query);
        }
    }
}