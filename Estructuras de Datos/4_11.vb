Module _4_11
    Sub main()
        Dim valores As New Stack
        Dim valor As Decimal
        Dim sumatoria As Decimal

        Do
            Console.Write("Valor: ")
            valor = Console.ReadLine

            If valor = 0 Then
                valores.Pop()
            End If
            sumatoria = sumatoria + valor
            valores.Push(valor)
            Console.WriteLine("Sumatoria: " & sumatoria)
        Loop
    End Sub
End Module
