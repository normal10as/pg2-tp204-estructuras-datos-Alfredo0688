Module _4_06
    Sub main()

        Dim produccionSemanal(4, 4) As ArrayList
        Dim empleadosPlanta As New Collection
        Dim produccion As Single
        Dim produccionTotal As Single
        Dim dia As String
        Dim eleccion As Char

        empleadosPlanta.Add("Jose Ramirez", "JR")
        empleadosPlanta.Add("Pedro Jimenez", "PJ")
        empleadosPlanta.Add("Marcelo Gonzales", "MG")
        empleadosPlanta.Add("Fernando Villar", "FV")
        empleadosPlanta.Add("Mariano Berzotti", "MB")


        Do
            Console.Write("Ingrese un día de la semana: ")
            dia = Console.ReadLine
            Console.WriteLine("Producción día: " & dia)
            For i = 1 To produccionSemanal.GetLength(0)


                Console.WriteLine("Empleado: " & empleadosPlanta(i))

                For j = 1 To produccionSemanal.GetLength(1)

                    Console.Write("Ingresar produccion: ")
                    produccion = Console.ReadLine
                    produccionTotal = produccion + produccionTotal
                    Console.Write("Ingresar otra carga en el día? [S/N] ")
                    eleccion = Console.ReadLine
                    If eleccion = "S" Then
                        eleccion = eleccion
                    ElseIf eleccion = "N" Then
                        Exit For
                    End If
                Next
                Console.WriteLine("Empleado: " & empleadosPlanta(i))
                Console.WriteLine("Total de producción: " & produccionTotal)
                Console.ReadKey()
                Console.WriteLine("")
            Next

        Loop

    End Sub
End Module
