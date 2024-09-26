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
        public int[] GenerarArregloNoRepetidoEntre(int minimo, int maximo, int tamaño)
        {
            // Verificar si es posible generar un arreglo con números únicos
            if (tamaño > (maximo - minimo + 1))
            {
                throw new ArgumentException("El tamaño del arreglo es mayor que el rango disponible de números únicos.");
            }

            // Crear un HashSet para evitar números repetidos
            HashSet<int> numeros = new HashSet<int>();

            // Generar números aleatorios no repetidos
            while (numeros.Count < tamaño)
            {
                int numeroAleatorio = GenerarNumeroEntre(minimo, maximo);
                numeros.Add(numeroAleatorio); // HashSet no permite duplicados
            }

            // Convertir el HashSet en un arreglo y devolverlo
            return new List<int>(numeros).ToArray();
        }
    }
}
