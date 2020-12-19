Imports System.Data.OleDb
Imports Práctica_3

Public Class AgenteBD

    Private Shared cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="



    Private Shared instancia As AgenteBD
    Private Shared conexion As OleDbConnection
    Private Shared rutaBD As String

    'Constructor de AgenteBD'
    Private Sub New()
        AgenteBD.conexion = New OleDbConnection(cadenaConexion & rutaBD)
        AgenteBD.conexion.Open()
    End Sub

    'Getter que devuelve una instancia de esta clase'
    Public Shared Function GetAgente(ruta As String) As AgenteBD
        Get_Ruta = ruta
        If instancia Is Nothing Then
            instancia = New AgenteBD
        End If
        Return instancia

    End Function

    Public Shared Function GetAgente() As AgenteBD

        If instancia Is Nothing Then
            instancia = New AgenteBD
        End If
        Return instancia

    End Function



    'Función que selecciona de la base de datos mediante la sentencia sql que lleva en el argumento'
    Function Leer(SQL As String) As OleDbDataReader

        Dim read As New OleDbCommand(SQL, conexion)
        Return read.ExecuteReader()

    End Function

    'Funcion Update que modifica los datos de la base de datos'
    Function Modificar(SQL As String) As Integer

        Dim Change As New OleDbCommand(SQL, conexion)
        Return Change.ExecuteNonQuery

    End Function

    Public Shared Property Get_Ruta As String
        Get
            Return rutaBD
        End Get
        Set(value As String)
            rutaBD = value
        End Set
    End Property

End Class
