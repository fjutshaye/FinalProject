using DatabaseTest1;
using System;

namespace FinalProject_v_0_1
{
    public partial class Page_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Request.Form.Get("username");
            string password = Request.Form.Get("password");
            if (username != null && password != null)
            {
                DatabaseTools.setConnection("localhost", "root", "", "finalproject");
                if (DatabaseTools.validateAccount(username, password))
                {
                    Response.Write("Login successfully");
                }
                else
                {
                    Response.Write("Login failed, please check your username and password.");
                }
            }
        }

    }
}