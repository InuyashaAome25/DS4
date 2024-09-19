using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8._2_DSIV
{
    internal class Cuenta
    {
        protected string idCuenta;

        public Cuenta(string prmidCuenta)
        {
            this.idCuenta = prmidCuenta;
            System.Console.WriteLine("Constructor Base para la cuenta {0}" +this.idCuenta);
        }

        public virtual void CalcularIntereses()
        {
            System.Console.WriteLine("Cuenta.CalcularIntereses() efectuado para la cuenta {0}", this.idCuenta);
        }

        public string getIdCuenta()
        {
            return this.idCuenta;
        }
    }
}
