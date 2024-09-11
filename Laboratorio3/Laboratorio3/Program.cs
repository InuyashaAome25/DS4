internal class Program
{
    //Link de GitHub repo: https://github.com/InuyashaAome25/DS4/tree/Laboratorios
    private static void Main(string[] args)
    {
        int primerNumero, segundoNumero, suma;

        Console.Write("Ingrese el primer número: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        suma = primerNumero + segundoNumero;

        Console.WriteLine("La suma de {0} y de {1} es {2}", primerNumero, segundoNumero, suma);
    }
}