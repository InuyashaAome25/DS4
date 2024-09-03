internal class Program
{
    private static void Main(string[] args)
    {
        Cliente cliente = new Cliente();
        cliente.FirstName = "Cesar";
        cliente.LastName = "Castillo";
        cliente.Age = 22;
        cliente.Id = 1;

        Console.WriteLine(cliente.GetFullName());
    }


    public class Cliente
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ushort Age { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName + " " + Age;
        }
    }


    //Definicion de metodos que suma dos números e imprimir resultado.

    int dato = 54;
    int dato2 = 75;
    public void Suma(int dato1, int dato2)
    {
        int valLocal = dato1 + dato2;
        Console.WriteLine(valLocal);
    }


}