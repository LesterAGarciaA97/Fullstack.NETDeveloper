<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logins.aspx.cs" Inherits="LoginASP.NET.Logins" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>Username</td>
                <td><asp:TextBox ID="TxtUsername" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Display name</td>
                <td><asp:TextBox ID="TxtDisplayname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
