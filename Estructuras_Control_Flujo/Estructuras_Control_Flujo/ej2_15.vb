Module ej2_15
    Const intanual As Single = 0.36
    Sub Main()
        Dim capital, interes, saldo, intganado As Single
        Dim meses As Byte
        Console.Write("Ingrese capital: ")
        capital = Console.ReadLine()
        Console.Write("Candidad de meses a aplazar: ")
        meses = Console.ReadLine()
        Console.WriteLine("|___MES____|" & "___CAPITAL___|" & "___INTERES___|" & "___SALDO___|")
        For i As Byte = 1 To meses Step +1
            interes = capital * (intanual / 12)
            saldo = capital + interes
            Console.WriteLine("     " & Math.Round(i, 2) & "        " & Math.Round(capital, 2) & "        " & Math.Round(interes, 2) & "        " & Math.Round(saldo, 2))
            intganado += interes
            capital = saldo
        Next
        Console.WriteLine("Intereses ganados: " & Math.Round(intganado, 2))
        Console.WriteLine("Saldo total: " & Math.Round(saldo, 2))
    End Sub
End Module
