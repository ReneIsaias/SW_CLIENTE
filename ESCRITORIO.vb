Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary
Public Class ESCRITORIO

    Dim YO As New TcpClient
    Dim NS As NetworkStream
    Dim PANTALLA As String

    Private Sub ESCRITORIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarme()
        getDataDB.Start()
        'inicio servicio
        conectarServicio()

        If RadioButtonZ.Checked Then
            PANTALLA = "ZONA"
        ElseIf RadioButtonC.Checked Then
            PANTALLA = "COMPLETA"
        End If
    End Sub
    Public Sub conectarServicio()
        Try
            YO.Connect(Form1.txtIpServidor.Text, Form1.PortEscritorio)
            Timer1.Interval = NumericUpDown1.Value * 1000
            Timer1.Start()
            LabelCONEXION.Text = "CONECTADO"
            If PANTALLA = "COMPLETA" Then
                Me.WindowState = FormWindowState.Minimized
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Timer1.Interval = NumericUpDown1.Value * 1000
    End Sub

    Private Sub RadioButtonZ_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonZ.CheckedChanged
        If RadioButtonZ.Checked Then
            PANTALLA = "ZONA"
        ElseIf RadioButtonC.Checked Then
            PANTALLA = "COMPLETA"
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub

    Private Sub RadioButtonC_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonC.CheckedChanged
        If RadioButtonZ.Checked Then
            PANTALLA = "ZONA"
        ElseIf RadioButtonC.Checked Then
            PANTALLA = "COMPLETA"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
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

    Private Sub getDataDB_Tick(sender As Object, e As EventArgs) Handles getDataDB.Tick
        Try
            lblNombre.Text = Form1.txtUsuario.Text
            lblIp.Text = Form1.txtIp.Text
            lblNotificacion.Text = Form1.txtIpServidor.Text
            'Get status client
            ejecutar("SELECT estadoUsuario FROM control WHERE ipUsuario = '" & Form1.txtIp.Text & "' AND nombreUsuario = '" & Form1.txtUsuario.Text & "' LIMIT 1")
            If leerRene.Read() Then
                If leerRene(0).ToString() = "0" Then
                    lblNotificacion.Text = "DESACTIVADO"
                    'Detener otros servicios
                    Try
                        NS.Dispose()
                        YO.Close()
                    Catch ex As Exception
                    End Try
                    Timer1.Stop()
                    getDataDB.Stop()
                    Close()
                Else
                    lblNotificacion.Text = "ACTIVADO"
                End If
            End If
            leerRene.Close()
        Catch ex As Exception
            MsgBox("Error al obtener los datos : " & ex.Message())
        End Try
    End Sub
End Class