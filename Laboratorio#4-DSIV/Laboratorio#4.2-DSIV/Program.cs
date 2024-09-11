internal class Program
{
    private static void Main(string[] args)
    {
        int facto =1, n;
        string linea;

        Console.Write("Ingrese un valor númerico entero: ");
        linea = Console.ReadLine();
        n = int.Parse(linea);

        for(int i = 1; i <= n; i++)
        {
            facto = facto * i;
        }
        Console.Write("La factorizacion es: "+facto);
        Console.ReadKey();
    }
}