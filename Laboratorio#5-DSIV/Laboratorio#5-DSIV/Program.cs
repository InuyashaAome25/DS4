internal class Program
{
    //link de repositorio: https://github.com/InuyashaAome25/DS4/tree/Laboratorios/Laboratorio%235-DSIV
    private static void Main(string[] args)
    {
        //Declaracion de vectores
        int valor[];
        int[] valores;      //arreglo sin inicializar

        valores = new int[100]; //Tiene 100 elementos disponibles
        valores = new int[20];  //Ahota tiene 20 elementos dispinibles

        //Declaracionde arreglo de Multidimenciones
        int[,] valores1;    //arreglo sin inicializar
        int[,] valores2 = new int[3,5];
        int[,,] valores3 = new int[3,7,9];      //Arreglo de tres dimenciones

        //Arreglo de un arreglo
        int[][] matriz0;
        //Inicializacion diferente
        int[][] matriz = new int[3][];
        for (int i = 0; i < matriz.Length; i++)
        {
            matriz[i] = new int[4];
        }
    }
}