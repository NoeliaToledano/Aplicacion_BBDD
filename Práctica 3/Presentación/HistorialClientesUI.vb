Public Class HistorialClientesUI
    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click
        'Método que controla el click en Aceptar

        Dim FechaIn As Date
        Dim FechaFin As Date
        Dim horas As Integer

        FechaIn = DateTimePicker1.Value
        FechaFin = DateTimePicker2.Value
        horas = DateDiff(DateInterval.Hour, FechaIn, FechaFin)


        If horas <= 0 Then
            MessageBox.Show("Has introducido una fecha fin menor o igual a la fecha inicio", "Error")

        Else
            ListDNI.Items.Clear()
            Dim _Clientes As Clientes = New Clientes

            _Clientes.leerH(FechaIn, FechaFin)

            For Each _Clientes In _Clientes.GetClienteDAO

                ListDNI.Items.Add(_Clientes.DNI) 'Muestra en el listbox los DNI de los clientes'
            Next
            _Clientes.VaciarListaClientesDAO()
        End If
    End Sub

    Private Sub ListDNI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListDNI.SelectedIndexChanged
        'Método que controla la selección de un valor en la ListDNI

        Dim FechaIn As Date
        Dim FechaFin As Date

        FechaIn = DateTimePicker1.Value
        FechaFin = DateTimePicker2.Value
        ListPatinetes.Items.Clear()
        txt_desc.Text = ""
        txt_IdT.Text = ""
        Dim dni As String = ListDNI.SelectedItem

        Dim _Cliente As Clientes = New Clientes
        _Cliente.LeerPersona(dni)

        txt_nombre.Text = _Cliente.Nombre
        txt_tlf.Text = _Cliente.Telefono
        txt_dir.Text = _Cliente.Direccion
        txt_em.Text = _Cliente.Email

        Dim _Patinete As Patinetes = New Patinetes
        'Se extra una colección de patinetes que ha reservado ese dni es un intervalo de tiempo
        _Patinete.leerPatineteD(dni, FechaIn, FechaFin)

        For Each _Patinete In _Patinete.GetpatinetesDAO
            ListPatinetes.Items.Add(_Patinete.IdP)
        Next
        _Patinete.VaciarListaPatineteDAO()
    End Sub

    Private Sub ListPatinetes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPatinetes.SelectedIndexChanged
        'Método que controla la selección de un valor en la ListPatinetes
        Dim IdP As Long = ListPatinetes.SelectedItem
        Dim _Patinete = New Patinetes
        _Patinete.leerPatinete(IdP)
        txt_Desc.Text = _Patinete.Descripcion
        txt_IdT.Text = _Patinete.IdTipo

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class