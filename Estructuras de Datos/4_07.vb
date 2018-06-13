Module _4_07

    Sub main()
        Dim VectorNotas As New ArrayList()
        Dim vectorNombres As New ArrayList()
        Dim vectorPromedios As New ArrayList()
        Dim mejoresAlumnos As New ArrayList()
        Dim nombreAlumno As String
        Dim notaAlumno As Single
        Dim acumuladorNota As Single
        Dim indice_nombres As Short
        Dim indice_notas As Short

        Console.WriteLine("Ingrese una lista de alumnos con sus respectivas calificaciones")
        Do
            Console.Write("Alumnos(max 40):")
            indice_nombres = Console.ReadLine
            Console.Write("Notas(max 4):")
            indice_notas = Console.ReadLine
        Loop Until validar_dimension(indice_nombres, indice_notas)
        indice_nombres = indice_nombres - 1

        For i = 0 To indice_nombres
            Do
                Console.Write("Ingrese el nombre del alumno {0} : ", i + 1)
                nombreAlumno = Console.ReadLine
            Loop Until validarNombre(nombreAlumno) And validarNombreUnico(nombreAlumno, vectorNombres)
            vectorNombres.Add(nombreAlumno)
            For j = 0 To indice_notas - 1
                Do
                    Console.Write("{0}ª nota: ", j + 1)
                    notaAlumno = Console.ReadLine
                Loop Until validarNota(notaAlumno)

                VectorNotas.Add(notaAlumno)
                acumuladorNota = notaAlumno + acumuladorNota
            Next
            'asignamos a nuestro vector promedio lo que devuelva la funcion que es el promedio
            vectorPromedios.Add(calcularPromedio(acumuladorNota, indice_notas))
            acumuladorNota = 0
        Next

        For i = 0 To vectorNombres.Count - 1
            Console.WriteLine("Alumno: {0} Promedio: {1} ", vectorNombres(i), vectorPromedios(i))
            Console.WriteLine(calificacionAlumno(vectorPromedios, i))

            Console.ReadKey()
        Next

        MejoresAlumnosFunction(vectorPromedios, mejoresAlumnos, indice_nombres)

        For Each mejores As Single In mejoresAlumnos
            Console.WriteLine("Mejor nota:" & mejores)
        Next
        Console.Write("Fin del programa")
        Console.ReadKey()
    End Sub

    Private Function validarNombre(nombre As String) As Boolean
        Return nombre <> "" And nombre.Length > 2
    End Function
    Private Function validarNota(nota As Single) As Boolean
        Return nota > 0 And nota <= 10
    End Function
    Private Function validarNombreUnico(nombre As String, vector As ArrayList) As Boolean
        For Each name As String In vector
            If vector.Contains(nombre) And nombre <> "" Then
                Console.WriteLine("El nombre ya existe")
                Return False
            End If
        Next
        Return True
    End Function

    Private Function calcularPromedio(acumulador, indice_max_nota) As Single
        Dim promedio As Single
        promedio = acumulador / indice_max_nota
        Return promedio
    End Function

    Private Function calificacionAlumno(vector As ArrayList, indice As Byte) As String

        If vector(indice) >= 6 Then
            Return "El alumno aprobó"
        End If
        Return "El alumno desaprobó"

    End Function

    Private Function validar_dimension(nombre As Byte, notas As Byte) As Boolean
        Return nombre <= 40 And nombre > 0 And notas <= 4 And notas > 0
    End Function

    Private Function MejoresAlumnosFunction(promedio As ArrayList, mejores As ArrayList, indice_max As Short)
        Dim auxiliar As Byte = 0

        For n = 0 To indice_max
            If promedio(n) > auxiliar Then
                auxiliar = promedio(n)
            End If
        Next

        For n = 0 To indice_max
            If promedio(n) = auxiliar Then
                mejores.Add(auxiliar)
            End If
        Next

        Return mejores
    End Function
End Module
