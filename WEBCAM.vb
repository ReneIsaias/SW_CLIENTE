Imports System.Runtime.InteropServices
Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary
Public Class WEBCAM

    Dim YO As New TcpClient
    Dim NS As NetworkStream
    Dim CALIDAD As String

    Public Const WM_CAP As Short = &H400S
    Public Const WM_CAP_DLG_VIDEOFORMAT As Integer = WM_CAP + 41
    Public Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Public Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Public Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30
    Public Const WM_CAP_SEQUENCE As Integer = WM_CAP + 62
    Public Const WM_CAP_FILE_SAVEAS As Integer = WM_CAP + 23
    Public Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Public Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Public Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Public Const WS_CHILD As Integer = &H40000000
    Public Const WS_VISIBLE As Integer = &H10000000
    Public Const SWP_NOMOVE As Short = &H2S
    Public Const SWP_NOSIZE As Short = 1
    Public Const SWP_NOZORDER As Short = &H4S
    Public Const HWND_BOTTOM As Short = 1
    Public Const WM_CAP_STOP As Integer = WM_CAP + 68

    Public iDevice As Integer = 0
    Public hHwnd As Integer

    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer,
        <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Public Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer,
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer,
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Public Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    Public Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer,
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer,
        ByVal nHeight As Short, ByVal hWndParent As Integer,
        ByVal nID As Integer) As Integer

    Public Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short,
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String,
        ByVal cbVer As Integer) As Boolean

    Public Sub OpenPreviewWindow()
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, 480, PictureBoxVISOR.Handle.ToInt32, 0)
        Dim CONTADOR As Integer = 0
        For I = 1 To 10
            Dim CONECTADO As Integer = SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0)
            If CONECTADO = 1 Then
                SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)
                SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)
                SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)
                SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, PictureBoxVISOR.Width, PictureBoxVISOR.Height, SWP_NOMOVE Or SWP_NOZORDER)
                Exit For
            End If
            CONTADOR = I
        Next
        If CONTADOR = 10 Then
            DestroyWindow(hHwnd)
            MsgBox("NO PUEDO CONECTAR LA CAMARA")
        End If
    End Sub

    Private Sub WEBCAM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarme()
        'inicio servicios
        Try
            OpenPreviewWindow()
            iniciaService()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If RadioButtonB.Checked Then
            CALIDAD = "BAJA"
        ElseIf RadioButtonA.Checked Then
            CALIDAD = "ALTA"
        End If
    End Sub

    Private Sub RadioButtonB_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonB.CheckedChanged
        If RadioButtonB.Checked Then
            CALIDAD = "BAJA"
        ElseIf RadioButtonA.Checked Then
            CALIDAD = "ALTA"
        End If
    End Sub

    Private Sub RadioButtonA_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonA.CheckedChanged
        If RadioButtonB.Checked Then
            CALIDAD = "BAJA"
        ElseIf RadioButtonA.Checked Then
            CALIDAD = "ALTA"
        End If
    End Sub

    Private Sub ButtonCONECTAR_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub iniciaService()
        Try
            YO.Connect(Form1.txtIpServidor.Text, Form1.PortWebcam)
            Timer1.Interval = CInt(1000 / NumericUpDown1.Value)
            Timer1.Start()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Get status client
        ejecutar("SELECT webcam FROM control WHERE ipUsuario = '" & Form1.txtIp.Text & "' AND nombreUsuario = '" & Form1.txtUsuario.Text & "' LIMIT 1")
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
        Dim BF As New BinaryFormatter
        Try
            NS = YO.GetStream
            If NS.DataAvailable Then
                PictureBoxREMOTO.Image = BF.Deserialize(NS)
            End If
        Catch ex As Exception
            ' MsgBox("EMISOR RECIBIR")
        End Try
        Try
            If CALIDAD = "ALTA" Then
                SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)
                Dim DATOS = Clipboard.GetDataObject
                Dim IMAGEN As Image = CType(DATOS.GetData(GetType(Bitmap)), Image)
                NS = YO.GetStream
                BF.Serialize(NS, IMAGEN)
            Else
                Dim IMAGEN As Bitmap
                IMAGEN = New Bitmap(PictureBoxVISOR.Width, PictureBoxVISOR.Height)
                Dim DIBUJO As Graphics = Graphics.FromImage(IMAGEN)
                DIBUJO.CopyFromScreen(Me.Location.X + PictureBoxVISOR.Location.X + 8,
                                      Me.Location.Y + PictureBoxVISOR.Location.Y + 30, 0, 0, PictureBoxVISOR.Size)
                NS = YO.GetStream
                BF.Serialize(NS, IMAGEN)
            End If
        Catch ex As Exception
            ' MsgBox("EMISOR ENVIAR")
        End Try
    End Sub
End Class