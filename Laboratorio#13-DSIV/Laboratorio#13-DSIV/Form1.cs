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

namespace Laboratorio_13_DSIV
{
    public partial class Form1 : Form
    {
        string connection = @"Server=Cesar-Castillo44;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            MessageBox.Show("Se abrio la conexioncon el servidor SQL Server y se selecciono la base de datos", "Conexion BD", MessageBoxButtons.OK);
            conn.Close();
            MessageBox.Show("Se cerro la conexion!!", "Cierre BD", MessageBoxButtons.OK);
        }
    }
}
