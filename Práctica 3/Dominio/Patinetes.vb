

Public Class Patinetes


    Private _Descripcion As String
    Private _IdTipo As Long
    Private _IdP As Long
    Dim _PatinetesDAO As New PatinetesDAO
    Private v As Object

    'Declaración de las propiedades de los atributos de un patinete'

    Property Descripcion As String
        Get
            Return Me._Descripcion
        End Get
        Set(value As String)
            Me._Descripcion = value
        End Set
    End Property

    Property IdTipo As Long
        Get
            Return Me._IdTipo
        End Get
        Set(value As Long)
            Me._IdTipo = value
        End Set
    End Property

    Public Property IdP As Long
        Get
            Return _IdP
        End Get
        Set(value As Long)
            Me._IdP = value
        End Set
    End Property

    'Función que devuelve la colección de objetos patinete de PatinetesDAO
    Public Function GetpatinetesDAO()

        Return _PatinetesDAO.GetLista
    End Function

    'Función que elimina la colección de objetos patinete de PatinetesDAO
    Public Function VaciarListaPatineteDAO()
        Return _PatinetesDAO.VaciarLista
    End Function

    'Constructor de la clase Persona'
    Sub New(Descripcion As String, IdTipo As Long)


        _Descripcion = Descripcion
        _IdTipo = IdTipo

    End Sub

    'Constructor de persona vacío'
    'Se usa para leer de la base de datos principalmente'
    Sub New()

    End Sub

    'Subprocedimientos para modificar la base de datos'

    'Inserta este patinete en la base de datos'
    Sub Insertar()

        _PatinetesDAO.Insert(Me)

    End Sub

    'Elimina el patinete'
    Sub Eliminar()

        _PatinetesDAO.Delete(Me)

    End Sub

    'Modifica los datos de este patinete'
    Sub Modificar()

        _PatinetesDAO.Update(Me)

    End Sub

    'Comprueba si existe el ID patinete'
    Sub leerPatinete(IdP As Long)

        Me.IdP = IdP
        _PatinetesDAO.Read(Me)

    End Sub

    'Método para leer de la BBDD aquellos patinetes que hayan sido reservados
    'en un período de tiempo indicado por un determinado cliente
    Sub leerPatineteD(dni As String, fechaIn As Date, fechaFin As Object)
        _PatinetesDAO.Read2(dni, fechaIn, fechaFin)
    End Sub

    'Método para leer de la BBDD aquellos patinetes que hayan sido reservados
    'en un período de tiempo indicado
    Sub leerPatineteD2(fechaIn As Date, fechaFin As Date)
        _PatinetesDAO.Read3(fechaIn, fechaFin)
    End Sub

    'Bucle en el que se leen todos los patinetes de la BBDD'
    Sub Leertodos()

        _PatinetesDAO.Readall()

    End Sub

End Class
