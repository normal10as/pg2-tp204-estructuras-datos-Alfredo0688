Module _4_03
    Private i As Byte 'nos sirve para establecer el rango maximo en la muestra de la carga
    Private promedio_vector(39) As Single 'lo establecemos a nivel proyecto para poder acceder a el dentro de la funcion
    Sub main()
        'usaremos vectores para almacenar los datos

        Dim alumnos(39) As String
        Dim alumnos_notas(39, 3) As Byte

        Dim nombre As String
        Dim nota As Single
        Dim eleccion As Char
        Dim acumulador_notas As Single

        For i = 0 To alumnos.Length - 1
            Console.Write("Ingrese nombre del alumno: ")
            nombre = Console.ReadLine
            alumnos(i) = nombre

            For j = 0 To 3
                Console.Write("Ingrese nota {0}: ", j + 1)
                nota = Console.ReadLine
                alumnos_notas(i, j) = nota
                acumulador_notas = acumulador_notas + nota
            Next
            Calcularpromedio(acumulador_notas, i) 'pasamos como parametro el acumulador total y el indice para trabajarlo dentro de la funcion

            Console.Write("Desea continuar la carga?[S/N]: ")
            eleccion = Console.ReadLine
            If eleccion = "N" Then
                Exit For
            End If

            acumulador_notas = 0

        Next

        For x = 0 To i

            Console.WriteLine("Alumno {0} {1}: ", x + 1, alumnos(x))

            For z = 0 To 3

                Console.WriteLine("Nota: " & alumnos_notas(x, z))
            Next

            Console.WriteLine("Promedio: " & promedio_vector(x))
            Calificacionalumno(x)
            Console.ReadKey()
        Next

    End Sub

    Private Function Validarnombre(nombre As String) As Boolean
        If nombre <> "" Then
            Return True
        Else
            Console.WriteLine("No se puede ingresar vacio")
            Return False
        End If

    End Function

    Private Function Validarnota(nota As Single) As Boolean
        If nota >= 0 And nota <= 10 Then
            Return True
        Else
            Console.WriteLine("Nota incorrecta")
            Return False
        End If

    End Function

    Private Function Calcularpromedio(acumuladorNotas As Single, indice As Byte) As Single
        Dim promedio As Single
        promedio = acumuladorNotas / 4
        promedio_vector(indice) = promedio
        Return promedio
    End Function

    Private Sub Calificacionalumno(indice)

        If promedio_vector(indice) >= 6 Then
            Console.WriteLine("El alumno aprobo")
        Else
            Console.WriteLine("El alumno desaprobó")
        End If

        Console.Read()
    End Sub

    Private Function Mejoresalumnos() As Single
        Dim auxiliar As Single
        For Each promedio As Single In promedio_vector
            If promedio > auxiliar Then
                auxiliar = promedio
            End If
        Next
        Return auxiliar
    End Function

End Module
