<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page_HomePage.aspx.cs" Inherits="FinalProject.Page_HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome</title>
    <link type="text/css" rel="stylesheet" href="StyleSheet1.css" />
</head>
<body>
    <form id="form1" runat="server">
         <div class="mainContainer">
            <div class="img_button">
                    <a href="Page_Profile.aspx"><img src="../src/icon_profile.png"/></a>
                    My Profile
            </div>
            <div class="img_button">
                    <a href="Page_Timetable.aspx"><img src="../src/icon_timetable.png"/></a>
                    My Timetable
            </div>
            <div class="img_button">
                    <a href="Page_Diary.aspx"><img src="../src/icon_diary.png"/></a>
                    My Diary
            </div>
            <div class="img_button">
                    <a href="Page_Course.aspx"><img src="../src/icon_course.png"/></a>
                    My Course
            </div>
        </div>
    <div class="footer">
        @copyright
    </div>
    </form>
</body>
</html>
