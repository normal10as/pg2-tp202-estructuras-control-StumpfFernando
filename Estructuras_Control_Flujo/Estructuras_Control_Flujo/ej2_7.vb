Module ej2_7
    Sub main()
        Dim angulo As Int16
        Dim grado As String
        Console.WriteLine("Ingrese el tamaño del angulo")
        angulo = Console.ReadLine()
        Select Case angulo
            Case 1 To 90
                grado = "Agudo"
            Case Is = 90
                grado = "Recto"
            Case 91 To 179
                grado = "Obtuso"
            Case Is = 180
                grado = "Llano"
            Case 181 To 359
                grado = "Concavo"
            Case Else
                Console.WriteLine("ERROR...")
        End Select
        Console.WriteLine("El angulo es {0}", grado)
        Console.ReadKey()
    End Sub
End Module
