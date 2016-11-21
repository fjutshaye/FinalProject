<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page_Signup.aspx.cs" Inherits="FinalProject_v_0_1.Pages.Page_Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../Style/StyleSheet.css"/>
    <script type="text/javascript" src="../Script/script_signUp.js"></script>
</head>
<body>
    <form id="signUp_form" runat="server" method="post" action="Page_Signup.aspx">
    <div class="signUp_div">
        <input type="text" name="signUp_username" id="signUp_username" class="signUp_textbox" placeholder="Valid Email Address"/>
        <label>This will be used as your username</label>
        <br />
        <input type="password" name="signUp_password" id="signUp_passwrod" class="signUp_textbox" placeholder="Password"/>
        <br />
        <input type="password" name="signUp_pwdConfirm" id="signUp_pwdConfirm" class="signUp_textbox" placeholder="Password Confirmation"/>
        <br />
        <input class="signUp_button" type="submit" name="Submit" value="Submit" onclick="return checkSignUp()"/>
        <input class="signUp_button" type="reset" name="Reset" value="Reset" />
        <div id="errMsg"></div>
    </div>
    </form>
</body>
</html>
