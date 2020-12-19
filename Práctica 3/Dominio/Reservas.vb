

Public Class Reservas

    Private _Id_Reserva As Integer
    Private _Fecha_inicio As DateTime
    Private _Fecha_fin As DateTime
    Private _IdCliente As String
    Private _Fecha_Reserva As String
    Private _Precio_Reserva As Long
    Dim _ReservasDAO As ReservasDAO = New ReservasDAO


    'Declaración de las propiedades DNI y Nombre'
    'Son los getter y setter del lenguaje java'


    Property ID_Reserva As Integer
        Get
            Return Me._ID_Reserva
        End Get
        Set(value As Integer)
            Me._ID_Reserva = value
        End Set
    End Property
    Property Fecha_inicio As String
        Get
            Return Me._Fecha_inicio
        End Get
        Set(value As String)
            Me._Fecha_inicio = value
        End Set
    End Property

    Property Fecha_fin As String
        Get
            Return Me._Fecha_fin
        End Get
        Set(value As String)
            Me._Fecha_fin = value
        End Set
    End Property
    Property IdCliente As String
        Get
            Return Me._IdCliente
        End Get
        Set(value As String)
            Me._IdCliente = value
        End Set
    End Property
    Property Fecha_Reserva As String
        Get
            Return Me._Fecha_Reserva
        End Get
        Set(value As String)
            Me._Fecha_Reserva = value
        End Set
    End Property
    Property Precio_Reserva As Long
        Get
            Return Me._Precio_Reserva
        End Get
        Set(value As Long)
            Me._Precio_Reserva = value
        End Set
    End Property

    Public Function GetReservasDAO()
        Return _ReservasDAO.GetLista
    End Function

    

    'Constructor de la clase Persona'
    Sub New(Fecha_inicio As String, Fecha_fin As String, IdCliente As String, Fecha_Reserva As String, Precio_Reserva As Long)

        _Fecha_inicio = Fecha_inicio
        _Fecha_fin = Fecha_fin
        _IdCliente = IdCliente
        _Fecha_Reserva = Fecha_Reserva
        _Precio_Reserva = Precio_Reserva

    End Sub

    'Constructor de persona vacío'
    'Se usa para leer de la base de datos principalmente'
    Sub New()

    End Sub

    Sub New(IdReserva As Integer, Fecha_inicio As String, Fecha_fin As String, IdCliente As String, Fecha_Reserva As String, Precio_Reserva As Long)
        _ID_Reserva = IdReserva
        _Fecha_inicio = Fecha_inicio
        _Fecha_fin = Fecha_fin
        _IdCliente = IdCliente
        _Fecha_Reserva = Fecha_Reserva
        _Precio_Reserva = Precio_Reserva

    End Sub

    Sub New(IdReserva As Integer)
        _ID_Reserva = IdReserva
    End Sub

    'Subprocedimientos para modificar la base de datos'

    'Esta clase llama a la clase PersonaDAO y elimina de la base de datos esta persona'
    Sub Eliminar()


        _ReservasDAO.Delete(Me)

    End Sub

    Sub EliminarUso()


        _ReservasDAO.DeleteUso(Me)

    End Sub
    Function Comprobar(fechaIn As Date, fechaFin As Date, patinete As Integer)
        Dim aux As Boolean = False
        aux = _ReservasDAO.Comprobar(fechaIn, fechaFin, patinete)
        Return aux
    End Function


    'Inserta esta persona en la base de datos'
    Sub Insertar()


        _ReservasDAO.Insert(Me)

    End Sub

    'Comprueba si existe el DNI'
    Sub LeerReserva(IdReserva As Integer)

        Me._Id_Reserva = IdReserva
        _ReservasDAO.Read(Me)

    End Sub

    'Bucle en el que se leen todas las personas'
    Sub LeerTodos()
        _ReservasDAO.ReadAll()
    End Sub

    'Modifica el nombre de esta persona, pero no el DNI'
    Sub Modificar()

        _ReservasDAO.Update(Me)

    End Sub

    Sub getId()
        _ReservasDAO.Identity(Me)
    End Sub
End Class
