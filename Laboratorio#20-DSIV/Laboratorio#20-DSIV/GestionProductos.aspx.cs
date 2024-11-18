using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_20_DSIV
{
    public partial class GestionProductos : System.Web.UI.Page
    {
        private bool nuevo;
        private SqlConnection conexion;
        private ConnectionStringSettings connString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEliminar.Enabled = false;

                txtID.Enabled = false;
                txtNombre.Enabled = false;
                txtPrecio.Enabled = false;
                txtStock.Enabled = false;
                txtBusqueda.Enabled = true;

                // Inicializar la conexión
                connString = ConfigurationManager.ConnectionStrings["ConexionBD"];
                if (connString != null)
                {
                    conexion = new SqlConnection(connString.ConnectionString);
                    Session["Conexion"] = conexion;
                }
                else
                {
                    lblMensaje.Text = "Error: No se pudo encontrar la cadena de conexión.";
                }

                // Inicializar la variable nuevo
                nuevo = true;
                Session["Nuevo"] = nuevo;
            }
            else
            {
                // Recuperar el estado de la variable nuevo de la sesión
                if (Session["Nuevo"] != null)
                {
                    nuevo = (bool)Session["Nuevo"];
                }

                // Recuperar la conexión de la sesión
                if (Session["Conexion"] != null)
                {
                    conexion = (SqlConnection)Session["Conexion"];
                }
                else
                {
                    connString = ConfigurationManager.ConnectionStrings["ConexionBD"];
                    if (connString != null)
                    {
                        conexion = new SqlConnection(connString.ConnectionString);
                        Session["Conexion"] = conexion;
                    }
                    else
                    {
                        lblMensaje.Text = "Error: No se pudo encontrar la cadena de conexión.";
                    }
                }
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (conexion == null)
            {
                lblMensaje.Text = "Error: La conexión a la base de datos no está inicializada.";
                return;
            }

            string query = "SELECT * FROM Laptops WHERE Id = @Id";
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.Parameters.AddWithValue("@Id", txtBusqueda.Text);

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtID.Text = reader["Id"].ToString();
                    txtNombre.Text = reader["NombreProduct"].ToString();
                    txtPrecio.Text = reader["Precio"].ToString();
                    txtStock.Text = reader["Stock"].ToString();

                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnEliminar.Enabled = true;

                    txtNombre.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtStock.Enabled = true;

                    nuevo = false;
                    Session["Nuevo"] = nuevo; // Guardar el estado de nuevo en la sesión
                    lblMensaje.Text = "Registro encontrado.";
                }
                else
                {
                    lblMensaje.Text = "No se encontraron registros.";
                }

                conexion.Close();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (conexion == null)
            {
                lblMensaje.Text = "Error: La conexión a la base de datos no está inicializada.";
                return;
            }

            if (nuevo)
            {
                // Verificar que los valores no estén vacíos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtStock.Text))
                {
                    lblMensaje.Text = "Por favor, completa todos los campos antes de guardar.";
                    return;
                }

                string query = "INSERT INTO Laptops (NombreProduct, Precio, Stock) VALUES (@NombreProduct, @Precio, @Stock)";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@NombreProduct", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Precio", txtPrecio.Text);
                    cmd.Parameters.AddWithValue("@Stock", txtStock.Text);

                    conexion.Open();

                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            lblMensaje.Text = "Registro Exitoso";
                        }
                        else
                        {
                            lblMensaje.Text = "No se pudo insertar el registro";
                        }
                    }
                    catch (Exception ex)
                    {
                        lblMensaje.Text = "Error: " + ex.Message;
                    }

                    conexion.Close();
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtID.Text))
                {
                    lblMensaje.Text = "El ID es necesario para actualizar el registro.";
                    return;
                }

                string query = "UPDATE Laptops SET NombreProduct = @NombreProduct, Precio = @Precio, Stock = @Stock WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@NombreProduct", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Precio", txtPrecio.Text);
                    cmd.Parameters.AddWithValue("@Stock", txtStock.Text);
                    cmd.Parameters.AddWithValue("@Id", txtID.Text);

                    conexion.Open();

                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            lblMensaje.Text = "Registro Actualizado Exitoso";
                        }
                        else
                        {
                            lblMensaje.Text = "No se pudo actualizar el registro";
                        }
                    }
                    catch (Exception ex)
                    {
                        lblMensaje.Text = "Error: " + ex.Message;
                    }

                    conexion.Close();
                }
            }

            // Restablecer estado de los controles
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            txtID.Enabled = false;
            txtBusqueda.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            txtBusqueda.Text = "";
            txtID.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";

            // Reiniciar el estado de nuevo
            nuevo = true;
            Session["Nuevo"] = nuevo;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                // Recuperar la conexión de la sesión
                if (Session["Conexion"] != null)
                {
                    conexion = (SqlConnection)Session["Conexion"];
                }
                else
                {
                    connString = ConfigurationManager.ConnectionStrings["ConexionBD"];
                    if (connString != null)
                    {
                        conexion = new SqlConnection(connString.ConnectionString);
                        Session["Conexion"] = conexion;
                    }
                    else
                    {
                        lblMensaje.Text = "Error: No se pudo encontrar la cadena de conexión.";
                        return;
                    }
                }

                using (SqlCommand cmd = new SqlCommand("DELETE FROM Laptops WHERE ID=@ID", conexion))
                {
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);

                    try
                    {
                        conexion.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            lblMensaje.Text = "Registro eliminado con éxito.";

                            // Restablecer estado de los controles después de eliminar
                            btnNuevo.Enabled = true;
                            btnGuardar.Enabled = false;
                            btnCancelar.Enabled = false;
                            btnEliminar.Enabled = false;
                            txtID.Enabled = true;
                            txtBusqueda.Enabled = true;
                            txtNombre.Enabled = false;
                            txtPrecio.Enabled = false;
                            txtStock.Enabled = false;
                            txtID.Text = "";
                            txtNombre.Text = "";
                            txtPrecio.Text = "";
                            txtStock.Text = "";
                        }
                        else
                        {
                            lblMensaje.Text = "No se encontró el registro para eliminar.";
                        }
                    }
                    catch (Exception ex)
                    {
                        lblMensaje.Text = "Error al eliminar: " + ex.Message;
                    }
                    finally
                    {
                        conexion.Close(); // Asegurarse de cerrar la conexión
                    }
                }
            }
            else
            {
                lblMensaje.Text = "Por favor, busca un registro antes de eliminar.";
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;

            txtID.Enabled = false;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            txtBusqueda.Enabled = false;
            txtNombre.Focus();
            nuevo = true;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;

            txtID.Enabled = false;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            txtBusqueda.Enabled = true;

            txtBusqueda.Text = "";
            txtID.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            // Redirigir a la página Default.aspx
            Response.Redirect("Default.aspx");
        }
    }

}