Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Module CONEXION
    Public strConection = "SERVER = 192.168.1.71; DATABASE = softwaremonitoreo; USER = root; PASSWORD = maquiabelico;"
    Public consultaRene As MySqlCommand
    Public leerRene As MySqlDataReader
    Public conexionRene As MySqlConnection

    Public Sub conectarme()
        Dim conectar As MySqlConnection
        conectar = New MySqlConnection(strConection)
        conectar.Open()
        'MsgBox("Conexion establecida")
        consultaRene = New MySqlCommand()
        consultaRene.Connection = conectar
    End Sub

    Public Sub ejecutar(ByVal sqlMio As String)
        consultaRene.CommandText = sqlMio
        leerRene = consultaRene.ExecuteReader()
    End Sub
    Public Sub llenaCombo(ByVal comboRene As ComboBox, ByVal sqlComboRene As String)
        ejecutar(sqlComboRene)
        comboRene.Items.Clear()
        While leerRene.Read()
            comboRene.Items.Add(leerRene(0))
        End While
        leerRene.Close()
    End Sub
    Public Sub llenaLista(ByVal listaRene As ListBox, ByVal sqlRene As String)
        ejecutar(sqlRene)
        listaRene.Items.Clear()
        While leerRene.Read()
            listaRene.Items.Add(leerRene(0).ToString())
        End While
        leerRene.Close()
        ' listaRene.SetSelected(listaRene.Items.Count - 1, True)
    End Sub

    Public Sub llenaRicht(ByVal richtRene As RichTextBox, ByVal sqlRene As String)
        ejecutar(sqlRene)
        richtRene.Clear()
        While leerRene.Read()
            richtRene.AppendText(leerRene(0).ToString())
        End While
        leerRene.Close()
        richtRene.ScrollToCaret()
    End Sub
    Public Sub llenaCuadricula(ByVal tablaRene As DataGridView, ByVal sqlReneTabla As String)
        ejecutar(sqlReneTabla)
        leerRene.Close()
        Dim cuadriculaRene As DataSet
        cuadriculaRene = New DataSet
        Dim datador As MySqlDataAdapter
        datador = New MySqlDataAdapter(consultaRene)
        datador.Fill(cuadriculaRene, "DATOS")
        tablaRene.DataSource = cuadriculaRene
        tablaRene.DataMember = "DATOS"
    End Sub
    Public Sub llenaListBox(ByVal listaRene As ListBox, ByVal sqlReneList As String)
        ejecutar(sqlReneList)
        listaRene.Items.Clear()
        While (leerRene.Read())
            listaRene.Items.Add(leerRene(0))
        End While
        leerRene.Close()
    End Sub
    Public Sub llenaCheckList(ByVal checkRene As CheckedListBox, ByVal sqlReneCheck As String)
        ejecutar(sqlReneCheck)
        checkRene.Items.Clear()
        While (leerRene.Read())
            checkRene.Items.Add(leerRene(0))
        End While
        leerRene.Close()
    End Sub
End Module