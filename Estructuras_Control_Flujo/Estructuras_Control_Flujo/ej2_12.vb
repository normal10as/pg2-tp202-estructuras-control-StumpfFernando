Module ej2_12
    Sub Main()
        Dim a, b, c, d As Integer
        Console.WriteLine("secuencia figunacci")
        a = 0
        b = 1
        While d < 20
            c = a + b
            a = b
            b = c
            d += 1
            Console.WriteLine(c)
        End While
        Console.ReadKey()
    End Sub
End Module