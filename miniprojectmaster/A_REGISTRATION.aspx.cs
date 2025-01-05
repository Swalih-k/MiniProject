using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace miniprojectmaster
{
    public partial class A_REGISTRATION : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dboperation db = new dboperation();
            string query = "insert into A_registration values('" + h_name.Text + "','" + location.Text + "','" + warden_name.Text + "')";
            db.exenonquery(query);
        }
    }
}