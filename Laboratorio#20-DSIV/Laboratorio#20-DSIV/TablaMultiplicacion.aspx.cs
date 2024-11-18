using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_20_DSIV
{
    public partial class TablaMultiplicacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            // Validar en el servidor
            if (Page.IsValid && int.TryParse(txtNumero.Text, out int numero))
            {
                StringBuilder resultados = new StringBuilder();
                resultados.Append("<h2>Tabla de Multiplicar para " + numero + "</h2><ul>");

                for (int i = 1; i <= 25; i++)
                {
                    resultados.AppendFormat("<li>{0} x {1} = {2}</li>", numero, i, numero * i);
                }

                resultados.Append("</ul>");
                litResultados.Text = resultados.ToString();
            }
            else
            {
                litResultados.Text = "<p style='color:red;'>Error al procesar el número. Intenta de nuevo.</p>";
            }
        }
    }
}