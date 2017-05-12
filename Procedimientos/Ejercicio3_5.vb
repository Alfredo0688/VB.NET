Module Ejercicio3_5

    Friend Const Pi As Double = 3.14159265

    Sub main()


        Dim r As Integer
        Dim h As Integer
        Console.WriteLine("Ingrese valores para calcular el volumen de un cilindro")

        r = Ingreso("Ingresar el radio de la base: ")
        h = Ingreso("Ingresar la altura del cilindro: ")


        Console.WriteLine(Calcular_Volumen(r, h))
        Console.ReadKey()

    End Sub

    Private Function Calcular_Volumen(radio As Integer, altura As Integer)

        Dim volumen As Decimal = (radio ^ 2) * altura * Pi

        Return volumen

    End Function

    Private Function Validar(valor) As Boolean
        Return valor > 0 And valor = Int(valor)
    End Function

    Public Function Ingreso(mensaje As String) As Integer
        Dim valor_x As Integer
        Do
            Console.WriteLine(mensaje)
            valor_x = Console.ReadLine

        Loop Until Validar(valor_x)
        Return valor_x
    End Function

End Module
