internal class Program
{
    private static void Main(string[] args)
    {
        int n, x;
        string cadena;

        Console.Write("Ingrese el valor de n: ");
        cadena = Console.ReadLine();
        n = int.Parse(cadena);
        x = 1;

        while (x <= n)
        {
            Console.WriteLine(x);
            Console.WriteLine(" , ");
            x = x + 1;
        }
        Console.ReadKey();
    }
}