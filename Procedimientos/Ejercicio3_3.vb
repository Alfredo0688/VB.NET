Module Ejercicio3_3

    Sub main()

        Dim numero As ULong
        Dim contador As Byte
        Dim potencia As Byte
        Console.Write("Ingresar un número para ver sus primeras 5 potencias: ")
        numero = Console.ReadLine
        potencia = numero

        For contador = 2 To 5

            Potencias(numero, potencia)

            Console.WriteLine("La potencia al: " & contador & " del numero es: " & numero)
            Console.ReadKey()
        Next

        Console.ReadLine()
    End Sub

    Private Function Potencias(ByRef num As Integer, potencia As Short)
        num = num * potencia
        Return num
    End Function

End Module
