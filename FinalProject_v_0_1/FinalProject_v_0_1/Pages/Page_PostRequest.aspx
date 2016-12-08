<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page_PostRequest.aspx.cs" Inherits="FinalProject_v_0_1.Pages.Page_PostRequest" %>

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
    <form id="form1" runat="server">
    <div class="requestDiv">
        <h2>Post Your Request</h2>
        <label>Destination: </label>
        <asp:TextBox runat="server" ID="TextBox_Destination" CssClass="signUp_textbox"></asp:TextBox>
        <label>Capacity: </label>
        <asp:DropDownList runat="server" ID="DropDownList_Capacity" CssClass="signUp_textbox">
            <asp:ListItem Selected="True">1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
        </asp:DropDownList>
        <br />
        <label>Date: </label>
        <asp:Calendar ID="Calendar_Resource" runat="server"></asp:Calendar>
        <br />
        <label>Time: </label>
        <asp:TextBox ID="TextBox_Hour" runat="server" BorderStyle="Solid" TextMode="Time">12</asp:TextBox>
        <label> : </label>
        <asp:TextBox ID="TextBox_Minute" runat="server" BorderStyle="Solid">00</asp:TextBox>
        <asp:DropDownList ID="DropDownList_AmPm" runat="server">
            <asp:ListItem Selected="True">am</asp:ListItem>
            <asp:ListItem>pm</asp:ListItem>
        </asp:DropDownList>
        <br />
        <label>More Description:</label>
        <asp:TextBox CssClass="signUp_textbox" ID="TextBox_Description" runat="server" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:Button runat="server" ID="Button_Submit" Text="Submit" CssClass="signUp_button" OnClick="Button_Submit_Click" />
        <br />
        <asp:Label ID="Label_Feedback" runat="server"></asp:Label>
        <asp:BulletedList ID="BulletedList_InfoFeedBack" runat="server" BulletStyle="Circle"></asp:BulletedList>
    </div>
    </form>
    <script>includeFooter()</script>
</body>
</html>
