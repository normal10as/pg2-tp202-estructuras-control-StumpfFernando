Module ej2_3

    Sub Main()
        Dim a, b, c, d, e, pos As Int32
        Console.WriteLine("Ingrese 5 valores")
        Console.WriteLine("Posicion 1: ")
        a = Console.ReadLine()
        Console.WriteLine("Posicion 2: ")
        b = Console.ReadLine()
        Console.WriteLine("Posicion 3: ")
        c = Console.ReadLine()
        Console.WriteLine("Posicion 4: ")
        d = Console.ReadLine()
        Console.WriteLine("Posicion 5: ")
        e = Console.ReadLine()

        If a > b And a > c And a > d And a > e Then
            pos = 1
            Console.WriteLine("{0} es el numero mayor en la posicion {1}", a, pos)
        ElseIf b > a And b > c And b > d And b > e Then
            pos = 2
            Console.WriteLine("{0} es el numero mayor en la posicion {1}", b, pos)
        ElseIf c > a And c > b And c > d And c > e Then
            pos = 3
            Console.WriteLine("{0} es el numero mayor en la posicion {1}", c, pos)
        ElseIf d > a And d > b And d > c And d > e Then
            pos = 4
            Console.WriteLine("{0} es el numero mayor en la posicion {1}", d, pos)
        ElseIf e > a And e > b And e > c And e > d Then
            pos = 5
            Console.WriteLine("{0} es el numero mayor en la posicion {1}", e, pos)
        End If
        Console.ReadKey()
    End Sub

End Module
