<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page_Signup.aspx.cs" Inherits="FinalProject_v_0_1.Pages.Page_Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../Style/StyleSheet.css"/>
    <script type="text/javascript" src="../Script/JavaScript.js"></script>
</head>
<body>
    <form id="signUp_form" runat="server" method="post" action="Page_Signup.aspx">
    <div>
        <label>Valid Email Address:</label>
        <input type="text" name="signUp_username" id="signUp_username" class="signUp_textbox" />
        <label>This will be used as your username</label>
        <br />
        <label>Password:</label>
        <input type="password" name="signUp_password" id="signUp_passwrod" class="signUp_textbox"/>
        <br />
        <label>Password Confirmation</label>
        <input type="password" name="signUp_pwdConfirm" id="signUp_pwdConfirm" class="signUp_textbox" />
        <br />
        <input type="submit" name="Submit" value="Submit" />
        <input type="reset" name="Reset" value="Reset" />
    </div>
    </form>
</body>
</html>
