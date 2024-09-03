internal class Program
{
    private static void Main()
    {
        //Asignacion a la variables estatica 
        Myclass.valor = 44;
        Myclass.valor2 = 0;

        int valor = 65;
        int valor2 = valor;
        valor = 28;

        Console.WriteLine(Myclass.valor);
        Console.WriteLine(Myclass.valor2);

        Console.WriteLine(valor);
        Console.WriteLine(valor2);


        //Nueva Instancia
        Myclass obj1 = new Myclass();
        obj1.FirstName = "Lewis";
        obj1.Age = 30;
        //Asignacion de una variable a otra 
        Myclass obj2 = obj1;
        //Cambioen la propiedad afectada tanto el obj1 con obj2
        obj2.FirstName = "Russell";

        Console.WriteLine(obj1.FirstName);
        Console.WriteLine(obj2.FirstName);
    }

    public class Myclass
    {
        //Declaracion de variable estatica
        public static int valor;
        public static int valor2;

        public string FirstName { get; set; }
        public ushort Age { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + Age;
        }
    }


}