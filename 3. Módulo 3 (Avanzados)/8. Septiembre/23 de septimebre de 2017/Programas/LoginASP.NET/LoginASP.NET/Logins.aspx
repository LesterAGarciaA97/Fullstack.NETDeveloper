<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logins.aspx.cs" Inherits="LoginASP.NET.Logins" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <nav class="navbar navbar-toggleable-md navbar-inverse bg-inverse">
  <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <a class="navbar-brand" href="#">Navbar</a>

  <div class="collapse navbar-collapse" id="navbarSupportedContent">
    <ul class="navbar-nav mr-auto">
      <li class="nav-item active">
        <a class="nav-link" href="#">Home <span class="sr-only">(current)</span></a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="#">Link</a>
      </li>
      <li class="nav-item">
        <a class="nav-link disabled" href="#">Disabled</a>
      </li>
    </ul>
    <form class="form-inline my-2 my-lg-0">
      <input class="form-control mr-sm-2" type="text" placeholder="Search">
      <button class="btn btn-outline-success my-2 my-sm-0" type="submit">Search</button>
    </form>
  </div>
</nav>
    <div class="jumbotron jumbotron-fluid">
  <div class="container">
    <h1 class="display-3">Catálogo de usuarios</h1>
    <p class="lead">Administración de usuarios para postear</p>
  </div>
</div>
    <div class="container">
    <form id="form1" runat="server">
        <div class="form-group">
                <label>Username</label>
                <asp:TextBox ID="TxtUsername" CssClass="form-control" placeholder="User Name" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
                <label>Display name</label>
                <asp:TextBox ID="TxtDisplayname" CssClass="form-control" placeholder="Display Name" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
    </form>
        </div>
 <div class="container" style="top:20px">
    <table class="table">
        <thead class="thead-inverse">
            <tr>
                <th>#</th>
                <th>USERNAME</th>
                <th>DISPLAY NAME</th>
            </tr>
        </thead>
        <tbody>
            <%  int NumeroRegistro = 0;
                foreach (System.Data.DataTable Tabla in Datos.Tables)
                { %>
            <% foreach (System.Data.DataRow Registro in Tabla.Rows) 
                { %>
                <tr>
                    <td><%= ++NumeroRegistro%></td>
                    <td><%= Registro.ItemArray[1]%></td>
                    <td><%= Registro.ItemArray[2]%></td>
                <%}%>
                </tr>
                <%}%>
        </tbody>
    </table>
 </div>
    <script src="/scripts/jquery-3.2.1.min.js"></script>
    <script src="/scripts/bootstrap.min.js"></script>
</body>
</html>