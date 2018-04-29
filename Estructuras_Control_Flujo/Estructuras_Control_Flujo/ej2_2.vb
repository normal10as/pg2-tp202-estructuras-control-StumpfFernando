Module ej2_2
    Sub Main()
        Dim a, b, c As Int16
        Console.WriteLine("Ingrese 3 valores")
        a = Console.ReadLine()
        b = Console.ReadLine()
        c = Console.ReadLine()

        If a < b And a < c Then
            Console.WriteLine("{0} es el menor", a)
        ElseIf b < a And b < c Then
            Console.WriteLine("{0} es el menor", b)
        Else
            Console.WriteLine("{0} es el menor", c)
        End If


        Console.ReadKey()
    End Sub

End Module
