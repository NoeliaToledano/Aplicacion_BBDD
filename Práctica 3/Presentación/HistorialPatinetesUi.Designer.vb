<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistorialPatinetesUi
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
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.lbl_Desc = New System.Windows.Forms.Label()
        Me.txt_tipo = New System.Windows.Forms.TextBox()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.ListDNI = New System.Windows.Forms.ListBox()
        Me.ListPatinetes = New System.Windows.Forms.ListBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_FechaFin = New System.Windows.Forms.Label()
        Me.lbl_FechaInicio = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_Id = New System.Windows.Forms.Label()
        Me.lbl_Nomb = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Location = New System.Drawing.Point(112, 325)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(28, 13)
        Me.lbl_tipo.TabIndex = 72
        Me.lbl_tipo.Text = "Tipo"
        '
        'lbl_Desc
        '
        Me.lbl_Desc.AutoSize = True
        Me.lbl_Desc.Location = New System.Drawing.Point(77, 295)
        Me.lbl_Desc.Name = "lbl_Desc"
        Me.lbl_Desc.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Desc.TabIndex = 71
        Me.lbl_Desc.Text = "Descripción"
        '
        'txt_tipo
        '
        Me.txt_tipo.Location = New System.Drawing.Point(146, 318)
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(100, 20)
        Me.txt_tipo.TabIndex = 70
        '
        'txt_desc
        '
        Me.txt_desc.Location = New System.Drawing.Point(146, 292)
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(100, 20)
        Me.txt_desc.TabIndex = 69
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Location = New System.Drawing.Point(387, 192)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(100, 54)
        Me.btn_Aceptar.TabIndex = 68
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'ListDNI
        '
        Me.ListDNI.FormattingEnabled = True
        Me.ListDNI.Location = New System.Drawing.Point(554, 60)
        Me.ListDNI.Name = "ListDNI"
        Me.ListDNI.Size = New System.Drawing.Size(167, 186)
        Me.ListDNI.TabIndex = 67
        '
        'ListPatinetes
        '
        Me.ListPatinetes.FormattingEnabled = True
        Me.ListPatinetes.Location = New System.Drawing.Point(80, 60)
        Me.ListPatinetes.Name = "ListPatinetes"
        Me.ListPatinetes.Size = New System.Drawing.Size(167, 186)
        Me.ListPatinetes.TabIndex = 66
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(387, 125)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker2.TabIndex = 65
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(387, 93)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 64
        '
        'lbl_FechaFin
        '
        Me.lbl_FechaFin.AutoSize = True
        Me.lbl_FechaFin.Location = New System.Drawing.Point(327, 125)
        Me.lbl_FechaFin.Name = "lbl_FechaFin"
        Me.lbl_FechaFin.Size = New System.Drawing.Size(54, 13)
        Me.lbl_FechaFin.TabIndex = 63
        Me.lbl_FechaFin.Text = "Fecha Fin"
        '
        'lbl_FechaInicio
        '
        Me.lbl_FechaInicio.AutoSize = True
        Me.lbl_FechaInicio.Location = New System.Drawing.Point(316, 93)
        Me.lbl_FechaInicio.Name = "lbl_FechaInicio"
        Me.lbl_FechaInicio.Size = New System.Drawing.Size(65, 13)
        Me.lbl_FechaInicio.TabIndex = 62
        Me.lbl_FechaInicio.Text = "Fecha Inicio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(609, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Lista de DNI"
        '
        'lbl_Id
        '
        Me.lbl_Id.AutoSize = True
        Me.lbl_Id.Location = New System.Drawing.Point(102, 44)
        Me.lbl_Id.Name = "lbl_Id"
        Me.lbl_Id.Size = New System.Drawing.Size(119, 13)
        Me.lbl_Id.TabIndex = 73
        Me.lbl_Id.Text = "Lista de ID de patinetes"
        '
        'lbl_Nomb
        '
        Me.lbl_Nomb.AutoSize = True
        Me.lbl_Nomb.Location = New System.Drawing.Point(571, 295)
        Me.lbl_Nomb.Name = "lbl_Nomb"
        Me.lbl_Nomb.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Nomb.TabIndex = 76
        Me.lbl_Nomb.Text = "Nombre"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(621, 292)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 75
        '
        'HistorialPatinetesUi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_Nomb)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_Id)
        Me.Controls.Add(Me.lbl_tipo)
        Me.Controls.Add(Me.lbl_Desc)
        Me.Controls.Add(Me.txt_tipo)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.ListDNI)
        Me.Controls.Add(Me.ListPatinetes)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lbl_FechaFin)
        Me.Controls.Add(Me.lbl_FechaInicio)
        Me.Name = "HistorialPatinetesUi"
        Me.Text = "HistorialPatinetesUi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_tipo As Label
    Friend WithEvents lbl_Desc As Label
    Friend WithEvents txt_tipo As TextBox
    Friend WithEvents txt_desc As TextBox
    Friend WithEvents btn_Aceptar As Button
    Friend WithEvents ListDNI As ListBox
    Friend WithEvents ListPatinetes As ListBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lbl_FechaFin As Label
    Friend WithEvents lbl_FechaInicio As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_Id As Label
    Friend WithEvents lbl_Nomb As Label
    Friend WithEvents txt_nombre As TextBox
End Class
