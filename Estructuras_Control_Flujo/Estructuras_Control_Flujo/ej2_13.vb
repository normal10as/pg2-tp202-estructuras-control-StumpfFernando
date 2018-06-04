Module ej2_13
    Sub Main()
        Dim a As Integer = 3
        While a < 1000
            If a Mod 2 <> 0 Then
                Console.WriteLine(a)
            End If
            a += 1
        End While
        Console.ReadKey()
    End Sub
End Module
