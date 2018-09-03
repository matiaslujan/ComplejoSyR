Imports System.Data.SqlClient

Public Class AlojamientoReservaClass
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

    Private IdAlojamiento_ As Integer

    Public Property IdAlojamiento() As Integer
        Get
            Return IdAlojamiento_
        End Get
        Set(ByVal value As Integer)
            IdAlojamiento_ = value
        End Set
    End Property

    Public Sub Agregar(ByVal idres As Integer, ByVal dgv As DataGridView)

        Conectar()

        For Each Row As DataGridViewRow In dgv.Rows

            If Row.Selected = True Then

                Dim comando As New SqlCommand("AlojResAgregar", conexion)
                comando.CommandType = CommandType.StoredProcedure

                Dim alojres As New AlojamientoReservaClass

                alojres.IdReserva = idres
                alojres.IdAlojamiento = Row.Cells("Id").Value
                comando.Parameters.AddWithValue("@IdReserva", alojres.IdReserva)
                comando.Parameters.AddWithValue("@IdAlojamiento", alojres.IdAlojamiento)

                comando.ExecuteNonQuery()
            End If
        Next
        Desconectar()

    End Sub


    Public Sub Eliminar(ByVal Id As Integer)

        Conectar()

        Dim comando As New SqlCommand("AlojResEliminar", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@id", Id)

        comando.ExecuteNonQuery()

        Desconectar()

    End Sub
    'trae los alojamientos de una reserva predeterminada

    Public Sub TraerAlojamiento(ByVal id As Integer, ByVal dgv As DataGridView)

        Conectar()

        Dim comando As New SqlCommand("AlojResTraer", conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@IdReserva", id)

        Dim table As New Data.DataTable

        Dim adapter As New SqlDataAdapter(comando)

        adapter.Fill(table)

        dgv.DataSource = table

        dgv.Columns("Id").Visible = False

        Desconectar()

        If dgv.RowCount > 0 Then

            dgv.Rows(0).Selected = False

        End If
    End Sub

End Class
