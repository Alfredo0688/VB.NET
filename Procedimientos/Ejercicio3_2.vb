Module Ejercicio3_2

    Sub main()


        Dim fecha As Date
        Dim num_dias As Integer

        Console.Write("Ingresar una fecha: ")
        fecha = Console.ReadLine 'DD-MM-YYYY
        Console.Write("Ingresar dias para sumarle a esa fecha: ")
        num_dias = Console.ReadLine

        Console.WriteLine(SumarDias(fecha, num_dias))

        'Console.WriteLine("La fecha con los dias agregados es: " & fecha)
        Console.ReadKey()
    End Sub

    Private Function SumarDias(fech As Date, dias As Integer) As String

        Return fech.AddDays(dias)

    End Function


End Module
