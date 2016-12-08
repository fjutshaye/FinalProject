var errInfo;
var noErrFlag;
function setTextBoxChangeable() {
    var name = document.getElementById("TextBox_Name");
    var phone = document.getElementById("TextBox_Phone");
    var carInfo = document.getElementById("TextBox_CarInfo");

    name.setAttribute("ReadOnly", false);
    phone.setAttribute("ReadOnly", false);
    carInfo.setAttribute("ReadOnly", false);
}
function validateProfileChange()
{
    errInfo = "";
    noErrFlag = true;

    var name = document.forms["profile_page"]["TextBox_Name"].value;
    var phone = document.forms["profile_page"]["TextBox_Phone"].value;
}