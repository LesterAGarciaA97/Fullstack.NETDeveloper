function registro() {    
    var username = document.getElementById("txtUsername");
    var displayname = document.getElementById("txtDisplayname");
    if(username.value == ""){
        alert("Invalid User Name");
    } else if(displayname.value == ""){
        alert("Invalid Display Name");
    } else {
        alert("Registro");
        $.ajax({
            type: "POST",
            url: 'Logins.aspx/registro',
            data: '{datos: "(' + '/' + $("#txtUsername").val() + '/,/' + $("#txtDisplayname").val() + '/)"}',
            contentType: "application/json",
            dataType: "json",
            success: OnSuccessAdd,
            failure: function (response) {
                alert(response.d);
            }
        });
    }
};



function OnSuccessAdd(response) {
    alert(response.d);
    location.reload();
}

function eliminar() {
    alert("Elimiinar");
}