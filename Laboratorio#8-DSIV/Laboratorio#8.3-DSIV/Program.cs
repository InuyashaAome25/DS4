internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Suma(1.5, 5.2));
    }

    static int Suma(int z, int y)
    {
        return z + y;
    }

    static double Suma(double z, double y)
    {
        return z + y;
    }

    static long Suma(long z, long y)
    {
        return z + y;
    }
}