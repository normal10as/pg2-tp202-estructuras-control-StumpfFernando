Module ej2_1

    Sub Main()
        Dim a, b As Int16
        Console.WriteLine("Ingrese valor de A")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese valor de B")
        b = Console.ReadLine()
        If a = b Then
            Console.WriteLine("A es igual a B")
        ElseIf a < b Then
            Console.WriteLine("A es menor que B")
        Else
            Console.WriteLine("A es mayor que B")
        End If
        Console.ReadKey()
    End Sub

End Module
