using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1_DSIV
{
    internal class MatrizCalculo
    {
        Random gebRandon = new Random();

        public void GenerarMatriz(int gen)
        {
            for (int i = 0; i < gen; i++)
            {
                for(int j = 0; j < gen; j++)
                {
                    int numRam = gebRandon.Next(101, 200);

                }
            }
        }
    }
}
