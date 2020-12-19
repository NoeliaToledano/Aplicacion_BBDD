Imports System.Data.OleDb

Public Class ReservasDAO


    Private Reservas_lista As Collection
    Private Agente As AgenteBD
    Dim Leer As OleDbDataReader
    Dim Reserva As Reservas
    Dim IdReserva As Integer
    Dim IdCliente As String
    Dim Fecha_inicio As Date
    Dim Fecha_fin As Date
    Dim Fecha_reserva As Date
    Dim Precio_reserva As Long

    'Constructor de PersonaDAO'
    Sub New()
        Reservas_lista = New Collection
    End Sub

    'Getter de lista'
    Public Function GetLista()

        Return Reservas_lista

    End Function

    'Subprocedimiento en el que se borra una nueva persona de la BBDD'
    Sub Delete(Reserva As Object)
        Agente = AgenteBD.GetAgente
        Agente.Modificar("DELETE FROM Reservas WHERE IdReserva=" & Reserva.ID_Reserva & ";")

    End Sub

    Sub DeleteUso(Reserva As Object)
        Agente = AgenteBD.GetAgente
        Agente.Modificar("DELETE FROM Uso_Patinetes WHERE IdReserva=" & Reserva.ID_Reserva & ";")

    End Sub

    Function Comprobar(fechaIn As Date, fechaFin As Date, patinete As Integer)
        Agente = AgenteBD.GetAgente
        Leer = Agente.Leer("SELECT p.IdReserva FROM Uso_Patinetes p WHERE p.IdReserva = (SELECT r.IdReserva FROM RESERVAS r WHERE r.Fecha_inicio <= #" & fechaIn & "# AND r.Fecha_fin >= #" & fechaFin & "# AND p.IdReserva = r.IdReserva) AND p.IdPatinete = " & patinete & ";")
        If Leer.Read() Then
            Return True
        End If
    End Function




    'Subprocedimiento en el que se inserta una nueva persona a la BBDD'
    Sub Insert(Reserva As Object)
        Agente = AgenteBD.GetAgente
        IdCliente = Reserva.IdCliente
        Fecha_inicio = Reserva.Fecha_Inicio
        Fecha_fin = Reserva.Fecha_Fin
        Fecha_reserva = Reserva.Fecha_Reserva
        Precio_reserva = Reserva.Precio_Reserva
        Agente.Modificar("INSERT INTO Reservas(Fecha_inicio,Fecha_fin,IdCliente,Fecha_Reserva,Precio_Reserva)  VALUES ('" & Fecha_inicio & "','" & Fecha_fin & "','" & IdCliente & "','" & Fecha_reserva & "','" & Precio_reserva & "');")

    End Sub

    'Subprocedimiento en el que se coge de la base de datos un dni igual al seleccionado'
    Sub Read(Reserva As Object)
        Agente = AgenteBD.GetAgente
        IdReserva = Reserva.Id_Reserva
        Leer = Agente.Leer("SELECT * FROM Reservas WHERE IdReserva =" & IdReserva & ";")


        If Leer.Read() Then
            Reserva.Fecha_inicio = Leer(1)
            Reserva.Fecha_fin = Leer(2)
            Reserva.IdCliente = Leer(3)
            Reserva.Fecha_Reserva = Leer(4)
            Reserva.Precio_Reserva = Leer(5)

        End If

    End Sub

    'Bucle en el que se leen todas las personas de la BBDD seleccionada'
    Sub ReadAll()
        Agente = AgenteBD.GetAgente
        Leer = Agente.Leer("SELECT * FROM RESERVAS ORDER BY IdReserva;")
        While Leer.Read()
            Reserva = New Reservas(Leer(0), Leer(1), Leer(2), Leer(3), Leer(4), Leer(5))
            Reservas_lista.Add(Reserva)
        End While

    End Sub

    'Subprocedimiento en el que se actualiza la información de la persona'
    Sub Update(Reserva As Object)
        Agente = AgenteBD.GetAgente
        Agente.Modificar("UPDATE Reservas SET Fecha_inicio='" & Reserva.Fecha_inicio & "',Fecha_fin='" & Reserva.Fecha_fin & "',IdCliente='" & Reserva.IdCliente & "',Fecha_Reserva='" & Reserva.Fecha_Reserva & "',Precio_Reserva='" & Reserva.Precio_Reserva & "' WHERE IdReserva=" & Reserva.ID_Reserva & ";") 'Modificar SQL

    End Sub

    Sub Identity(Reserva As Object)
        Agente = AgenteBD.GetAgente
        Leer = Agente.Leer("SELECT @@Identity")
        If Leer.Read() Then
            Reserva.ID_Reserva = Leer(0)
        End If
    End Sub

End Class




