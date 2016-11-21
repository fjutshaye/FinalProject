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
                DatabaseTools.setConnection("localhost", "root", "", "finalproject");
                if (DatabaseTools.insertUser(username, password))
                {
                    Response.Redirect("Page_Login.aspx");
                }
                else
                {
                    Response.Write("<p>Error, failed to create account</p>");
                }
                //if (DatabaseTools.validateAccount(username, password))
                //{
                //    //Response.Write("Login successfully");
                //    Session["username"] = username;
                //    Response.Redirect("Page_Home.aspx");
                //}
                //else
                //{
                //    Response.Write("Login failed, please check your username and password.");
                //}
            }
        }
    }
}