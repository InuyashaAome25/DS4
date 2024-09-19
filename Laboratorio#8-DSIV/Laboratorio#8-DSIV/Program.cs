using Laboratorio_8_DSIV;

internal class Program
{
    private static void Main(string[] args)
    {
        Trabajador objp = new Trabajador("Cesar", 22, "784559-CC", 800);

        Console.WriteLine("Nombre: "+objp.nombre);
        Console.WriteLine("Edad: " +objp.edad);
        Console.WriteLine("NIF= " + objp.NIF);
        Console.WriteLine("Sueldo: " +objp.Sueldo);
        Console.ReadKey();
    }
}