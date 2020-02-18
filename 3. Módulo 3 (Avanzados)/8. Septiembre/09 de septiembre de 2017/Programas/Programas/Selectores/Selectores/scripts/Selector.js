$(function () {
    $("#asterisco").click(function () {
        $("*").addClass("seleccionado");
    });
    $("#SignoDeNumero").click(function () {
        $("#correo").addClass("seleccionado");
    });
    $("#campo").click(function () {
        $(".campo").addClass("seleccionado");
    });
    $("#SelectorDIV").click(function () {
        $("DIV").addClass("seleccionado");
    });
    $("#SelectorP").click(function () {
        $("p").addClass("seleccionado");
    });
    $("#SelectorINPUT").click(function () {
        $("input").addClass("seleccionado");
    })
});