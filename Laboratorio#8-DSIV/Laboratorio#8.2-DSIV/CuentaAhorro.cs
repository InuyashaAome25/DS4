using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8._2_DSIV
{
    internal class CuentaAhorro : Cuenta
    {
        public CuentaAhorro(string prmidCuenta) : base(prmidCuenta)
        {
        }

        public override void CalcularIntereses()
        {
            System.Console.WriteLine("CuentaAhorro.CalcularIntereses() efectuado para " +
                "la cuenta {0}", getIdCuenta());
        }
    }
}
