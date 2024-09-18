using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_7._2_DSIV
{
    internal class JuegoDeDados
    {
        private Dado dado1, dado2, dado3;

        public JuegoDeDados()
        {
            dado1 = new Dado();
            dado2 = new Dado();
            dado3 = new Dado();
        }

        public void Jugar()
        {
            dado1.Lanzar();
            dado1.Imprimir();
            dado2.Lanzar();
            dado2.Imprimir();
            dado3.Lanzar();
            dado3.Imprimir();
            if (dado1.RetornarValor() == dado2.RetornarValor() && 
                dado1.RetornarValor() == dado3.RetornarValor())
            {
                Console.WriteLine("Gano");
            }
            else
            {
                Console.WriteLine("Perdio");
            }
            Console.ReadKey();
        }
    }
}
