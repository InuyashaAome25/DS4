internal class Program
{
    private static void Main(string[] args)
    {
        // Recorrer los números del 1 al 100
        for (int i = 1; i <= 100; i++)
        {
            // Verificar si el número es par o divisible entre 3
            if (i % 2 == 0 || i % 3 == 0)
            {
                // Mostrar el número
                Console.WriteLine(i);
            }
        }
    }
}