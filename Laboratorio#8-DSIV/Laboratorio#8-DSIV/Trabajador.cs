using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8_DSIV
{
    internal class Trabajador : Persona
    {
        public int Sueldo;
        public Trabajador(string nombre, int edad, string nIF, int sueldo) : base(nombre, edad, nIF)
        {
            Sueldo = sueldo;
        }
    }
}
