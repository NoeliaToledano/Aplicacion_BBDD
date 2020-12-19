Public Class Clientes

    Private _DNI As String
    Private _Nombre As String
    Private _Telefono As Integer
    Private _Direccion As String
    Private _Email As String
    Dim _ClientesDAO As ClientesDAO = New ClientesDAO

    'Declaración de las propiedades de los atributos de un cliente'
    Property DNI As String
        Get
            Return Me._DNI
        End Get
        Set(value As String)
            Me._DNI = value
        End Set
    End Property

    Property Nombre As String
        Get
            Return Me._Nombre
        End Get
        Set(value As String)
            Me._Nombre = value
        End Set
    End Property

    Property Telefono As Integer
        Get
            Return Me._Telefono
        End Get
        Set(value As Integer)
            Me._Telefono = value
        End Set
    End Property

    Property Direccion As String
        Get
            Return Me._Direccion
        End Get
        Set(value As String)
            Me._Direccion = value
        End Set
    End Property

    Property Email As String
        Get
            Return Me._Email
        End Get
        Set(value As String)
            Me._Email = value
        End Set
    End Property

    'Función que devuelve la colección de objetos clientes de ClientesDAO
    Public Function GetClienteDAO()

        Return _ClientesDAO.GetLista
    End Function

    'Función que elimina la colección de objetos clientes de ClientesDAO
    Function VaciarListaClientesDAO()
        Return _ClientesDAO.VaciarLista
    End Function

    'Constructor de la clase Cliente'
    Sub New(DNI As String, Nombre As String, Telefono As Integer, Direccion As String, Email As String)
        _DNI = DNI
        _Nombre = Nombre
        _Telefono = Telefono
        _Direccion = Direccion
        _Email = Email

    End Sub



    'Método para actualizar la ruta de la bbdd en el agente.
    Sub Get_Ruta(ruta As String)
        _ClientesDAO = New ClientesDAO
        _ClientesDAO.Get_Ruta(ruta)

    End Sub

    'Constructor de cliente vacío'
    'Se usa para leer de la base de datos principalmente'
    Sub New()

    End Sub

    'Subprocedimientos para modificar la base de datos'

    'Inserta este cliente en la base de datos'
    Sub Insertar()
        _ClientesDAO = New ClientesDAO
        _ClientesDAO.Insert(Me)

    End Sub

    'Elimina de la base de datos este cliente'
    Sub Eliminar()
        _ClientesDAO.Delete(Me)
    End Sub

    'Modifica el nombre de este cliente, pero no el DNI'
    Sub Modificar()

        _ClientesDAO.Update(Me)

    End Sub

    'Comprueba si existe el DNI en la BBDD'
    Sub LeerPersona(DNI As String)

        Me._DNI = DNI
        _ClientesDAO.Read(Me)

    End Sub

    'Método para leer de la BBDD aquellos clientes que hayan reservado un patinete
    'en un período de tiempo indicado
    Sub leerH(fechaIn As Date, fechaFin As Date)
        _ClientesDAO.Read2(fechaIn, fechaFin)
    End Sub

    'Método para leer de la BBDD aquellos clientes que hayan reservado 
    'un determinado patinete en un período de tiempo indicado
    Sub leerPat(idP As Integer, fechaIn As Date, fechaFin As Date)
        _ClientesDAO.Read3(idP, fechaIn, fechaFin)
    End Sub

    'Bucle en el que se leen todos los clientes de la BBDD'
    Sub LeerTodos()
        _ClientesDAO.Readall()
    End Sub

End Class
