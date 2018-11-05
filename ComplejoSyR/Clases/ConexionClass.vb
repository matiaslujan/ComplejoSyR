Imports System.Data
Imports System.Data.SqlClient

Public Class ConexionClass

    Private conexion_ As New SqlConnection

    Public Property conexion() As SqlConnection
        Get
            Return conexion_
        End Get
        Set(ByVal value As SqlConnection)
            conexion_ = value
        End Set
    End Property
    Private strConexion_ As String
    Public Property strConexion() As String
        Get
            Return strConexion_
        End Get
        Set(ByVal value As String)
            strConexion_ = value
        End Set
    End Property
    Private servidor_ As String
    Public Property servidor() As String
        Get
            Return servidor_
        End Get
        Set(ByVal value As String)
            servidor_ = value
        End Set
    End Property
    Private usuario_ As String
    Public Property usuario() As String
        Get
            Return usuario_
        End Get
        Set(ByVal value As String)
            usuario_ = value
        End Set
    End Property
    Private basededatos_ As String
    Public Property basededatos() As String
        Get
            Return basededatos_
        End Get
        Set(ByVal value As String)
            basededatos_ = value
        End Set
    End Property
    Private password_ As String
    Public Property password() As String
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
    Public Sub New()

        servidor = "LAPTOP-K16JEHVE\DEVELOPER"
        basededatos = "complejosolyrio"
        usuario = ""
        password = ""

        If usuario = "" And password = "" Then

            intsecurity = True

        End If
    End Sub
    Public Sub Conectar()
        Try

    
            strConexion_ = "Server=" & servidor & ";Database=" & basededatos & ";Trusted_connection=true;"

            conexion.ConnectionString = strConexion_

            conexion.Open()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub Desconectar()
   
        Try
            conexion.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub
End Class
