Imports System.Data.OleDb

Public Class TipoPatineteUI
    Private Sub btn_Añadir_Click(sender As Object, e As EventArgs) Handles btn_Añadir.Click
        'Método para insertar en la bbdd los datos de un tipo de patinete
        Dim Marca As String
        Dim PesoPermitido As Long
        Dim Velocidad As Long
        Dim PrecioxHora As Decimal

        'Comprueba si los campos de texto están vacíos'
        If (txt_Marca.Text = "" Or txt_Peso.Text = "" Or txt_vel.Text = "" Or Txt_Pph.Text = "") Or
            Not Comprobar(txt_Marca.Text, txt_Peso.Text, txt_vel.Text, Txt_Pph.Text) Then
            MessageBox.Show("No se puede añadir", "Error")

        Else
            Marca = txt_Marca.Text
            PesoPermitido = txt_Peso.Text
            Velocidad = txt_vel.Text
            PrecioxHora = Txt_Pph.Text
            Dim excep As Boolean = False
            Dim _TipoPatinete As New Tipo_patinete(Marca, PesoPermitido, Velocidad, PrecioxHora)

            Try
                _TipoPatinete.Insertar()
            Catch ex As OleDbException
                excep = True
                MessageBox.Show("El cliente no se ha creado correctamente. 
Compruebe los datos introducidos", "Error")
            End Try
            If Not excep Then
                MessageBox.Show("El tipo de patinete se ha creado correctamente", "")
            End If
            actualizar()

        End If
    End Sub



    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        'Método para eliminar tipos de patinetes
        Dim IdTipo As Long
        Dim Marca As String
        Dim PesoPermitido As Long
        Dim Velocidad As Long
        Dim PrecioxHora As Decimal

        If MessageBox.Show("¿Estás seguro de que desea eliminar?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

            'Comprueba si los campos de texto están vacíos'
            If (ListTipos.SelectedItem Is Nothing Or txt_Marca.Text = "" Or txt_Peso.Text = "" Or txt_vel.Text = "" Or Txt_Pph.Text = "") Or
            Not Comprobar(txt_Marca.Text, txt_Peso.Text, txt_vel.Text, Txt_Pph.Text) Then
                MessageBox.Show("No se puede eliminar", "Error")

            Else
                IdTipo = ListTipos.SelectedItem
                Marca = txt_Marca.Text
                PesoPermitido = txt_Peso.Text
                Velocidad = txt_vel.Text
                PrecioxHora = Txt_Pph.Text
                Dim excep As Boolean = False

                Dim _TipoPatinete As New Tipo_patinete(Marca, PesoPermitido, Velocidad, PrecioxHora)
                _TipoPatinete.Tipo = ListTipos.SelectedItem

                Try
                    _TipoPatinete.Eliminar()
                Catch ex As OleDbException
                    excep = True
                    MessageBox.Show("El tipo de patinete no se ha eliminado correctamente. 
Compruebe los datos introducidos y que el tipo de patinete no esté actualmente en uso", "Error")
                End Try
                If Not excep Then
                    MessageBox.Show("El tipo de patinete se ha eliminado correctamente", "")
                End If
                actualizar()


            End If
        End If
    End Sub

    Private Sub btn_Mod_Click(sender As Object, e As EventArgs) Handles btn_Mod.Click
        'Método para modificar los datos de los tipos de patinetes
        Dim IdTipo As Long
        Dim Marca As String
        Dim PesoPermitido As Long
        Dim Velocidad As Long
        Dim PrecioxHora As Decimal

        'Comprueba si los campos de texto están vacíos'
        If (ListTipos.SelectedItem Is Nothing Or txt_Marca.Text = "" Or txt_Peso.Text = "" Or txt_vel.Text = "" Or Txt_Pph.Text = "") Or
            Not Comprobar(txt_Marca.Text, txt_Peso.Text, txt_vel.Text, Txt_Pph.Text) Then
            MessageBox.Show("No se puede modificar", "Error")

        Else
            IdTipo = ListTipos.SelectedItem
            Marca = txt_Marca.Text
            PesoPermitido = txt_Peso.Text
            Velocidad = txt_vel.Text
            PrecioxHora = Txt_Pph.Text
            Dim excep As Boolean = False

            Dim _TipoPatinete As New Tipo_patinete(Marca, PesoPermitido, Velocidad, PrecioxHora)
            _TipoPatinete.Tipo = IdTipo

            Try
                _TipoPatinete.Modificar()
            Catch ex As OleDbException
                excep = True
                MessageBox.Show("El cliente no se ha modificado correctamente. 
Compruebe los datos introducidos", "Error")
            End Try
            If Not excep Then
                MessageBox.Show("El tipo de patinete se ha modificado correctamente", "")
            End If
            actualizar()

        End If
    End Sub

    Function Comprobar(Marca As String, Peso As String, Vel As String, Pph As String) As Boolean

        Comprobar = True
        If TypeOf Marca IsNot String Then
            MessageBox.Show("Marca no es una cadena de caracteres", "Error")
            Comprobar = False
        End If
        If Not IsNumeric(Peso) Then
            MessageBox.Show("Peso no es número", "Error")
            Comprobar = False
        End If
        If Not IsNumeric(Vel) Then
            MessageBox.Show("Velocidad no es un número", "Error")
            Comprobar = False
        End If
        If Not IsNumeric(Pph) Then
            MessageBox.Show("El precio no es un número", "Error")
            Comprobar = False
        End If


    End Function

    Private Sub ListTipos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListTipos.SelectedIndexChanged

        Dim idtipo As Long = ListTipos.SelectedItem
        Dim _Tipo As Tipo_patinete = New Tipo_patinete
        _Tipo.leerreserva(idtipo)
        txt_Marca.Text = _Tipo.Marca
        txt_Peso.Text = _Tipo.PesoPermitido
        txt_vel.Text = _Tipo.Velocidad
        Txt_Pph.Text = _Tipo.PrecioxHora

    End Sub

    Private Sub ClientesUI_Activated(sender As Object, e As EventArgs) Handles MyBase.Shown

        Dim _Tipo = New Tipo_patinete
        _Tipo.VaciarListaTipo_patineteDAO()
        _Tipo.leertodos() 'Lee todas las reservas en la base de datos'
        For Each _Tipo In _Tipo.GetTipo_patineteDAO
            ListTipos.Items.Add(_Tipo.Tipo) 'Muestra en el listbox los DNI de las personas'
        Next
        _Tipo.VaciarListaTipo_patineteDAO()
    End Sub

    Sub actualizar()
        ListTipos.Items.Clear()
        Dim _Tipo = New Tipo_patinete
        _Tipo.VaciarListaTipo_patineteDAO()
        _Tipo.leertodos() 'Lee todas las reservas en la base de datos'

        For Each _Tipo In _Tipo.GetTipo_patineteDAO
            If Not (ListTipos.Items.Contains(_Tipo.Tipo)) Then
                ListTipos.Items.Add(_Tipo.Tipo) 'Muestra en el listbox los ID de los tipos de patinete'
            End If
        Next
        txt_Marca.Text = ""
        txt_Peso.Text = ""
        txt_vel.Text = ""
        Txt_Pph.Text = ""
        _Tipo.VaciarListaTipo_patineteDAO()

    End Sub
End Class