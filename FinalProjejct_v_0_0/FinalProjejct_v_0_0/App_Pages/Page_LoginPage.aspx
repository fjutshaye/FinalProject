<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page_LoginPage.aspx.cs" Inherits="FinalProject.Page_LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <h1>Login Page</h1>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox_Username" runat="server" placeholder="Username"></asp:TextBox>
            <asp:TextBox ID="TextBox_Password" runat="server" placeholder="Password"></asp:TextBox>
            <input type="submit" name="Login" value="Login" />
        </div>
    </form>
</body>
</html>
