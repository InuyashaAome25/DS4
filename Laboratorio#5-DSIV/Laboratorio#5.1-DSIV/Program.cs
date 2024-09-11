internal class Program
{
    private int[] sueldos;

    public void CargarSueldo()
    {
        sueldos = new int[6];

        for (int i = 0; i <= 5; i++)
        {
            Console.Write("Ingrese el sueldo del operario"+i+": ");
            string dato;
            dato = Console.ReadLine();
            sueldos[i] = int.Parse(dato);
        }
    }

    public void Imprimir()
    {
        Console.Write("Los 5 suerldos de los operarios \n");
        for (int i = 0; i <= 5; i++)
        {
            Console.Write("[" + sueldos[i]+"] ");
        }
        Console.ReadKey();
    }
    static void Main(string[] args)
    {
        Program pv = new Program();

        pv.CargarSueldo();
        pv.Imprimir();
    }
}