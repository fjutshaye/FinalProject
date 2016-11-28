using DatabaseTest1;
using System;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;

namespace FinalProject_v_0_1.Pages
{
    public partial class Page_Profile : System.Web.UI.Page
    {
        private string username;
        private object[] userProfile = new object[5];

        protected void Page_Load(object sender, EventArgs e)
        {
            username = (string)Session["username"];
            Label_Username.Text = username;

            if (!IsPostBack)
            {
                userProfile = DatabaseTools.queryProfile(username);
                if (!userProfile[4].Equals(null))
                {
                    DropDownList_CarInfo.Items.Add(new ListItem(userProfile[4].ToString()));
                }
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

            userProfile = DatabaseTools.queryProfile(username);
            if (!userProfile[4].Equals(null))
            {
                DropDownList_CarInfo.Items.Add(new ListItem(userProfile[4].ToString()));
            }
        }

        protected void Button_PostCarpool_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                
                DateTime dt = getCarpoolDateTime();
                if (dt.CompareTo(DateTime.Now) < 0)
                {
                    BulletedList_InfoFeedBack.Items.Add("Don't set date earlier than today.");
                    return;
                }
                //Response.Write(dt.Date.ToString());
                string carpoolId = generateCarpoolId();
                bool temp = DatabaseTools.insertCarpool(carpoolId, username, TextBox_Destination.Text, dt, DropDownList_CarInfo.SelectedValue.ToString(),
                    int.Parse(DropDownList_Capacity.SelectedValue.ToString()), TextBox_Description.Text);
                if (temp)
                {
                    Label_Feedback.Text = "Post Successfully. Your Carpool ID is " + carpoolId;
                }
                else
                {
                    Label_Feedback.Text = "Failed to Post";
                }
            }
        }

        private DateTime getCarpoolDateTime()
        {
            DateTime dt = Calendar_Resource.SelectedDate;
            int hour = int.Parse(TextBox_Hour.Text);
            int min = int.Parse(TextBox_Minute.Text);
            if (DropDownList_AmPm.SelectedValue.Equals("pm"))
            {
                hour += 12;
                if (hour >= 24)
                    hour = 0;
            }
            return dt.AddHours(hour).AddMinutes(min);
        }
        private string generateCarpoolId()
        {
            Guid g = new Guid();
            g = Guid.NewGuid();
            return g.ToString();
        }
        private bool validation()
        {
            BulletedList_InfoFeedBack.Items.Clear();

            if (!ValidationTools.chequeDestination(TextBox_Destination.Text))
            {
                BulletedList_InfoFeedBack.Items.Add("Invalid Destination");
                return false;
            }
            if(!ValidationTools.chequeTime(TextBox_Hour.Text, TextBox_Minute.Text))
            {
                BulletedList_InfoFeedBack.Items.Add("Invalid Time");
                return false;
            }
            if (!ValidationTools.chequeDescription(TextBox_Description.Text))
            {
                BulletedList_InfoFeedBack.Items.Add("Invalid Time");
                return false;
            }
            return true;
        }
    }
}