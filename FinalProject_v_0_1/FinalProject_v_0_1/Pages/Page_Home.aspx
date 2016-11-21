<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page_Home.aspx.cs" Inherits="FinalProject_v_0_1.Pages.Page_Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../Style/StyleSheet.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Welcome, 
        <asp:Label runat="server" ID="label_username"></asp:Label>
    </div>
    <div class="mainContainer">
        <a href="Page_Profile.aspx">
            <div class="img_button">
            <img src="../src/icon_profile.png"/>
            My Profile
            </div>
        </a>
        <a href="Page_SearchCar.aspx">
            <div class="img_button">
                <img src="../src/icon_pickup.png"/>
                Need a Ride
            </div>
        </a>
        <a href="Page_ViewPosts.aspx">
            <div class="img_button">
                <img src="../src/icon_viewposts.png"/>
                View Posts
            </div>
        </a>
        <a href="Page_Messages.aspx">
            <div class="img_button">
                <img src="../src/icon_message.png"/>
                Messages
            </div>
        </a>
    </div>
    </form>
</body>
</html>
