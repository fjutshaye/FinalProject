var errInfo = "";
var noErrFlag;

function checkInput()
{
    //var username = document.forms["login_form"]["username"].value;
    //var password = document.forms["login_form"]["password"].value;
    //alert(username);
    checkUsername();
    checkPassword();
    if (noErrFlag == false) {
        document.getElementById('errorMsg').innerHTML = "<ul class=\"errorMsg\">" + errInfo + "</ul>";
    }

    return noErrFlag;
}

function checkUsername() 
{
    var username = document.forms["login_form"]["username"].value;
    if (username == "" || username == null) {
        noErrFlag = false;
        errInfo = errInfo + "<li>Username is mandatory, please input an email address.</li>";
        return;
    }
    else {
        noErrFlag = validateUsername(username);
        return;
    }
}
function validateUsername(username)
{
    var pattern = /(\w+)\@(\w+)\.[a-zA-Z]/g;

    if (!pattern.test(username)) {
        errInfo = errInfo + "<li>Username must be an valid email address.</li>";
        return false;
    }

    return true;
}
function checkPassword() 
{
    var password = document.forms["login_form"]["password"].value;
    if (password == "" || password == null) {
        noErrFlag = false;
        errInfo = errInfo + "<li>Password is mandatory, please input a password.</li>";
        return;
    }
}