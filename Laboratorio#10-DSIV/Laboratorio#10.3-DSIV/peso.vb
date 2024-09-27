Module peso

    Sub Main()
        'Declaracion de variables 
        Dim M As Double
        Dim G As Double
        Dim P As Double

        'Ingresar valores para la variables
        G = 9.8
        Console.WriteLine("Ingrese la masa del objecto:")
        M = Console.ReadLine

        'Realiza los procesos
        P = M * G

        'Mostrar resultados 
        Console.WriteLine("Peso del objecto: {0}", P)
        Console.ReadKey()

    End Sub

End Module
