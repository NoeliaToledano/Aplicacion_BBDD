
Imports System.Data.OleDb


Public Class PatinetesDAO

    Private Patinetes_lista As Collection
    Private Agente As AgenteBD = AgenteBD.GetAgente
    Dim Leer As OleDbDataReader
    Dim Patinete As Patinetes
    Dim IdPatinete As Integer
    Dim IdTipo As Long
    Dim Descripcion As String

    'Constructor de PatinetesDAO'
    Sub New()
        Patinetes_lista = New Collection
    End Sub

    'Getter de lista'
    Public Function GetLista()

        Return Patinetes_lista
    End Function

    Public Function VaciarLista()

        Patinetes_lista = Nothing
        Patinetes_lista = New Collection

    End Function

    'Subprocedimiento en el que se inserta un nuevo patinete a la BBDD'
    Sub Insert(Patinete As Object)
        Agente = AgenteBD.GetAgente
        IdTipo = Patinete.IdTipo
        Descripcion = Patinete.Descripcion
        Agente.Modificar("INSERT INTO PATINETES(Descripción,IdTipo) VALUES ('" & Descripcion & "'," & IdTipo & ");")

    End Sub

    'Subprocedimiento en el que se borra un patinete de la BBDD'
    Sub Delete(Patinete As Object)
        Agente = AgenteBD.GetAgente
        IdPatinete = Patinete.IdP
        Agente.Modificar("DELETE FROM PATINETES WHERE IdPatinete=" & IdPatinete & ";")

    End Sub

    'Subprocedimiento en el que se actualiza la información de la persona'
    Sub Update(Patinete As Object)
        Agente = AgenteBD.GetAgente
        Agente.Modificar("UPDATE PATINETES SET IdTipo=" & Patinete.IdTipo & ", Descripción='" & Patinete.Descripcion & "' WHERE IdPatinete=" & Patinete.IdP & ";") 'Modificar SQL

    End Sub
    'Subprocedimiento en el que se actualiza la información del patinete'
    Sub Read(Patinete As Object)
        Agente = AgenteBD.GetAgente
        IdPatinete = Patinete.IdP
        Leer = Agente.Leer("SELECT * FROM PATINETES WHERE IdPatinete=" & IdPatinete & ";")
        If Leer.Read() Then
            Patinete.IdP = Leer(0)
            Patinete.Descripcion = Leer(1)
            Patinete.IdTipo = Leer(2)
        End If

    End Sub

    'Bucle en el que se leen todas los patinetes de la BBDD seleccionada'
    Sub Readall()
        Agente = AgenteBD.GetAgente
        Leer = Agente.Leer("SELECT * FROM PATINETES ORDER BY IdPatinete;")
        While Leer.Read()
            Patinete = New Patinetes(Leer(1), Leer(2))
            Patinete.IdP = Leer(0)
            Patinetes_lista.Add(Patinete)
        End While

    End Sub

    'Método para leer de la BBDD aquellos patinetes que hayan sido reservados
    'en un período de tiempo indicado por un determinado cliente
    Sub Read2(dni As String, fechaIn As Date, fechaFin As Object)
        Agente = AgenteBD.GetAgente
        Leer = Agente.Leer("SELECT * FROM PATINETES WHERE IdPatinete IN (SELECT IdPatinete FROM USO_PATINETES WHERE IdReserva IN(SELECT IdReserva FROM RESERVAS WHERE IdCliente='" & dni & "' AND Fecha_inicio < #" & fechaFin & "# AND Fecha_fin > #" & fechaIn & "# order by IdReserva));")
        While Leer.Read()
            Patinete = New Patinetes(Leer(1), Leer(2))
            Patinete.IdP = Leer(0)
            Patinetes_lista.Add(Patinete)
        End While
    End Sub

    'Método para leer de la BBDD aquellos patinetes que hayan sido reservados
    'en un período de tiempo indicado
    Sub Read3(fechaIn As Date, fechaFin As Date)
        Agente = AgenteBD.GetAgente
        Leer = Agente.Leer("SELECT * FROM PATINETES WHERE IdPatinete IN (SELECT IdPatinete FROM USO_PATINETES WHERE IdReserva IN(SELECT IdReserva FROM RESERVAS WHERE Fecha_inicio < #" & fechaFin & "# AND Fecha_fin > #" & fechaIn & "#  order by IdReserva));")
        While Leer.Read()
            Patinete = New Patinetes(Leer(1), Leer(2))
            Patinete.IdP = Leer(0)
            Patinetes_lista.Add(Patinete)
        End While
    End Sub

End Class


