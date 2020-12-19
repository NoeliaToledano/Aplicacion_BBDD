Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class ClientesUI


    Private Sub btn_Añadir_Click(sender As Object, e As EventArgs) Handles btn_Añadir.Click
        'Método para insertar en la bbdd los datos de un cliente
        Dim DNI As String
        Dim Nombre As String
        Dim Tlf As Long
        Dim Dir As String
        Dim Em As String
        Dim excep As Boolean = False

        'Comprueba si los campos de texto están vacíos'
        If (txt_DNI.Text = "" Or txt_Nombre.Text = "" Or txt_Tlf.Text = "" Or txt_Dir.Text = "" Or txt_Em.Text = "") Or
            Not Comprobar(txt_DNI.Text, txt_Nombre.Text, txt_Tlf.Text, txt_Dir.Text, txt_Em.Text) Then
            MessageBox.Show("No se puede añadir", "Error")

        Else
            DNI = txt_DNI.Text
            Nombre = txt_Nombre.Text
            Tlf = txt_Tlf.Text
            Dir = txt_Dir.Text
            Em = txt_Em.Text
            Dim Cliente As New Clientes(DNI, Nombre, Tlf, Dir, Em)
            'Comprueba si existe el DNI en la BBDD'
            If (ListDNI.Items.Contains(Cliente.DNI)) Then
                MessageBox.Show("Este DNI ya se encuentra en la BBDD", "Error")
            Else
                'Añade la nueva persona si el DNI no existe'
                Cliente.Insertar()




                If Not excep Then
                    MessageBox.Show("El cliente se ha registrado correctamente", "")
                End If
            End If
            actualizar()

        End If
    End Sub


    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        'Método para eliminar los datos de un cliente'
        Dim DNI As String
        Dim Nombre As String
        Dim Tlf As Long
        Dim Dir As String
        Dim Em As String
        Dim excep As Boolean = False
        If MessageBox.Show("¿Estás seguro de que desea eliminar?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

            'Comprueba si los campos de texto están vacíos'
            If (txt_DNI.Text = "" Or txt_Nombre.Text = "" Or txt_Tlf.Text = "" Or txt_Dir.Text = "" Or txt_Em.Text = "") Or
            Not Comprobar(txt_DNI.Text, txt_Nombre.Text, txt_Tlf.Text, txt_Dir.Text, txt_Em.Text) Then
                MessageBox.Show("No se puede eliminar", "Error")

            Else
                DNI = txt_DNI.Text
                Nombre = txt_Nombre.Text
                Tlf = txt_Tlf.Text
                Dir = txt_Dir.Text
                Em = txt_Em.Text
                Dim Cliente As New Clientes(DNI, Nombre, Tlf, Dir, Em)

                'Comprueba si existe el DNI en la BBDD'
                If (ListDNI.Items.Contains(Cliente.DNI)) Then
                    Try
                        Cliente.Eliminar()
                    Catch ex As OleDbException
                        excep = True
                        MessageBox.Show("El cliente no se ha eliminado correctamente. 
Compruebe los datos introducidos o que no tenga ningun patinete en uso", "Error")
                    End Try
                    If Not excep Then

                        MessageBox.Show("El cliente se ha eliminado correctamente")
                    End If
                Else
                    MessageBox.Show("DNI no se encuentra en la BBDD", "Error")
                End If
                actualizar()

            End If
        End If
    End Sub

    Private Sub btn_Mod_Click(sender As Object, e As EventArgs) Handles btn_Mod.Click
        'Método para actualizar datos de un cliente'
        Dim DNI As String = ""
        Dim Nombre As String = ""
        Dim Tlf As Integer
        Dim Dir As String = ""
        Dim Em As String = ""
        Dim excep As Boolean = False

        'Comprueba si los campos de texto están vacíos'
        If (txt_DNI.Text = "" Or txt_Nombre.Text = "" Or txt_Tlf.Text = "" Or txt_Dir.Text = "" Or txt_Em.Text = "") Or
            Not Comprobar(txt_DNI.Text, txt_Nombre.Text, txt_Tlf.Text, txt_Dir.Text, txt_Em.Text) Then
            MessageBox.Show("No se puede modificar", "Error")

        Else

            DNI = txt_DNI.Text
            Nombre = txt_Nombre.Text
            Tlf = txt_Tlf.Text
            Dir = txt_Dir.Text
            Em = txt_Em.Text
            Dim _Cliente As New Clientes(DNI, Nombre, Tlf, Dir, Em)
            If (ListDNI.Items.Contains(_Cliente.DNI)) Then
                'Comprueba si el DNI que ha escrito existe en la BBDD'
                Try
                    _Cliente.Modificar()
                    actualizar()
                Catch ex As OleDbException
                    excep = True
                    MessageBox.Show("El cliente no se ha modificado correctamente. 
Compruebe los datos introducidos", "Error")
                End Try
                If Not excep Then

                    MessageBox.Show("El cliente se ha modificado correctamente")
                End If

            Else
                MessageBox.Show("Ese cliente no está en nuestra base de datos")
            End If
        End If
    End Sub

    Private Sub ListDNI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListDNI.SelectedIndexChanged
        'Método que controla la selección de un valor en el ListDNI
        Dim DNI As String = ListDNI.SelectedItem
        Dim _Cliente As Clientes = New Clientes
        _Cliente.LeerPersona(DNI)
        txt_DNI.Text = _Cliente.DNI
        txt_Nombre.Text = _Cliente.Nombre
        txt_Tlf.Text = _Cliente.Telefono
        txt_Dir.Text = _Cliente.Direccion
        txt_Em.Text = _Cliente.Email
    End Sub

    Private Sub ClientesUI_Activated(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Método el cual se ejecuta nada más abrirse esta ventana
        Dim _Cliente = New Clientes

        _Cliente.LeerTodos() 'Lee todas las reservas en la base de datos'
        For Each _Cliente In _Cliente.GetClienteDAO
            ListDNI.Items.Add(_Cliente.DNI) 'Muestra en el listbox los DNI de las personas'
        Next
        _Cliente.VaciarListaClientesDAO()
    End Sub

    Function Comprobar(DNI As String, Nombre As String, Tlf As String, Dir As String, Em As String) As Boolean
        'Método que sirve para comprobar que los tipos de datos introducidos son los correctos
        Comprobar = True
        If TypeOf DNI IsNot String Then
            MessageBox.Show("DNI no es una cadena de caracteres", "Error")
            Comprobar = False
        End If
        If TypeOf Nombre IsNot String Then
            MessageBox.Show("Nombre no es una cadena de caracteres", "Error")
            Comprobar = False
        End If
        If Not IsNumeric(Tlf) Then
            MessageBox.Show("Peso no es número", "Error")
            Comprobar = False
        End If
        If TypeOf Dir IsNot String Then
            MessageBox.Show("La dirección no es una cadena de caracteres", "Error")
            Comprobar = False
        End If
        If TypeOf Em IsNot String Then
            MessageBox.Show("El email no es una cadena de caracteres", "Error")
            Comprobar = False
        End If
    End Function

    Sub actualizar()
        'Método que limpia la listaDNI, lee los datos de la bbdd y los vuelve a meter en la listaDNI
        Dim _Cliente = New Clientes

        ListDNI.Items.Clear()
        _Cliente.LeerTodos() 'Lee todas las reservas en la base de datos'
        For Each _Cliente In _Cliente.GetClienteDAO
            If Not (ListDNI.Items.Contains(_Cliente.DNI)) Then
                ListDNI.Items.Add(_Cliente.DNI) 'Muestra en el listbox los DNI de las personas'
            End If
        Next
        txt_DNI.Text = ""
        txt_Nombre.Text = ""
        txt_Tlf.Text = ""
        txt_Dir.Text = ""
        txt_Em.Text = ""
        _Cliente.VaciarListaClientesDAO()
    End Sub

End Class