<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatineteUi
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
        Me.lbl_IdTipo = New System.Windows.Forms.Label()
        Me.lbl_Desc = New System.Windows.Forms.Label()
        Me.txt_IdT = New System.Windows.Forms.TextBox()
        Me.txt_Desc = New System.Windows.Forms.TextBox()
        Me.ListId = New System.Windows.Forms.ListBox()
        Me.lbl_Id = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Mod
        '
        Me.btn_Mod.Location = New System.Drawing.Point(521, 164)
        Me.btn_Mod.Name = "btn_Mod"
        Me.btn_Mod.Size = New System.Drawing.Size(75, 34)
        Me.btn_Mod.TabIndex = 12
        Me.btn_Mod.Text = "Modificar datos"
        Me.btn_Mod.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Location = New System.Drawing.Point(521, 118)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 11
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Añadir
        '
        Me.btn_Añadir.Location = New System.Drawing.Point(521, 71)
        Me.btn_Añadir.Name = "btn_Añadir"
        Me.btn_Añadir.Size = New System.Drawing.Size(75, 23)
        Me.btn_Añadir.TabIndex = 10
        Me.btn_Añadir.Text = "Añadir"
        Me.btn_Añadir.UseVisualStyleBackColor = True
        '
        'lbl_IdTipo
        '
        Me.lbl_IdTipo.AutoSize = True
        Me.lbl_IdTipo.Location = New System.Drawing.Point(281, 139)
        Me.lbl_IdTipo.Name = "lbl_IdTipo"
        Me.lbl_IdTipo.Size = New System.Drawing.Size(40, 13)
        Me.lbl_IdTipo.TabIndex = 18
        Me.lbl_IdTipo.Text = "Id Tipo"
        '
        'lbl_Desc
        '
        Me.lbl_Desc.AutoSize = True
        Me.lbl_Desc.Location = New System.Drawing.Point(258, 99)
        Me.lbl_Desc.Name = "lbl_Desc"
        Me.lbl_Desc.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Desc.TabIndex = 17
        Me.lbl_Desc.Text = "Descripción"
        '
        'txt_IdT
        '
        Me.txt_IdT.Location = New System.Drawing.Point(327, 136)
        Me.txt_IdT.Name = "txt_IdT"
        Me.txt_IdT.Size = New System.Drawing.Size(100, 20)
        Me.txt_IdT.TabIndex = 15
        '
        'txt_Desc
        '
        Me.txt_Desc.Location = New System.Drawing.Point(327, 96)
        Me.txt_Desc.Name = "txt_Desc"
        Me.txt_Desc.Size = New System.Drawing.Size(100, 20)
        Me.txt_Desc.TabIndex = 14
        '
        'ListId
        '
        Me.ListId.FormattingEnabled = True
        Me.ListId.Location = New System.Drawing.Point(36, 38)
        Me.ListId.Name = "ListId"
        Me.ListId.Size = New System.Drawing.Size(167, 186)
        Me.ListId.TabIndex = 45
        '
        'lbl_Id
        '
        Me.lbl_Id.AutoSize = True
        Me.lbl_Id.Location = New System.Drawing.Point(58, 22)
        Me.lbl_Id.Name = "lbl_Id"
        Me.lbl_Id.Size = New System.Drawing.Size(119, 13)
        Me.lbl_Id.TabIndex = 46
        Me.lbl_Id.Text = "Lista de ID de patinetes"
        '
        'PatineteUi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 261)
        Me.Controls.Add(Me.lbl_Id)
        Me.Controls.Add(Me.ListId)
        Me.Controls.Add(Me.lbl_IdTipo)
        Me.Controls.Add(Me.lbl_Desc)
        Me.Controls.Add(Me.txt_IdT)
        Me.Controls.Add(Me.txt_Desc)
        Me.Controls.Add(Me.btn_Mod)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Añadir)
        Me.Name = "PatineteUi"
        Me.Text = "PatineteUi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Mod As Button
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btn_Añadir As Button
    Friend WithEvents lbl_IdTipo As Label
    Friend WithEvents lbl_Desc As Label
    Friend WithEvents txt_IdT As TextBox
    Friend WithEvents txt_Desc As TextBox
    Friend WithEvents ListId As ListBox
    Friend WithEvents lbl_Id As Label
End Class
