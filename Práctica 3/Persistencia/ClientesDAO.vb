Imports System.Data.OleDb


Public Class ClientesDAO

    Private Clientes_lista As Collection
    Private Agente As AgenteBD
    Dim Leer As OleDbDataReader
    Dim Cliente As Clientes
    Dim DNI As String
    Dim Nombre As String
    Dim Tlf As Integer
    Dim Dir As String
    Dim Em As String



    'Constructor de ClientesDAO'
    Sub New()
        Clientes_lista = New Collection
    End Sub

    'Getter de lista'
    Public Function GetLista()

        Return Clientes_lista

    End Function

    'Función para vaciar la colección
    Function VaciarLista()
        Clientes_lista = Nothing
        Clientes_lista = New Collection
    End Function

    'Subprocedimiento en el que se inserta un nuevo cliente en la BBDD'
    Sub Insert(Cliente As Object)

        Agente = AgenteBD.GetAgente
        Agente.Modificar("INSERT INTO CLIENTES VALUES ('" & Cliente.DNI & "','" & Cliente.Nombre & "', '" & Cliente.Telefono & "','" & Cliente.Direccion & "','" & Cliente.Email & "');")

    End Sub

    'Subprocedimiento en el que se borra un cliente de la BBDD'
    Sub Delete(Cliente As Object)

        Agente = AgenteBD.GetAgente
        Agente.Modificar("DELETE FROM CLIENTES WHERE DNI='" & Cliente.DNI & "';")

    End Sub

    'Subprocedimiento en el que se actualiza la información del cliente'
    Sub Update(Cliente As Object)
        Agente = AgenteBD.GetAgente
        DNI = Cliente.DNI
        Nombre = Cliente.Nombre
        Tlf = Cliente.Telefono
        Dir = Cliente.Direccion
        Em = Cliente.Email
        Agente.Modificar("UPDATE CLIENTES SET Nombre='" & Nombre & "',Teléfono=" & Tlf & ", Dirección='" & Dir & "', Email='" & Em & "' WHERE DNI='" & DNI & "';") 'Modificar SQL

    End Sub

    'Subprocedimiento en el que se selecciona de la base de datos un cliente 
    ' con un DNI igual al seleccionado'
    Sub Read(Cliente As Object)
        Agente = AgenteBD.GetAgente
        DNI = Cliente.DNI
        Leer = Agente.Leer("SELECT * FROM CLIENTES WHERE DNI='" & DNI & "';")
        If Leer.Read() Then
            Cliente.DNI = Leer(0)
            Cliente.Nombre = Leer(1)
            Cliente.Telefono = Leer(2)
            Cliente.Direccion = Leer(3)
            Cliente.Email = Leer(4)
        End If

    End Sub

    'Método para leer de la BBDD aquellos clientes que hayan reservado 
    'al menos un patinete en un período de tiempo indicado
    Sub Read2(fechaIn As Date, fechaFin As Date)
        Agente = AgenteBD.GetAgente
        Dim _Cliente
        Leer = Agente.Leer("SELECT * FROM CLIENTES WHERE DNI IN (SELECT DISTINCT IdCliente FROM RESERVAS WHERE Fecha_inicio < #" & fechaFin & "# AND Fecha_fin > #" & fechaIn & "#);")
        While Leer.Read()
            _Cliente = New Clientes(Leer(0), Leer(1), Leer(2), Leer(3), Leer(4))
            Clientes_lista.Add(_Cliente)
        End While

    End Sub

    'Método para leer de la BBDD aquellos clientes que hayan reservado 
    'un determinado patinete en un período de tiempo indicado
    Sub Read3(idP As Integer, fechaIn As Date, fechaFin As Date)
        Agente = AgenteBD.GetAgente
        Dim _Cliente
        Leer = Agente.Leer("SELECT * FROM CLIENTES WHERE DNI IN (SELECT IdCliente FROM RESERVAS WHERE  Fecha_inicio < #" & fechaFin & "# AND Fecha_fin > #" & fechaIn & "# AND IdReserva IN (SELECT IdReserva FROM USO_PATINETES WHERE IdPatinete=" & idP & "));
")
        While Leer.Read()
            _Cliente = New Clientes(Leer(0), Leer(1), Leer(2), Leer(3), Leer(4))
            Clientes_lista.Add(_Cliente)
        End While
    End Sub

    'Bucle en el que se leen todos los clientes de la BBDD seleccionada'
    Sub Readall()
        Agente = AgenteBD.GetAgente
        Leer = Agente.Leer("SELECT * FROM CLIENTES ORDER BY DNI;")
        While Leer.Read()
            Cliente = New Clientes(Leer(0), Leer(1), Leer(2), Leer(3), Leer(4))
            Clientes_lista.Add(Cliente)
        End While

    End Sub

    'Método para modificar la ruta de la BBDD
    Sub Get_Ruta(ruta As String)
        Agente = AgenteBD.GetAgente(ruta)
    End Sub


End Class
