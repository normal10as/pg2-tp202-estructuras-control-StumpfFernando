﻿Module ej2_5
    Enum mes
        enero
        febrero
        marzo
        abril
        mayo
        junio
        julio
        agosto
        septiembre
        octubre
        noviembre
        diciembre
    End Enum
    Sub Main()
        Console.WriteLine("Ingrese el numero correspondiente para el mes")
        Dim x As Int16 = Console.ReadLine()
        Select Case x

            Case 1
                Console.WriteLine(mes.enero.ToString)
            Case 2
                Console.WriteLine(mes.febrero.ToString)
            Case 3
                Console.WriteLine(mes.marzo.ToString)
            Case 4
                Console.WriteLine(mes.abril.ToString)
            Case 5
                Console.WriteLine(mes.mayo.ToString)
            Case 6
                Console.WriteLine(mes.junio.ToString)
            Case 7
                Console.WriteLine(mes.julio.ToString)
            Case 8
                Console.WriteLine(mes.agosto.ToString)
            Case 9
                Console.WriteLine(mes.septiembre.ToString)
            Case 10
                Console.WriteLine(mes.octubre.ToString)
            Case 11
                Console.WriteLine(mes.noviembre.ToString)
            Case 12
                Console.WriteLine(mes.diciembre.ToString)
            Case Else
                Console.WriteLine("Invalido")


        End Select
        Console.ReadKey()

    End Sub


End Module
