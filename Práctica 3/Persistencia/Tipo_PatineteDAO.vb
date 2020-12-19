
Imports System.Data.OleDb

Public Class Tipo_patineteDAO

    Private Tipo_patinete_lista As Collection
    Private Agente As AgenteBD = AgenteBD.GetAgente
    Dim Leer As OleDbDataReader
    Dim Tipo_Patin As Tipo_patinete
    Dim IdTipo As Integer
    Dim PrecioxHora As Decimal

    'Constructor de Tipo_patineteDAO'
    Sub New()
        Tipo_patinete_lista = New Collection
    End Sub

    'Función que devuelve la colección de objetos clientes de Tipo_patineteDAO
    Public Function GetLista()

        Return Tipo_patinete_lista

    End Function

    'Función que elimina la colección de objetos clientes de Tipo_patineteDAO
    Public Function VaciarLista()

        Tipo_patinete_lista = Nothing
        Tipo_patinete_lista = New Collection

    End Function

    'Subprocedimiento en el que se inserta este tipo de patinete en la base de datos'
    Sub Insert(Tipo_Patin As Object)

        Agente.Modificar("INSERT INTO TIPO_PATINETE(Marca, PesoPermitido, Velocidad, PrecioxHora) VALUES ('" & Tipo_Patin.Marca & "','" & Tipo_Patin.PesoPermitido & "','" & Tipo_Patin.Velocidad & "','" & Tipo_Patin.PrecioxHora & "');")

    End Sub

    'Subprocedimiento en el que se borra un tipo de patinete de la BBDD'
    Sub Delete(Tipo_Patin As Object)

        Agente.Modificar("DELETE FROM TIPO_PATINETE WHERE IdTipo=" & Tipo_Patin.Tipo & ";")

    End Sub

    'Subprocedimiento en el que se actualiza la información de un tipo de patinete'
    Sub Update(Tipo_Patin As Object)

        Agente.Modificar("UPDATE Tipo_Patinete  SET Marca='" & Tipo_Patin.Marca & "',PesoPermitido=" & Tipo_Patin.PesoPermitido & ",Velocidad=" & Tipo_Patin.Velocidad & ",PrecioxHora=" & Tipo_Patin.PrecioxHora & " WHERE IdTipo=" & Tipo_Patin.Tipo & ";") 'Modificar SQL

    End Sub

    'Subprocedimiento en el que se coge de la base de datos un tipo de patinete igual al seleccionado'
    Sub Read(Tipo_Patin As Object)
        Agente = AgenteBD.GetAgente
        IdTipo = Tipo_Patin.Tipo
        Leer = Agente.Leer("SELECT * FROM Tipo_Patinete  WHERE IdTipo=" & IdTipo & ";")
        If Leer.Read() Then
            Tipo_Patin.Tipo = Leer(0)
            Tipo_Patin.Marca = Leer(1)
            Tipo_Patin.PesoPermitido = Leer(2)
            Tipo_Patin.Velocidad = Leer(3)
            Tipo_Patin.PrecioxHora = Leer(4)
        End If

    End Sub

    'Bucle en el que se leen todos los tipos de patinete de la BBDD seleccionada'
    Sub readall()
        Agente = AgenteBD.GetAgente
        Leer = Agente.Leer("select * from tipo_patinete  order by idtipo;")
        While Leer.Read()
            Tipo_Patin = New Tipo_patinete(Leer(1), Leer(2), Leer(3), Leer(4))
            Tipo_Patin.Tipo = Leer(0)
            Tipo_patinete_lista.Add(Tipo_Patin)
        End While

    End Sub


    'Método que devuelve una colección ordenada de mayor a menor 
    'de tipos de patinetes que más han ganado en un intervalo de tiempo
    Sub Ranking(fechaIn As Date, fechaFin As Date)
        Agente = AgenteBD.GetAgente
        Leer = Agente.Leer("SELECT  TIPO_PATINETE.IdTIpo, Marca,PesoPermitido,Velocidad,PrecioxHora, sum(Precio_Reserva)
FROM RESERVAS 
INNER JOIN ((TIPO_PATINETE 
INNER JOIN PATINETES ON TIPO_PATINETE.IdTipo = PATINETES.IdTipo) 
INNER JOIN USO_PATINETES ON PATINETES.IdPatinete = USO_PATINETES.IdPatinete)
 ON RESERVAS.IdReserva = USO_PATINETES.IdReserva
WHERE Fecha_inicio < #" & fechaFin & "# AND Fecha_fin > #" & fechaIn & "#
group by TIPO_PATINETE.IdTIpo,Marca,PesoPermitido,Velocidad,PrecioxHora
order by sum(Precio_Reserva) DESC;")

        While Leer.Read()
            Tipo_Patin = New Tipo_patinete(Leer(1), Leer(2), Leer(3), Leer(4))
            Tipo_Patin.Tipo = Leer(0)
            Tipo_Patin.GananciasAcumuladas = Leer(5)
            Tipo_patinete_lista.Add(Tipo_Patin)
        End While
    End Sub
End Class


