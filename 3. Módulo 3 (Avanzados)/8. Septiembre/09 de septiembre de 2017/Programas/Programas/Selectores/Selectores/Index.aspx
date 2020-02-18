<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Selectores.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Selector</title>
    <script type="text/javascript" src="scripts/jquery-3.2.1.min.js"></script>
</head>
<body>
    <table border="5">
        <thead>
            <tr>
                <th>Selector</th>
                <th>Seleccionar</th>
                <th>Ejemplo</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <th><strong>$("*")</strong></th>
                <th><strong>Todo el documento</strong></th>
                <th><input type="button" id="asterisco" value="Seleccionar" /></th>
            </tr>
            <tr>
                <th><strong>$("#correo")</strong></th>
                <th><strong>Elemento que tenga el id correo</strong></th>
                <th><input type="button" id="SignoDeNumero" value="Seleccionar" /></th>
            </tr>
            <tr>
                <th><strong>$(".campo")</strong></th>
                <th><strong>Todo los elementos que tengan la clase campo</strong></th>
                <th><input type="button" id="campo" value="Seleccionar" /></th>
            </tr>
            <tr>
                <th><strong>$("DIV")</strong></th>
                <th><strong>Todos los elementos DIV</strong></th>
                <th><input type="button" id="SelectorDIV" value="Seleccionar" /></th>
            </tr>
            <tr>
                <th><strong>$("p")</strong></th>
                <th><strong>Todos los elementos P</strong></th>
                <th><input type="button" id="SelectorP" value="Seleccionar" /></th>
            </tr>
            <tr>
                <th><strong>$("input")</strong></th>
                <th><strong>Todos los elementos de tipo input</strong></th>
                <th><input type="button" id="SelectorINPUT" value="Seleccionar" /></th>
            </tr>
        </tbody>
    </table>
    <div id="ContenedorElementos">
        <h2>Elementos</h2>
        <fieldset id="ContenedorElementosInterno">
            <label>Correo</label>
            <input value="lesterg.34@gmail.com" id="correo" type="text"/>
        </fieldset>
        <div>
            <br />
            <input type="text" value="clase campo" class="campo" />
            <input type="text" value="clase campo" class="campo" />
            <input type="text" value="clase campo" class="campo" />
            <input type="text" value="clase campo" class="campo" />
            <input type="text" value="clase campo" class="campo" />
            <input type="text" value="clase campo" class="campo" />
        </div>
        <div>
            <br />
            DIV
        </div>
         <div>
            <br />
            DIV
        </div>
         <div>
            <br />
            DIV
        </div>
        <p>
            P
        </p>
        <p>
            P
        </p>
        <input type="text" value="INPUT" />
        <input type="text" value="INPUT" />
        <input type="text" value="INPUT" />
    </div>
    <script src="scripts/Selector.js?1.1"></script>
    <link rel="stylesheet" type="text/css" href="./assets/css/Style.css" />
</body>
</html>
