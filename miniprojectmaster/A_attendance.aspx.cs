using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace miniprojectmaster
{
    public partial class WebForm15 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dboperation db = new dboperation();
                string query = "select * from s_registration";
                DataTable dt = db.exetables(query);

                DropDownList2.DataSource = dt;
                DropDownList2.DataTextField = "f_name";
                DropDownList2.DataValueField = "r_id";
                DropDownList2.DataBind();
                
            }
            join();
            Grid();
        }


        public void join()
        {
            string query = "select a_id,date,A_attendance.status,s_registration.f_name from A_attendance inner join s_registration on A_attendance.r_id=s_registration.r_id";
            dboperation db = new dboperation();
            DataTable dt = db.exetables(query);
            dt = db.exetables(query);
        }
        public void Grid()
        {
            string query = "select * from A_attendance";
            dboperation db = new dboperation();
            DataTable dt = db.exetables(query);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }











        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            dboperation db = new dboperation();
            int h_id = Convert.ToInt32(Session["hstl_id"].ToString());
            string query = "insert into A_attendance (date,status,r_id) values('" + Calendar1.SelectedDate + "','" + TextBox2.Text + "','" + DropDownList2.SelectedValue + "')";
            db.exenonquery(query);
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int a_id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            string query = "delete from A_attendance where a_id=" + a_id + ""; 
            dboperation db = new dboperation();
            db.exenonquery(query);
        }
    }
}