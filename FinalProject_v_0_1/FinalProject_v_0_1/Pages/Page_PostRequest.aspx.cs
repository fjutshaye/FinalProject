using DatabaseTest1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject_v_0_1.Pages
{
    public partial class Page_PostRequest : System.Web.UI.Page
    {
        private string username;

        protected void Page_Load(object sender, EventArgs e)
        {
            username = (string)Session["username"];
            Label_Username.Text = username;
        }

        private DateTime getRequestDateTime()
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
        private string generateRequestId()
        {
            Guid g = new Guid();
            g = Guid.NewGuid();
            return g.ToString() + "/111";
        }
        private bool validation()
        {
            BulletedList_InfoFeedBack.Items.Clear();

            if (!ValidationTools.chequeDestination(TextBox_Destination.Text))
            {
                BulletedList_InfoFeedBack.Items.Add("Invalid Destination");
                return false;
            }
            if (!ValidationTools.chequeTime(TextBox_Hour.Text, TextBox_Minute.Text))
            {
                BulletedList_InfoFeedBack.Items.Add("Invalid Time");
                return false;
            }
            return true;
        }

        protected void Button_Submit_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                DateTime dt = getRequestDateTime();
                if (dt.CompareTo(DateTime.Now) < 0)
                {
                    BulletedList_InfoFeedBack.Items.Add("Don't set date earlier than today.");
                    return;
                }
                string requestlId = generateRequestId();
                bool temp = DatabaseTools.insertRequest(requestlId, username, TextBox_Destination.Text, dt,
                    int.Parse(DropDownList_Capacity.SelectedValue.ToString()), TextBox_Description.Text);
                if (temp)
                {
                    Label_Feedback.Text = "Post Successfully. Your Request ID is " + requestlId;
                }
                else
                {
                    Label_Feedback.Text = "Failed to Post";
                }
            }
        }
    }
}