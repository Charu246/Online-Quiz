using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H0ECJ3B\SQLEXPRESS;Initial Catalog=quiz;Integrated Security=True");
        SqlDataReader dr;
     
        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            //username=ascea01 and password=123456
            SqlCommand cmd = new SqlCommand("select * from login where username='" + TextBox1.Text + "' and password= '" + TextBox2.Text + "' ", con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("WebForm1.aspx");
            }
            else
            {
                Label4.Visible = true;
                Label4.Text = "Invalid userid or password";
            }
            con.Close();
        }
    }
}