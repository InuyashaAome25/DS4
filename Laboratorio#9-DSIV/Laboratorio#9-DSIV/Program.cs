internal class Program
{
    private static void Main(string[] args)
    {
        double precio = -1; // Inicializamos el precio con un valor inválido

        // Repetir mientras el precio sea negativo o inválido
        while (precio < 0)
        {
            Console.Write("Ingrese el precio del producto (debe ser positivo): $");

            // Intentar convertir la entrada del usuario a un número
            try
            {
                precio = Convert.ToDouble(Console.ReadLine());

                // Verificar si el precio es negativo
                if (precio < 0)
                {
                    Console.WriteLine("Error: El precio no puede ser negativo. Inténtelo de nuevo.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Entrada no válida. Por favor ingrese un número válido.");
            }
        }

        // Solicitar el método de pago
        Console.WriteLine("Ingrese el método de pago. E) Para efectivo T) Para tarjeta:");
        string metodo = Console.ReadLine().ToUpper(); // Convertir a mayúsculas para evitar problemas con minúsculas

        if (metodo == "E")
        {
            Console.WriteLine("El monto a pagar es: $" + precio + " (Pago en efectivo)");
        }
        else if (metodo == "T")
        {
            string tarjeta; // Usar string para manejar correctamente los 16 dígitos
            bool esValida = false;

            // Solicitar el número de la tarjeta hasta que tenga 16 dígitos válidos
            while (!esValida)
            {
                Console.WriteLine("Ingrese los dígitos de su tarjeta (16 dígitos):");
                tarjeta = Console.ReadLine();

                // Verificar que la tarjeta tenga exactamente 16 caracteres y que sean solo dígitos
                if (tarjeta.Length == 16 && long.TryParse(tarjeta, out _))
                {
                    esValida = true; // Si es válida, salir del bucle
                }
                else
                {
                    Console.WriteLine("Error: La tarjeta debe tener exactamente 16 dígitos numéricos. Inténtelo de nuevo.");
                }
            }

            // Si la tarjeta es válida, continuar con el programa
            Console.WriteLine("Número de tarjeta ingresado correctamente.");
            Console.WriteLine("El monto a pagar es: $" + precio + " (Pago con tarjeta)");
        }
        else
        {
            // Manejar la entrada no válida del método de pago
            Console.WriteLine("Error: Método de pago no válido. Inténtelo de nuevo.");
        }

    }
}