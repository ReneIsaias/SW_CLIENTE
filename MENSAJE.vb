Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary
Public Class MENSAJE

    Dim YO2 As New TcpClient
    Dim NS2 As NetworkStream

    Private Sub MENSAJE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarme()
        Try
            YO2.Connect(Form1.txtIpServidor.Text, Form1.PortMensaje)
            Timer1.Interval = 3000
            Timer1.Start()
            RichTextBoxRECIBIDO.SelectionColor = Color.Red
            RichTextBoxRECIBIDO.AppendText("CONECTADO" & vbCrLf)
            RichTextBoxRECIBIDO.ScrollToCaret()
            TextBoxMENSAJE.Focus()
            Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Size.Width, 200)
        Catch ex As Exception
            ' MsgBox(ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub TextBoxMENSAJE_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxMENSAJE.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim ENVIO As Byte() = System.Text.Encoding.UTF7.GetBytes(TextBoxMENSAJE.Text)
                NS2 = YO2.GetStream()
                Dim BF2 As New BinaryFormatter
                BF2.Serialize(NS2, ENVIO)
                RichTextBoxRECIBIDO.SelectionColor = Color.Black
                RichTextBoxRECIBIDO.AppendText("YO : " & TextBoxMENSAJE.Text & vbCrLf)
                RichTextBoxRECIBIDO.ScrollToCaret()
                TextBoxMENSAJE.Clear()
                e.SuppressKeyPress = True
            End If
        Catch ex As Exception
            TextBoxMENSAJE.Clear()
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            ' MsgBox("SERVIDOR DESCONECTADO")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Get status client
        ejecutar("SELECT mensaje FROM control WHERE ipUsuario = '" & Form1.txtIp.Text & "' AND nombreUsuario = '" & Form1.txtUsuario.Text & "' LIMIT 1")
        If leerRene.Read() Then
            If leerRene(0).ToString() = "0" Then
                lblNotificacion.Text = "DESACTIVADO"
                Try
                    NS2.Dispose()
                    YO2.Close()
                Catch ex As Exception
                End Try
                Timer1.Stop()
                Close()
            Else
                lblNotificacion.Text = "ACTIVADO"
            End If
        End If
        leerRene.Close()
        'OTROS SERVICIOS
        Dim BF2 As New BinaryFormatter
        Try
            NS2 = YO2.GetStream
            If NS2.DataAvailable Then
                Dim MENSAJE As String = System.Text.Encoding.UTF7.GetString(BF2.Deserialize(NS2))
                RichTextBoxRECIBIDO.SelectionColor = Color.White
                RichTextBoxRECIBIDO.AppendText("Servidor : " & MENSAJE & vbCrLf)
                RichTextBoxRECIBIDO.ScrollToCaret()
            End If
        Catch ex As Exception
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            '  MsgBox("DESCONECTADO")
        End Try
    End Sub
End Class