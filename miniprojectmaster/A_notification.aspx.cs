using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace miniprojectmaster
{
    public partial class WebForm17 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dboperation db = new dboperation();
                string query = "select * from s_registration";
                DataTable dt = db.exetables(query);

                DropDownList1.DataSource = dt;
                DropDownList1.DataTextField = "f_name";
                DropDownList1.DataValueField = "r_id";
                DropDownList1.DataBind();
            }
            join();
        }

        public void join()
        {
            string query = "select * from A_notification inner join s_registration on A_notification.n_id=s_registration.r_id";
            dboperation db = new dboperation();
            DataTable dt = db.exetables(query);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            dboperation db = new dboperation();
            int h_id = Convert.ToInt32(Session["hstl_id"].ToString());
            string query="insert into A_notification values('"+TextBox1.Text+"','"+DropDownList1.SelectedValue+"')";
            db.exenonquery(query);
        }
    }
}