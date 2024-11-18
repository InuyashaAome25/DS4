using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_20_DSIV
{
    public partial class MatrizNXN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerarMatriz_Click(object sender, EventArgs e)
        {
            int N;
            if (int.TryParse(txtN.Text, out N) && N > 0)
            {
                DataTable dt = new DataTable();

                // Crear columnas
                for (int i = 0; i < N; i++)
                {
                    dt.Columns.Add(i.ToString());
                }

                // Llenar filas
                for (int i = 0; i < N; i++)
                {
                    DataRow dr = dt.NewRow();
                    for (int j = 0; j < N; j++)
                    {
                        dr[j] = (i + j == N - 1) ? 1 : 0;
                    }
                    dt.Rows.Add(dr);
                }

                gvMatriz.DataSource = dt;
                gvMatriz.DataBind();
            }
            else
            {
                // Mostrar mensaje de error si el valor de N no es válido
                gvMatriz.DataSource = null;
                gvMatriz.DataBind();
                // Aquí puedes agregar un mensaje de error visible en el formulario
                Response.Write("<script>alert('Por favor, ingrese un valor válido para N.');</script>");
            }
        }
    }
}