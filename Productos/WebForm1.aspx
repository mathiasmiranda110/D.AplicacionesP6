<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Productos.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .nuevoEstilo1 {
            background-color: #000000;
            color: #FFFF00;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="nuevoEstilo1">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="X-Large" Height="50px" Text="Bienvenido a la aplicacion de consulta del almacen" Width="300px"></asp:Label>
            <br />
            <br />
&nbsp;<asp:Label ID="Label2" runat="server" Text="Mediante esta aplicación podremos ver diferentes listas respecto a nuestros productos en almacen"></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            </asp:GridView>
            <br />
&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Mostrar Nombres" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Mostrar Codigos" />
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Mostrar Precios" />
&nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Mostrar Stock" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="MOSTRAR TABLA COMPLETA" />
        </div>
    </form>
</body>
</html>
