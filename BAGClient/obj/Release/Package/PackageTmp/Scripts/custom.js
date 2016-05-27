/*BAG*/

/*Login*/

function Redirect()
{
    if(document.getElementById("resultTarget")=="")
    {
        window.location.href = window.location.origin + '/Dashboard';
    }
}

function Login() {
    var strMsg = "";
    var Valid = true;

    if (document.getElementById('EmailId').value == "") {
        Valid = false;
        strMsg += " Please Enter the Email-Id ";
    }
    else if (ValidateEmail('EmailId', false) == false) {
        Valid = false;
        strMsg += " Please Enter valid Email-Id ";
    }
    if (document.getElementById('password').value == "") {
        Valid = false;
        strMsg += " Please Enter the Password ";
    }
    if (strMsg == "") {
        jQuery.ajax({
            url: '/Account/ManualLogin',
            method: "POST",
            cache: false,
            data: { EmailId: document.getElementById('EmailId').value, Password: document.getElementById('password').value }
        }).done(function (d) {
            if (d == "1") {
                window.location.href = window.location.origin + '/Dashboard';
            }
            else {
                jQuery('#errmsg').text('Invalid Credentials');
            }
        });
    }
    else {
        jQuery('#errmsg').text(strMsg);
    }
}

/*Registration validation*/
function Registration() {
    var strMsg = "Please Enter";
    var Valid = true;

    if (document.getElementById('First_Name').value == "") {
        Valid = false;
        strMsg += " Name ";
    }
    if (document.getElementById('Email_Id').value == "") {
        Valid = false;
        strMsg += " Email-Id ";
    }
    else if (ValidateEmail('Email_Id', false) == false) {
        Valid = false;
        strMsg += " valid Email-Id ";
    } 
    if (document.getElementById('Phone_No').value == "") {
        Valid = false;
        strMsg += " Phone No. ";
    }
    if (document.getElementById('Password').value == "") {
        Valid = false;
        strMsg += " Password ";
    }
    if (document.getElementById('Password').value != document.getElementById('Cfm_Password').value) {
        Valid = false;
        strMsg += " mismatched Confirm password.";
    }
    if (strMsg == "Please Enter") {
        return true;
    }
    else {
        jQuery('#resultTarget').text(strMsg);
        return false;
    }
}

/*Event Creation validation*/
function EventCreation() {
    var strMsg = "Please Enter";
    var Valid = true;

    if (document.getElementById('CreateEvent_Event_Name').value == "") {
        Valid = false;
        strMsg += " Event Name ";
    }
    if (document.getElementById('CreateEvent_Start_Date').value == "") {
        Valid = false;
        strMsg += " Start Date ";
    }
    if (document.getElementById('CreateEvent_End_Date').value == "") {
        Valid = false;
        strMsg += " End Date ";
    }
    if (document.getElementById('CreateEvent_Description').value == "") {
        Valid = false;
        strMsg += " Description ";
    }
    else if (document.getElementById('CreateEvent_Description').value.length < 100) {
        Valid = false;
        strMsg += " Description Should Contain min 100 words ";
    }
    if (document.getElementById('CreateEvent_Event_Location').value == "") {
        Valid = false;
        strMsg += " Event Location.";
    }
    if (strMsg == "Please Enter") {
        return true;
    }
    else {
        jQuery('#resultTarget').text(strMsg);
        return false;
    }
}


function ChangePassword() {
    var strMsg = "Please Enter the";
    var Valid = true;

    if (document.getElementById('Old_Password').value == "") {
        Valid = false;
        strMsg += "  Old Pasword ";
    }
    if (document.getElementById('New_Password').value == "") {
        Valid = false;
        strMsg += "  New Password ";
    }
    if (document.getElementById('Conf_New_Password').value == "") {
        Valid = false;
        strMsg += "  Confirm Password ";
    }
    if (document.getElementById('New_Password').value != document.getElementById('Conf_New_Password').value) {
        Valid = false;
        strMsg += " Mismatched Password ";
    }
    if (strMsg == "Please Enter the") {
        return true;
    }
    else {
        jQuery('#resultTarget').text(strMsg);
        return false;
    }
}

function ResetPassword() {
    var strMsg = "Please Enter the";
    var Valid = true;

    if (document.getElementById('New_Password').value == "") {
        Valid = false;
        strMsg += "  New Password ";
    }
    if (document.getElementById('Conf_New_Password').value == "") {
        Valid = false;
        strMsg += "  Confirm Password ";
    }
    if (document.getElementById('New_Password').value != document.getElementById('Conf_New_Password').value) {
        Valid = false;
        strMsg += " Mismatched Password ";
    }
    if (strMsg == "Please Enter the") {
        return true;
    }
    else {
        jQuery('#resultTarget').text(strMsg);
        return false;
    }
}

/*Global*/
function EnableKeys(keyType, e) {

    var keyCode;
    if (window.event) //IE
        keyCode = event.keyCode;
    else if (e.which) //Netscape/Firefox/Opera
        keyCode = e.which;

    //Enable only alphabets
    if (keyType == 0) {
        if (!((keyCode >= 65 && keyCode <= 90) || (keyCode >= 97 && keyCode <= 122) || (keyCode == 8) || (String(keyCode) == 'undefined')))
            return false;
    }

    //Enable only alphabets and Space
    if (keyType == 1) {
        if (!((keyCode >= 65 && keyCode <= 90) || (keyCode >= 97 && keyCode <= 122) || (keyCode == 8) || (keyCode == 32) || (String(keyCode) == 'undefined')))
            return false;
    }

    //Enable only integer values
    if (keyType == 2) {
        if (!((keyCode >= 48 && keyCode <= 57) || (keyCode == 8) || (String(keyCode) == 'undefined')))
            return false;
    }

    //Enable only integer values
    if (keyType == 20) {
        if (!((keyCode >= 65 && keyCode <= 90) || (keyCode >= 97 && keyCode <= 122) || (keyCode == 8) || (keyCode == 39) || (keyCode == 32) || (String(keyCode) == 'undefined')))
            return false;
    }

    //Enable only alpha numaric
    if (keyType == 3) {
        if (!((keyCode >= 65 && keyCode <= 90) || (keyCode >= 97 && keyCode <= 122) || (keyCode >= 48 && keyCode <= 57) || (keyCode == 8) || (String(keyCode) == 'undefined')))
            return false;
    }

    //Enable only alpha numaric and - _ . @ (For Emaild)
    if (keyType == 4) {
        if (!((keyCode >= 65 && keyCode <= 90) || (keyCode >= 97 && keyCode <= 122) || (keyCode >= 48 && keyCode <= 57) || (keyCode == 8) || (keyCode == 64) || (keyCode == 95) || (keyCode == 45) || (keyCode == 95) || (keyCode == 46) || (keyCode == 45) || (String(keyCode) == 'undefined')))
            return false;
    }

    //Enable only alpha numaric and / (For PF Number)
    if (keyType == 5) {
        if (!((keyCode >= 65 && keyCode <= 90) || (keyCode >= 97 && keyCode <= 122) || (keyCode >= 48 && keyCode <= 57) || (keyCode == 8) || (keyCode == 47) || (keyCode == 95) || (keyCode == 32) || (keyCode == 45) || (String(keyCode) == 'undefined')))
            return false;
    }

    //Enable only alphabets and Space and ,
    if (keyType == 6) {
        if (!((keyCode >= 65 && keyCode <= 90) || (keyCode >= 97 && keyCode <= 122) || (keyCode == 8) || (keyCode == 44) || (keyCode == 32) || (String(keyCode) == 'undefined')))
            return false;
    }

    //Enable only integer and Space
    if (keyType == 7) {
        if (!((keyCode >= 48 && keyCode <= 57) || (keyCode == 8) || (keyCode == 32) || (String(keyCode) == 'undefined')))
            return false;
    }

    //Enable only alpha numaric space and - /
    if (keyType == 8) {
        if (!((keyCode >= 65 && keyCode <= 90) || (keyCode >= 97 && keyCode <= 122) || (keyCode >= 48 && keyCode <= 57) || (keyCode == 8) || (keyCode == 95) || (keyCode == 32) || (keyCode == 45) || (keyCode == 47) || (String(keyCode) == 'undefined')))
            return false;
    }

    //Enable only alpha numaric and space
    if (keyType == 9) {
        if (!((keyCode >= 65 && keyCode <= 90) || (keyCode >= 97 && keyCode <= 122) || (keyCode >= 48 && keyCode <= 57) || (keyCode == 8) || (keyCode == 32) || (String(keyCode) == 'undefined')))
            return false;
    }

    //Enable alpha numaric and space and %,+,-
    if (keyType == 10) {
        if (!((keyCode >= 65 && keyCode <= 90) || (keyCode >= 97 && keyCode <= 122) || (keyCode >= 48 && keyCode <= 57) || (keyCode == 8) || (keyCode == 32) || (keyCode == 43) || (keyCode == 45) || (keyCode == 37) || (String(keyCode) == 'undefined')))
            return false;
    }

    //Enable alpha numaric and space and %,-,_,(,),{,},[,],/,\, and comma.
    if (keyType == 11) {
        if (!((keyCode >= 65 && keyCode <= 90) || (keyCode >= 97 && keyCode <= 122) || (keyCode >= 48 && keyCode <= 57) || (keyCode == 8) || (keyCode == 32) || (keyCode == 44) || (keyCode == 45) || (keyCode == 95) || (keyCode == 40) || (keyCode == 41) || (keyCode == 46) || (keyCode == 123) || (keyCode == 125) || (keyCode == 91) || (keyCode == 93) || (keyCode == 92) || (keyCode == 47) || (keyCode == 37) || (String(keyCode) == 'undefined')))
            return false;
    }

    //Enable Float Values
    if (keyType == 12) {
        if (!((keyCode >= 48 && keyCode <= 57) || (keyCode == 46) || (keyCode == 8) || (String(keyCode) == 'undefined')))
            return false;
    }

    //Enable only integer values and comma
    if (keyType == 13) {
        if (!((keyCode >= 48 && keyCode <= 57) || (keyCode == 8) || (keyCode == 44) || (String(keyCode) == 'undefined')))
            return false;
    }

    //Enable only alpha numaric and Space
    if (keyType == 14) {
        if (!((keyCode >= 65 && keyCode <= 90) || (keyCode >= 97 && keyCode <= 122) || (keyCode >= 48 && keyCode <= 57) || (keyCode == 8) || (keyCode == 32) || (String(keyCode) == 'undefined')))
            return false;
    }

    //Enable only integer values with dot(.)
    if (keyType == 15) {
        if (!((keyCode >= 48 && keyCode <= 57) || (keyCode == 46) || (keyCode == 8) || (String(keyCode) == 'undefined')))
            return false;
    }

    //Enable only A,a,B,b,O,o,+,- (For Blood group)
    if (keyType == 16) {
        if (!((keyCode == 65) || (keyCode == 97) || (keyCode == 8) || (keyCode == 66) || (keyCode == 98) || (keyCode == 111) || (keyCode == 79) || (keyCode == 43) || (keyCode == 45) || (String(keyCode) == 'undefined')))
            return false;
    }

    //Enable only integer values with dot(.) and %
    if (keyType == 17) {
        if (!((keyCode >= 48 && keyCode <= 57) || (keyCode == 46) || (keyCode == 8) || (keyCode == 37) || (String(keyCode) == 'undefined')))
            return false;
    }

    //Enable only integer values with dot(.)
    if (keyType == 18) {
        if (!((keyCode >= 48 && keyCode <= 57) || (keyCode == 46) || (keyCode == 8) || (String(keyCode) == 'undefined')))
            return false;
    }

    if (keyType == 19)
        return false;
}

function ValidateEmail(ctrl, AllowEmpty) {
    try {
        if (!AllowEmpty) {
            if (document.getElementById(ctrl).value == "") {

                return false;
            }
        }
        if (document.getElementById(ctrl).value == "") {

            return true;
        }
        var _a = document.getElementById(ctrl).value.toString().split("@");
        var _Valid = false;
        if (_a.length > 1) {
            var _b = _a[1].split(".");
            if (_b.length > 3)
                _Valid = false;
            else {
                var _c = _b[_b.length - 1].length;
                if (_c == 2 || _c == 3)
                    _Valid = true;
                else
                    _Valid = false;
            }
        }
        return _Valid;
    }
    catch (Ex) {
        return false;
    }
}


