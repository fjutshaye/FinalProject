<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page_Profile.aspx.cs" Inherits="FinalProject_v_0_1.Pages.Page_Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../Style/StyleSheet.css" />
    <script type="text/javascript" src="../Script/script_profile.js"></script>
</head>
<body>
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
        <asp:TextBox CssClass="signUp_textbox" ID="TextBox_CarInfo" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <asp:Button CssClass="signUp_button" ID="Button_ChangeProfile" runat="server" Text="Change My Profile" OnClientClick="setTextBoxChangeable()" />
        <asp:Button CssClass="signUp_button" ID="Button_SaveProfile" runat="server" Text="Save" Enabled="False" />
    </div>
    <div class="profile_div">
        <h2>Post My Carpool</h2>
        <label>Destination:</label>
        <asp:TextBox CssClass="signUp_textbox" ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <label>Date & Time</label>
        <asp:DropDownList CssClass="signUp_textbox" ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:DropDownList CssClass="signUp_textbox" ID="DropDownList2" runat="server">
        </asp:DropDownList>
        <asp:DropDownList CssClass="signUp_textbox" ID="DropDownList3" runat="server">
        </asp:DropDownList>
        <br />
        <label>Car Information:</label>
        <asp:DropDownList CssClass="signUp_textbox" ID="DropDownList4" runat="server"></asp:DropDownList>
        <br />
        <label>Capacity</label>
        <asp:DropDownList CssClass="signUp_textbox" ID="DropDownList5" runat="server"></asp:DropDownList>
        <br />
        <label>More Description:</label>
        <asp:TextBox CssClass="signUp_textbox" ID="TextBox6" runat="server" TextMode="MultiLine"></asp:TextBox>
    </div>
    </form>
</body>
</html>
