Imports System.Data.OleDb

Public Class PatineteUi
    Private Sub btn_añadir_click(sender As Object, e As EventArgs) Handles btn_Añadir.Click
        'Método para insertar en la bbdd los datos de un patinete
        Dim descripcion As String
        Dim idtipo As Long
        Dim excep As Boolean = False
        'comprueba si los campos de texto están vacíos'
        If (txt_Desc.Text = "" Or txt_IdT.Text = "") Or
            Not Comprobar(txt_Desc.Text, txt_IdT.Text) Then
            MessageBox.Show("No se puede añadir", "error")

        Else
            descripcion = txt_Desc.Text
            idtipo = txt_IdT.Text

            Dim patinete As New Patinetes(descripcion, idtipo)
            Try
                patinete.Insertar()

            Catch ex As OleDbException
                excep = True
                MessageBox.Show("El patinete no se ha creado correctamente. 
Compruebe el id tipo en la pestaña de Tipos de patinetes", "Error")
            End Try

            actualizar()
            If Not excep Then

                MessageBox.Show("El patinete se ha creado correctamente", "Error")
            End If
        End If
    End Sub


    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        'Método para eliminar los datos de un patinete'
        Dim descripcion As String
        Dim idtipo As Long
        Dim excep As Boolean = False

        If MessageBox.Show("¿Estás seguro de que desea eliminar?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

            'comprueba si los campos de texto están vacíos'
            If (ListId.SelectedItem Is Nothing Or txt_Desc.Text = "" Or txt_IdT.Text = "") Or
            Not Comprobar(txt_Desc.Text, txt_IdT.Text) Then
                MessageBox.Show("No se puede eliminar", "Error")

            Else
                descripcion = txt_Desc.Text
                idtipo = txt_IdT.Text

                Dim patinete As New Patinetes(descripcion, idtipo)
                patinete.IdP = ListId.SelectedItem

                Try
                    patinete.Eliminar()

                Catch ex As OleDbException
                    excep = True
                    MessageBox.Show("El patinete no se ha eliminado correctamente. 
Compruebe que el patinete no esté en uso actualmente", "Error")
                End Try
                If Not excep Then
                    MessageBox.Show("El patinete se ha eliminado correctamente", "Error")
                End If
                actualizar()

            End If
        End If
    End Sub

    Private Sub btn_Mod_Click(sender As Object, e As EventArgs) Handles btn_Mod.Click
        'Método para actualizar datos de unpatinete'
        Dim descripcion As String
        Dim idtipo As Long
        Dim excep As Boolean = False

        'comprueba si los campos de texto están vacíos'
        If (ListId.SelectedItem Is Nothing Or txt_Desc.Text = "" Or txt_IdT.Text = "") Or
            Not Comprobar(txt_Desc.Text, txt_IdT.Text) Then
            MessageBox.Show("No se puede modificar", "Error")

        Else
            descripcion = txt_Desc.Text
            idtipo = txt_IdT.Text

            Dim patinete As New Patinetes(descripcion, idtipo)
            patinete.IdP = ListId.SelectedItem

            Try
                patinete.Modificar()

            Catch ex As OleDbException
                excep = True
                MessageBox.Show("El patinete no se ha modificado correctamente. 
Compruebe el id tipo en la pestaña de Tipos de patinetes", "Error")
            End Try

            actualizar()
            If Not excep Then

                MessageBox.Show("El patinete se ha modificado correctamente", "Error")
            End If
        End If
    End Sub

    Private Sub PatineteUi_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Método el cual se ejecuta nada más abrirse esta ventana
        Dim _Patinete = New Patinetes


        _Patinete.Leertodos() 'Lee todas las reservas en la base de datos'
        For Each _Patinete In _Patinete.GetpatinetesDAO()
            ListId.Items.Add(_Patinete.IdP) 'Muestra en el listbox los DNI de las personas'
        Next
        _Patinete.VaciarListaPatineteDAO()
    End Sub

    Private Sub ListTipos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListId.SelectedIndexChanged
        'Método que controla la selección de un valor en el ListId
        Dim IdP As Long = ListId.SelectedItem
        Dim _Patinete = New Patinetes
        _Patinete.leerPatinete(IdP)
        txt_Desc.Text = _Patinete.Descripcion
        txt_IdT.Text = _Patinete.IdTipo

    End Sub

    Sub actualizar()
        'Método que limpia la ListId, lee los datos de la bbdd y los vuelve a meter en la ListId
        ListId.Items.Clear()
        Dim _Patinete = New Patinetes
        _Patinete.Leertodos() 'Lee todas las reservas en la base de datos'

        For Each _Patinete In _Patinete.GetpatinetesDAO()
            If Not (ListId.Items.Contains(_Patinete.IdP)) Then
                ListId.Items.Add(_Patinete.IdP) 'Muestra en el listbox los DNI de las personas'
            End If
        Next
        txt_Desc.Text = ""
        txt_IdT.Text = ""
        _Patinete.VaciarListaPatineteDAO()
    End Sub

    Function Comprobar(Descripcion As String, IdTipo As String) As Boolean
        'Método que sirve para comprobar que los tipos de datos introducidos son los correctos
        Comprobar = True
        If TypeOf Descripcion IsNot String Then
            MessageBox.Show("Descripcion no es una cadena de caracteres", "Error")
            Comprobar = False
        End If
        If Not IsNumeric(IdTipo) Then
            MessageBox.Show("IdTipo no es número", "Error")
            Comprobar = False
        End If

    End Function

End Class