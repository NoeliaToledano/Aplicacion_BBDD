
Imports System.Data.OleDb

Public Class Uso_patinetesDAO

    Private Uso_patinetes_lista As Collection
    Private Agente As AgenteBD = AgenteBD.GetAgente
    Dim Leer As OleDbDataReader
    Dim Uso_patin As Uso_patinetes
    Dim IdReserva As Integer
    Dim IdPatinete As Integer

    'Constructor de PersonaDAO'
    Sub New()
        Uso_patinetes_lista = New Collection
    End Sub

    'Getter de lista'
    Public Function GetLista()

        Return Uso_patinetes_lista

    End Function

    'Subprocedimiento en el que se borra una nueva persona de la BBDD'
    Sub Delete(Uso_patin As Object)

        Agente.Modificar("DELETE FROM Uso_patinetes WHERE IdReserva='" & Uso_patin.IdReserva & "';")

    End Sub

    'Subprocedimiento en el que se inserta una nueva persona a la BBDD'
    Sub Insert(Uso_patin As Object)
        Agente = AgenteBD.GetAgente
        IdReserva = Uso_patin.IdReserva
        IdPatinete = Uso_patin.IdPatinete
        Agente.Modificar("INSERT INTO Uso_patinetes (IdReserva, IdPatinete) VALUES ('" & IdReserva & "','" & IdPatinete & "');")

    End Sub

    'Subprocedimiento en el que se coge de la base de datos un dni igual al seleccionado'
    Sub Read(Uso_patin As Object)

        IdReserva = Uso_patin.IdReserva
        Leer = Agente.Leer("SELECT * FROM USO_PATINETES WHERE IdReserva=" & IdReserva & ";")
        If Leer.Read() Then
            Uso_patin.IdPatinete = Leer(1)
        End If

    End Sub

    'Bucle en el que se leen todas las personas de la BBDD seleccionada'
    Sub ReadAll()

        Leer = Agente.Leer("SELECT * FROM Tipo_Patinete ORDER BY IdTipo;")
        While Leer.Read()
            Uso_patin = New Uso_patinetes(Leer(0), Leer(1))
            Uso_patinetes_lista.Add(Uso_patin)
        End While

    End Sub

    Sub ReadReserva()

        Leer = Agente.Leer("SELECT * FROM Uso_Patinetes ORDER BY IdReserva;")
        While Leer.Read()
            Uso_patin = New Uso_patinetes(Leer(0), Leer(1))
            Uso_patinetes_lista.Add(Uso_patin)
        End While

    End Sub


    Sub ReadH(fechaIn As Date, fechaFin As Date)

        Leer = Agente.Leer("SELECT * FROM Uso_patinetes WHERE IdReserva=(SELECT IdReserva FROM RESERVAS WHERE Fecha_inicio >= '" & fechaIn & "' AND Fecha_fin <= '" & fechaFin & "');")
        If Leer.Read() Then
            Uso_patin = New Uso_patinetes(Leer(0), Leer(1))
            Uso_patinetes_lista.Add(Uso_patin)
        End If
    End Sub

    'Subprocedimiento en el que se actualiza la información de la persona'
    Sub Update(Uso_patin As Object)

        Agente.Modificar("UPDATE Uso_patinetes  SET IdPatinete='" & Uso_patin.IdPatinete & "' WHERE IdReserva='" & Uso_patin.IdReserva & "';") 'Modificar SQL

    End Sub


End Class


