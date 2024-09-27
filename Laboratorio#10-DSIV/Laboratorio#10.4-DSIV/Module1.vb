Module Module1

    Public Sub Main(args() As String)
        Dim perrito As Perro = New Perro()
        perrito.nombre = "Rocky"
        perrito.raza = "Rhodesian Ridgeback"
        perrito.altura = "1.05cm"

        Console.WriteLine(perrito.comer("Carne"))

        Dim perrito2 As Perro = New Perro()
        perrito2.nombre = "QAMRA"
        perrito2.altura = "0.50cm"

        Console.WriteLine(perrito2.comer("Pollo"))

        Dim perrito3 As Perro = New Perro("Peluchin", "Poodle", "0.50cm")

        Console.WriteLine(perrito3.comer("Pan"))
    End Sub

End Module
