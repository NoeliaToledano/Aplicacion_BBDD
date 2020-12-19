<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_TipoP = New System.Windows.Forms.Button()
        Me.btn_Clientes = New System.Windows.Forms.Button()
        Me.btn_Patinetes = New System.Windows.Forms.Button()
        Me.btn_Ruta = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_conectar = New System.Windows.Forms.Button()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_PrecioRes = New System.Windows.Forms.TextBox()
        Me.lbl_Pph = New System.Windows.Forms.Label()
        Me.txt_FechaReserva = New System.Windows.Forms.TextBox()
        Me.lbl_Vel = New System.Windows.Forms.Label()
        Me.txt_IdC = New System.Windows.Forms.TextBox()
        Me.btn_Mod = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.lbl_Peso = New System.Windows.Forms.Label()
        Me.lbl_Marca = New System.Windows.Forms.Label()
        Me.btn_Añadir = New System.Windows.Forms.Button()
        Me.ListReservas = New System.Windows.Forms.ListBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ListIdPat = New System.Windows.Forms.ListBox()
        Me.btn_ranking = New System.Windows.Forms.Button()
        Me.btn_hisCli = New System.Windows.Forms.Button()
        Me.btn_hisPat = New System.Windows.Forms.Button()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_tipo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_TipoP
        '
        Me.btn_TipoP.Enabled = False
        Me.btn_TipoP.Location = New System.Drawing.Point(224, 213)
        Me.btn_TipoP.Name = "btn_TipoP"
        Me.btn_TipoP.Size = New System.Drawing.Size(70, 83)
        Me.btn_TipoP.TabIndex = 1
        Me.btn_TipoP.Text = "Tipos de Patinetes"
        Me.btn_TipoP.UseVisualStyleBackColor = True
        '
        'btn_Clientes
        '
        Me.btn_Clientes.Enabled = False
        Me.btn_Clientes.Location = New System.Drawing.Point(310, 213)
        Me.btn_Clientes.Name = "btn_Clientes"
        Me.btn_Clientes.Size = New System.Drawing.Size(79, 83)
        Me.btn_Clientes.TabIndex = 2
        Me.btn_Clientes.Text = "Clientes"
        Me.btn_Clientes.UseVisualStyleBackColor = True
        '
        'btn_Patinetes
        '
        Me.btn_Patinetes.Enabled = False
        Me.btn_Patinetes.Location = New System.Drawing.Point(405, 213)
        Me.btn_Patinetes.Name = "btn_Patinetes"
        Me.btn_Patinetes.Size = New System.Drawing.Size(75, 83)
        Me.btn_Patinetes.TabIndex = 3
        Me.btn_Patinetes.Text = "Patinetes"
        Me.btn_Patinetes.UseVisualStyleBackColor = True
        '
        'btn_Ruta
        '
        Me.btn_Ruta.Location = New System.Drawing.Point(38, 305)
        Me.btn_Ruta.Name = "btn_Ruta"
        Me.btn_Ruta.Size = New System.Drawing.Size(113, 44)
        Me.btn_Ruta.TabIndex = 5
        Me.btn_Ruta.Text = "Ruta de datos"
        Me.btn_Ruta.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_conectar
        '
        Me.btn_conectar.Enabled = False
        Me.btn_conectar.Location = New System.Drawing.Point(38, 395)
        Me.btn_conectar.Name = "btn_conectar"
        Me.btn_conectar.Size = New System.Drawing.Size(113, 25)
        Me.btn_conectar.TabIndex = 6
        Me.btn_conectar.Text = "Conectar"
        Me.btn_conectar.UseVisualStyleBackColor = True
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(171, 318)
        Me.txtRuta.Multiline = True
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(487, 78)
        Me.txtRuta.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Precio Reserva"
        '
        'txt_PrecioRes
        '
        Me.txt_PrecioRes.Enabled = False
        Me.txt_PrecioRes.Location = New System.Drawing.Point(310, 163)
        Me.txt_PrecioRes.Name = "txt_PrecioRes"
        Me.txt_PrecioRes.Size = New System.Drawing.Size(100, 20)
        Me.txt_PrecioRes.TabIndex = 40
        '
        'lbl_Pph
        '
        Me.lbl_Pph.AutoSize = True
        Me.lbl_Pph.Location = New System.Drawing.Point(224, 135)
        Me.lbl_Pph.Name = "lbl_Pph"
        Me.lbl_Pph.Size = New System.Drawing.Size(80, 13)
        Me.lbl_Pph.TabIndex = 39
        Me.lbl_Pph.Text = "Fecha Reserva"
        '
        'txt_FechaReserva
        '
        Me.txt_FechaReserva.Enabled = False
        Me.txt_FechaReserva.Location = New System.Drawing.Point(310, 132)
        Me.txt_FechaReserva.Name = "txt_FechaReserva"
        Me.txt_FechaReserva.Size = New System.Drawing.Size(100, 20)
        Me.txt_FechaReserva.TabIndex = 38
        '
        'lbl_Vel
        '
        Me.lbl_Vel.AutoSize = True
        Me.lbl_Vel.Location = New System.Drawing.Point(239, 106)
        Me.lbl_Vel.Name = "lbl_Vel"
        Me.lbl_Vel.Size = New System.Drawing.Size(51, 13)
        Me.lbl_Vel.TabIndex = 37
        Me.lbl_Vel.Text = "Id Cliente"
        '
        'txt_IdC
        '
        Me.txt_IdC.Enabled = False
        Me.txt_IdC.Location = New System.Drawing.Point(310, 103)
        Me.txt_IdC.Name = "txt_IdC"
        Me.txt_IdC.Size = New System.Drawing.Size(100, 20)
        Me.txt_IdC.TabIndex = 36
        '
        'btn_Mod
        '
        Me.btn_Mod.Enabled = False
        Me.btn_Mod.Location = New System.Drawing.Point(436, 142)
        Me.btn_Mod.Name = "btn_Mod"
        Me.btn_Mod.Size = New System.Drawing.Size(75, 34)
        Me.btn_Mod.TabIndex = 35
        Me.btn_Mod.Text = "Modificar datos"
        Me.btn_Mod.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.Location = New System.Drawing.Point(436, 96)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 34
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'lbl_Peso
        '
        Me.lbl_Peso.AutoSize = True
        Me.lbl_Peso.Location = New System.Drawing.Point(239, 76)
        Me.lbl_Peso.Name = "lbl_Peso"
        Me.lbl_Peso.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Peso.TabIndex = 33
        Me.lbl_Peso.Text = "Ficha Fin"
        '
        'lbl_Marca
        '
        Me.lbl_Marca.AutoSize = True
        Me.lbl_Marca.Location = New System.Drawing.Point(239, 44)
        Me.lbl_Marca.Name = "lbl_Marca"
        Me.lbl_Marca.Size = New System.Drawing.Size(65, 13)
        Me.lbl_Marca.TabIndex = 32
        Me.lbl_Marca.Text = "Fecha Inicio"
        '
        'btn_Añadir
        '
        Me.btn_Añadir.Enabled = False
        Me.btn_Añadir.Location = New System.Drawing.Point(436, 49)
        Me.btn_Añadir.Name = "btn_Añadir"
        Me.btn_Añadir.Size = New System.Drawing.Size(75, 23)
        Me.btn_Añadir.TabIndex = 29
        Me.btn_Añadir.Text = "Añadir"
        Me.btn_Añadir.UseVisualStyleBackColor = True
        '
        'ListReservas
        '
        Me.ListReservas.Enabled = False
        Me.ListReservas.FormattingEnabled = True
        Me.ListReservas.Location = New System.Drawing.Point(38, 30)
        Me.ListReservas.Name = "ListReservas"
        Me.ListReservas.Size = New System.Drawing.Size(167, 186)
        Me.ListReservas.TabIndex = 42
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(310, 38)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 43
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(310, 70)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker2.TabIndex = 44
        '
        'ListIdPat
        '
        Me.ListIdPat.Enabled = False
        Me.ListIdPat.FormattingEnabled = True
        Me.ListIdPat.Location = New System.Drawing.Point(591, 30)
        Me.ListIdPat.Name = "ListIdPat"
        Me.ListIdPat.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListIdPat.Size = New System.Drawing.Size(167, 186)
        Me.ListIdPat.TabIndex = 45
        '
        'btn_ranking
        '
        Me.btn_ranking.Enabled = False
        Me.btn_ranking.Location = New System.Drawing.Point(486, 237)
        Me.btn_ranking.Name = "btn_ranking"
        Me.btn_ranking.Size = New System.Drawing.Size(102, 35)
        Me.btn_ranking.TabIndex = 48
        Me.btn_ranking.Text = "Ranking de tipos de patinetes"
        Me.btn_ranking.UseVisualStyleBackColor = True
        '
        'btn_hisCli
        '
        Me.btn_hisCli.Enabled = False
        Me.btn_hisCli.Location = New System.Drawing.Point(486, 273)
        Me.btn_hisCli.Name = "btn_hisCli"
        Me.btn_hisCli.Size = New System.Drawing.Size(102, 23)
        Me.btn_hisCli.TabIndex = 47
        Me.btn_hisCli.Text = "Historial Clientes"
        Me.btn_hisCli.UseVisualStyleBackColor = True
        '
        'btn_hisPat
        '
        Me.btn_hisPat.Enabled = False
        Me.btn_hisPat.Location = New System.Drawing.Point(486, 211)
        Me.btn_hisPat.Name = "btn_hisPat"
        Me.btn_hisPat.Size = New System.Drawing.Size(102, 23)
        Me.btn_hisPat.TabIndex = 46
        Me.btn_hisPat.Text = "Historial Patinetes"
        Me.btn_hisPat.UseVisualStyleBackColor = True
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Enabled = False
        Me.txt_descripcion.Location = New System.Drawing.Point(658, 237)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(100, 20)
        Me.txt_descripcion.TabIndex = 50
        '
        'txt_tipo
        '
        Me.txt_tipo.Enabled = False
        Me.txt_tipo.Location = New System.Drawing.Point(658, 270)
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(100, 20)
        Me.txt_tipo.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(594, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Descripcion"
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Location = New System.Drawing.Point(607, 273)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(28, 13)
        Me.lbl_tipo.TabIndex = 53
        Me.lbl_tipo.Text = "Tipo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_tipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_tipo)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.btn_ranking)
        Me.Controls.Add(Me.btn_hisCli)
        Me.Controls.Add(Me.btn_hisPat)
        Me.Controls.Add(Me.ListIdPat)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ListReservas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_PrecioRes)
        Me.Controls.Add(Me.lbl_Pph)
        Me.Controls.Add(Me.txt_FechaReserva)
        Me.Controls.Add(Me.lbl_Vel)
        Me.Controls.Add(Me.txt_IdC)
        Me.Controls.Add(Me.btn_Mod)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.lbl_Peso)
        Me.Controls.Add(Me.lbl_Marca)
        Me.Controls.Add(Me.btn_Añadir)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.btn_conectar)
        Me.Controls.Add(Me.btn_Ruta)
        Me.Controls.Add(Me.btn_Patinetes)
        Me.Controls.Add(Me.btn_Clientes)
        Me.Controls.Add(Me.btn_TipoP)
        Me.Name = "Form1"
        Me.Text = "+"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_TipoP As Button
    Friend WithEvents btn_Clientes As Button
    Friend WithEvents btn_Patinetes As Button
    Friend WithEvents btn_Ruta As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_conectar As Button
    Friend WithEvents txtRuta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_PrecioRes As TextBox
    Friend WithEvents lbl_Pph As Label
    Friend WithEvents txt_FechaReserva As TextBox
    Friend WithEvents lbl_Vel As Label
    Friend WithEvents txt_IdC As TextBox
    Friend WithEvents btn_Mod As Button
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents lbl_Peso As Label
    Friend WithEvents lbl_Marca As Label
    Friend WithEvents btn_Añadir As Button
    Friend WithEvents ListReservas As ListBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ListIdPat As ListBox
    Friend WithEvents btn_ranking As Button
    Friend WithEvents btn_hisCli As Button
    Friend WithEvents btn_hisPat As Button
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents txt_tipo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_tipo As Label
End Class
