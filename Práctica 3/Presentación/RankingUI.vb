Public Class RankingUI
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
            ListTiposPatinetes.Items.Clear()
            Dim _Tipo As Tipo_patinete = New Tipo_patinete

            txt_marca.Text = ""
            txt_peso.Text = ""
            txt_precio.Text = ""
            txt_vel.Text = ""

            _Tipo.VaciarListaTipo_patineteDAO()
            _Tipo.leerRanking(FechaIn, FechaFin)

            For Each _Tipo In _Tipo.GetTipo_patineteDAO

                ListTiposPatinetes.Items.Add(_Tipo.Tipo) 'Muestra en el listbox los IdTipo de cada Tipo de patinete'
            Next
        End If
    End Sub

    Private Sub ListTiposPatinetes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListTiposPatinetes.SelectedIndexChanged
        'Método que controla la selección de un valor en la ListTiposPatinetes
        Dim FechaIn As Date
        Dim FechaFin As Date

        FechaIn = DateTimePicker1.Value
        FechaFin = DateTimePicker2.Value

        Dim col As Collection
        Dim _Tipo As Tipo_patinete = New Tipo_patinete
        _Tipo.leerRanking(FechaIn, FechaFin)
        col = _Tipo.GetTipo_patineteDAO


        Dim num As Integer
        num = 1
        Dim _Tipo2 As Tipo_patinete = New Tipo_patinete
        _Tipo2 = col.Item(ListTiposPatinetes.SelectedItem)

        'Bucle para coger el item adecuado de la colección
        For Each _Tipo In col
            _Tipo2 = col.Item(num)
            If ListTiposPatinetes.SelectedItem = _Tipo2.Tipo Then
                txt_marca.Text = _Tipo2.Marca
                txt_peso.Text = _Tipo2.PesoPermitido
                txt_precio.Text = _Tipo2.PrecioxHora
                txt_vel.Text = _Tipo2.Velocidad
                txt_Gan.Text = _Tipo2.GananciasAcumuladas
            End If
            num = num + 1
        Next

    End Sub
End Class