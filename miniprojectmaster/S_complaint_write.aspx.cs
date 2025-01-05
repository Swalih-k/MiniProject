using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace miniprojectmaster
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                DropDownList2.Items.Add(i.ToString());
            }
            for (int j = 1; j <= 12; j++)
            {
                DropDownList3.Items.Add(j.ToString());
            }
            for (int k = 2024; k <= 2025; k++)
            {
                DropDownList4.Items.Add(k.ToString());
            }
            if (!IsPostBack)
            {
                dboperation db = new dboperation();
                string query = "select * from A_registration";
                DataTable dt = db.exetables(query);

                DropDownList5.DataSource = dt;
                DropDownList5.DataTextField = "h_name";
                DropDownList5.DataValueField = "h_id";
                DropDownList5.DataBind();
            }
            joint();
            grid( );
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string date1 = "";
            date1 = DropDownList2.Text + "/" + DropDownList3.Text + "/" + DropDownList4.Text;

            dboperation db = new dboperation();
            int r_id = Convert.ToInt32(Session["stud_id"].ToString());
            string query = "insert into s_complaintwrite values('" + TextBox1.Text + "','" + r_id + "','" + date1 + "','','" + DropDownList5.Text + "')";
            db.exenonquery(query);
        }

        public void joint()
        {
            string query = "select * from s_complaintwrite inner join A_registration on s_complaintwrite.c_id=A_registration.h_id";
            dboperation db = new dboperation();
            DataTable dt = db.exetables(query);
        }
        public void grid()
        {
            int r_id = Convert.ToInt32(Session["stud_id"].ToString());
            string query = "select * from s_complaintwrite where r_id="+r_id+" ";
            dboperation db = new dboperation();
            DataTable dt = db.exetables(query);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}