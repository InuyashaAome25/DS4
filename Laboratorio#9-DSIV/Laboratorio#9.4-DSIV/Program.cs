using Laboratorio_9._4_DSIV;

internal class Program
{
    private static void Main(string[] args)
    {
        // Crear una instancia de la clase Aleatorios
        Aleatorios aleatorio = new Aleatorios();

        // Ejemplo: Generar un número aleatorio entre 10 y 50
        int numero = aleatorio.GenerarNumeroEntre(10, 50);
        Console.WriteLine("Número aleatorio entre 10 y 50: " + numero);

        // Ejemplo: Generar un arreglo de 5 números aleatorios entre 1 y 100
        int[] arreglo = aleatorio.GenerarArregloEntre(1, 100, 5);

        Console.WriteLine("Arreglo de números aleatorios entre 1 y 100:");
        foreach (int num in arreglo)
        {
            Console.WriteLine(num);
        }
    }
}