Imports System.Data
Imports System.Data.SqlClient

Public Class AlojamientoClass

    Inherits ConexionClass

    Private Id_ As Integer
    Public Property id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Private Numero_ As String

    Public Property Numero() As String
        Get
            Return Numero_
        End Get
        Set(ByVal value As String)
            Numero_ = value
        End Set
    End Property

    Private Capacidad_ As Integer

    Public Property Capacidad() As Integer
        Get
            Return Capacidad_
        End Get
        Set(ByVal value As Integer)
            Capacidad_ = value
        End Set
    End Property

    Private idModalidad_ As Integer

    Public Property idModalidad() As Integer
        Get
            Return idModalidad_
        End Get
        Set(ByVal value As Integer)
            idModalidad_ = value

        End Set
    End Property

    Private Sector_ As String

    Public Property Sector() As String
        Get
            Return Sector_
        End Get
        Set(ByVal value As String)
            Sector_ = value
        End Set
    End Property
    'lista de alojamientos
    Public Sub Traer(ByVal dgv As DataGridView)
        Try
            Conectar()

            Dim comando As New SqlCommand("AlojamientoTraer", conexion)

            comando.CommandType = CommandType.StoredProcedure

            Dim table As New Data.DataTable

            Dim adapter As New SqlDataAdapter(comando)

            adapter.Fill(table)

            dgv.DataSource = table
            dgv.Columns("Id").Visible = False
            dgv.Columns("IdModalidad").Visible = False


        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()

        End Try
    End Sub

    Public Sub Agregar(ByVal alojamiento As AlojamientoClass)
        Try
            Conectar()
            Dim comando As New SqlCommand("AlojamientoAgregar", conexion)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@Numero", alojamiento.Numero)
            comando.Parameters.AddWithValue("@Capacidad", alojamiento.Capacidad)
            comando.Parameters.AddWithValue("@idModalidad", alojamiento.idModalidad)
            comando.Parameters.AddWithValue("@Sector", alojamiento.Sector)
            comando.ExecuteNonQuery()


        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()

        End Try
    End Sub

    Public Sub Modificar(ByVal alojamiento As AlojamientoClass)
        Try
            Conectar()

            Dim comando As New SqlCommand("AlojamientoModificar", conexion)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@Numero", alojamiento.Numero)
            comando.Parameters.AddWithValue("@Capacidad", alojamiento.Capacidad)
            comando.Parameters.AddWithValue("@idModalidad", alojamiento.idModalidad)
            comando.Parameters.AddWithValue("@Sector", alojamiento.Sector)
            comando.Parameters.AddWithValue("@Id", alojamiento.id)

            comando.ExecuteNonQuery()


        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()

        End Try
    End Sub

    Public Sub Eliminar(ByVal Id As Integer)

        Try
            Conectar()

            Dim comando As New SqlCommand("AlojamientoEliminar", conexion)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@Id", Id)

            comando.ExecuteNonQuery()


        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()

        End Try
    End Sub
    '' traer alojamientos disponibles segun las fechas ingresadas

    Public Sub AlojDisponibles(ByVal dgv As DataGridView, ByVal FIng As Date, ByVal FEg As Date, ByVal Tipo As String)
        Try

            Conectar()

            Dim comando As New SqlCommand("AlojamientosDisponibles", conexion)

            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@FI", FIng)
            comando.Parameters.AddWithValue("@FE", FEg)
            comando.Parameters.AddWithValue("@Tipo", Tipo)

            Dim table As New Data.DataTable

            Dim adapter As New SqlDataAdapter(comando)

            adapter.Fill(table)

            dgv.DataSource = table

            dgv.Columns("Id").Visible = False

        Catch ex As Exception

            MsgBox(ex.Message)
        Finally

            Desconectar()

        End Try
    End Sub
End Class
