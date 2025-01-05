using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace miniprojectmaster
{
    public partial class WebForm16 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //dboperation db = new dboperation();
                //string query1 = "select * from s_registration";
                //DataTable dt = db.exetables(query1);

                //DropDownList1.DataSource = dt;
                //DropDownList1.DataTextField = "f_name";
                //DropDownList1.DataValueField = "r_id";
                //DropDownList1.DataBind();

                dboperation db = new dboperation();
                string query = "select * from A_registration";
                DataTable dt = db.exetables(query);

                DropDownList2.DataSource = dt;
                DropDownList2.DataTextField = "h_name";
                DropDownList2.DataValueField = "h_id";
                DropDownList2.DataBind();

            }
            join();
        }
        public void join()
        {
            string query = "select * from s_registration inner join s_parentreg on s_registration.r_id=s_parentreg.p_id";

            dboperation db = new dboperation();
            DataTable dt = db.exetables(query);
            dt = db.exetables(query);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            


            dboperation db = new dboperation();
            int r_id = Convert.ToInt32(Session["stud_id"].ToString());
            string query = "insert into s_parentreg values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + DropDownList2.SelectedValue + "','Pending')";
            db.exenonquery(query);
        }
    }
}