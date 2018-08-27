Imports System.Data.SqlClient
Public Class ModalidadClass
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

    Private Tipo_ As String
    Public Property Tipo() As String
        Get
            Return Tipo_
        End Get
        Set(ByVal value As String)
            Tipo_ = value
        End Set
    End Property

    Public Sub Traer(ByVal dgv As DataGridView)

        Conectar()

        Dim comando As New SqlCommand("ModalidadTraer", conexion)

        comando.CommandType = CommandType.StoredProcedure

        Dim tabla As New Data.DataTable

        Dim lista As New SqlDataAdapter(comando)

        lista.Fill(tabla)

        dgv.DataSource = tabla
        dgv.Columns("Id").Visible = False

        Desconectar()

    End Sub
    Public Sub Agregar(ByVal modalidad As ModalidadClass)

        Conectar()
        Dim comando As New SqlCommand("ModalidadAgregar", conexion)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@Nombre", modalidad.Nombre)

        comando.Parameters.AddWithValue("@Tipo", modalidad.Tipo)

        comando.ExecuteNonQuery()

        Desconectar()
    End Sub

    Public Sub Modificar(ByVal modalidad As ModalidadClass)

        Conectar()
        Dim comando As New SqlCommand("ModalidadModificar", conexion)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@Nombre", modalidad.Nombre)

        comando.Parameters.AddWithValue("@Tipo", modalidad.Tipo)

        comando.Parameters.AddWithValue("@Id", modalidad.Id)

        comando.ExecuteNonQuery()

        Desconectar()

    End Sub

    Public Sub Eliminar(ByVal id As Integer)

        Conectar()

        Dim comando As New SqlCommand("ModalidadEliminar", conexion)
        comando.CommandType = CommandType.StoredProcedure


        comando.Parameters.AddWithValue("@id", id)

        comando.ExecuteNonQuery()

        Desconectar()

    End Sub

    Public Sub CargarCombo(ByVal combo As ComboBox)

        Conectar()
        Dim comando As New SqlCommand("ModalidadTraer", conexion)
        comando.CommandType = CommandType.StoredProcedure

        Dim lista As SqlDataReader = comando.ExecuteReader

        Dim lista2 As New List(Of ModalidadClass)

        If lista.HasRows Then

            While lista.Read()

                Dim modalidad As New ModalidadClass

                modalidad.Id = (lista("id"))

                modalidad.Nombre = (lista("nombre"))

                lista2.Add(modalidad)

            End While

            combo.DataSource = lista2

            combo.DisplayMember = "Nombre"

            combo.ValueMember = "id"

        End If



        Desconectar()

    End Sub
End Class
