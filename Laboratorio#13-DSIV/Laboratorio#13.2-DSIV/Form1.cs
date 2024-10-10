using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Laboratorio_13._2_DSIV
{
    public partial class Form1 : Form
    {
        string connection = @"Server=Cesar-Castillo44;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            // Consulta SQL
            string query = "SELECT ProductName FROM [dbo].[Products]";

            // Crear una lista para almacenar los nombres de los productos
            List<string> productNames = new List<string>();

            // Usar SqlConnection y SqlCommand para ejecutar la consulta
            using (SqlConnection conn = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Leer los datos y agregarlos a la lista
                while (reader.Read())
                {
                    productNames.Add(reader["ProductName"].ToString());
                }

                reader.Close();
            }

            // Mostrar los nombres de los productos en el ListBox
            listProduct.Items.Clear();
            foreach (string productName in productNames)
            {
                listProduct.Items.Add(productName);
            }
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
