internal class Program
{
    private static void Main(string[] args)
    {
        int valor;

        Console.WriteLine("Ingrese un numero");
        try
        {
            valor = Int16.Parse(Console.ReadLine());
        }
        catch (FormatException ex)
        {
            Console.WriteLine("No ha ingresado un valor numerico");
            valor = -1;
        }
        
        Console.WriteLine(valor);
    }
}