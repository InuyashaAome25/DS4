using Laboratorio_9._4_DSIV;

internal class Program
{
    private static void Main(string[] args)
    {
        // Crear una instancia de la clase Aleatorios
        Aleatorios aleatorio = new Aleatorios();

        // Definir los valores mínimo, máximo y tamaño del arreglo
        int minimo = 1;
        int maximo = 100;
        int tamaño = 10;

        // Generar un arreglo de números no repetidos entre el mínimo y el máximo
        try
        {
            int[] arregloNoRepetido = aleatorio.GenerarArregloNoRepetidoEntre(minimo, maximo, tamaño);

            Console.WriteLine("Arreglo de números no repetidos entre {0} y {1}:", minimo, maximo);
            foreach (int num in arregloNoRepetido)
            {
                Console.WriteLine(num);
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}