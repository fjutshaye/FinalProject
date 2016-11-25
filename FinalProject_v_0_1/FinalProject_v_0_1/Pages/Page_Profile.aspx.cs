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
            username = (string)Session["username"];

            if (!IsPostBack)
            {
                userProfile = DatabaseTools.queryProfile(username);
                TextBox_Name.Text = userProfile[1].ToString();
                TextBox_Phone.Text = userProfile[2].ToString();
                TextBox_Email.Text = userProfile[0].ToString();
                TextBox_CarInfo.Text = userProfile[4].ToString();
            }
        }

        protected void Button_ChangeProfile_Click(object sender, EventArgs e)
        {
            TextBox_Name.ReadOnly = false;
            TextBox_Phone.ReadOnly = false;
            TextBox_CarInfo.ReadOnly = false;
            Button_SaveProfile.Enabled = true;
        }

        protected void Button_SaveProfile_Click(object sender, EventArgs e)
        {
            TextBox_Name.ReadOnly = true;
            TextBox_Phone.ReadOnly = true;
            TextBox_CarInfo.ReadOnly = true;
            Button_SaveProfile.Enabled = false;

            DatabaseTools.updateProfile((string)Session["username"], TextBox_Name.Text, TextBox_Phone.Text, TextBox_CarInfo.Text);
        }
    }
}