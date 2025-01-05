using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace miniprojectmaster
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            grid();
        }
        public void grid()
        {
            int h_id = Convert.ToInt32(Session["hstl_id"].ToString());
            string query = "select * from s_fees inner join s_registration on s_fees.r_id=s_registration.r_id where h_id=" + h_id + "";
            dboperation db = new dboperation();
            DataTable dt = db.exetables(query);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int fee_id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            string query = "delete from s_fees where fee_id=" + fee_id + "";
            dboperation db = new dboperation();
            db.exenonquery(query);
            grid();
        }
    }
}