<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENSAJE
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
        Me.components = New System.ComponentModel.Container()
        Me.TextBoxMENSAJE = New System.Windows.Forms.TextBox()
        Me.RichTextBoxRECIBIDO = New System.Windows.Forms.RichTextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblNotificacion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxMENSAJE
        '
        Me.TextBoxMENSAJE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxMENSAJE.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxMENSAJE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMENSAJE.ForeColor = System.Drawing.Color.Black
        Me.TextBoxMENSAJE.Location = New System.Drawing.Point(12, 387)
        Me.TextBoxMENSAJE.Multiline = True
        Me.TextBoxMENSAJE.Name = "TextBoxMENSAJE"
        Me.TextBoxMENSAJE.Size = New System.Drawing.Size(340, 71)
        Me.TextBoxMENSAJE.TabIndex = 1
        '
        'RichTextBoxRECIBIDO
        '
        Me.RichTextBoxRECIBIDO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRECIBIDO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RichTextBoxRECIBIDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRECIBIDO.ForeColor = System.Drawing.Color.Black
        Me.RichTextBoxRECIBIDO.Location = New System.Drawing.Point(12, 34)
        Me.RichTextBoxRECIBIDO.Name = "RichTextBoxRECIBIDO"
        Me.RichTextBoxRECIBIDO.ReadOnly = True
        Me.RichTextBoxRECIBIDO.Size = New System.Drawing.Size(340, 322)
        Me.RichTextBoxRECIBIDO.TabIndex = 15
        Me.RichTextBoxRECIBIDO.Text = ""
        '
        'lblEstado
        '
        Me.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblEstado.AutoSize = True
        Me.lblEstado.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.White
        Me.lblEstado.Location = New System.Drawing.Point(51, 9)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(271, 20)
        Me.lblEstado.TabIndex = 36
        Me.lblEstado.Text = "MENSAJE CLIENTE-SERVIDOR"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(34, 364)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "MENSAJE "
        '
        'Timer1
        '
        '
        'lblNotificacion
        '
        Me.lblNotificacion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNotificacion.AutoSize = True
        Me.lblNotificacion.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNotificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotificacion.ForeColor = System.Drawing.Color.White
        Me.lblNotificacion.Location = New System.Drawing.Point(255, 364)
        Me.lblNotificacion.Name = "lblNotificacion"
        Me.lblNotificacion.Size = New System.Drawing.Size(59, 20)
        Me.lblNotificacion.TabIndex = 38
        Me.lblNotificacion.Text = "status"
        '
        'MENSAJE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(364, 470)
        Me.Controls.Add(Me.lblNotificacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.TextBoxMENSAJE)
        Me.Controls.Add(Me.RichTextBoxRECIBIDO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MENSAJE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENSAJE CLIENTE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxMENSAJE As TextBox
    Friend WithEvents RichTextBoxRECIBIDO As RichTextBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblNotificacion As Label
End Class
