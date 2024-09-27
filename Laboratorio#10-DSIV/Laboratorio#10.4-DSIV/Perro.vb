Public Class Perro
    Public Property nombre As String
    Public Property raza As String
    Public Property altura As String

    Public Function comer(carne As String) As String
        Return nombre + " mide " + altura + " y comerá " + carne
    End Function
    Public Sub dormir()

    End Sub

    Public Sub labrar()

    End Sub

    Public Function calcularCostos(costo As Double, impuesto As Double) As Double
        Dim preciototal As Double

        preciototal = costo + (costo * impuesto)

        Return preciototal
    End Function
    Public Sub New()

    End Sub

    Public Sub New(nombre As String, raza As String, altura As String)
        Me.nombre = nombre
        Me.raza = raza
        Me.altura = altura
    End Sub

End Class
