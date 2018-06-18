Module _4_10

    Private Nombres As New Stack


    Sub main()
        Dim nombre As String
        Dim eleccion As Byte

        Console.WriteLine("1-Agregar nombres 2-Extraer nombres y mostrarlo en pantalla")
        Do
            Console.Write("Elección: ")
            eleccion = Console.ReadLine

            Select Case eleccion

                Case 1
                    Console.WriteLine("Agregar un nombre a la pila")
                    Console.Write("Nombre: ")
                    nombre = Console.ReadLine
                    Nombres.Push(nombre)
                Case 2
                    Console.WriteLine(Nombres.Pop)
            End Select

        Loop Until Nombres.Count = 0

        Console.ReadKey()
    End Sub
End Module
