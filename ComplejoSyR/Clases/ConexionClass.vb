Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient


Public Class ConexionClass


    Private strConexion_ As String
    Private objConexion_ As SqlConnection
    Private servidor_ As String
    Private baseDatos_ As String
    Private usuario_ As String
    Private password_ As String
    Private miConfiguracion As ConfiguracionConexion

    Public Sub New()
        miConfiguracion = New ConfiguracionConexion
        servidor_ = miConfiguracion.servidorSQL
        baseDatos_ = miConfiguracion.baseDatosSQL
        usuario_ = miConfiguracion.usuarioSQL
        password_ = miConfiguracion.passwordSQL
    End Sub

    Protected Property strConexion() As String
        Get
            Return strConexion_
        End Get
        Set(ByVal value As String)
            strConexion_ = value
        End Set
    End Property

    Protected Property Conexion() As SqlConnection
        Get
            Return objConexion_
        End Get
        Set(ByVal value As SqlConnection)
            objConexion_ = value
        End Set
    End Property

    Protected Property servidor() As String
        Get
            Return servidor_
        End Get
        Set(ByVal value As String)
            servidor_ = value
        End Set
    End Property

    Protected Property baseDatos() As String
        Get
            Return baseDatos_
        End Get
        Set(ByVal value As String)
            baseDatos_ = value
        End Set
    End Property

    Protected Property usuario() As String
        Get
            Return usuario_
        End Get
        Set(ByVal value As String)
            usuario_ = value
        End Set
    End Property

    Protected Property password() As String
        Get
            Return password_
        End Get
        Set(ByVal value As String)
            password_ = value
        End Set
    End Property
    Private intsecurity_ As Boolean = False
    Public Property intsecurity() As Boolean
        Get
            Return intsecurity_
        End Get
        Set(ByVal value As Boolean)
            intsecurity_ = value
        End Set
    End Property
    Protected Function Conectar()
        Try

            If usuario_ = "" And password_ = "" Then
                strConexion = "Data Source=" & servidor_ & "; DataBase=" & baseDatos_ & "; Trusted_Connection=True"
            Else
                strConexion = "Data Source=" & servidor_ & "; DataBase=" & baseDatos_ & "; user=" & usuario_ & "; password=" & password_
            End If
            Conexion = New SqlConnection(strConexion)
            Conexion.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Protected Function Desconectar()
        Try
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
