<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MatrizNXN.aspx.cs" Inherits="Laboratorio_20_DSIV.MatrizNXN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Matriz N x N</title>
</head>
<body>
    <form id="form1" runat="server">
        <div> 
            <h1>Matriz De Dimensión N x N</h1>

            <asp:TextBox ID="txtN" runat="server" Placeholder="Ingrese el valor de N"></asp:TextBox> 
            <asp:Button ID="btnGenerarMatriz" runat="server" Text="Generar Matriz" OnClick="btnGenerarMatriz_Click"/> 
            <asp:GridView ID="gvMatriz" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
