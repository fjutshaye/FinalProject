<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page_Login.aspx.cs" Inherits="FinalProject_v_0_1.Page_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link type="text/css" rel="stylesheet" href="../Style/StyleSheet.css"/>
    <script type="text/javascript" src="../Script/JavaScript.js"></script>
</head>
<body>
    <script type="text/javascript" src="../Script/FacebookLogin.js"></script>

    <form id="login_form" method="post" runat="server" action="Page_Login.aspx">
    <div>
        <%--username must be an email address--%>
        <input type="text" class="login_textbox" name="username" id="username" placeholder="USERNAME" required="required"/>
        <input type="password" class="login_textbox" name="password" id="password" placeholder="PASSWORD" required="required"/>
        <input type="submit" class ="login_button" name="Login" value="Login" onclick="return checkInput()"/>
        <asp:Label CssClass="loing_label" ID="Label_static1" runat="server" Text="Don't have an account ?"></asp:Label>
        <asp:HyperLink CssClass="login_a" ID="Link_signup" runat="server">Sign up</asp:HyperLink>
    </div>
    <fb:login-button scope="public_profile,email" onlogin="checkLoginState();">Login with Facebook Account
    </fb:login-button>
    <!--
      Below we include the Login Button social plugin. This button uses
      the JavaScript SDK to present a graphical Login button that triggers
      the FB.login() function when clicked.
    -->
    <div id="status">
    </div>
    </form>

    <div id="errorMsg"></div>
</body>
</html>
