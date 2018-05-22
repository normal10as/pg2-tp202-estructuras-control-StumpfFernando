Module ej2_11
    Sub main()
        Dim num = 1, p, i As Integer

        Do While num <> 0
            Console.WriteLine("ingrese un numero")
            num = Console.ReadLine()
            If num Mod 2 = 0 Then
                p += 1
                Console.WriteLine("el numero " & num & " es par ")
            Else
                i += 1
                Console.WriteLine("el numero " & num & " es impar ")
            End If
        Loop
        If p = 0 Or i = 0 Then
            If p > i Then
                Console.WriteLine("Todos los numeros ingresados son pares")
            Else
                Console.WriteLine("Tdoso los numeros ingresados son impares")
            End If
        Else
            Console.WriteLine("Ingreso " & p & " numeros pares y " & i & " numeros impares.")

        End If
        Console.ReadKey()
    End Sub
End Module
