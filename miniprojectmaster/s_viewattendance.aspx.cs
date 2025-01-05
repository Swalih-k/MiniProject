using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace miniprojectmaster
{
    public partial class WebForm19 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Grid();
        }
        public void Grid()
        {
            string query = "select * from A_attendance";
            dboperation db = new dboperation();
            DataTable dt = db.exetables(query);
            GridView1.DataSource = dt;
            GridView1.DataBind();
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