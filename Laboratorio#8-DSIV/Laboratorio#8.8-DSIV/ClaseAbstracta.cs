using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8._8_DSIV
{
    abstract class ClaseAbstracta
    {
        abstract protected string tomarValor();
        abstract public string prefixValor(string prefix);

        public void printOut()
        {
            Console.WriteLine(tomarValor());
        }
    }
}
