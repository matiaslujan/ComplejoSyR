Imports System.Data.SqlClient

Public Class PagoClass
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

    Private Descripcion_ As String

    Public Property Descripcion() As String
        Get
            Return Descripcion_
        End Get
        Set(ByVal value As String)
            Descripcion_ = value
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
    Private accion_ As String
    Public Property accion() As String
        Get
            Return accion_
        End Get
        Set(ByVal value As String)
            accion_ = value
        End Set
    End Property
    'Public Sub Traer(ByVal lst As List(Of PagoClass), ByVal IdReserva As Integer)
    '    Try
    '        Conectar()

    '        Dim comando As New SqlCommand("PagosTraer", conexion)

    '        comando.CommandType = CommandType.StoredProcedure

    '        comando.Parameters.AddWithValue("@IdReserva", IdReserva)


    '        Dim lista As SqlDataReader = comando.ExecuteReader

    '        If lista.HasRows Then

    '            For Each row In lista

    '                Dim pago As New PagoClass

    '                pago.Id = (lista("Id"))
    '                pago.Descripcion = (lista("Descripcion"))
    '                pago.Fecha = (lista("Fecha"))
    '                pago.Importe = (lista("Importe"))
    '                pago.IdReserva = (lista("IdReserva"))
    '                lst.Add(pago)

    '            Next

    '        End If


    '    Catch ex As Exception

    '        MsgBox(ex.Message)
    '    Finally
    '        Desconectar()
    '    End Try

    'End Sub

    Public Sub Actualizar(ByRef lst As List(Of PagoClass))
        Try
            Conectar()

            For Each row In lst

                Select Case row.accion

                    Case "Agregar"

                        Dim comando As New SqlCommand("PagoAgregar", conexion)
                        comando.CommandType = CommandType.StoredProcedure

                        comando.Parameters.AddWithValue("@IdReserva", row.IdReserva)
                        comando.Parameters.AddWithValue("@Importe", row.Importe)
                        comando.Parameters.AddWithValue("@Descripcion", row.Descripcion)
                        comando.Parameters.AddWithValue("@Fecha", row.Fecha)

                        comando.ExecuteNonQuery()

                    Case "Modificar"

                        Dim comando As New SqlCommand("PagoModificar", conexion)
                        comando.CommandType = CommandType.StoredProcedure

                        comando.Parameters.AddWithValue("@IdReserva", row.IdReserva)
                        comando.Parameters.AddWithValue("@Importe", row.Importe)
                        comando.Parameters.AddWithValue("@Descripcion", row.Descripcion)
                        comando.Parameters.AddWithValue("@Fecha", row.Fecha)
                        comando.Parameters.AddWithValue("@Id", row.Id)

                        comando.ExecuteNonQuery()

                    Case "Eliminar"

                        Dim comando As New SqlCommand("PagoEliminar", conexion)

                        comando.CommandType = CommandType.StoredProcedure

                        comando.Parameters.AddWithValue("@Id", row.Id)

                        comando.ExecuteNonQuery()


                End Select
   
            Next


        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try

    End Sub

End Class
