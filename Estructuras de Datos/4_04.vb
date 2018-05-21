Module _4_04

    Sub main()

        Dim paises As New Collection
        Dim pais As String

        paises.Add("Argentina", "AR")
        paises.Add("Brasil", "BR")
        paises.Add("Chile", "CH")
        paises.Add("Perú", "PE")

        Do
            Console.Write("Ingrese el nombre de dominio de un país o vacío para salir: ")
            pais = Console.ReadLine
            If paises.Contains(pais) Then

                Console.WriteLine("País: " & paises.Item(pais))
            ElseIf Not paises.Contains(pais) And pais <> "" Then
                Console.WriteLine("Dominio no encontrado")
            End If
        Loop Until pais = ""

        Console.Write("fin del programa")
        Console.ReadLine()
    End Sub



End Module
