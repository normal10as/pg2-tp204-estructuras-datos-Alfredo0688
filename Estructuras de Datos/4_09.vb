Module _4_09
    Sub main()

        Dim clientes As New Queue
        Dim nombre As String
        Dim eleccion As Byte
        Console.WriteLine("Programa para dar turnos por orden de llegada a una tienda")
        Do
            Console.Write("1-dar turno  2-llamar próximo cliente: ")
            eleccion = Console.ReadLine
            Select Case eleccion
                Case 1
                    Console.Write("Ingrese el nombre del cliente: ")
                    nombre = Console.ReadLine
                    clientes.Enqueue(nombre)
                Case 2
                    Console.WriteLine("Llamar al próximo cliente: " & clientes.Dequeue)

            End Select

            Console.WriteLine("Cantidad de cliente: " & clientes.Count)

            Console.WriteLine("Cliente en espera 1: " & clientes(0))

            If clientes.Count > 1 Then
                Console.WriteLine("Cliente en espera 2: " & clientes(1))
            End If

            If clientes.Count = 0 Then
                Console.WriteLine("No hay clientes")
                Console.ReadKey()
            End If

        Loop Until clientes.Count = 0



    End Sub
End Module
