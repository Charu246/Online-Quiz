using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Timers;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        System.Timers.Timer t;
        int h, m, s;

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H0ECJ3B\SQLEXPRESS;Initial Catalog=quiz;Integrated Security=True");
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
           
        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {

            invoke(new Action(() =>
           {
               s -= 1;
               if(s == 60)
               {
                   s = 0;
                   m -= 1;
               }
               if (m == 60)
               {
                   m = 0;
                   h -= 1;
               }
               Label4.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));

           }));
           
        }

        private void invoke(Action action)
        {
           
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            foreach (DataListItem dl in DataList1.Items)
            {
                RadioButton rb1 = (RadioButton)dl.FindControl("RadioButton1");
                Label l1 = (Label)dl.FindControl("Label1");
                l1.Visible = true;

                if (rb1.Checked == true)
                {
                    
                     if (rb1.Text.Equals(l1.Text))
                     {
                         Label l2 = (Label)dl.FindControl("Label2");
                         l2.Text = "The  answer is" + l1.Text.ToString();
                        l2.ForeColor = System.Drawing.Color.Red;
                    }
                     else
                     {
                         Label l2 = (Label)dl.FindControl("Label2");
                         l2.Text = "The correct answer is" + l1.Text.ToString();
                        l2.ForeColor = System.Drawing.Color.Red;
                     }
                }
            }
                foreach (DataListItem dl in DataList1.Items)
                {
                    RadioButton rb2 = (RadioButton)dl.FindControl("RadioButton2");
                    Label l1 = (Label)dl.FindControl("Label1");
                    l1.Visible = true;
                    if (rb2.Checked == true)
                    {
                        if (rb2.Text.Equals(l1.Text))
                        {
                            Label l2 = (Label)dl.FindControl("Label2");
                            l2.Text = "The correct answer is" + l1.Text.ToString();
                        }
                        else
                        {
                            Label l2 = (Label)dl.FindControl("Label2");
                            l2.Text = "The correct answer is" + l1.Text.ToString();
                        }
                    }
                }
            foreach (DataListItem dl in DataList1.Items)
            {
                RadioButton rb3 = (RadioButton)dl.FindControl("RadioButton3");
                Label l1 = (Label)dl.FindControl("Label1");
                l1.Visible = true;
                if (rb3.Checked == true)
                {
                    if (rb3.Text.Equals(l1.Text))
                    {
                        Label l2 = (Label)dl.FindControl("Label2");
                        l2.Text = "The correct answer is" + l1.Text.ToString();
                    }
                    else
                    {
                        Label l2 = (Label)dl.FindControl("Label2");
                        l2.Text = "The correct answer is" + l1.Text.ToString();
                    }
                }
            }
                        foreach (DataListItem dl in DataList1.Items)
                        {
                            RadioButton rb4 = (RadioButton)dl.FindControl("RadioButton4");
                            Label l1 = (Label)dl.FindControl("Label1");
                            l1.Visible = true;
                            if (rb4.Checked == true)
                            {
                                if (rb4.Text.Equals(l1.Text))
                                {
                                    Label l2 = (Label)dl.FindControl("Label2");
                                    l2.Text = "The correct answer is" + l1.Text.ToString();
                                }
                                else
                                {
                                    Label l2 = (Label)dl.FindControl("Label2");
                                    l2.Text = "The correct answer is" + l1.Text.ToString();
                                }
                            }

                        }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            t.Start();
        }
    }
}