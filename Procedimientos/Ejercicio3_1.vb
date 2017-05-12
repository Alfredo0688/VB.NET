Module Ejercicio3_1

    Sub Main()

        FechaActual()
        Console.WriteLine("La hora actual es: " & HoraActual())
        Console.ReadKey()

    End Sub

    Private Sub FechaActual()
        'Dim fecha As Date = "11-05-2017"
        Console.WriteLine("La fecha actual es: " & Date.Today)

    End Sub

    Private Function HoraActual() As String
        Return TimeOfDay
    End Function


End Module
