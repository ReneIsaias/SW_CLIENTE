<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ESCRITORIO
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonC = New System.Windows.Forms.RadioButton()
        Me.RadioButtonZ = New System.Windows.Forms.RadioButton()
        Me.LabelCONEXION = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.LabelESCRITORIO = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblIp = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblNotificacion = New System.Windows.Forms.Label()
        Me.getDataDB = New System.Windows.Forms.Timer(Me.components)
        Me.lblServer = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RadioButtonC)
        Me.GroupBox1.Controls.Add(Me.RadioButtonZ)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(724, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(161, 69)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PANTALLA"
        '
        'RadioButtonC
        '
        Me.RadioButtonC.AutoSize = True
        Me.RadioButtonC.Checked = True
        Me.RadioButtonC.Location = New System.Drawing.Point(7, 43)
        Me.RadioButtonC.Name = "RadioButtonC"
        Me.RadioButtonC.Size = New System.Drawing.Size(121, 24)
        Me.RadioButtonC.TabIndex = 1
        Me.RadioButtonC.TabStop = True
        Me.RadioButtonC.Text = "COMPLETA"
        Me.RadioButtonC.UseVisualStyleBackColor = True
        '
        'RadioButtonZ
        '
        Me.RadioButtonZ.AutoSize = True
        Me.RadioButtonZ.Location = New System.Drawing.Point(6, 21)
        Me.RadioButtonZ.Name = "RadioButtonZ"
        Me.RadioButtonZ.Size = New System.Drawing.Size(75, 24)
        Me.RadioButtonZ.TabIndex = 0
        Me.RadioButtonZ.Text = "ZONA"
        Me.RadioButtonZ.UseVisualStyleBackColor = True
        '
        'LabelCONEXION
        '
        Me.LabelCONEXION.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCONEXION.AutoSize = True
        Me.LabelCONEXION.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCONEXION.ForeColor = System.Drawing.Color.Black
        Me.LabelCONEXION.Location = New System.Drawing.Point(727, 250)
        Me.LabelCONEXION.Name = "LabelCONEXION"
        Me.LabelCONEXION.Size = New System.Drawing.Size(147, 18)
        Me.LabelCONEXION.TabIndex = 17
        Me.LabelCONEXION.Text = "DESCONECTADO"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(724, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "SEG/IMG"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.NumericUpDown1.DecimalPlaces = 1
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.NumericUpDown1.Location = New System.Drawing.Point(816, 195)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(69, 26)
        Me.NumericUpDown1.TabIndex = 15
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LabelESCRITORIO
        '
        Me.LabelESCRITORIO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelESCRITORIO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelESCRITORIO.Location = New System.Drawing.Point(12, 49)
        Me.LabelESCRITORIO.Name = "LabelESCRITORIO"
        Me.LabelESCRITORIO.Size = New System.Drawing.Size(709, 488)
        Me.LabelESCRITORIO.TabIndex = 13
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Lime
        Me.lblNombre.Location = New System.Drawing.Point(45, 9)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(74, 25)
        Me.lblNombre.TabIndex = 20
        Me.lblNombre.Text = "USER"
        '
        'lblIp
        '
        Me.lblIp.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblIp.AutoSize = True
        Me.lblIp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIp.ForeColor = System.Drawing.Color.Lime
        Me.lblIp.Location = New System.Drawing.Point(247, 9)
        Me.lblIp.Name = "lblIp"
        Me.lblIp.Size = New System.Drawing.Size(33, 25)
        Me.lblIp.TabIndex = 21
        Me.lblIp.Text = "IP"
        '
        'Timer1
        '
        '
        'lblNotificacion
        '
        Me.lblNotificacion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNotificacion.AutoSize = True
        Me.lblNotificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotificacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNotificacion.Location = New System.Drawing.Point(703, 9)
        Me.lblNotificacion.Name = "lblNotificacion"
        Me.lblNotificacion.Size = New System.Drawing.Size(171, 25)
        Me.lblNotificacion.TabIndex = 24
        Me.lblNotificacion.Text = "NOTIFICACION"
        '
        'getDataDB
        '
        Me.getDataDB.Interval = 3000
        '
        'lblServer
        '
        Me.lblServer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblServer.AutoSize = True
        Me.lblServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServer.ForeColor = System.Drawing.Color.Lime
        Me.lblServer.Location = New System.Drawing.Point(460, 9)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(128, 25)
        Me.lblServer.TabIndex = 25
        Me.lblServer.Text = "SERVIDOR"
        '
        'ESCRITORIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(893, 546)
        Me.Controls.Add(Me.lblServer)
        Me.Controls.Add(Me.lblNotificacion)
        Me.Controls.Add(Me.lblIp)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelCONEXION)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.LabelESCRITORIO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ESCRITORIO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ESCRITORIO CLIENTE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonC As RadioButton
    Friend WithEvents RadioButtonZ As RadioButton
    Friend WithEvents LabelCONEXION As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents LabelESCRITORIO As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblIp As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblNotificacion As Label
    Friend WithEvents getDataDB As Timer
    Friend WithEvents lblServer As Label
End Class
