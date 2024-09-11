
internal class Program
{
    private static void Main(string[] args)
    {
        int numeroUno = 70;
        double numeroDos = 89.99;
        double numeroTres = 89.99;

        Console.WriteLine(Suma(numeroUno, numeroDos));

        Console.WriteLine(Suma(numeroUno, numeroDos, numeroTres));
    }

    private static double Suma(int x, double y, double z = 0)
    {
        return x + y + z;
    }
}