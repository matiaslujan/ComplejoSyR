Imports System.Data
Imports System.Data.SqlClient

Public Class ServicioClass

    Inherits ConexionClass

    Private Id_ As Integer

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Private IdReserva_ As Integer

    Public Property IdReserva() As Integer
        Get
            Return IdReserva_
        End Get
        Set(ByVal value As Integer)
            IdReserva_ = value
        End Set
    End Property

    Private Fecha_ As Date

    Public Property Fecha() As Date
        Get

            Return Fecha_
        End Get
        Set(ByVal value As Date)
            Fecha_ = value
        End Set
    End Property

    Private Importe_ As Decimal

    Public Property Importe() As Decimal
        Get
            Return Importe_
        End Get
        Set(ByVal value As Decimal)
            Importe_ = value
        End Set
    End Property

    Private Descripcion_ As String

    Public Property Descripcion() As String
        Get
            Return Descripcion_
        End Get
        Set(ByVal value As String)
            Descripcion_ = value
        End Set
    End Property

    Private Accion_ As String
    Public Property Accion() As String
        Get
            Return Accion_
        End Get
        Set(ByVal value As String)
            Accion_ = value
        End Set
    End Property

    Public Sub actualizar(ByRef lst As List(Of ServicioClass))

        Try
            Conectar()

            For Each row In lst

                Select Case row.Accion

                    Case "Agregar"

                        Dim comando As New SqlCommand("ServicioAgregar", conexion)
                        comando.CommandType = CommandType.StoredProcedure

                        comando.Parameters.AddWithValue("@IdReserva", row.IdReserva)
                        comando.Parameters.AddWithValue("@Importe", row.Importe)
                        comando.Parameters.AddWithValue("@Descripcion", row.Descripcion)
                        comando.Parameters.AddWithValue("@Fecha", row.Fecha)

                        comando.ExecuteNonQuery()

                    Case "Modificar"

                        Dim comando As New SqlCommand("ServicioModificar", conexion)
                        comando.CommandType = CommandType.StoredProcedure

                        comando.Parameters.AddWithValue("@IdReserva", row.IdReserva)
                        comando.Parameters.AddWithValue("@Importe", row.Importe)
                        comando.Parameters.AddWithValue("@Descripcion", row.Descripcion)
                        comando.Parameters.AddWithValue("@Fecha", row.Fecha)
                        comando.Parameters.AddWithValue("@Id", row.Id)

                        comando.ExecuteNonQuery()

                    Case "Eliminar"

                        Dim comando As New SqlCommand("ServicioEliminar", conexion)

                        comando.CommandType = CommandType.StoredProcedure

                        comando.Parameters.AddWithValue("@Id", row.Id)

                        comando.ExecuteNonQuery()


                End Select
       

            Next
            Desconectar()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub
    Public Sub Traer(ByRef lst As List(Of ServicioClass), ByVal id As Integer)

        Conectar()

        Dim comando As New SqlCommand("ServicioTraer", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@IdReserva", id)


        Dim lista As SqlDataReader = comando.ExecuteReader

        If lista.HasRows Then

            For Each row In lista

                Dim servicio As New ServicioClass

                servicio.Id = (lista("Id"))
                servicio.Descripcion = (lista("Descripcion"))
                servicio.Fecha = (lista("Fecha"))
                servicio.Importe = (lista("Importe"))
                servicio.IdReserva = (lista("IdReserva"))
                lst.Add(servicio)

            Next

        End If

        Desconectar()

    End Sub


    Public Sub Agregar(ByVal serv As ServicioClass)

        Conectar()

        Dim comando As New SqlCommand("ServicioAgregar", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@IdReserva", serv.IdReserva)
        comando.Parameters.AddWithValue("@Fecha", serv.Fecha)
        comando.Parameters.AddWithValue("@Importe", serv.Importe)
        comando.Parameters.AddWithValue("@Descripcion", serv.Descripcion)

        comando.ExecuteNonQuery()

        Desconectar()

    End Sub

    Public Sub Modificar(ByVal serv As ServicioClass)
        Conectar()

        Dim comando As New SqlCommand("ServicioModificar", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@IdReserva", serv.IdReserva)
        comando.Parameters.AddWithValue("@Fecha", serv.Fecha)
        comando.Parameters.AddWithValue("@Importe", serv.Importe)
        comando.Parameters.AddWithValue("@Descripcion", serv.Descripcion)
        comando.Parameters.AddWithValue("@Id", serv.Id)

        comando.ExecuteNonQuery()

        Desconectar()

    End Sub

    Public Sub Eliminar(ByVal id As Integer)

        Conectar()

        Dim comando As New SqlCommand("ServicioEliminar", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@Id", id)
        comando.ExecuteNonQuery()

        Desconectar()

    End Sub
    Public Sub SubTotal(ByVal txt As TextBox, ByVal id As Integer)

        Conectar()


        Dim comando As New SqlCommand("ReservaImportes", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@Id", id)

        Dim lista As SqlDataReader = comando.ExecuteReader

        If lista.HasRows Then

            While lista.Read()


                txt.Text = (lista("Servicios"))


            End While

        End If

        Desconectar()
    End Sub
End Class
