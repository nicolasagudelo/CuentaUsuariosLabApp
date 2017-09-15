Imports System.Data.OleDb
Imports System.Configuration

Public Class Form1
    Implements IMessageFilter
    Dim comando As OleDbCommand
    Dim Adaptador As OleDbDataAdapter
    Dim Constructor As OleDbCommandBuilder

    Dim conexionstring As String = ("Provider=Microsoft.Jet.OLEDB.4.0;" & ConfigurationSettings.AppSettings("Key1"))
    Dim Oledb As String
    Dim conexion As New OleDbConnection(conexionstring)
    Dim numero_usuarios As Integer

    Public Sub New()
        InitializeComponent()
        Application.AddMessageFilter(Me)
        Timer1.Enabled = True
    End Sub

    Public Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
        'Reinicio del timer cuando se detecta uso del teclado o mouse
        If (m.Msg >= &H100 And m.Msg <= &H109) Or (m.Msg >= &H200 And m.Msg <= &H20E) Then
            Timer1.Stop()
            Timer1.Start()
        End If
        Return Nothing
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Timer1.Stop()
        contador = 0
        ContarUsuarios()
        RevisarEstado(numero_usuarios)
        TabControl1.SelectedIndex = 0
        LblInfo.Text = "Personas en el laboratorio:"
        LblNumero.Text = contador
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.MinimumSize = Screen.PrimaryScreen.WorkingArea.Size
        ContarUsuarios()
        RevisarEstado(numero_usuarios)
        LblInfo.Text = "Personas en el laboratorio:"
        LblNumero.Text = contador
    End Sub

    Public Sub ContarUsuarios()

        Try
            Oledb = "SELECT count (USERID) as c
                    from USERINFO;"
            conexion.Open()
            comando = New OleDbCommand(Oledb, conexion)
            numero_usuarios = comando.ExecuteScalar
            conexion.Close()
        Catch ex As Exception
            MsgBox("No se pudo obtener el numero de usuarios del sistema", False, "Error")
            conexion.Close()
            End
        End Try
    End Sub



    Dim contador As Integer = 0

    Public Sub RevisarEstado(usuarios)

        Dim nombres(usuarios) As String
        Dim estado(usuarios) As Integer
        Dim tarjetas(usuarios) As String

        Dim x1 As Integer = 26
        Dim y1 As Integer = 20
        Dim x2 As Integer = 26
        Dim y2 As Integer = 20

        For i = 1 To usuarios
            Try
                Oledb = "Select name from USERINFO
                        where USERID = " & i + 4 & ";"
                conexion.Open()
                comando = New OleDbCommand(Oledb, conexion)
                nombres(i) = comando.ExecuteScalar
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message, False, "Error")
                conexion.Close()
                Exit Sub
            End Try
            Try
                Oledb = "Select CardNo from USERINFO
                        where name = '" & nombres(i) & "';"
                conexion.Open()
                comando = New OleDbCommand(Oledb, conexion)
                tarjetas(i) = comando.ExecuteScalar
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message, False, "Error")
                conexion.Close()
                Exit Sub
            End Try

            Try
                Oledb = "select  top 1 event_point_id
                from acc_monitor_log
                where card_no = '" & tarjetas(i) & "' and device_name = '192.168.1.203' and event_point_id in (1,2)
                order by -time; "
                conexion.Open()
                comando = New OleDbCommand(Oledb, conexion)
                'Adaptador = New OleDbDataAdapter(comando)
                estado(i) = comando.ExecuteScalar
                conexion.Close()
                If estado(i) = Nothing Then
                    estado(i) = 2
                End If
            Catch ex As Exception
                MsgBox(ex.Message, False, "Error")
                conexion.Close()
                Exit Sub
            End Try

            'Debug.WriteLine(nombres(i), tarjetas(i))
            'Debug.WriteLine(estado(i))
            Dim j As Integer = 0
            Dim labels(usuarios)
            If estado(i) = 1 Then
                contador += 1
                labels(j) = New Label
                labels(j).AutoSize = True
                labels(j).Location = New Point(x1, y1)
                labels(j).Text = nombres(i)
                labels(j).Width = 60
                labels(j).Height = 15
                labels(j).forecolor = Color.Black
                labels(j).Visible = True
                labels(j).BorderStyle = BorderStyle.Fixed3D
                labels(j).font = New Font("Arial", 12, FontStyle.Bold)
                labels(j).parent = Me.UsuarioEnLab
                If labels(j).text = "prueba" Or labels(j).text = "BACKUP" Then
                    labels(j).visible = False
                    y2 -= 40
                    contador -= 1
                End If
                y1 += 40
                If y1 > 590 Then
                    x1 += 150
                    y1 = 20
                End If
                j += 1
            End If

                Dim k As Integer = 0
            Dim labels2(usuarios)
            If estado(i) = 2 Then
                labels2(k) = New Label
                labels2(k).AutoSize = True
                labels2(k).Location = New Point(x2, y2)
                labels2(k).Text = nombres(i)
                labels2(k).Width = 60
                labels2(k).Height = 15
                labels2(k).forecolor = Color.Black
                labels2(k).Visible = True
                labels2(k).BorderStyle = BorderStyle.Fixed3D
                labels2(k).font = New Font("Arial", 12, FontStyle.Bold)
                labels2(k).parent = Me.UsuariosNoEnLab
                If labels2(k).text = "prueba" Or labels2(k).text = "BACKUP" Then
                    labels2(k).visible = False
                    y2 -= 40
                End If
                y2 += 40
                If y2 > 590 Then
                    x2 += 150
                    y2 = 20
                End If
                k += 1
            End If

        Next

    End Sub
    Dim pest_actual As Integer
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is UsuarioEnLab Then
            pest_actual = 1
            LblInfo.Text = "Personas en el laboratorio: " & contador
            LblNumero.Visible = True
        Else
            pest_actual = 2
            LblNumero.Visible = False
            LblInfo.Text = "Personas fuera del laboratorio"
        End If
    End Sub
End Class
