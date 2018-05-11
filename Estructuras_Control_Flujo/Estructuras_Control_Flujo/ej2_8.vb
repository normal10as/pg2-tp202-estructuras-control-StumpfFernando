Module ej2_8



    Sub Main()
        Dim x, y, febrero As Int16

        Console.WriteLine("Ingrese el año y a continuacion el numero correspondiente para el mes")
        y = Console.ReadLine()
        x = Console.ReadLine()
        If (y Mod 4 = 0 And y Mod 100 <> 0 Or y Mod 400 = 0) Then
            febrero = 29
        Else
            febrero = 28
        End If

        Select Case x
            Case 1, 3, 5, 7, 8, 10, 12
                Console.WriteLine("El mes tiene " & mes.enero & " dias.")
            Case 4, 6, 9, 11
                Console.WriteLine("El mes tiene " & mes.abril & " dias.")
            Case 2
                Console.WriteLine(febrero)
            Case Else
                Console.WriteLine("ERROR...")
        End Select

    End Sub

End Module
