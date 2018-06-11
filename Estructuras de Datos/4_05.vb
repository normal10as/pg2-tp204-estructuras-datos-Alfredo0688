Module _4_05
    Sub main()

        Dim paises As New Collection
        Dim pais As String
        Dim eleccion As String
        Dim dominio As String
        Dim nombrePais As String = ""

        paises.Add("Argentina", "AR")
        paises.Add("Brasil", "BR")
        paises.Add("Chile", "CH")
        paises.Add("Perú", "PE")

        Console.WriteLine("De acuerdo a una lista de paises con sus respectivos dominios cargados en una coleccion")
        Do
            Console.WriteLine("Eliga las opciones a realizar")
            Console.WriteLine("Agregar - Editar - Borrar - Buscar - Salir")
            Console.Write("Elección: ")
            eleccion = Console.ReadLine
            Select Case eleccion

                Case "Agregar"
                    Console.WriteLine("Ingrese primero el dominio, por ejemplo AR(Argentina) y luego el nombre del país")
                    Do

                        Console.Write("Dominio: ")
                        dominio = Console.ReadLine

                        If paises.Contains(dominio) Then
                            Console.WriteLine("El dominio ingresado ya se encuentra en la lista")
                        Else
                            Console.Write("País: ")
                            nombrePais = Console.ReadLine
                        End If
                    Loop Until paises.Contains(dominio) = False

                    paises.Add(nombrePais, dominio)
                Case "Editar"

                    Console.WriteLine("Seleccione el páis a editar de acuerdo a su nombre de dominio")
                    Console.Write("Dominio: ")
                    dominio = Console.ReadLine
                    If paises.Contains(dominio) Then
                        Console.WriteLine("País encontrado: " & paises.Item(dominio))
                        Console.ReadKey()
                        paises.Remove(dominio)
                        Console.Write("Ingrese el dominio: ")
                        dominio = Console.ReadLine
                        Console.Write("Ingrese el país: ")
                        pais = Console.ReadLine
                        paises.Add(pais, dominio)
                    Else
                        Console.WriteLine("Pais no encontrado")
                    End If

                Case "Borrar"
                    Console.WriteLine("Seleccione el páis a borrar de acuerdo a su nombre de dominio")
                    Console.Write("Dominio: ")
                    dominio = Console.ReadLine
                    If paises.Contains(dominio) Then

                        Console.WriteLine("País encontrado: " & paises.Item(dominio))
                        Console.ReadKey()
                        paises.Remove(dominio)
                    Else
                        Console.WriteLine("Pais no encontrado")
                    End If
                Case "Buscar"

                    Do
                        Console.Write("Ingrese el nombre de dominio de un país o vacío para salir: ")
                        pais = Console.ReadLine
                        If paises.Contains(pais) Then

                            Console.WriteLine("País: " & paises.Item(pais))
                        ElseIf Not paises.Contains(pais) And pais <> "" Then
                            Console.WriteLine("Dominio no encontrado")
                        End If
                    Loop Until pais = ""
                Case "Salir"
                    For Each mostrarPais As String In paises
                        Console.WriteLine("País {0} {1}: {2} ", mostrarPais.Count, mostrarPais.Length, mostrarPais)
                        Console.ReadKey()

                    Next
                    Exit Do
                Case Else
                    Console.WriteLine("Escriba correctamente")
            End Select
        Loop
    End Sub

    Private Function validarDominio(dominio As String) As Boolean
        Return dominio.Length = 2
    End Function

End Module
