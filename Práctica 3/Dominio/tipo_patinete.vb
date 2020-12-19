

Public Class Tipo_patinete



    Private _Marca As String
    Private _PesoPermitido As Long
    Private _Velocidad As Long
    Private _PrecioxHora As Decimal
    Private _Tipo As Long
    Private _GananciasAcumuladas As Decimal
    Dim _Tipo_patineteDAO As Tipo_patineteDAO = New Tipo_patineteDAO


    'Declaración de las propiedades de los atributos de un tipo de patinete'

    Property Marca As String
        Get
            Return Me._Marca
        End Get
        Set(value As String)
            Me._Marca = value
        End Set
    End Property

    Property PesoPermitido As Long
        Get
            Return Me._PesoPermitido
        End Get
        Set(value As Long)
            Me._PesoPermitido = value
        End Set
    End Property
    Property Velocidad As Long
        Get
            Return Me._Velocidad
        End Get
        Set(value As Long)
            Me._Velocidad = value
        End Set
    End Property
    Property PrecioxHora As Decimal
        Get
            Return Me._PrecioxHora
        End Get
        Set(value As Decimal)
            Me._PrecioxHora = value
        End Set
    End Property

    Public Property Tipo As Long
        Get
            Return _Tipo
        End Get
        Set(value As Long)
            _Tipo = value
        End Set
    End Property

    Public Property GananciasAcumuladas As Decimal
        Get
            Return _GananciasAcumuladas
        End Get
        Set(value As Decimal)
            _GananciasAcumuladas = value
        End Set
    End Property

    'Función que devuelve la colección de objetos clientes de Tipo_patineteDAO
    Public Function GetTipo_patineteDAO()
        Return _Tipo_patineteDAO.GetLista
    End Function

    'Función que elimina la colección de objetos clientes de Tipo_patineteDAO
    Public Function VaciarListaTipo_patineteDAO()
        _Tipo_patineteDAO.VaciarLista()
    End Function

    'Constructor de la clase Tipo Patinete'
    Sub New(Marca As String, PesoPermitido As Long, Velocidad As Long, PrecioxHora As Decimal)

        _Marca = Marca
        _PesoPermitido = PesoPermitido
        _Velocidad = Velocidad
        _PrecioxHora = PrecioxHora

    End Sub

    'Constructor de Tipo Patinete vacío'
    Sub New()

    End Sub

    'Subprocedimientos para modificar la base de datos'

    'Inserta este tipo de patinete en la base de datos'
    Sub Insertar()

        _Tipo_patineteDAO.Insert(Me)

    End Sub

    'Esta clase elimina de la base de datos este tipo de patinete'
    Sub Eliminar()

        _Tipo_patineteDAO.Delete(Me)

    End Sub

    'Modifica el los datos de este tipo de patinetes'
    Sub Modificar()

        _Tipo_patineteDAO.Update(Me)

    End Sub

    'Comprueba si existe el tipo de patinete'
    Sub leerreserva(idtipo As Long)

        Me._Tipo = idtipo
        _Tipo_patineteDAO.Read(Me)

    End Sub

    'Bucle en el que se leen todos los tipos de patinetes'
    Sub leertodos()

        _Tipo_patineteDAO.readall()

    End Sub

    'Método que devuelve una colección ordenada de mayor a menor 
    'de tipos de patinetes que más han ganado en un intervalo de tiempo
    Sub leerRanking(fechaIn As Date, fechaFin As Date)
        _Tipo_patineteDAO.Ranking(fechaIn, fechaFin)
    End Sub

End Class
