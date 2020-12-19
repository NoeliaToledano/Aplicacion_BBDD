<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesUI
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
        Me.btn_Mod = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Añadir = New System.Windows.Forms.Button()
        Me.lbl_Tlf = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_DNI = New System.Windows.Forms.Label()
        Me.txt_Tlf = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.txt_DNI = New System.Windows.Forms.TextBox()
        Me.lbl_Dir = New System.Windows.Forms.Label()
        Me.txt_Dir = New System.Windows.Forms.TextBox()
        Me.lbl_Em = New System.Windows.Forms.Label()
        Me.txt_Em = New System.Windows.Forms.TextBox()
        Me.ListDNI = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Mod
        '
        Me.btn_Mod.Location = New System.Drawing.Point(478, 152)
        Me.btn_Mod.Name = "btn_Mod"
        Me.btn_Mod.Size = New System.Drawing.Size(75, 34)
        Me.btn_Mod.TabIndex = 12
        Me.btn_Mod.Text = "Modificar datos"
        Me.btn_Mod.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Location = New System.Drawing.Point(478, 106)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 11
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Añadir
        '
        Me.btn_Añadir.Location = New System.Drawing.Point(478, 59)
        Me.btn_Añadir.Name = "btn_Añadir"
        Me.btn_Añadir.Size = New System.Drawing.Size(75, 23)
        Me.btn_Añadir.TabIndex = 10
        Me.btn_Añadir.Text = "Añadir"
        Me.btn_Añadir.UseVisualStyleBackColor = True
        '
        'lbl_Tlf
        '
        Me.lbl_Tlf.AutoSize = True
        Me.lbl_Tlf.Location = New System.Drawing.Point(228, 116)
        Me.lbl_Tlf.Name = "lbl_Tlf"
        Me.lbl_Tlf.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Tlf.TabIndex = 24
        Me.lbl_Tlf.Text = "Teléfono"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(233, 76)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Nombre.TabIndex = 23
        Me.lbl_Nombre.Text = "Nombre"
        '
        'lbl_DNI
        '
        Me.lbl_DNI.AutoSize = True
        Me.lbl_DNI.Location = New System.Drawing.Point(251, 30)
        Me.lbl_DNI.Name = "lbl_DNI"
        Me.lbl_DNI.Size = New System.Drawing.Size(26, 13)
        Me.lbl_DNI.TabIndex = 22
        Me.lbl_DNI.Text = "DNI"
        '
        'txt_Tlf
        '
        Me.txt_Tlf.Location = New System.Drawing.Point(283, 113)
        Me.txt_Tlf.Name = "txt_Tlf"
        Me.txt_Tlf.Size = New System.Drawing.Size(100, 20)
        Me.txt_Tlf.TabIndex = 21
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(283, 73)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_Nombre.TabIndex = 20
        '
        'txt_DNI
        '
        Me.txt_DNI.Location = New System.Drawing.Point(283, 30)
        Me.txt_DNI.Name = "txt_DNI"
        Me.txt_DNI.Size = New System.Drawing.Size(100, 20)
        Me.txt_DNI.TabIndex = 19
        '
        'lbl_Dir
        '
        Me.lbl_Dir.AutoSize = True
        Me.lbl_Dir.Location = New System.Drawing.Point(225, 153)
        Me.lbl_Dir.Name = "lbl_Dir"
        Me.lbl_Dir.Size = New System.Drawing.Size(52, 13)
        Me.lbl_Dir.TabIndex = 26
        Me.lbl_Dir.Text = "Dirección"
        '
        'txt_Dir
        '
        Me.txt_Dir.Location = New System.Drawing.Point(283, 150)
        Me.txt_Dir.Name = "txt_Dir"
        Me.txt_Dir.Size = New System.Drawing.Size(100, 20)
        Me.txt_Dir.TabIndex = 25
        '
        'lbl_Em
        '
        Me.lbl_Em.AutoSize = True
        Me.lbl_Em.Location = New System.Drawing.Point(245, 193)
        Me.lbl_Em.Name = "lbl_Em"
        Me.lbl_Em.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Em.TabIndex = 28
        Me.lbl_Em.Text = "Email"
        '
        'txt_Em
        '
        Me.txt_Em.Location = New System.Drawing.Point(283, 190)
        Me.txt_Em.Name = "txt_Em"
        Me.txt_Em.Size = New System.Drawing.Size(100, 20)
        Me.txt_Em.TabIndex = 27
        '
        'ListDNI
        '
        Me.ListDNI.FormattingEnabled = True
        Me.ListDNI.Location = New System.Drawing.Point(12, 30)
        Me.ListDNI.Name = "ListDNI"
        Me.ListDNI.Size = New System.Drawing.Size(167, 186)
        Me.ListDNI.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Lista de DNI"
        '
        'ClientesUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListDNI)
        Me.Controls.Add(Me.lbl_Em)
        Me.Controls.Add(Me.txt_Em)
        Me.Controls.Add(Me.lbl_Dir)
        Me.Controls.Add(Me.txt_Dir)
        Me.Controls.Add(Me.lbl_Tlf)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.lbl_DNI)
        Me.Controls.Add(Me.txt_Tlf)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.txt_DNI)
        Me.Controls.Add(Me.btn_Mod)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Añadir)
        Me.Name = "ClientesUI"
        Me.Text = "ClientesUI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Mod As Button
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btn_Añadir As Button
    Friend WithEvents lbl_Tlf As Label
    Friend WithEvents lbl_Nombre As Label
    Friend WithEvents lbl_DNI As Label
    Friend WithEvents txt_Tlf As TextBox
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents txt_DNI As TextBox
    Friend WithEvents lbl_Dir As Label
    Friend WithEvents txt_Dir As TextBox
    Friend WithEvents lbl_Em As Label
    Friend WithEvents txt_Em As TextBox
    Friend WithEvents ListDNI As ListBox
    Friend WithEvents Label1 As Label
End Class
