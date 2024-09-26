using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_9._4_DSIV
{
    internal class Aleatorios
    {
        private Random random;
        public Aleatorios()
        {
            random = new Random();
        }

        // Método para generar un número aleatorio entre dos números (inclusive)
        public int GenerarNumeroEntre(int minimo, int maximo)
        {
            // Generar y devolver un número aleatorio entre minimo y maximo (ambos incluidos)
            return random.Next(minimo, maximo + 1);
        }

        // Método para generar un arreglo de números aleatorios entre dos números
        public int[] GenerarArregloEntre(int minimo, int maximo, int tamaño)
        {
            // Crear un arreglo para almacenar los números aleatorios
            int[] arreglo = new int[tamaño];

            // Llenar el arreglo con números aleatorios entre minimo y maximo (inclusive)
            for (int i = 0; i < tamaño; i++)
            {
                arreglo[i] = GenerarNumeroEntre(minimo, maximo);
            }

            // Devolver el arreglo generado
            return arreglo;
        }
    }
}
