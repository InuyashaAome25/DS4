using Laboratorio_8._4_DSIV;

internal class Program
{
    private static void Main(string[] args)
    {
        Empleado empleado = new Empleado();
        empleado.Nombre = "Ludy Calderon";
        Console.WriteLine($"Nombre del Empleado: {empleado.Nombre}");

        CuentaBancaria ctBan = new CuentaBancaria();
        ctBan.Saldo = 500;

        //CuentaBancaria ctBan = new CuentaBancaria();
        //ctBan.Saldo = -500;

        Console.WriteLine($"El saldo del Empleado: {ctBan.Saldo}");

        Cobertura c = new Cobertura(5);
        Console.WriteLine($"Con una cobertura de: {c.Radio}");
    }
}