using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8_DSIV
{
    internal class Persona
    {
        public string nombre;
        public int edad;
        public string NIF;

        public void cumpleaños()
        {
            edad++;
        }

        public Persona(string nombre, int edad, string nIF)
        {
            this.nombre = nombre;
            this.edad = edad;
            NIF = nIF;
        }
    }
}
