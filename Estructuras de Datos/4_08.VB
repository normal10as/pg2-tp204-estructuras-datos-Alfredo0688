Module _4_08
    Sub main()

        Dim paises As New Hashtable
        Dim dominio As String

        paises.Add("AR", "Argentina")
        paises.Add("BR", "Brasil")
        paises.Add("CH", "Chile")
        paises.Add("PE", "Perú")
        paises.Add("UR", "Uruguay")
        Do
            Console.WriteLine("Ingresar un dominio de un país sudamericano para ver si se encuentra en la lista o cero para salir")
            Console.Write("Dominio: ")
            dominio = Console.ReadLine

            If paises.Contains(dominio) And dominio <> "" Then
                Console.WriteLine("El país es: " & paises.Item(dominio))
            Else
                Console.WriteLine("La clave no existe")
            End If

        Loop Until dominio = ""


    End Sub
End Module
