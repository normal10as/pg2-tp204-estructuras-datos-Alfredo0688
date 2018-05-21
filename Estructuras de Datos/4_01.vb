Module _4_01

    Sub Main()

        Dim valores() As Short = {10, 5, 5, 8, 9}
        Dim media As Single
        Dim n As Byte
        Dim z As Byte = 1

        For n = 0 To valores.Length - 1
            media = media + valores(n)
        Next

        media = media / n

        Console.WriteLine("Media: " & media)
        Console.ReadLine()

        For x = 0 To valores.Length - 1
            Console.Write("Elemento {0} ", z)
            Console.Write(valores(x))
            Console.Write(" Desviación: ")
            Console.WriteLine(valores(x) - media)
            Console.ReadKey()
            z += 1
        Next
        Console.Write("fin")
        Console.ReadKey()
    End Sub

End Module
