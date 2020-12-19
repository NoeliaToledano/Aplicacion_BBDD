Public Class Uso_patinetes

    Private _IdReserva As Integer 'no se asigna ningun valor, al meterlo en la base de datos se asigna automaticamente un valor'
    Private _IdPatinete As Integer

    Dim _Uso_patinetesDAO As New Uso_patinetesDAO




    'Declaración de las propiedades DNI y Nombre'
    'Son los getter y setter del lenguaje java'


    Property IdReserva As Integer
        Get
            Return Me._IdReserva
        End Get
        Set(value As Integer)
            Me._IdReserva = value
        End Set
    End Property



    Property IdPatinete As Integer
        Get
            Return Me._IdPatinete
        End Get
        Set(value As Integer)
            Me._IdPatinete = value
        End Set
    End Property


    Public Function GetUso_patinetesDAO()
        Return _Uso_patinetesDAO.GetLista
    End Function


    'Constructor de la clase Persona'
    Sub New(_IdReserva As Integer, _IdPatinete As Integer)

        IdReserva = _IdReserva
        IdPatinete = _IdPatinete

    End Sub

    'Constructor de persona vacío'
    'Se usa para leer de la base de datos principalmente'
    Sub New()

    End Sub

    'Subprocedimientos para modificar la base de datos'

    'Esta clase llama a la clase PersonaDAO y elimina de la base de datos esta persona'
    Sub Eliminar()


        _Uso_patinetesDAO.Delete(Me)

    End Sub

    'Inserta esta persona en la base de datos'
    Sub Insertar()


        _Uso_patinetesDAO.Insert(Me)

    End Sub

    'Comprueba si existe el DNI'
    'Sub leerreserva()

    '    Me._Uso_patinetesDAO = IdReserva
    '    _Uso_patinetesDAO.Read(Me)

    'End Sub

    'Bucle en el que se leen todas las personas'
    Sub leertodos()

        _Uso_patinetesDAO.ReadAll()

    End Sub

    Sub leerReserva()

        _Uso_patinetesDAO.ReadReserva()

    End Sub

    Sub leerH(fechaIn As Date, fechaFin As Date)
        _Uso_patinetesDAO.ReadH(fechaIn, fechaFin)
    End Sub

    'Modifica el nombre de esta persona, pero no el DNI'
    Sub Modificar()

        _Uso_patinetesDAO.Update(Me)

    End Sub

    Sub leerReserva(IdReserva As Integer)
        Me._IdReserva = IdReserva
        _Uso_patinetesDAO.Read(Me)
    End Sub
End Class
