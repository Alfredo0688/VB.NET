Module Ejercicio3_6

    Sub main()

        Dim num As Integer
        Dim contador As Byte = 1
        Dim acumulador As Integer

        Console.WriteLine("Saber la sumatoria de sus cuadrados entre un numero x y el 1: ")
        num = Ingreso("Ingrese el numero: ")

        For contador = contador To num

            Console.WriteLine(Calcular_Sumatoria(acumulador, contador))
            Console.ReadKey()
        Next

    End Sub


    Private Function Calcular_Sumatoria(ByRef acumul As Integer, cont As Byte)


        acumul = acumul + (cont ^ 2)

        Return acumul

    End Function

    Private Function Validar(dato) As Boolean
        Return dato > 0 And dato = Int(dato)
    End Function


    Private Function Ingreso(mensaje As String) As Integer
        Dim numero_x As Integer
        Do
            Console.Write(mensaje)
            numero_x = Console.ReadLine

        Loop Until Validar(numero_x)
        Return numero_x

    End Function


End Module
