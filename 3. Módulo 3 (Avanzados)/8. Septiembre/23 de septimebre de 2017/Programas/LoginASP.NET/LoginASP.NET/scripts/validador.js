$("#btnGuardar").click(function () {
    var UserName = document.getElementById("txtUsername");
    var DisplayName = document.getElementById("txtDisplayName");
    if (UserName.value == "") {
        alert("Invalid user name");
    }
    else if (DisplayName.value == "") {
        alert("Invalid display name");
    }
    else {
        alert("Listo");
    }
});