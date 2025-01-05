using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace miniprojectmaster
{
    public partial class WebForm26 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Grid();
        }
        public void Grid()
        {
            string query = "select * from s_registration";
            dboperation db = new dboperation();
            DataTable dt = db.exetables(query);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int r_id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            string query = "update s_registration set status='Success' where r_id=" + r_id + "";
            dboperation db = new dboperation();
            db.exenonquery(query);
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            int r_id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            string query = "delete from s_registration where r_id=" + r_id + "";
            dboperation db = new dboperation();
            db.exenonquery(query);
        }
    }
}