using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8._4_DSIV
{
    internal class CuentaBancaria
    {
        private decimal saldo;
        public decimal Saldo
        {
            get { return saldo; }
            set 
            {
                if (value >= 0)
                {
                    saldo = value;
                }else
                {
                    throw new ArgumentException("El salgo no puede ser negativo!!!");
                }
            }
        }
    }
}
