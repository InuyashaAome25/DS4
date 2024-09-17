internal class Program
{
    public static void checkAge(int age)
    {
        if (age < 10)
        {
            throw new ArgumentException("Ingreso Denegado!!! - No cumple con la edad minima requerida");
        }else
        {
            Console.WriteLine("Acceso Concedido");
        }
    }
    private static void Main(string[] args)
    {
        checkAge(9);
    }
}