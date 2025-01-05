using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace miniprojectmaster
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dboperation db =new dboperation();
            string query = "insert into A_foodreg values('" + DropDownList1.Text + "','" + DropDownList2.Text + "','" + DropDownList3.Text + "')";
            db.exenonquery(query);
        }
    }
}