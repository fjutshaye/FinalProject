using DatabaseTest1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject_v_0_1.Pages
{
    public partial class Page_Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Request.Form.Get("signUp_username");
            string password = Request.Form.Get("signUp_password");
            if (username != null && password != null)
            {
                if (DatabaseTools.singUptUser("%", username, password))
                {
                    if (DatabaseTools.singUptUser("localhost", username, password))
                    {
                        if (DatabaseTools.insertProfile(username))
                        {
                            Response.Redirect("Page_Login.aspx");
                        }
                        else
                        {
                            Response.Write("<p>Error, failed to create account</p>");
                        }
                    }
                    else
                    {
                        Response.Write("<p>Error, failed to create account</p>");
                    }
                }
                else
                {
                    Response.Write("<p>Error, failed to create account</p>");
                }
            }
        }
    }
}