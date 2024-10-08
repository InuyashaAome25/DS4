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

namespace Laboratorio_12._3_DSIV
{
    public partial class Form1 : Form
    {
        double semiperimetro = 0; // Variable para almacenar el semiperímetro

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los tres lados del triángulo de los TextBoxes
                double ladoA = Convert.ToDouble(txtLadoA.Text);
                double ladoB = Convert.ToDouble(txtLadoB.Text);
                double ladoC = Convert.ToDouble(txtLadoC.Text);

                // Calcular el semiperímetro
                semiperimetro = (ladoA + ladoB + ladoC) / 2;

                // Mostrar el semiperímetro en TextBox5
                txtPerimetro.Text = semiperimetro.ToString("F2");  // Mostrar con dos decimales
            }
            catch (FormatException)
            {
                // Manejo de errores en caso de ingreso incorrecto
                MessageBox.Show("Por favor, ingrese valores válidos para los lados.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si ya se calculó el semiperímetro
                if (semiperimetro == 0)
                {
                    MessageBox.Show("Primero debe calcular el semiperímetro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener los tres lados del triángulo de los TextBoxes
                double ladoA = Convert.ToDouble(txtLadoA.Text);
                double ladoB = Convert.ToDouble(txtLadoB.Text);
                double ladoC = Convert.ToDouble(txtLadoC.Text);

                // Calcular el área usando la fórmula de Herón
                double area = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));

                // Mostrar el área en TextBox6
                txtArea.Text = area.ToString("F2");  // Mostrar con dos decimales
            }
            catch (FormatException)
            {
                // Manejo de errores en caso de ingreso incorrecto
                MessageBox.Show("Por favor, ingrese valores válidos para los lados.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Para manejar otros posibles errores (por ejemplo, un triángulo no válido)
                MessageBox.Show("Error en el cálculo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtLadoA.Text = "";
            txtLadoB.Text = "";
            txtLadoC.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }
    }
}
