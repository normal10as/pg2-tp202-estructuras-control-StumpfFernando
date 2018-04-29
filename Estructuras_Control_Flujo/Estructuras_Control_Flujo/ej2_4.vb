Module ej2_4
    Sub Main()
        Dim des As Single
        Dim precio, cant, subtotal As Integer
        Console.WriteLine("Cantidad:")
        cant = Console.ReadLine()
        Console.WriteLine("Precio unitario:")
        precio = Console.ReadLine()

        If cant >= 10 And cant <= 50 Then
            des = 0.05
        ElseIf cant >= 51 And cant <= 250 Then
            des = 0.1
        ElseIf cant >= 251 Then
            des = 0.2
        End If
        subtotal = cant * precio
        Console.WriteLine("El porcentaje de descuento aplicado es del {0} %", des * 100)
        Console.WriteLine("Subtotal....................... " & subtotal)
        Console.WriteLine("Monto descontado............... {0} ", subtotal * des)
        Console.WriteLine("Total a pagar.................. {0} ", subtotal - (subtotal * des))
        Console.ReadKey()
    End Sub
End Module
