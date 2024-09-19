using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8._8_DSIV
{
    internal class ClaseConcentral :ClaseAbstracta
    {
        protected override string tomarValor()
        {
            return "ClaseConcentra1";
        }
        public override string prefixValor(string prefix)
        {
            return $"{prefix}ClaseConcentral";
        }
    }
}
