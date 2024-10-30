using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_15._4_DSIV
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ButtonSumar_Click(object sender, EventArgs e)
        {
            int data = Convert.ToInt32(numero1.Text);
            int data2 = Convert.ToInt32(numero2.Text);
            int resultado = sumar(data, data2); // Usar int para el resultado

            // Mostrar el resultado en el Label
            ResultadoSum.Text = "El resultado es: " + resultado.ToString();

        }

        public int sumar(int dato1, int dato2)
        {
            int result = dato1 + dato2;
            return result;
        }
    }
}