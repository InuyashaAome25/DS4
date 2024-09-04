internal class Program
{
    private static void Main(string[] args)
    {
        CalculosMatematicos objCal = new CalculosMatematicos();

        int primerNumero, segundoNumero;
        int result;

        Console.Write("Ingrese el primer número: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        result = objCal.Calcular(primerNumero, segundoNumero);

        Console.WriteLine("La operacion de {0} y de {1} es {2}", primerNumero, segundoNumero, result);
    }

    public class CalculosMatematicos
    {
        public int Calcular(int dato, int dato2)
        {
            int calculo=0;

            calculo = (dato+dato2)*(dato-dato2);

            return calculo;
        }

    }
}