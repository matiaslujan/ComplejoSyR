Imports System.Data
Imports System.Data.SqlClient
Public Class ReservaClass
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

    Private IdCliente_ As Integer

    Public Property IdCliente() As Integer
        Get
            Return IdCliente_
        End Get
        Set(ByVal value As Integer)
            IdCliente_ = value
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

    Private FIngreso_ As Date

    Public Property FIngreso() As Date
        Get
            Return FIngreso_
        End Get
        Set(ByVal value As Date)
            FIngreso_ = value
        End Set
    End Property

    Private FEgreso_ As Date

    Public Property FEgreso() As Date
        Get
            Return FEgreso_
        End Get
        Set(ByVal value As Date)
            FEgreso_ = value
        End Set
    End Property

    Private CantPersonas_ As Integer

    Public Property CantPersonas() As Integer
        Get
            Return CantPersonas_
        End Get
        Set(ByVal value As Integer)
            CantPersonas_ = value
        End Set
    End Property

    Private CantDias_ As Integer

    Public Property CantDias() As Integer
        Get
            Return CantDias_
        End Get
        Set(ByVal value As Integer)
            CantDias_ = value
        End Set
    End Property

    Private ImpDia_ As Decimal

    Public Property ImpDia() As Decimal
        Get
            Return ImpDia_

        End Get
        Set(ByVal value As Decimal)
            ImpDia_ = value
        End Set
    End Property

    Private ImpTotal_ As Decimal

    Public Property ImpTotal() As Decimal
        Get
            Return ImpTotal_
        End Get
        Set(ByVal value As Decimal)
            ImpTotal_ = value
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

    Private Cancelada_ As Boolean
    Public Property Cancelada() As Boolean
        Get
            Return Cancelada_
        End Get
        Set(ByVal value As Boolean)
            Cancelada_ = value
        End Set
    End Property
    Public Sub Traer(ByVal dgv As DataGridView)

        Conectar()


        Dim comando As New SqlCommand("ReservasTraer", conexion)
        comando.CommandType = CommandType.StoredProcedure

        Dim table As New Data.DataTable

        Dim adapter As New SqlDataAdapter(comando)

        adapter.Fill(table)

        dgv.DataSource = table
        dgv.Columns("Id").Visible = False

        Desconectar()

    End Sub

    Public Sub Datos(ByVal reserva As ReservaClass)

        Conectar()

        Dim comando As New SqlCommand("ReservaDatos", conexion)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@Id", reserva.id)

        Dim lista As SqlDataReader = comando.ExecuteReader

        If lista.HasRows Then

            While lista.Read()

                reserva.id = (lista("Id"))
                reserva.IdCliente = (lista("IdCliente"))
                reserva.Fecha = (lista("FReserva"))
                reserva.FIngreso = (lista("FIngreso"))
                reserva.FEgreso = (lista("FEgreso"))
                reserva.CantPersonas = (lista("CantPersonas"))
                reserva.CantDias = (lista("CantDias"))
                reserva.ImpDia = (lista("ImpDia"))
                reserva.ImpTotal = (lista("ImpTotal"))
                reserva.Descripcion = (lista("Descripcion"))
                reserva.Cancelada = (lista("Cancelada"))

            End While

        End If

        Desconectar()

    End Sub
    Public Sub Agregar(ByVal reserva As ReservaClass)

        Conectar()

        Dim comando As New SqlCommand("ReservaAgregar", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@IdCliente", reserva.IdCliente)
        comando.Parameters.AddWithValue("@FIngreso", reserva.FIngreso)
        comando.Parameters.AddWithValue("@FEgreso", reserva.FEgreso)
        comando.Parameters.AddWithValue("@FReserva", reserva.Fecha)
        comando.Parameters.AddWithValue("@CantDias", reserva.CantDias)
        comando.Parameters.AddWithValue("@cantPersonas", reserva.CantPersonas)
        comando.Parameters.AddWithValue("@impDia", reserva.ImpDia)
        comando.Parameters.AddWithValue("@ImpTotal", reserva.ImpTotal)
        comando.Parameters.AddWithValue("@Descripcion", reserva.Descripcion)
        comando.Parameters.AddWithValue("@Cancelada", reserva.Cancelada)

        comando.ExecuteNonQuery()


        Desconectar()

    End Sub

    Public Sub Modificar(ByVal reserva As ReservaClass)

        Conectar()

      
        Dim comando As New SqlCommand("ReservaModificar", conexion)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@IdCliente", reserva.IdCliente)
        comando.Parameters.AddWithValue("@FIngreso", reserva.FIngreso)
        comando.Parameters.AddWithValue("@FEgreso", reserva.FEgreso)
        comando.Parameters.AddWithValue("@FReserva", reserva.Fecha)
        comando.Parameters.AddWithValue("@CantDias", reserva.CantDias)
        comando.Parameters.AddWithValue("@CantPersonas", reserva.CantPersonas)
        comando.Parameters.AddWithValue("@ImpDia", reserva.ImpDia)
        comando.Parameters.AddWithValue("@ImpTotal", reserva.ImpTotal)
        comando.Parameters.AddWithValue("@Descripcion", reserva.Descripcion)
        comando.Parameters.AddWithValue("@Cancelada", reserva.Cancelada)
        comando.Parameters.AddWithValue("@Id", reserva.Id)

        comando.ExecuteNonQuery()

        Desconectar()

    End Sub

    Public Sub Eliminar(ByVal Id As Integer)

        Conectar()

        Dim comando As New SqlCommand("ReservaEliminar", conexion)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@id", Id)

        comando.ExecuteNonQuery()

        Desconectar()

    End Sub

    Public Sub ultimoid(ByVal txt As TextBox)

        Conectar()


        Dim comando As New SqlCommand("ReservaUltimoId", conexion)
        comando.CommandType = CommandType.StoredProcedure


        txt.Text = comando.ExecuteScalar

        Desconectar()


    End Sub
    Public Sub Buscar(ByVal Nombre As String, ByVal dgv As DataGridView)


        Conectar()

        Dim comando As New SqlCommand("ReservaBuscar", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@Nombre", Nombre)
        Dim tabla As New Data.DataTable

        Dim lista As New SqlDataAdapter(comando)

        lista.Fill(tabla)

        dgv.DataSource = tabla

        Desconectar()

    End Sub

    Public Sub TraerOcupacion(ByVal dgv As DataGridView, ByVal FIng As Date, ByVal FEg As Date)

        Conectar()


        Dim comando As New SqlCommand("AlojamientosOcupacion", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@FI", FIng)

        comando.Parameters.AddWithValue("@FE", FEg)

        Dim table As New Data.DataTable

        Dim adapter As New SqlDataAdapter(comando)

        adapter.Fill(table)

        dgv.DataSource = table

        dgv.Columns("Id").Visible = False
        dgv.Columns("IdReserva").Visible = False
        dgv.Columns("Nombre").HeaderText = "Modalidad"
        dgv.Columns("FIngreso").HeaderText = "Ingreso"
        dgv.Columns("FEgreso").HeaderText = "Egreso"
        dgv.Columns("Numero").Width = 50
        dgv.Columns("Numero").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Desconectar()

        If dgv.RowCount > 0 Then


            For Each Row As DataGridViewRow In dgv.Rows

                If IsDBNull(Row.Cells("IdReserva").Value) = True Then

                    Row.DefaultCellStyle.BackColor = Color.GreenYellow
                Else
                    Row.DefaultCellStyle.BackColor = Color.Salmon

                End If
            Next

            dgv.Rows(0).Selected = False

        End If



    End Sub

    Public Sub Importes(ByVal id As Integer, ByVal txtTot As TextBox, ByVal txtPag As TextBox, ByVal txtDeuda As TextBox)

        Conectar()

        Dim comando As New SqlCommand("ReservaImportes", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@Id", id)

        Dim lista As SqlDataReader = comando.ExecuteReader

        If lista.HasRows Then

            While lista.Read()

                txtTot.Text = (lista("Total"))
                txtPag.Text = (lista("Pagado"))
                txtDeuda.Text = (lista("Deuda"))
                'txtServ.Text = (lista("Servicios"))


            End While

        End If

        Desconectar()

    End Sub
End Class
