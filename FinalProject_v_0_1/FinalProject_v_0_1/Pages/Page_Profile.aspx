<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page_Profile.aspx.cs" Inherits="FinalProject_v_0_1.Pages.Page_Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../Style/StyleSheet.css" />
    <script type="text/javascript" src="../Script/PagesLoad.js"></script>
</head>
<body>
    <div>account: <asp:label ID="Label_Username" runat="server"></asp:label></div>
    <script>includeNavigation()</script>
    <form id="profile_page" runat="server">
    <div class="profile_div">
        <h2>Profile Options</h2>
        <label>Name:</label>
        <asp:TextBox CssClass="signUp_textbox" ID="TextBox_Name" runat="server" ReadOnly="True"></asp:TextBox><br />
        <br />
        <label>Phone Number:</label>
        <asp:TextBox CssClass="signUp_textbox" ID="TextBox_Phone" runat="server" TextMode="Phone" ReadOnly="True"></asp:TextBox><br />
        <br />
        <label>Email:</label>
        <asp:TextBox CssClass="signUp_textbox" ID="TextBox_Email" runat="server" TextMode="Email" ReadOnly="True"></asp:TextBox><br />
        <br />
        <label>My Car Information:</label>
        <asp:TextBox CssClass="signUp_textbox" ID="TextBox_CarInfo" runat="server" ReadOnly="True" BorderStyle="Solid" MaxLength="120" Rows="5" TextMode="MultiLine" Wrap="False"></asp:TextBox>
        <br />
        <asp:Button CssClass="signUp_button" ID="Button_ChangeProfile" runat="server" Text="Change My Profile" OnClick="Button_ChangeProfile_Click" />
        <asp:Button CssClass="signUp_button" ID="Button_SaveProfile" runat="server" Text="Save" Enabled="False" OnClick="Button_SaveProfile_Click" />
    </div>
    <div class="profile_div">
        <h2>Post My Carpool</h2>
        <label>Destination:</label>
        <asp:TextBox CssClass="signUp_textbox" ID="TextBox_Destination" runat="server"></asp:TextBox>
        <br />
        <label>Date & Time</label>
        <asp:Calendar ID="Calendar_Resource" runat="server"></asp:Calendar>
        <br />
        <label>Car Information:</label>
        <asp:DropDownList CssClass="signUp_textbox" ID="DropDownList_CarInfo" runat="server">
        </asp:DropDownList>
        <br />
        <label>Capacity</label>
        <asp:DropDownList CssClass="signUp_textbox" ID="DropDownList_Capacity" runat="server">
            <asp:ListItem Selected="True">1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem Value="6"></asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem Value="0">7+</asp:ListItem>
        </asp:DropDownList>
        <br />
        <label>More Description:</label>
        <asp:TextBox CssClass="signUp_textbox" ID="TextBox_Description" runat="server" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:Button CssClass="signUp_button" ID="Button_PostCarpool" runat="server" text="Post My Carpool" OnClick="Button_PostCarpool_Click"/>
        <br />
        <asp:Label ID="Label_Feedback" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
