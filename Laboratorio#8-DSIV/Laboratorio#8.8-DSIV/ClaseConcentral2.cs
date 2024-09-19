using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8._8_DSIV
{
    internal class ClaseConcentral2 : ClaseAbstracta
    {
        protected override string tomarValor()
        {
            return "ClseConcentral2";
        }
        public override string prefixValor(string prefix)
        {
            return $"{prefix}ClaseConcentral2";
        }
    }
}
