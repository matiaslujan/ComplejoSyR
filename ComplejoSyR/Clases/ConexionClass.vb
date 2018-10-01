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

    Public Sub Conectar()
        Try

            conexion.ConnectionString = "Server=LAPTOP-K16JEHVE\DEVELOPER;Database=complejosolyrio;Trusted_connection=true;"

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
