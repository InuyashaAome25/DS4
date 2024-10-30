<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio_15._4_DSIV.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <H1>
                Suma de Valores
            </H1>
            <h3>
                Ingrese Dos Valores Númericos
            </h3>
        </div>
        <div>
            <p>Dato 1:
                <asp:TextBox ID="numero1" runat="server"></asp:TextBox>
            </p>
            <h5>Dato 2:
                <asp:TextBox ID="numero2" runat="server"></asp:TextBox>
            </h5>
            <p>
                <asp:Button ID="ButtonSumar" runat="server" Text="Sumar" Width="190px" OnClick="ButtonSumar_Click" />
            </p>
        </div>
        <asp:Label ID="ResultadoSum" runat="server" Text=" "></asp:Label>
    </form>
</body>
</html>
