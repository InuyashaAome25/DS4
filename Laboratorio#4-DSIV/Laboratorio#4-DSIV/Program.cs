internal class Program
{
    //Link de repositorio https://github.com/InuyashaAome25/DS4/tree/Laboratorios/Laboratorio%234-DSIV
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