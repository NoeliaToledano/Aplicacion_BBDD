<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RankingUI
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
        Me.lbl_Id = New System.Windows.Forms.Label()
        Me.lbl_Peso = New System.Windows.Forms.Label()
        Me.lbl_marca = New System.Windows.Forms.Label()
        Me.txt_peso = New System.Windows.Forms.TextBox()
        Me.txt_marca = New System.Windows.Forms.TextBox()
        Me.ListTiposPatinetes = New System.Windows.Forms.ListBox()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_FechaFin = New System.Windows.Forms.Label()
        Me.lbl_FechaInicio = New System.Windows.Forms.Label()
        Me.lbl_pph = New System.Windows.Forms.Label()
        Me.lbl_Vel = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.txt_vel = New System.Windows.Forms.TextBox()
        Me.lbl_Gan = New System.Windows.Forms.Label()
        Me.txt_Gan = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_Id
        '
        Me.lbl_Id.AutoSize = True
        Me.lbl_Id.Location = New System.Drawing.Point(84, 30)
        Me.lbl_Id.Name = "lbl_Id"
        Me.lbl_Id.Size = New System.Drawing.Size(119, 13)
        Me.lbl_Id.TabIndex = 79
        Me.lbl_Id.Text = "Lista de ID de patinetes"
        '
        'lbl_Peso
        '
        Me.lbl_Peso.AutoSize = True
        Me.lbl_Peso.Location = New System.Drawing.Point(278, 79)
        Me.lbl_Peso.Name = "lbl_Peso"
        Me.lbl_Peso.Size = New System.Drawing.Size(114, 13)
        Me.lbl_Peso.TabIndex = 78
        Me.lbl_Peso.Text = "Peso máximo permitido"
        '
        'lbl_marca
        '
        Me.lbl_marca.AutoSize = True
        Me.lbl_marca.Location = New System.Drawing.Point(355, 53)
        Me.lbl_marca.Name = "lbl_marca"
        Me.lbl_marca.Size = New System.Drawing.Size(37, 13)
        Me.lbl_marca.TabIndex = 77
        Me.lbl_marca.Text = "Marca"
        '
        'txt_peso
        '
        Me.txt_peso.Location = New System.Drawing.Point(398, 72)
        Me.txt_peso.Name = "txt_peso"
        Me.txt_peso.Size = New System.Drawing.Size(100, 20)
        Me.txt_peso.TabIndex = 76
        '
        'txt_marca
        '
        Me.txt_marca.Location = New System.Drawing.Point(398, 46)
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.Size = New System.Drawing.Size(100, 20)
        Me.txt_marca.TabIndex = 75
        '
        'ListTiposPatinetes
        '
        Me.ListTiposPatinetes.FormattingEnabled = True
        Me.ListTiposPatinetes.Location = New System.Drawing.Point(62, 46)
        Me.ListTiposPatinetes.Name = "ListTiposPatinetes"
        Me.ListTiposPatinetes.Size = New System.Drawing.Size(167, 186)
        Me.ListTiposPatinetes.TabIndex = 74
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Location = New System.Drawing.Point(644, 136)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(100, 54)
        Me.btn_Aceptar.TabIndex = 84
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(644, 85)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker2.TabIndex = 83
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(644, 53)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 82
        '
        'lbl_FechaFin
        '
        Me.lbl_FechaFin.AutoSize = True
        Me.lbl_FechaFin.Location = New System.Drawing.Point(584, 85)
        Me.lbl_FechaFin.Name = "lbl_FechaFin"
        Me.lbl_FechaFin.Size = New System.Drawing.Size(54, 13)
        Me.lbl_FechaFin.TabIndex = 81
        Me.lbl_FechaFin.Text = "Fecha Fin"
        '
        'lbl_FechaInicio
        '
        Me.lbl_FechaInicio.AutoSize = True
        Me.lbl_FechaInicio.Location = New System.Drawing.Point(573, 53)
        Me.lbl_FechaInicio.Name = "lbl_FechaInicio"
        Me.lbl_FechaInicio.Size = New System.Drawing.Size(65, 13)
        Me.lbl_FechaInicio.TabIndex = 80
        Me.lbl_FechaInicio.Text = "Fecha Inicio"
        '
        'lbl_pph
        '
        Me.lbl_pph.AutoSize = True
        Me.lbl_pph.Location = New System.Drawing.Point(313, 131)
        Me.lbl_pph.Name = "lbl_pph"
        Me.lbl_pph.Size = New System.Drawing.Size(79, 13)
        Me.lbl_pph.TabIndex = 88
        Me.lbl_pph.Text = "Precio por hora"
        '
        'lbl_Vel
        '
        Me.lbl_Vel.AutoSize = True
        Me.lbl_Vel.Location = New System.Drawing.Point(338, 101)
        Me.lbl_Vel.Name = "lbl_Vel"
        Me.lbl_Vel.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Vel.TabIndex = 87
        Me.lbl_Vel.Text = "Velocidad"
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(398, 124)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(100, 20)
        Me.txt_precio.TabIndex = 86
        '
        'txt_vel
        '
        Me.txt_vel.Location = New System.Drawing.Point(398, 98)
        Me.txt_vel.Name = "txt_vel"
        Me.txt_vel.Size = New System.Drawing.Size(100, 20)
        Me.txt_vel.TabIndex = 85
        '
        'lbl_Gan
        '
        Me.lbl_Gan.AutoSize = True
        Me.lbl_Gan.Location = New System.Drawing.Point(253, 173)
        Me.lbl_Gan.Name = "lbl_Gan"
        Me.lbl_Gan.Size = New System.Drawing.Size(139, 13)
        Me.lbl_Gan.TabIndex = 90
        Me.lbl_Gan.Text = "Ganancias en este intervalo"
        '
        'txt_Gan
        '
        Me.txt_Gan.Location = New System.Drawing.Point(398, 170)
        Me.txt_Gan.Name = "txt_Gan"
        Me.txt_Gan.Size = New System.Drawing.Size(100, 20)
        Me.txt_Gan.TabIndex = 89
        '
        'RankingUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 296)
        Me.Controls.Add(Me.lbl_Gan)
        Me.Controls.Add(Me.txt_Gan)
        Me.Controls.Add(Me.lbl_pph)
        Me.Controls.Add(Me.lbl_Vel)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.txt_vel)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lbl_FechaFin)
        Me.Controls.Add(Me.lbl_FechaInicio)
        Me.Controls.Add(Me.lbl_Id)
        Me.Controls.Add(Me.lbl_Peso)
        Me.Controls.Add(Me.lbl_marca)
        Me.Controls.Add(Me.txt_peso)
        Me.Controls.Add(Me.txt_marca)
        Me.Controls.Add(Me.ListTiposPatinetes)
        Me.Name = "RankingUI"
        Me.Text = "RankingUI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Id As Label
    Friend WithEvents lbl_Peso As Label
    Friend WithEvents lbl_marca As Label
    Friend WithEvents txt_peso As TextBox
    Friend WithEvents txt_marca As TextBox
    Friend WithEvents ListTiposPatinetes As ListBox
    Friend WithEvents btn_Aceptar As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lbl_FechaFin As Label
    Friend WithEvents lbl_FechaInicio As Label
    Friend WithEvents lbl_pph As Label
    Friend WithEvents lbl_Vel As Label
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents txt_vel As TextBox
    Friend WithEvents lbl_Gan As Label
    Friend WithEvents txt_Gan As TextBox
End Class
