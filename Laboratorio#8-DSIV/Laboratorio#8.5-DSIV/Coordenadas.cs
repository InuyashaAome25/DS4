using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8._5_DSIV
{
    internal partial class Coordenadas
    {
        public int x;
        public int y;

        public Coordenadas(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    internal partial class Coordenadas
    {
        public void verCordenadas()
        {
            Console.WriteLine("Coordenadas {0},{1}", x, y);
        }
    }
}
