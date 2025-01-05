using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace miniprojectmaster
{
    public partial class WebForm21 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dboperation db = new dboperation();
                int r_id = Convert.ToInt32(Session["stud_id"].ToString());
                string query = "select * from s_registration where r_id=" + r_id + "";
                DataTable dt = new DataTable();
                dt = db.exetables(query);
                if (dt.Rows.Count > 0)
                {
                    TextBox5.Text = dt.Rows[0][0].ToString();
                    TextBox1.Text = dt.Rows[0][1].ToString();
                    TextBox2.Text = dt.Rows[0][2].ToString();
                    TextBox3.Text = dt.Rows[0][3].ToString();
                    

                }
                view();
            }
        }
            public void view()                                                        //view

            {
                string query = "select * from s_registration";
                dboperation db = new dboperation();
                DataTable dt = db.exetables(query);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }

            protected void Button1_Click(object sender, EventArgs e)
            {
            string query = "update s_registration set f_name='" + TextBox1.Text + "',l_name='" + TextBox2.Text + "',email='" + TextBox3.Text + "'";
            dboperation db = new dboperation();
            db.exenonquery(query);
        }

            

           

        protected void LinkButton2_Click1(object sender, EventArgs e)
        {
            int r_id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            string query = "delete from s_registration where r_id=" + r_id + "";
            dboperation db = new dboperation();
            db.exenonquery(query);
            view();
        }
    }
    } 