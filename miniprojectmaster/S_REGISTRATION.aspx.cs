using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace miniprojectmaster
{
    public partial class S_REGISTRATION : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dboperation db = new dboperation();
            string query = "insert into s_registration values('" + f_name.Text + "','" + l_name.Text + "','" + email.Text + "','" + password.Text + "','" + confirm_password.Text + "','Pending')";
            db.exenonquery(query);
        }
    }
}