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
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIp = New System.Windows.Forms.TextBox()
        Me.listChatGlobal = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblbloquetrue = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblWebcam = New System.Windows.Forms.Label()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.lblTransferir = New System.Windows.Forms.Label()
        Me.lblBloqueo = New System.Windows.Forms.Label()
        Me.lblApagado = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblServidor = New System.Windows.Forms.Label()
        Me.txtIpServidor = New System.Windows.Forms.TextBox()
        Me.pictureServer = New System.Windows.Forms.PictureBox()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblNotificacion = New System.Windows.Forms.Label()
        Me.timerChatGeneral = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelCONEXION = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.LabelESCRITORIO = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pictureServer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.White
        Me.txtUsuario.Location = New System.Drawing.Point(12, 93)
        Me.txtUsuario.MaxLength = 50
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(149, 26)
        Me.txtUsuario.TabIndex = 1
        Me.txtUsuario.Text = "Ulises"
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(145, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(492, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SOFTWARE MONITOREO CLIENTE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(182, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "IP"
        '
        'txtIp
        '
        Me.txtIp.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtIp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIp.ForeColor = System.Drawing.Color.White
        Me.txtIp.Location = New System.Drawing.Point(167, 93)
        Me.txtIp.MaxLength = 50
        Me.txtIp.Name = "txtIp"
        Me.txtIp.Size = New System.Drawing.Size(149, 26)
        Me.txtIp.TabIndex = 2
        Me.txtIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'listChatGlobal
        '
        Me.listChatGlobal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.listChatGlobal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.listChatGlobal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listChatGlobal.ForeColor = System.Drawing.Color.White
        Me.listChatGlobal.FormattingEnabled = True
        Me.listChatGlobal.ItemHeight = 20
        Me.listChatGlobal.Location = New System.Drawing.Point(12, 125)
        Me.listChatGlobal.Name = "listChatGlobal"
        Me.listChatGlobal.Size = New System.Drawing.Size(304, 264)
        Me.listChatGlobal.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 391)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "MENSAJE"
        '
        'txtMensaje
        '
        Me.txtMensaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMensaje.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.ForeColor = System.Drawing.Color.White
        Me.txtMensaje.Location = New System.Drawing.Point(12, 417)
        Me.txtMensaje.MaxLength = 50
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(304, 65)
        Me.txtMensaje.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.LabelESCRITORIO)
        Me.Panel1.Controls.Add(Me.TextBox8)
        Me.Panel1.Controls.Add(Me.LabelCONEXION)
        Me.Panel1.Controls.Add(Me.lblbloquetrue)
        Me.Panel1.Controls.Add(Me.lblEstado)
        Me.Panel1.Controls.Add(Me.lblWebcam)
        Me.Panel1.Controls.Add(Me.lblMensaje)
        Me.Panel1.Controls.Add(Me.lblTransferir)
        Me.Panel1.Controls.Add(Me.lblBloqueo)
        Me.Panel1.Controls.Add(Me.lblApagado)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblServidor)
        Me.Panel1.Controls.Add(Me.txtIpServidor)
        Me.Panel1.Controls.Add(Me.pictureServer)
        Me.Panel1.Controls.Add(Me.btnConectar)
        Me.Panel1.Location = New System.Drawing.Point(322, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(459, 463)
        Me.Panel1.TabIndex = 17
        Me.Panel1.Visible = False
        '
        'lblbloquetrue
        '
        Me.lblbloquetrue.AutoSize = True
        Me.lblbloquetrue.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbloquetrue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblbloquetrue.Location = New System.Drawing.Point(33, 412)
        Me.lblbloquetrue.Name = "lblbloquetrue"
        Me.lblbloquetrue.Size = New System.Drawing.Size(0, 31)
        Me.lblbloquetrue.TabIndex = 36
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.White
        Me.lblEstado.Location = New System.Drawing.Point(32, 58)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(64, 20)
        Me.lblEstado.TabIndex = 35
        Me.lblEstado.Text = "espera"
        '
        'lblWebcam
        '
        Me.lblWebcam.AutoSize = True
        Me.lblWebcam.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblWebcam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWebcam.ForeColor = System.Drawing.Color.White
        Me.lblWebcam.Location = New System.Drawing.Point(32, 348)
        Me.lblWebcam.Name = "lblWebcam"
        Me.lblWebcam.Size = New System.Drawing.Size(64, 20)
        Me.lblWebcam.TabIndex = 34
        Me.lblWebcam.Text = "espera"
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.White
        Me.lblMensaje.Location = New System.Drawing.Point(32, 290)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(64, 20)
        Me.lblMensaje.TabIndex = 33
        Me.lblMensaje.Text = "espera"
        '
        'lblTransferir
        '
        Me.lblTransferir.AutoSize = True
        Me.lblTransferir.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTransferir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransferir.ForeColor = System.Drawing.Color.White
        Me.lblTransferir.Location = New System.Drawing.Point(32, 232)
        Me.lblTransferir.Name = "lblTransferir"
        Me.lblTransferir.Size = New System.Drawing.Size(64, 20)
        Me.lblTransferir.TabIndex = 32
        Me.lblTransferir.Text = "espera"
        '
        'lblBloqueo
        '
        Me.lblBloqueo.AutoSize = True
        Me.lblBloqueo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblBloqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBloqueo.ForeColor = System.Drawing.Color.White
        Me.lblBloqueo.Location = New System.Drawing.Point(32, 174)
        Me.lblBloqueo.Name = "lblBloqueo"
        Me.lblBloqueo.Size = New System.Drawing.Size(64, 20)
        Me.lblBloqueo.TabIndex = 31
        Me.lblBloqueo.Text = "espera"
        '
        'lblApagado
        '
        Me.lblApagado.AutoSize = True
        Me.lblApagado.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblApagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApagado.ForeColor = System.Drawing.Color.White
        Me.lblApagado.Location = New System.Drawing.Point(32, 116)
        Me.lblApagado.Name = "lblApagado"
        Me.lblApagado.Size = New System.Drawing.Size(64, 20)
        Me.lblApagado.TabIndex = 30
        Me.lblApagado.Text = "espera"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(12, 317)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 24)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "WEBCAM :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(12, 259)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 24)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "MENSAJE :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(12, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 24)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "TRANSFERIR  :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 24)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "BLOQUEAR :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 24)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "APAGAR :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 24)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "ESTADO :"
        '
        'lblServidor
        '
        Me.lblServidor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblServidor.AutoSize = True
        Me.lblServidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServidor.Location = New System.Drawing.Point(224, 5)
        Me.lblServidor.Name = "lblServidor"
        Me.lblServidor.Size = New System.Drawing.Size(103, 20)
        Me.lblServidor.TabIndex = 20
        Me.lblServidor.Text = "SERVIDOR"
        '
        'txtIpServidor
        '
        Me.txtIpServidor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIpServidor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtIpServidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIpServidor.ForeColor = System.Drawing.Color.White
        Me.txtIpServidor.Location = New System.Drawing.Point(172, 221)
        Me.txtIpServidor.MaxLength = 50
        Me.txtIpServidor.Name = "txtIpServidor"
        Me.txtIpServidor.Size = New System.Drawing.Size(274, 26)
        Me.txtIpServidor.TabIndex = 4
        Me.txtIpServidor.Text = "192.168.1.71"
        Me.txtIpServidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pictureServer
        '
        Me.pictureServer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureServer.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pictureServer.Location = New System.Drawing.Point(172, 27)
        Me.pictureServer.Name = "pictureServer"
        Me.pictureServer.Size = New System.Drawing.Size(274, 188)
        Me.pictureServer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureServer.TabIndex = 18
        Me.pictureServer.TabStop = False
        '
        'btnConectar
        '
        Me.btnConectar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConectar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnConectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConectar.ForeColor = System.Drawing.Color.White
        Me.btnConectar.Location = New System.Drawing.Point(182, 253)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(248, 41)
        Me.btnConectar.TabIndex = 5
        Me.btnConectar.Text = "CONECTAR"
        Me.btnConectar.UseVisualStyleBackColor = False
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(8, 9)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(65, 20)
        Me.lblCliente.TabIndex = 18
        Me.lblCliente.Text = "Cliente"
        '
        'lblNotificacion
        '
        Me.lblNotificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNotificacion.AutoSize = True
        Me.lblNotificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotificacion.ForeColor = System.Drawing.Color.White
        Me.lblNotificacion.Location = New System.Drawing.Point(12, 489)
        Me.lblNotificacion.Name = "lblNotificacion"
        Me.lblNotificacion.Size = New System.Drawing.Size(120, 20)
        Me.lblNotificacion.TabIndex = 19
        Me.lblNotificacion.Text = "notificaciones"
        '
        'timerChatGeneral
        '
        Me.timerChatGeneral.Interval = 3000
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'LabelCONEXION
        '
        Me.LabelCONEXION.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCONEXION.AutoSize = True
        Me.LabelCONEXION.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCONEXION.ForeColor = System.Drawing.Color.Black
        Me.LabelCONEXION.Location = New System.Drawing.Point(238, 308)
        Me.LabelCONEXION.Name = "LabelCONEXION"
        Me.LabelCONEXION.Size = New System.Drawing.Size(147, 18)
        Me.LabelCONEXION.TabIndex = 20
        Me.LabelCONEXION.Text = "DESCONECTADO"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox8.Location = New System.Drawing.Point(182, 360)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox8.Size = New System.Drawing.Size(222, 29)
        Me.TextBox8.TabIndex = 35
        Me.TextBox8.Visible = False
        '
        'LabelESCRITORIO
        '
        Me.LabelESCRITORIO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelESCRITORIO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelESCRITORIO.Location = New System.Drawing.Point(13, 401)
        Me.LabelESCRITORIO.Name = "LabelESCRITORIO"
        Me.LabelESCRITORIO.Size = New System.Drawing.Size(433, 51)
        Me.LabelESCRITORIO.TabIndex = 37
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(793, 518)
        Me.Controls.Add(Me.lblNotificacion)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.listChatGlobal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLIENTE PRINCIAL"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pictureServer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIp As TextBox
    Friend WithEvents listChatGlobal As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblServidor As Label
    Friend WithEvents txtIpServidor As TextBox
    Friend WithEvents pictureServer As PictureBox
    Friend WithEvents btnConectar As Button
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblNotificacion As Label
    Friend WithEvents timerChatGeneral As Timer
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblWebcam As Label
    Friend WithEvents lblMensaje As Label
    Friend WithEvents lblTransferir As Label
    Friend WithEvents lblBloqueo As Label
    Friend WithEvents lblApagado As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblbloquetrue As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelCONEXION As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents LabelESCRITORIO As Label
End Class
