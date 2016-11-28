var errInfo;
var noErrFlag;
var errDiv;
var username;
var password;
var pConfirm;
function checkSignUp() {
    errInfo = "";
    noErrFlag = true;
    username = document.forms["signUp_form"]["signUp_username"].value;
    password = document.forms["signUp_form"]["signUp_password"].value;
    pConfirm = document.forms["signUp_form"]["signUp_pwdConfirm"].value;

    if (!checkUsername(username)){
        noErrFlag = false;
    }
    if (!checkPassword(password)) {
        noErrFlag = false;
    }
    if (!checkPConfirm(password,pConfirm)) {
        noErrFlag = false;
    }
    document.getElementById("errMsg").innerHTML = "<ul class=\"errorMsg\">" + errInfo + "</ul>";
    return noErrFlag;
}
function checkUsername(username) {
    var pattern = /(\w+)\@(\w+)\.[a-zA-Z]/g;
    if (username == "") {
        errInfo += "<li>Username is empty</li>";
        return false;
    }
    else if (!pattern.test(username)) {
            errInfo = errInfo + "<li>Username must be an valid email address.</li>";
            return false;
    }
    return true;
}
function checkPassword(password) {
    if (password == "") {
        errInfo += "<li>Password is empty</li>";
        return false;
    }
    else {
        var pattern = /^([a-zA-Z0-9@*#]{8,15})$/;
        if (!pattern.test(password)) {
            errInfo += "<li>Password must consists of at least 8 characters and not more than 15 characters)";
            return false;
        }
        else
            return true;
    }
}
function checkPConfirm(password, pConfirm) {
    if (password != pConfirm) {
        errInfo += "<li>Password confirmation and password don't match";
        return false;
    }
    else
        return true;
}