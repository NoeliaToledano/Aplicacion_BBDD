Public Class Form1


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_Ruta.Click


        OpenFileDialog1.Filter = "ACCDB files (*.accdb)|*.accdb"
        'Muestra un pop up donde tienes que poner la ruta de tu base de datos'
        OpenFileDialog1.FileName = "Patinator"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then

            Dim _Clientes As Clientes = New Clientes
            txtRuta.Text = OpenFileDialog1.FileName
            _Clientes.Get_Ruta(txtRuta.Text)
            btn_conectar.Enabled = True
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_conectar.Click
        txtRuta.Enabled = False
        btn_Ruta.Enabled = False
        btn_conectar.Enabled = False
        ListReservas.Enabled = True
        ListIdPat.Enabled = True
        btn_Añadir.Enabled = True
        btn_Clientes.Enabled = True
        btn_Eliminar.Enabled = True
        btn_hisCli.Enabled = True
        btn_hisPat.Enabled = True
        btn_Mod.Enabled = True
        btn_Patinetes.Enabled = True
        btn_ranking.Enabled = True
        btn_TipoP.Enabled = True
        DateTimePicker1.Enabled = True
        DateTimePicker2.Enabled = True
        txt_IdC.Enabled = True


        Dim _Reserva As Reservas = New Reservas

        _Reserva.LeerTodos() 'Lee todas las reservas en la base de datos'
        For Each _Reserva In _Reserva.GetReservasDAO
            ListReservas.Items.Add(_Reserva.ID_Reserva) 'Muestra en el listbox los DNI de las personas'
        Next

        txt_FechaReserva.Enabled = False

        Dim _Patinete As Patinetes = New Patinetes
        _Patinete.Leertodos() 'Lee todas los patinetes en la base de datos'
        For Each _Patinete In _Patinete.GetpatinetesDAO
            txt_descripcion.Text = _Patinete.Descripcion
            ListIdPat.Items.Add(_Patinete.IdP) 'Muestra en el listbox los DNI de las personas'
        Next



    End Sub



    Private Sub btn_Clientes_Click(sender As Object, e As EventArgs) Handles btn_Clientes.Click
        ClientesUI.Show()

    End Sub





    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListReservas.SelectedIndexChanged

        'Rellena los campos de texto DNI y Nombre con los datos de la persona seleccionada de la lista'
        Dim IdReserva As Integer = ListReservas.SelectedItem
        Dim _Reserva As Reservas = New Reservas
        _Reserva.LeerReserva(IdReserva)
        DateTimePicker1.Value = _Reserva.Fecha_inicio
        DateTimePicker2.Value = _Reserva.Fecha_fin
        txt_IdC.Text = _Reserva.IdCliente
        txt_FechaReserva.Text = _Reserva.Fecha_Reserva
        txt_PrecioRes.Text = _Reserva.Precio_Reserva
        'txt_PrecioRes.Text = DateTimePicker1.Value.ToString



        Dim _Patinete As Patinetes = New Patinetes
        _Patinete.Leertodos() 'Lee todas los patinetes en la base de datos'
        For Each _Patinete In _Patinete.GetpatinetesDAO

            ListIdPat.SetSelected(_Patinete.IdP - 1, False)

        Next



        Dim _Uso As Uso_patinetes = New Uso_patinetes
        _Uso.leerReserva() 'Lee todas las reservas en la base de datos'
        For Each _Uso In _Uso.GetUso_patinetesDAO
            If _Uso.IdReserva = IdReserva Then
                ListIdPat.SetSelected(_Uso.IdPatinete - 1, True)
            End If

        Next


    End Sub

    Private Sub btn_añadir_click(sender As Object, e As EventArgs) Handles btn_Añadir.Click
        Dim FechaIn As Date
        Dim FechaFin As Date
        Dim IdC As String
        Dim FechaRes As String
        Dim PrecioRes As Long = 0
        Dim horas As Long

        IdC = txt_IdC.Text
        Dim _Cliente As Clientes = New Clientes()
        Dim aux2 As Boolean = False
        _Cliente.LeerTodos() 'Lee todas las reservas en la base de datos'
        For Each _Cliente In _Cliente.GetClienteDAO
            If IdC = _Cliente.DNI Then
                aux2 = True
                FechaIn = DateTimePicker1.Value
                FechaFin = DateTimePicker2.Value


                horas = DateDiff(DateInterval.Hour, FechaIn, FechaFin)
                If horas <= 0 Then
                    MessageBox.Show("Introduce bien las fechas", "error")
                Else

                    FechaRes = txt_FechaReserva.Text

                    For Each item In ListIdPat.SelectedItems

                        Dim Patinete As Patinetes = New Patinetes
                        Patinete.Leertodos()
                        For Each Patinete In Patinete.GetpatinetesDAO
                            If item = Patinete.IdP Then
                                Dim tipo As Integer = Patinete.IdTipo
                                Dim TipoPatinete As Tipo_patinete = New Tipo_patinete
                                TipoPatinete.leertodos()
                                For Each TipoPatinete In TipoPatinete.GetTipo_patineteDAO
                                    If tipo = TipoPatinete.Tipo Then
                                        PrecioRes += horas * TipoPatinete.PrecioxHora
                                    End If
                                Next
                            End If


                        Next
                    Next


                    Dim _Reserva = New Reservas(FechaIn, FechaFin, IdC, Now, PrecioRes)


                    Dim aux As Integer = 0

                    For Each item In ListIdPat.SelectedItems
                        aux += 1

                        If (_Reserva.Comprobar(FechaIn, FechaFin, item) = False) Then
                            If aux = 1 Then
                                _Reserva.Insertar()
                                actualizar()
                                _Reserva.getId()


                            End If

                            Dim r = _Reserva.ID_Reserva

                            Dim _Uso = New Uso_patinetes(r, item)
                            _Uso.Insertar()
                            MsgBox("La reserva se ha añadido correctamente")


                        Else
                            MessageBox.Show("No se puede añadir", "error")

                        End If
                    Next
                End If

            End If

        Next
        If Not aux2 Then
            MessageBox.Show("Cliente no encontrado", "ERROR")
        End If


    End Sub

    Public Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click

        Dim FechaIn As Date
        Dim FechaFin As Date
        Dim IdC As String ' int?
        Dim FechaRes As String
        Dim PrecioRes As Long


        FechaIn = DateTimePicker1.Value
        FechaFin = DateTimePicker2.Value
        IdC = txt_IdC.Text
        FechaRes = txt_FechaReserva.Text
        PrecioRes = txt_PrecioRes.Text

        Dim aux2 As Boolean = False
        IdC = txt_IdC.Text
        Dim _Cliente As Clientes = New Clientes()

        _Cliente.LeerTodos() 'Lee todas las reservas en la base de datos'
        For Each _Cliente In _Cliente.GetClienteDAO
            If IdC = _Cliente.DNI Then
                aux2 = True
                If MessageBox.Show("¿Estás seguro de que desea eliminar?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then




                    'comprueba si los campos de texto están vacíos'
                    If (txt_FechaReserva.Text = "" Or txt_IdC.Text = "") Then


                        MessageBox.Show("no se puede eliminar", "error")



                    Else

                        Dim _Reserva As Reservas = New Reservas(FechaIn, FechaFin, IdC, FechaRes, PrecioRes)

                        'comprueba si existe el dni en la bbdd'
                        'If (ListReservas.Items.Contains(_Reserva)) Then
                        '    MsgBox("dni ya se encuentra en la bbdd")
                        'Else
                        '    'añade la nueva persona si el dni no existe'


                        If (ListReservas.Items.Contains(ListReservas.SelectedItem)) Then

                            _Reserva.ID_Reserva = ListReservas.SelectedItem
                            ListReservas.Items.Remove(_Reserva)
                            ListReservas.Items.Clear()

                            _Reserva.EliminarUso()
                            _Reserva.Eliminar()
                            actualizar()
                            MsgBox("La reserva se ha eliminado correctamente")
                        End If

                        Dim _Patinete As Patinetes = New Patinetes
                        _Patinete.Leertodos() 'Lee todas los patinetes en la base de datos'
                        For Each _Patinete In _Patinete.GetpatinetesDAO

                            ListIdPat.SetSelected(_Patinete.IdP - 1, False)

                        Next

                    End If

                End If


            End If
        Next

        If Not aux2 Then
            MessageBox.Show("Cliente no encontrado", "ERROR")
        End If


    End Sub

    Private Sub btn_Mod_Click(sender As Object, e As EventArgs) Handles btn_Mod.Click
        Dim FechaIn As String 'date?
        Dim FechaFin As String
        Dim IdC As String ' int?
        Dim FechaRes As String
        Dim PrecioRes As Long

        IdC = txt_IdC.Text
        Dim _Cliente As Clientes = New Clientes()
        Dim aux2 As Boolean = False
        _Cliente.LeerTodos() 'Lee todas las reservas en la base de datos'
        For Each _Cliente In _Cliente.GetClienteDAO
            If IdC = _Cliente.DNI Then

                aux2 = True
                FechaIn = DateTimePicker1.Value
                FechaFin = DateTimePicker2.Value
                IdC = txt_IdC.Text
                FechaRes = txt_FechaReserva.Text
                PrecioRes = txt_PrecioRes.Text
                Dim _Reserva = New Reservas(FechaIn, FechaFin, IdC, FechaRes, PrecioRes)



                'comprueba si existe el dni en la bbdd'
                'If (ListReservas.Items.Contains(_Reserva)) Then
                '    MsgBox("dni ya se encuentra en la bbdd")
                'Else
                '    'añade la nueva persona si el dni no existe'

                If (ListReservas.Items.Contains(ListReservas.SelectedItem)) Then
                    _Reserva.ID_Reserva = ListReservas.SelectedItem
                    _Reserva.Modificar()
                    MsgBox("La reserva se ha modificado correctamente")
                End If

            End If

        Next

        If Not aux2 Then
            MessageBox.Show("Cliente no encontrado", "ERROR")
        End If

    End Sub

    Private Sub btn_TipoP_Click(sender As Object, e As EventArgs) Handles btn_TipoP.Click
        TipoPatineteUI.Show()

    End Sub

    Private Sub btn_Patinetes_Click(sender As Object, e As EventArgs) Handles btn_Patinetes.Click
        PatineteUi.Show()

    End Sub

    Sub actualizar()
        Dim _Reserva = New Reservas

        _Reserva.GetReservasDAO()
        _Reserva.LeerTodos() 'Lee todas las reservas en la base de datos'
        For Each _Reserva In _Reserva.GetReservasDAO
            If Not (ListReservas.Items.Contains(_Reserva.ID_Reserva)) Then
                ListReservas.Items.Add(_Reserva.ID_Reserva) 'Muestra en el listbox los DNI de las personas'
            End If
        Next


    End Sub

    Private Sub btn_hisPat_Click(sender As Object, e As EventArgs) Handles btn_hisPat.Click
        HistorialPatinetesUi.Show()

    End Sub



    Private Sub ListIdPat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListIdPat.SelectedIndexChanged

        Dim IdPatinete As Long = ListIdPat.SelectedItem
        Dim _Patinete As Patinetes = New Patinetes
        _Patinete.leerPatinete(IdPatinete)
        txt_descripcion.Text = _Patinete.Descripcion
        txt_tipo.Text = _Patinete.IdTipo
        'txt_PrecioRes.Text = DateTimePicker1.Value.ToString
    End Sub




    Private Sub btn_hisCli_Click(sender As Object, e As EventArgs) Handles btn_hisCli.Click
        HistorialClientesUI.Show()
    End Sub

    Private Sub btn_ranking_Click(sender As Object, e As EventArgs) Handles btn_ranking.Click
        RankingUI.Show()
    End Sub



End Class
