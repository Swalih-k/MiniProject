using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace miniprojectmaster
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
            }
            grid();

        }
        public void grid()
        {
            int h_id = Convert.ToInt32(Session["hstl_id"].ToString());
            string query="select * from s_complaintwrite inner join s_registration on s_complaintwrite.r_id=s_registration.r_id where h_id="+h_id+"";
            dboperation db = new dboperation();
            DataTable dt = db.exetables(query);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

       

       

       

      

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = "update s_complaintwrite set replay='" + replay.Text + "' where c_id='" + TextBox1.Text + "' ";
            dboperation db = new dboperation();
            db.exenonquery(query);
            grid();


        }

        

        

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            int c_id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            string query = "select * from s_complaintwrite where c_id=" + c_id + "";
            dboperation db = new dboperation();
            DataTable dt = db.exetables(query);
            if (dt.Rows.Count > 0)
            {
                TextBox1.Text = dt.Rows[0][0].ToString();
                replay.Text = dt.Rows[0][1].ToString();
            }
        }

        protected void LinkButton2_Click1(object sender, EventArgs e)
        {
            int c_id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            string query = "delete from s_complaintwrite where c_id=" + c_id + "";
            dboperation db = new dboperation();
            db.exenonquery(query);
        }
    }
}