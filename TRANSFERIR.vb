Imports System.IO
Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Public Class TRANSFERIR

    Dim YO As New TcpClient
    Dim NS As NetworkStream
    Private Sub TRANSFERIR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarme()
        'CARGA SI LA HAY LA RUTA CON LA QUE SE CONECTO POR ULTIMA VEZ
        Try
            TextBoxRUTA.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\RUTA.txt")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonRUTA_Click(sender As Object, e As EventArgs) Handles ButtonRUTA.Click
        'DONDE GUARDARA LOS ARCHIVOS QUE RECIBA
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBoxRUTA.Text = FolderBrowserDialog1.SelectedPath & "\"
        End If
    End Sub

    Private Sub ButtonCONECTAR_Click(sender As Object, e As EventArgs) Handles ButtonCONECTAR.Click
        If TextBoxRUTA.Text <> "" Then 'SI SE HA ELEGIDO RUTA DE DESCARGA
            'INICIA LA CONEXION
            Try
                YO.Connect(TextBoxIP.Text, TextBoxPUERTO.Text)
                Timer1.Interval = 3000
                Timer1.Start()
                TextBoxRUTA.ReadOnly = True
                ButtonRUTA.Visible = False
                ButtonCONECTAR.Visible = False
                LabelTRANSMISION.Text = "CONECTADO"
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\RUTA.txt", TextBoxRUTA.Text, False)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else 'SI NO SE HA ELEGIDO RUTA DE DESCARGA
            MsgBox("FALTA RUTA DONDE GUARDAR LOS ARCHIVOS") 'CIERRA LA CONEXION
        End If
    End Sub

    Private Sub ButtonELEGIR_Click(sender As Object, e As EventArgs) Handles ButtonELEGIR.Click
        'ELIGE EL ARCHIVO Y CREA UN ARRAY DE BYTES
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBoxARCHIVO.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ButtonENVIAR_Click(sender As Object, e As EventArgs) Handles ButtonENVIAR.Click
        Dim BF As New BinaryFormatter
        Try
            'ENVIA EL NOMBRE ARCHIVO
            Dim NOMBRE As String = TextBoxARCHIVO.Text
            NOMBRE = NOMBRE.Remove(0, NOMBRE.LastIndexOf("\") + 1)
            Dim ARCHIVO As Byte() = Nothing
            ARCHIVO = Encoding.UTF7.GetBytes(NOMBRE)
            NS = YO.GetStream
            BF.Serialize(NS, ARCHIVO)
            Threading.Thread.Sleep(1000) 'PARA SEPARAR EL ENVIO DEL NOMBRE DEL ENVIO DEL ARCHIVO
            'ENVIA EL ARCHIVO
            Dim MEMORIA As Byte() = File.ReadAllBytes(TextBoxARCHIVO.Text)
            NS = YO.GetStream
            BF.Serialize(NS, MEMORIA)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Get status client
        ejecutar("SELECT transferir FROM control WHERE ipUsuario = '" & Form1.txtIp.Text & "' AND nombreUsuario = '" & Form1.txtUsuario.Text & "' LIMIT 1")
        If leerRene.Read() Then
            If leerRene(0).ToString() = "0" Then
                lblNotificacion.Text = "DESACTIVADO"
                Try
                    NS.Dispose()
                    YO.Close()
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
        'RECEPCION DE ARCHIVOS
        Dim BF As New BinaryFormatter
        Try
            If NS.DataAvailable Then
                If LabelESTADO.Text = "ESTADO" Or LabelESTADO.Text = "GUARDADO OK" Then
                    BF = New BinaryFormatter
                    LabelESTADO.Text = Encoding.UTF7.GetString(BF.Deserialize(NS))
                    LabelNOMBRE.Text = LabelESTADO.Text
                    LabelESTADO.Text = "DESCARGANDO..."
                Else
                    BF = New BinaryFormatter
                    Dim RECIBIDO As Byte() = BF.Deserialize(NS)
                    File.WriteAllBytes(TextBoxRUTA.Text & LabelNOMBRE.Text, RECIBIDO)
                    LabelESTADO.Text = "GUARDADO OK"
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class