Module ej2_14
    Sub Main()
        Dim cantidad, preciou, subtotal, descuento As Decimal
        cantidad = 1
        Do While cantidad <> 0
            Console.WriteLine("Ingrese numero de unidades: ")
            cantidad = Console.ReadLine()
            Console.WriteLine("Precio unitario: ")
            preciou = Console.ReadLine()
            If cantidad >= 10 And cantidad <= 50 Then
                descuento = 0.05
            ElseIf cantidad >= 51 And cantidad <= 250 Then
                descuento = 0.1
            ElseIf cantidad >= 251 Then
                descuento = 0.2
            Else
                descuento = 0
            End If
            subtotal = cantidad * preciou
            Console.WriteLine("Subtotal: {0}", subtotal)
            Console.WriteLine("Descuento aplicado: {0}%", descuento * 100)
            Console.WriteLine("Monto descontado: {0}", subtotal * descuento)
            Console.WriteLine("Total a cobrar: {0}", subtotal - (subtotal * descuento))
            Console.WriteLine("*********************************************")
        Loop
    End Sub
End Module
