using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace miniprojectmaster
{
    public partial class WebForm20 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            view();
        }

        public void view()                                                        //view

        {
            string query = "select * from A_staffreg";
            dboperation db = new dboperation();
            DataTable dt = db.exetables(query);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int room_id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            string query = "delete from A_staffreg where room_id=" + room_id + "";
            dboperation db = new dboperation();
            db.exenonquery(query);
        }
    }
}