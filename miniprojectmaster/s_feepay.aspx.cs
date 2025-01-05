using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace miniprojectmaster
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dboperation db = new dboperation();
                string query = "select * from A_registration";
                DataTable dt = db.exetables(query);

                h_idlist.DataSource = dt;
                h_idlist.DataTextField = "h_name";
                h_idlist.DataValueField = "h_id";
                h_idlist.DataBind();
            }
            joint();
        }

        public void joint()
        {
            string query = "select * from s_fees inner join  s_registration on s_fees.fee_id=s_registration.r_id";
            dboperation db = new dboperation();
            DataTable dt = db.exetables(query);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            dboperation db = new dboperation();
            int r_id = Convert.ToInt32(Session["stud_id"].ToString());
            string query = "insert into s_fees values('" + r_id + "','" + Date.Text + "','" + h_idlist.Text + "','" + Amount.Text + "')";
            db.exenonquery(query);
        }
    }
}