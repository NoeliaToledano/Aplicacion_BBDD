<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistorialClientesUI
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
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_FechaFin = New System.Windows.Forms.Label()
        Me.lbl_FechaInicio = New System.Windows.Forms.Label()
        Me.ListDNI = New System.Windows.Forms.ListBox()
        Me.ListPatinetes = New System.Windows.Forms.ListBox()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.lbl_tlf = New System.Windows.Forms.Label()
        Me.lbl_Nomb = New System.Windows.Forms.Label()
        Me.txt_tlf = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_Dir = New System.Windows.Forms.Label()
        Me.txt_dir = New System.Windows.Forms.TextBox()
        Me.lbl_Em = New System.Windows.Forms.Label()
        Me.txt_em = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_IdT = New System.Windows.Forms.TextBox()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.lbl_Id = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(351, 89)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker2.TabIndex = 48
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(351, 57)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 47
        '
        'lbl_FechaFin
        '
        Me.lbl_FechaFin.AutoSize = True
        Me.lbl_FechaFin.Location = New System.Drawing.Point(291, 89)
        Me.lbl_FechaFin.Name = "lbl_FechaFin"
        Me.lbl_FechaFin.Size = New System.Drawing.Size(54, 13)
        Me.lbl_FechaFin.TabIndex = 46
        Me.lbl_FechaFin.Text = "Fecha Fin"
        '
        'lbl_FechaInicio
        '
        Me.lbl_FechaInicio.AutoSize = True
        Me.lbl_FechaInicio.Location = New System.Drawing.Point(280, 57)
        Me.lbl_FechaInicio.Name = "lbl_FechaInicio"
        Me.lbl_FechaInicio.Size = New System.Drawing.Size(65, 13)
        Me.lbl_FechaInicio.TabIndex = 45
        Me.lbl_FechaInicio.Text = "Fecha Inicio"
        '
        'ListDNI
        '
        Me.ListDNI.FormattingEnabled = True
        Me.ListDNI.Location = New System.Drawing.Point(43, 42)
        Me.ListDNI.Name = "ListDNI"
        Me.ListDNI.Size = New System.Drawing.Size(167, 186)
        Me.ListDNI.TabIndex = 49
        '
        'ListPatinetes
        '
        Me.ListPatinetes.FormattingEnabled = True
        Me.ListPatinetes.Location = New System.Drawing.Point(518, 42)
        Me.ListPatinetes.Name = "ListPatinetes"
        Me.ListPatinetes.Size = New System.Drawing.Size(167, 186)
        Me.ListPatinetes.TabIndex = 50
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Location = New System.Drawing.Point(351, 155)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(100, 54)
        Me.btn_Aceptar.TabIndex = 51
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'lbl_tlf
        '
        Me.lbl_tlf.AutoSize = True
        Me.lbl_tlf.Location = New System.Drawing.Point(55, 289)
        Me.lbl_tlf.Name = "lbl_tlf"
        Me.lbl_tlf.Size = New System.Drawing.Size(49, 13)
        Me.lbl_tlf.TabIndex = 57
        Me.lbl_tlf.Text = "Teléfono"
        '
        'lbl_Nomb
        '
        Me.lbl_Nomb.AutoSize = True
        Me.lbl_Nomb.Location = New System.Drawing.Point(60, 259)
        Me.lbl_Nomb.Name = "lbl_Nomb"
        Me.lbl_Nomb.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Nomb.TabIndex = 56
        Me.lbl_Nomb.Text = "Nombre"
        '
        'txt_tlf
        '
        Me.txt_tlf.Location = New System.Drawing.Point(110, 282)
        Me.txt_tlf.Name = "txt_tlf"
        Me.txt_tlf.Size = New System.Drawing.Size(100, 20)
        Me.txt_tlf.TabIndex = 55
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(110, 256)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 54
        '
        'lbl_Dir
        '
        Me.lbl_Dir.AutoSize = True
        Me.lbl_Dir.Location = New System.Drawing.Point(52, 311)
        Me.lbl_Dir.Name = "lbl_Dir"
        Me.lbl_Dir.Size = New System.Drawing.Size(52, 13)
        Me.lbl_Dir.TabIndex = 59
        Me.lbl_Dir.Text = "Dirección"
        '
        'txt_dir
        '
        Me.txt_dir.Location = New System.Drawing.Point(110, 308)
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.Size = New System.Drawing.Size(100, 20)
        Me.txt_dir.TabIndex = 58
        '
        'lbl_Em
        '
        Me.lbl_Em.AutoSize = True
        Me.lbl_Em.Location = New System.Drawing.Point(60, 337)
        Me.lbl_Em.Name = "lbl_Em"
        Me.lbl_Em.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Em.TabIndex = 61
        Me.lbl_Em.Text = "Email"
        '
        'txt_em
        '
        Me.txt_em.Location = New System.Drawing.Point(110, 334)
        Me.txt_em.Name = "txt_em"
        Me.txt_em.Size = New System.Drawing.Size(100, 20)
        Me.txt_em.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(497, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Id Tipo Patinete"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(516, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Descripción"
        '
        'txt_IdT
        '
        Me.txt_IdT.Location = New System.Drawing.Point(585, 282)
        Me.txt_IdT.Name = "txt_IdT"
        Me.txt_IdT.Size = New System.Drawing.Size(100, 20)
        Me.txt_IdT.TabIndex = 63
        '
        'txt_desc
        '
        Me.txt_desc.Location = New System.Drawing.Point(585, 256)
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(100, 20)
        Me.txt_desc.TabIndex = 62
        '
        'lbl_Id
        '
        Me.lbl_Id.AutoSize = True
        Me.lbl_Id.Location = New System.Drawing.Point(549, 24)
        Me.lbl_Id.Name = "lbl_Id"
        Me.lbl_Id.Size = New System.Drawing.Size(119, 13)
        Me.lbl_Id.TabIndex = 66
        Me.lbl_Id.Text = "Lista de ID de patinetes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Lista de DNI"
        '
        'HistorialClientesUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 403)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_Id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_IdT)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.lbl_Em)
        Me.Controls.Add(Me.txt_em)
        Me.Controls.Add(Me.lbl_Dir)
        Me.Controls.Add(Me.txt_dir)
        Me.Controls.Add(Me.lbl_tlf)
        Me.Controls.Add(Me.lbl_Nomb)
        Me.Controls.Add(Me.txt_tlf)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.ListPatinetes)
        Me.Controls.Add(Me.ListDNI)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lbl_FechaFin)
        Me.Controls.Add(Me.lbl_FechaInicio)
        Me.Name = "HistorialClientesUI"
        Me.Text = "Historial de clientes por fecha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lbl_FechaFin As Label
    Friend WithEvents lbl_FechaInicio As Label
    Friend WithEvents ListDNI As ListBox
    Friend WithEvents ListPatinetes As ListBox
    Friend WithEvents btn_Aceptar As Button
    Friend WithEvents lbl_tlf As Label
    Friend WithEvents lbl_Nomb As Label
    Friend WithEvents txt_tlf As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents lbl_Dir As Label
    Friend WithEvents txt_dir As TextBox
    Friend WithEvents lbl_Em As Label
    Friend WithEvents txt_em As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_IdT As TextBox
    Friend WithEvents txt_desc As TextBox
    Friend WithEvents lbl_Id As Label
    Friend WithEvents Label3 As Label
End Class
