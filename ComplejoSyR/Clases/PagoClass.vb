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

    Private Importe_ As Decimal

    Public Property Importe() As Decimal
        Get
            Return Importe_
        End Get
        Set(ByVal value As Decimal)
            Importe_ = value
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

    Public Sub Traer(ByVal dgv As DataGridView, ByVal IdReserva As Integer)

        Conectar()

        Dim comando As New SqlCommand("PagosTraer", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@IdReserva", IdReserva)

        Dim table As New Data.DataTable

        Dim adapter As New SqlDataAdapter(comando)

        adapter.Fill(table)

        dgv.DataSource = table
        dgv.Columns("Id").Visible = False
        dgv.Columns("IdReserva").Visible = False

        If dgv.RowCount > 0 Then

            dgv.Rows(0).Selected = False

        End If

        Desconectar()

    End Sub

    Public Sub Agregar(ByVal pago As PagoClass)

        Conectar()

        Dim comando As New SqlCommand("PagoAgregar", conexion)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@IdReserva", pago.IdReserva)
        comando.Parameters.AddWithValue("@Importe", pago.Importe)
        comando.Parameters.AddWithValue("@Descripcion", pago.Descripcion)
        comando.Parameters.AddWithValue("@Fecha", pago.Fecha)

        comando.ExecuteNonQuery()

        Desconectar()

    End Sub


    Public Sub Modificar(ByVal pago As PagoClass)

        Conectar()


        Dim comando As New SqlCommand("PagoModificar", conexion)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@IdReserva", pago.IdReserva)
        comando.Parameters.AddWithValue("@Importe", pago.Importe)
        comando.Parameters.AddWithValue("@Descripcion", pago.Descripcion)
        comando.Parameters.AddWithValue("@Fecha", pago.Fecha)
        comando.Parameters.AddWithValue("@Id", pago.Id)

        comando.ExecuteNonQuery()

        Desconectar()

    End Sub

    Public Sub Eliminar(ByVal id As Integer)

        Conectar()

        Dim comando As New SqlCommand("PagoEliminar", conexion)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@Id", id)

        comando.ExecuteNonQuery()

        Desconectar()

    End Sub

End Class
