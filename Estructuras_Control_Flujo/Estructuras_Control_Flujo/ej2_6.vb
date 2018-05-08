Module ej2_6



    Sub Main()
        Dim des As Single
        Dim precio, cant, subtotal As Integer
        Console.WriteLine("Cantidad:")
        cant = Console.ReadLine()
        Console.WriteLine("Precio unitario:")
        precio = Console.ReadLine()
        Select Case cant
            Case 10 To 50
                des = 0.05
            Case 51 To 250
                des = 0.1
            Case Is > 251
                des = 0.2
            Case Else
                des = 0%
        End Select
        subtotal = cant * precio
        Console.WriteLine("El porcentaje de descuento aplicado es del {0} %", des * 100)
        Console.WriteLine("Subtotal....................... " & subtotal)
        Console.WriteLine("Monto descontado............... {0} ", subtotal * des)
        Console.WriteLine("Total a pagar.................. {0} ", subtotal - (subtotal * des))
        Console.ReadKey()
    End Sub


End Module
