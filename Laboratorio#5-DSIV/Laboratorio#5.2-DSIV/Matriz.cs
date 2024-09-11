internal class Matriz
{
    private int[,] mate;

    public void Ingresar()
    {
        mate = new int[3, 4];
        for (int j = 0; j < 3; j++)
        {
            for (int k = 0; k < 3; k++)
            {
                Console.Write("Ingrese posición ["+(j+1)+","+(k+1)+"] :");
                string datos;
                datos = Console.ReadLine();
                mate[j,k] = int.Parse(datos);
            }
        }
    }

    public void Imprimir()
    {
        for (int j = 0;j < 3; j++)
        {
            for (int k = 0;k < 3; k++)
            {
                Console.WriteLine(mate[j,k]+ " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
    private static void Main(string[] args)
    {
        Matriz ma = new Matriz();
        ma.Ingresar();
        ma.Imprimir();
    }
}