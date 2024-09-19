using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8._9_DSIV
{
    internal class Template : iTemplate
    {
        public void ponerVariable(string nombre, string var)
        {
            Console.WriteLine($"Metodo para poner variable {nombre} : {var}");
        }
        public void verHtml(string template)
        {
            Console.WriteLine(template);
        }
    }
}
