internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la nota del estudiante");
        float score = float.Parse(Console.ReadLine());

        if (score >= 70)
        {
            Console.WriteLine();
            Console.WriteLine($"Su nota es {score} ha aprovado la materia");
        }else
        {
            Console.WriteLine();
            Console.WriteLine($"Su nota es {score} ha reprovado la materia, debe repetir!!");
        }
    }
}