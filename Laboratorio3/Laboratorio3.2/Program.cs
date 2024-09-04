internal class Program
{
    private static void Main(string[] args)
    {
        CalculosMatematicos objArea = new CalculosMatematicos();

        double numero;
        double result;

        Console.Write("Ingrese el radio del circulo: ");
        numero = Convert.ToDouble(Console.ReadLine());

        result = objArea.calculoArea(numero);

        Console.WriteLine("El área del circulo es de " + result);
    }

    public class CalculosMatematicos
    {
        public double calculoArea(double radio)
        {
            const double PI = 3.1416;
            double calculo = 0;

            calculo = PI * Math.Pow(radio, 2);

            return calculo;
        }

    }
}