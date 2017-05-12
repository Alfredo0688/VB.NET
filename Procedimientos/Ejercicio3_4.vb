Module Ejercicio3_4

    Sub main()

        'hipotenusa c^2= a^2 + b^2

        Dim lado_a As Short
        Dim lado_b As Short
        lado_a = Ingreso("Ingresar lado A")
        lado_b = Ingreso("Ingresar lado B")
        
        Console.WriteLine("Hipotenusa: " & Calc_Hipotenusa(lado_a, lado_b))

        Console.ReadKey()


    End Sub


    Private Function Calc_Hipotenusa(ladoa As Short, ladob As Short)
        Dim hipotenusa As Integer
        hipotenusa = Math.Sqrt(ladoa ^ 2 + ladob ^ 2)

        Return hipotenusa

    End Function

    Private Function Validar(dato) As Boolean
        Return dato > 0 And dato = Int(dato)
    End Function

    Public Function Ingreso(mensaje)
        Dim valor As Short
        Do
            Console.WriteLine(mensaje)
            valor = Console.ReadLine
        Loop Until (Validar(valor))
        Return valor
    End Function


End Module
