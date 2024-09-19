using Laboratorio_8._8_DSIV;

internal class Program
{
    private static void Main(string[] args)
    {
        ClaseConcentral claseConcentral = new ClaseConcentral();
        claseConcentral.printOut();
        Console.WriteLine(claseConcentral.prefixValor("ES_"));

        ClaseConcentral2 claseConcentral2 = new ClaseConcentral2();
        claseConcentral2.printOut();
        Console.WriteLine(claseConcentral2.prefixValor("ES_"));
    }
}