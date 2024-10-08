using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laboratorio_12_DSIV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la velocidad y el tiempo de los TextBoxes
                double velocidad = Convert.ToDouble(txtVelocidad.Text);
                double tiempo = Convert.ToDouble(txtTiempo.Text);

                // Calcular la distancia
                double distancia = velocidad * tiempo;

                // Mostrar el resultado en TextBox3
                txtResultados.Text = distancia.ToString() + " metros";
            }
            catch (FormatException)
            {
                // Manejo de errores en caso de ingreso incorrecto
                MessageBox.Show("Por favor, ingrese valores válidos para la velocidad y el tiempo.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtVelocidad.Text = "";
            txtTiempo.Text = "";
            txtResultados.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }
    }
}
