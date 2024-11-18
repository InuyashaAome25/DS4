<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionProductos.aspx.cs" Inherits="Laboratorio_20_DSIV.GestionProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Gestion De Productos</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="bg-primary text-white">
    <div class="container mt-5">
        <h1 class="text-center">Gestión de Productos</h1>
        <div class="card bg-light text-dark p-4">
            <!-- Formulario -->
            <form id="GestionProduct" runat="server">
                 <!-- Contenedor de Búsqueda -->
                <div class="mb-3 d-flex align-items-center">
                    <label for="txtBusqueda" class="form-label me-2">Buscar por ID:</label>
                    <asp:TextBox ID="txtBusqueda" runat="server" class="form-control me-2" style="flex: 1;" />
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="btnBuscar_Click" />
                </div>

                <div class="mb-3">
                    <label for="txtID" class="form-label">ID:</label>
                    <asp:TextBox ID="txtID" runat="server" CssClass="form-control" Enabled="false" />
                </div>

                <div class="mb-3">
                    <label for="txtNombre" class="form-label">Nombre:</label>
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" />
                </div>

                <div class="mb-3">
                    <label for="txtPrecio" class="form-label">Precio:</label>
                    <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" />
                </div>

                <div class="mb-3">
                    <label for="txtStock" class="form-label">Stock:</label>
                    <asp:TextBox ID="txtStock" runat="server" CssClass="form-control" />
                </div>

                <!-- Botones -->
                <div class="d-flex justify-content-between">
                    <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" CssClass="btn btn-success" OnClick="btnNuevo_Click" />
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" Enabled="false" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-warning" OnClick="btnCancelar_Click" Enabled="false" />
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click" Enabled="false" />
                    <asp:Button ID="btnSalir" runat="server" Text="Salir" CssClass="btn btn-secondary" OnClick="btnSalir_Click" />
                </div>
            </form>
        </div>

        <!-- Mensaje al usuario -->
        <asp:Label ID="lblMensaje" runat="server" CssClass="text-center mt-3 d-block text-white" />
    </div>
</body>
</html>
