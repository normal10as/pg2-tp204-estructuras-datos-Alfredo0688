Module _4_02
    Sub main()

        Dim codigoProducto() As Byte = {4, 6, 8}
        Dim nombreProducto() As String = {"Harina", "Sal", "Azucar"}
        Dim precioUnitario() As Single = {25.3, 14.8, 22.15}

        Dim cantidad As Single
        Dim totalGeneral As Single
       
        For n = 0 To codigoProducto.Length - 1

            Console.Write("Codigo de producto: ")
            Console.WriteLine(codigoProducto(n))
            Console.Write("Descripcion: ")
            Console.WriteLine(nombreProducto(n))
            Console.Write("Precio unitario: ")
            Console.WriteLine(precioUnitario(n))
            Console.Write("Cantidad: ")
            cantidad = Console.ReadLine
            cantidad = cantidad * precioUnitario(n)
            totalGeneral = totalGeneral + cantidad
            Console.WriteLine("Cantidad: {0} Total General: {1}: ", cantidad, totalGeneral)
            Console.ReadKey()
        Next



    End Sub
End Module
