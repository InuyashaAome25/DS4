internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int[] datos = [1, 2, 3];
            Console.WriteLine(datos[10]);
        }catch (Exception ex)
        {
            Console.WriteLine("Surgio un fallo, valide el indice del arreglo");
        }
        finally
        {
            Console.WriteLine("Continuacion con la aplicacion, luego del bloque try/catch");
        }
    }
}