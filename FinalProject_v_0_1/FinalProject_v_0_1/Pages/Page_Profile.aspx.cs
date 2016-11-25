using DatabaseTest1;
using System;

namespace FinalProject_v_0_1.Pages
{
    public partial class Page_Profile : System.Web.UI.Page
    {
        private string username;
        private object[] userProfile;
        protected void Page_Load(object sender, EventArgs e)
        {
            //username = (string)Session["username"];
            //userProfile = DatabaseTools.queryProfile(username);

            //TextBox_Name.Text = userProfile[1].ToString();
            //TextBox_Phone.Text = userProfile[2].ToString();
            //TextBox_Email.Text  = userProfile[0].ToString();
            //TextBox_CarInfo.Text  = userProfile[4].ToString();
        }
    }
}