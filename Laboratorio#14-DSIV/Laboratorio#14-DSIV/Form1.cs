using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Laboratorio_14_DSIV
{
    public partial class Productos : Form
    {
        string connection = @"Server=Cesar-Castillo44;Database=BDProductos;TrustServerCertificate=true;Integrated Security=SSPI;";
        Boolean nuevo;
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            txtID.Enabled = false;
            txtBusqueda.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
            txtID.Enabled = false;
            txtBusqueda.Enabled = false;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            txtNombre.Focus();
            nuevo = true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (nuevo)
            {
                string Query = "INSERT INTO Laptops (NombreProduct, Precio, Stock)"
                    + "VALUES ('" + txtNombre.Text + "' , '" + txtPrecio.Text + "' , '" + txtStock.Text + "')";

                SqlConnection conn = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro Exitoso", "Registro BD", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString(), "Error", MessageBoxButtons.OKCancel);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                string Query = "UPDATE Laptops SET NombreProduct='" + txtNombre.Text +
                    "', Precio='" + txtPrecio.Text +
                    "', " + "Stock='" + txtStock.Text + "' WHERE Id=" + txtID.Text + "";

                SqlConnection conn = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro Actualizado Exitoso!!", "Actualizacion BD", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString(), "Error", MessageBoxButtons.OKCancel);
                }
                finally
                {
                    conn.Close();
                }
            }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Query = "DELETE FROM Laptops WHERE Id='" + this.txtID.Text + "';";

            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Eliminacion Exitoso", "Registro BD", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Error", MessageBoxButtons.OKCancel);
            }
            finally
            {
                conn.Close();
            }

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM Laptops WHERE ID=" +txtBusqueda.Text;

            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conn.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnEliminar.Enabled = true;
                    txtID.Enabled = false;
                    txtBusqueda.Enabled = false;
                    txtNombre.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtStock.Enabled = true;
                    txtNombre.Focus();
                    txtID.Text = reader["ID"].ToString();
                    txtNombre.Text = reader["NombreProduct"].ToString();
                    txtPrecio.Text = reader["Precio"].ToString();
                    txtStock.Text = reader["Stock"].ToString();
                    nuevo = false;
                }
                else
                {
                    MessageBox.Show("Ningún registro encontrado con el ID ingresado !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Error", MessageBoxButtons.OKCancel);
            }
            finally
            {
                conn.Close();
            }
            txtBusqueda.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
