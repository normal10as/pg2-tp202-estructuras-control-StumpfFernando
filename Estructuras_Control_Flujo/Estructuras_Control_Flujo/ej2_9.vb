Module ej2_9
    Sub Main()

        Console.WriteLine("Ingrese la medida a convertir: " + vbLf + "A: PIE" + vbLf + "B: YARDA" + vbLf + "C: PULGADA" + vbLf + "D: METRO" + vbLf + "***************")
        Dim X As Char = Console.ReadLine()
        Dim cant As Int16
        Console.WriteLine("ingrese unidades a convertir ")
        cant = Console.ReadLine()
        Console.WriteLine("***************")
        Select Case X
            Case "a", "A"
                Console.WriteLine(cant & " pies equivale a " & cant * 12 & " pulgadas")
            Case "b", "B"
                Console.WriteLine(cant & " yardas esquivale a " & cant * 3 & " pies")
            Case "c", "C"
                Console.WriteLine(cant & " pulgadas equivale a " & cant * 2, 54 & " cm")
            Case "d", "D"
                Console.WriteLine(cant & " metros equivale a " & cant * 100 & " cm")
            Case Else
                Console.WriteLine("ERROR")

        End Select
        Console.ReadKey()
    End Sub
End Module

