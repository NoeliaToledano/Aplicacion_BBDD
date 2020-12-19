<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipoPatineteUI
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
        Me.btn_Añadir = New System.Windows.Forms.Button()
        Me.txt_Marca = New System.Windows.Forms.TextBox()
        Me.txt_Peso = New System.Windows.Forms.TextBox()
        Me.lbl_Marca = New System.Windows.Forms.Label()
        Me.lbl_Peso = New System.Windows.Forms.Label()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Mod = New System.Windows.Forms.Button()
        Me.lbl_Vel = New System.Windows.Forms.Label()
        Me.txt_vel = New System.Windows.Forms.TextBox()
        Me.lbl_Pph = New System.Windows.Forms.Label()
        Me.Txt_Pph = New System.Windows.Forms.TextBox()
        Me.ListTipos = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Añadir
        '
        Me.btn_Añadir.Location = New System.Drawing.Point(473, 60)
        Me.btn_Añadir.Name = "btn_Añadir"
        Me.btn_Añadir.Size = New System.Drawing.Size(75, 23)
        Me.btn_Añadir.TabIndex = 0
        Me.btn_Añadir.Text = "Añadir"
        Me.btn_Añadir.UseVisualStyleBackColor = True
        '
        'txt_Marca
        '
        Me.txt_Marca.Location = New System.Drawing.Point(317, 57)
        Me.txt_Marca.Name = "txt_Marca"
        Me.txt_Marca.Size = New System.Drawing.Size(100, 20)
        Me.txt_Marca.TabIndex = 2
        '
        'txt_Peso
        '
        Me.txt_Peso.Location = New System.Drawing.Point(317, 99)
        Me.txt_Peso.Name = "txt_Peso"
        Me.txt_Peso.Size = New System.Drawing.Size(100, 20)
        Me.txt_Peso.TabIndex = 3
        '
        'lbl_Marca
        '
        Me.lbl_Marca.AutoSize = True
        Me.lbl_Marca.Location = New System.Drawing.Point(274, 60)
        Me.lbl_Marca.Name = "lbl_Marca"
        Me.lbl_Marca.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Marca.TabIndex = 5
        Me.lbl_Marca.Text = "Marca"
        '
        'lbl_Peso
        '
        Me.lbl_Peso.AutoSize = True
        Me.lbl_Peso.Location = New System.Drawing.Point(197, 101)
        Me.lbl_Peso.Name = "lbl_Peso"
        Me.lbl_Peso.Size = New System.Drawing.Size(114, 13)
        Me.lbl_Peso.TabIndex = 6
        Me.lbl_Peso.Text = "Peso máximo permitido"
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Location = New System.Drawing.Point(473, 107)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 7
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Mod
        '
        Me.btn_Mod.Location = New System.Drawing.Point(473, 153)
        Me.btn_Mod.Name = "btn_Mod"
        Me.btn_Mod.Size = New System.Drawing.Size(75, 34)
        Me.btn_Mod.TabIndex = 9
        Me.btn_Mod.Text = "Modificar datos"
        Me.btn_Mod.UseVisualStyleBackColor = True
        '
        'lbl_Vel
        '
        Me.lbl_Vel.AutoSize = True
        Me.lbl_Vel.Location = New System.Drawing.Point(257, 142)
        Me.lbl_Vel.Name = "lbl_Vel"
        Me.lbl_Vel.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Vel.TabIndex = 11
        Me.lbl_Vel.Text = "Velocidad"
        '
        'txt_vel
        '
        Me.txt_vel.Location = New System.Drawing.Point(317, 139)
        Me.txt_vel.Name = "txt_vel"
        Me.txt_vel.Size = New System.Drawing.Size(100, 20)
        Me.txt_vel.TabIndex = 10
        '
        'lbl_Pph
        '
        Me.lbl_Pph.AutoSize = True
        Me.lbl_Pph.Location = New System.Drawing.Point(232, 182)
        Me.lbl_Pph.Name = "lbl_Pph"
        Me.lbl_Pph.Size = New System.Drawing.Size(79, 13)
        Me.lbl_Pph.TabIndex = 13
        Me.lbl_Pph.Text = "Precio por hora"
        '
        'Txt_Pph
        '
        Me.Txt_Pph.Location = New System.Drawing.Point(317, 179)
        Me.Txt_Pph.Name = "Txt_Pph"
        Me.Txt_Pph.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Pph.TabIndex = 12
        '
        'ListTipos
        '
        Me.ListTipos.FormattingEnabled = True
        Me.ListTipos.Location = New System.Drawing.Point(12, 40)
        Me.ListTipos.Name = "ListTipos"
        Me.ListTipos.Size = New System.Drawing.Size(167, 186)
        Me.ListTipos.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Lista de tipos de patinetes"
        '
        'TipoPatineteUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListTipos)
        Me.Controls.Add(Me.lbl_Pph)
        Me.Controls.Add(Me.Txt_Pph)
        Me.Controls.Add(Me.lbl_Vel)
        Me.Controls.Add(Me.txt_vel)
        Me.Controls.Add(Me.btn_Mod)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.lbl_Peso)
        Me.Controls.Add(Me.lbl_Marca)
        Me.Controls.Add(Me.txt_Peso)
        Me.Controls.Add(Me.txt_Marca)
        Me.Controls.Add(Me.btn_Añadir)
        Me.Name = "TipoPatineteUI"
        Me.Text = "TipoPatineteUI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Añadir As Button
    Friend WithEvents txt_Marca As TextBox
    Friend WithEvents txt_Peso As TextBox
    Friend WithEvents lbl_Marca As Label
    Friend WithEvents lbl_Peso As Label
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btn_Mod As Button
    Friend WithEvents lbl_Vel As Label
    Friend WithEvents txt_vel As TextBox
    Friend WithEvents lbl_Pph As Label
    Friend WithEvents Txt_Pph As TextBox
    Friend WithEvents ListTipos As ListBox
    Friend WithEvents Label1 As Label
End Class
