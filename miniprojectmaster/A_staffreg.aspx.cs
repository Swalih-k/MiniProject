using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace miniprojectmaster
{
    public partial class WebForm18 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string gen = "";
            if (RadioButton1.Checked == true)
            {
                
                    gen = "male";

                }
                else
                {
                    gen = "female";

                }
                dboperation db = new dboperation();
            string query = "insert into A_staffreg values('" + TextBox1.Text + "','" + DropDownList1.Text + "','" + TextBox2.Text + "','"+gen+"')";
            db.exenonquery(query);
        }
    }
}