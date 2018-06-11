Module _4_03

    Sub main()
        Dim alumnos_nombres(39) As String
        Dim alumnos_notas(39, 3) As Byte
        Dim promedio_vector(39) As Single
        Dim mejoresAlumnosVector(39) As Single
        Dim cantidad_alumnos, cantidad_notas As Byte
        Dim nombre As String
        Dim nota As Single
        Dim acumulador_notas As Single

        Console.WriteLine("Cargar una serie de alumnos y sus respectivas notas ")
        Console.Write("Cantidad de Alumnos del curso(máximo 40): ")
        cantidad_alumnos = Console.ReadLine
        Console.Write("Cantidad de notas(máximo 4): ")
        cantidad_notas = Console.ReadLine

        ReDim alumnos_notas(cantidad_alumnos, cantidad_notas)
        ReDim alumnos_nombres(cantidad_alumnos)
        ReDim promedio_vector(cantidad_alumnos)
        ReDim mejoresAlumnosVector(cantidad_alumnos)

        For n = 0 To alumnos_notas.GetUpperBound(0) - 1
            Do
                Console.Write("Ingrese nombre del alumno: ")
                nombre = Console.ReadLine
            Loop Until Validarnombre(nombre) And validar_nombre_unico(alumnos_nombres, nombre)

            alumnos_nombres(n) = nombre

            For j = 0 To alumnos_notas.GetUpperBound(1) - 1
                Do
                    Console.Write("Ingrese nota {0}: ", j + 1)
                    nota = Console.ReadLine
                Loop Until Validarnota(nota)
                alumnos_notas(n, j) = nota
                acumulador_notas = acumulador_notas + nota
            Next
            Calcularpromedio(promedio_vector, acumulador_notas, n, cantidad_notas)
            acumulador_notas = 0
        Next

        For x = 0 To alumnos_notas.GetUpperBound(0) - 1

            Console.WriteLine("Alumno {0} {1}: ", x + 1, alumnos_nombres(x))

            For z = 0 To alumnos_notas.GetUpperBound(1) - 1
                Console.WriteLine("Nota: " & alumnos_notas(x, z))
            Next

            Console.WriteLine("Promedio: " & promedio_vector(x))
            Calificacionalumno(promedio_vector, x)


            Console.ReadKey()

        Next
        ObtenerMejoresAlumnos(mejoresAlumnosVector, promedio_vector, cantidad_alumnos) 'devuelve un array cargado con las mejores calificaciones

        VerMejoresAlumnos(mejoresAlumnosVector, alumnos_nombres, cantidad_alumnos) 'muestra los mejores alumnos con su nombre y nota basado en dos vectores
        Console.ReadKey()
    End Sub

    Private Function Validarnombre(nombre As String) As Boolean
        If nombre <> "" And nombre.Length > 2 Then
            Return True
        Else
            Console.WriteLine("No se puede ingresar vacio")
            Return False
        End If
    End Function

    Private Function validar_nombre_unico(Vector, variable) As Boolean
        For Each nombres In Vector
            If variable = nombres And variable <> "" Then
                Console.WriteLine("El nombre ya existe, ingresar otro")
                Return False
            End If
        Next
        Return True
    End Function

    Private Function Validarnota(nota As Single) As Boolean
        If nota >= 0 And nota <= 10 Then
            Return True
        Else
            Console.WriteLine("Nota incorrecta")
            Return False
        End If
    End Function

    Private Sub Calcularpromedio(promedio_Vector As Array, acumuladorNotas As Single, indice As Byte, cantidad_notas As Byte)
        Dim promedio As Single = acumuladorNotas / cantidad_notas
        promedio_Vector(indice) = promedio
    End Sub

    Private Sub Calificacionalumno(vector, indice)
        If vector(indice) >= 6 Then
            Console.WriteLine("El alumno/a aprobo")
        Else
            Console.WriteLine("El alumno/a desaprobó")
        End If
    End Sub

    Private Function ObtenerMejoresAlumnos(mejoresAlumnos As Array, vector_promedio As Array, indiceMaximo As Byte) As Single
        Dim var_auxiliar As Single
        indiceMaximo = indiceMaximo - 1 'este indice lo uso como referencia maxima en los bucles por eso resto 1
        While var_auxiliar = 0
            For n = 0 To indiceMaximo
                If vector_promedio(n) > var_auxiliar Then
                    var_auxiliar = vector_promedio(n)
                End If
            Next
        End While

        For n = 0 To indiceMaximo
            If vector_promedio(n) = var_auxiliar Then
                mejoresAlumnos(n) = var_auxiliar
            End If
        Next

        Return mejoresAlumnos(indiceMaximo)

    End Function

    Private Sub VerMejoresAlumnos(mejoresAlumnos As Array, vectorNombres As Array, indiceMaximo As Byte)
        indiceMaximo = indiceMaximo - 1
        For x = 0 To indiceMaximo
            If mejoresAlumnos(x) <> 0 Then
                Console.WriteLine("Mejor Nota: {0} Alumno:{1} ", mejoresAlumnos(x), vectorNombres(x))
            End If
        Next
    End Sub
End Module
