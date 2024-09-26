internal class Program
{
    private static void Main(string[] args)
    {
        // Solicitar los tres lados del triángulo
        Console.WriteLine("Ingresa el primer lado del triángulo:");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa el segundo lado del triángulo:");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa el tercer lado del triángulo:");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        // Comprobar si los lados forman un triángulo válido
        if ((lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1))
        {
            // Determinar el tipo de triángulo
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es equilátero.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("El triángulo es isósceles.");
            }
            else
            {
                Console.WriteLine("El triángulo es escaleno.");
            }
        }
        else
        {
            Console.WriteLine("Los lados ingresados no forman un triángulo válido.");
        }
    }
}