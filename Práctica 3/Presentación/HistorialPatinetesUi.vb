Public Class HistorialPatinetesUi
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
            ListPatinetes.Items.Clear()
            Dim _Patinetes As Patinetes = New Patinetes

            _Patinetes.leerPatineteD2(FechaIn, FechaFin)

            For Each _Patinetes In _Patinetes.GetpatinetesDAO

                ListPatinetes.Items.Add(_Patinetes.IdP) 'Muestra en el listbox los ID de los patinetes'
            Next
            _Patinetes.VaciarListaPatineteDAO()
        End If
    End Sub

    Private Sub ListPatinetes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPatinetes.SelectedIndexChanged
        'Método que controla la selección de un valor en la ListPatinetes
        Dim FechaIn As Date
        Dim FechaFin As Date
        FechaIn = DateTimePicker1.Value
        FechaFin = DateTimePicker2.Value
        txt_nombre.Text = ""

        Dim IdP As Integer = ListPatinetes.SelectedItem
        ListDNI.Items.Clear()
        Dim _Patinetes As Patinetes = New Patinetes
        _Patinetes.leerPatinete(IdP)

        txt_desc.Text = _Patinetes.IdP
        txt_tipo.Text = _Patinetes.IdTipo


        Dim _Clientes As Clientes = New Clientes
        _Clientes.leerPat(IdP, FechaIn, FechaFin)

        For Each _Clientes In _Clientes.GetClienteDAO

            ListDNI.Items.Add(_Clientes.DNI)
        Next
        _Clientes.VaciarListaClientesDAO()
    End Sub

    Private Sub ListDNI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListDNI.SelectedIndexChanged
        'Método que controla la selección de un valor en la ListDNI
        Dim dni As String = ListDNI.SelectedItem
        Dim _Cliente As Clientes = New Clientes
        _Cliente.LeerPersona(dni)
        txt_nombre.Text = _Cliente.Nombre

    End Sub


End Class