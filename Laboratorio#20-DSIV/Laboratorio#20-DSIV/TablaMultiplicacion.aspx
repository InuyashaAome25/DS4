<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TablaMultiplicacion.aspx.cs" Inherits="Laboratorio_20_DSIV.TablaMultiplicacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Tabla De Multiplicar</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <!-- El contenido del formulario -->
            <div>
                <h1>Tabla de Multiplicar</h1>
                <asp:Label ID="lblNumero" runat="server" Text="Introduce un número:"></asp:Label>
                <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvNumero" runat="server" ControlToValidate="txtNumero"
                    ErrorMessage="El número es obligatorio." ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="rvNumero" runat="server" ControlToValidate="txtNumero"
                    MinimumValue="1" MaximumValue="1000" Type="Integer"
                    ErrorMessage="Introduce un número entre 1 y 1000." ForeColor="Red"></asp:RangeValidator>
                <br /><br />
                <asp:Button ID="btnGenerar" runat="server" Text="Generar" OnClick="btnGenerar_Click" />
                <br /><br />
                <asp:Literal ID="litResultados" runat="server"></asp:Literal>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
