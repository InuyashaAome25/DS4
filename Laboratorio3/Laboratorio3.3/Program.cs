internal class Program
{
    private static void Main(string[] args)
    {
        CalculosMatematicos objPeri = new CalculosMatematicos();

        int primerNumero, segundoNumero;
        int result;

        Console.Write("Ingrese el primer número: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        result = objPeri.calculoArea(primerNumero, segundoNumero);

        Console.WriteLine("El área del perimero es de: " +result);
    }

    public class CalculosMatematicos
    {
        public int calculoArea(int alto, int ancho)
        {
            int perimetro;
            perimetro = 2 * (alto + ancho);
            return perimetro;
        }

    }
}