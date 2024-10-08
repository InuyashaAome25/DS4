using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        int dato;
        int multiplicacion=1;

        do
        {
            Console.WriteLine("Ingrese un dato numerico, para generar la matriz n x n.");
            dato = int.Parse(Console.ReadLine());

            if (dato % 2 !=0)
            {
                Console.WriteLine("Ingrese una matriz par, no se acepta matriz impar. Vuelva a intentarlo!!");
            }
        }while (dato%2 != 0);

        

        int[,] matriz = new int[dato,dato];

        //Instancia a Random
        Random random = new Random();
        int numRandom = random.Next(101,200);

        // Obtener las dos filas del medio
        int fila1 = dato / 2 - 1;
        int fila2 = dato / 2;


        for (int j = 1; j < dato - 1; j++)
        {
            // Generar y asignar un número aleatorio a las filas del medio
            int numRandom1 = random.Next(101, 200);
            int numRandom2 = random.Next(101, 200);

            matriz[fila1, j] = numRandom1;
            matriz[fila2, j] = numRandom2;

            // Multiplicar los valores aleatorios
            multiplicacion *= numRandom1;
            multiplicacion *= numRandom2;
        }


        Console.WriteLine("\nLa matriz es:");
        for (int i = 0;i < dato; i++)
        {
            for(int j = 0;j < dato; j++)
            {
                Console.Write(matriz[i,j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nEl resultado de la multiplicacion de los numeros generado es de: "+ multiplicacion);
    }
}