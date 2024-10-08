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

namespace Laboratorio_12_2_DSIV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener las tres notas de los TextBoxes
                double nota1 = Convert.ToDouble(txtNota.Text);
                double nota2 = Convert.ToDouble(txtNota2.Text);
                double nota3 = Convert.ToDouble(txtNota3.Text);

                // Calcular el promedio
                double promedio = (nota1 + nota2 + nota3) / 3;

                // Mostrar el promedio en TextBox4
                txtNotaPromedio.Text = promedio.ToString("F2");  // Mostrar con dos decimales
            }
            catch (FormatException)
            {
                // Manejo de errores en caso de ingreso incorrecto
                MessageBox.Show("Por favor, ingrese valores válidos para las notas.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtNotaPromedio.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }
    }
}
