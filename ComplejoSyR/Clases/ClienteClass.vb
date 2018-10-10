Imports System.Data
Imports System.Data.SqlClient

Public Class ClienteClass
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
    Private Nombre_ As String

    Public Property Nombre() As String
        Get
            Return Nombre_

        End Get
        Set(ByVal value As String)
            Nombre_ = value

        End Set
    End Property
    Private Domicilio_ As String

    Public Property Domicilio() As String
        Get
            Return Domicilio_

        End Get
        Set(ByVal value As String)
            Domicilio_ = value

        End Set
    End Property
    Private Provincia_ As String

    Public Property Provincia() As String
        Get
            Return Provincia_

        End Get
        Set(ByVal value As String)
            Provincia_ = value

        End Set
    End Property
    Private Telefono_ As String
    Public Property Telefono() As String
        Get
            Return Telefono_

        End Get
        Set(ByVal value As String)
            Telefono_ = value

        End Set
    End Property
    Private Correo_ As String

    Public Property Correo() As String
        Get
            Return Correo_

        End Get
        Set(ByVal value As String)

            Correo_ = value

        End Set
    End Property
    Private Vehiculo_ As String

    Public Property Vehiculo() As String
        Get
            Return Vehiculo_

        End Get
        Set(ByVal value As String)
            Vehiculo_ = value

        End Set
    End Property
    Private Patente_ As String

    Public Property Patente() As String
        Get
            Return Patente_

        End Get
        Set(ByVal value As String)
            Patente_ = value

        End Set
    End Property
    Public Sub Traer(ByVal dgv As DataGridView)
        Try
            Conectar()

            Dim comando As New SqlCommand("ClienteTraer", conexion)

            comando.CommandType = CommandType.StoredProcedure

            Dim lista As New SqlDataAdapter(comando)

            Dim tabla As New Data.DataTable

            lista.Fill(tabla)

            dgv.DataSource = tabla

            dgv.Columns("Id").Visible = False


        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()

        End Try

    End Sub
    Public Sub Agregar(ByVal Cliente As ClienteClass)
        Try
            Conectar()

            Dim comando As New SqlCommand("ClienteAgregar", conexion)

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@Nombre", Cliente.Nombre)
            comando.Parameters.AddWithValue("@Domicilio", Cliente.Domicilio)
            comando.Parameters.AddWithValue("@Telefono", Cliente.Telefono)
            comando.Parameters.AddWithValue("@Correo", Cliente.Correo)
            comando.Parameters.AddWithValue("@Provincia", Cliente.Provincia)
            comando.Parameters.AddWithValue("@Vehiculo", Cliente.Vehiculo)
            comando.Parameters.AddWithValue("@Patente", Cliente.Patente)

            comando.ExecuteNonQuery()



        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()

        End Try
    End Sub
    Public Sub Modificar(ByVal Cliente As ClienteClass)
        Try
            Conectar()

            Dim comando As New SqlCommand("ClienteModificar", conexion)

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@Nombre", Cliente.Nombre)
            comando.Parameters.AddWithValue("@Domicilio", Cliente.Domicilio)
            comando.Parameters.AddWithValue("@Telefono", Cliente.Telefono)
            comando.Parameters.AddWithValue("@Correo", Cliente.Correo)
            comando.Parameters.AddWithValue("@Provincia", Cliente.Provincia)
            comando.Parameters.AddWithValue("@Vehiculo", Cliente.Vehiculo)
            comando.Parameters.AddWithValue("@Patente", Cliente.Patente)
            comando.Parameters.AddWithValue("@Id", Cliente.Id)

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

            Dim comando As New SqlCommand("ClienteEliminar", conexion)

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@Id", Id)

            comando.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()

        End Try


    End Sub
    Public Sub cargarCombo(ByVal combo As ComboBox)
        Try
            Conectar()

            Dim comando As New SqlCommand("ClienteTraer", conexion)

            comando.CommandType = CommandType.StoredProcedure

            Dim lista As SqlDataReader = comando.ExecuteReader

            Dim lista2 As New List(Of ClienteClass)

            If lista.HasRows Then

                While lista.Read()

                    Dim cliente As New ClienteClass

                    cliente.Id = (lista("id"))

                    cliente.Nombre = (lista("nombre"))

                    lista2.Add(cliente)

                End While

                combo.DataSource = lista2

                combo.DisplayMember = "Nombre"

                combo.ValueMember = "id"

            End If


        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()

        End Try
    End Sub

    Public Sub Buscar(ByVal Nombre As String, ByVal dgv As DataGridView)
        Try
            Conectar()

            Dim comando As New SqlCommand("ClienteBuscar", conexion)

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@Nombre", Nombre)

            Dim tabla As New Data.DataTable

            Dim lista As New SqlDataAdapter(comando)

            lista.Fill(tabla)

            dgv.DataSource = tabla


        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()

        End Try
    End Sub

    Public Sub Historial(ByVal id As Integer, ByVal dgv As DataGridView)
        Try
            Conectar()

            Dim comando As New SqlCommand("ClienteHistorial", conexion)

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@Id", id)

            Dim table As New Data.DataTable
            Dim lista As New SqlDataAdapter(comando)
            lista.Fill(table)

            dgv.DataSource = table
            dgv.Columns("Id").Visible = False


        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()

        End Try
    End Sub

    Public Sub ultimoid(ByRef cliente As ClienteClass)
        Try
            Conectar()

            Dim comando As New SqlCommand("ClienteUltimo", conexion)

            comando.CommandType = CommandType.StoredProcedure

            cliente.Id = comando.ExecuteScalar



        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()

        End Try

    End Sub

End Class
