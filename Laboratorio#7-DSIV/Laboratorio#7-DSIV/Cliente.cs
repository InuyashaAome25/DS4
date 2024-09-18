using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_7_DSIV
{
    internal class Cliente
    {
        private string nombre;
        private int monto;

        public Cliente(string dato)
        {
            nombre = dato;
            monto = 0;
        }

        public void Depositar(int transf)
        {
            monto = monto + transf;
        }

        public void Extraer(int sust)
        {
            monto = monto - sust;
        }

        public int RetornarMonto()
        {
            return monto;
        }

        public void Imprimir()
        {
            Console.WriteLine(nombre + " tiene depositado en la cuenta la suma de: $"+monto);
        }
    }
}
