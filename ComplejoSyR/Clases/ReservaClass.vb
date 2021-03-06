﻿Imports System.Data
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
    Private Retiro_ As Boolean
    Public Property Retiro() As Boolean
        Get
            Return Retiro_
        End Get
        Set(ByVal value As Boolean)
            Retiro_ = value
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
    Private Sub ColumLstReservas(ByVal dgv As DataGridView)
        dgv.Columns("Id").Visible = False
        dgv.Columns("Numero").HeaderText = "N°"
        dgv.Columns("Numero").Width = 50
        dgv.Columns("Numero").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub
    Public Sub Traer(ByVal dgv As DataGridView)
        Try
            Conectar()

            Dim comando As New SqlCommand("ReservasTraer", conexion)

            comando.CommandType = CommandType.StoredProcedure

            Dim table As New Data.DataTable

            Dim adapter As New SqlDataAdapter(comando)

            adapter.Fill(table)

            dgv.DataSource = table

            If dgv.Rows.Count > 0 Then

                dgv.Rows(0).Selected = False

            End If
            ColumLstReservas(dgv)
        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try


    End Sub

    Public Sub Datos(ByVal reserva As ReservaClass)
        Try
            Conectar()

            Dim comando As New SqlCommand("ReservaDatos", conexion)

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@Id", reserva.Id)

            Dim lista As SqlDataReader = comando.ExecuteReader

            If lista.HasRows Then

                While lista.Read()

                    reserva.Id = (lista("Id"))
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
                    reserva.Retiro = (lista("Retiro"))

                End While

            End If


        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try

    End Sub
    Public Sub Agregar(ByVal reserva As ReservaClass)
        Try
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
            comando.Parameters.AddWithValue("@Retiro", reserva.Retiro)

            comando.ExecuteNonQuery()


        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try

    End Sub

    Public Sub Modificar(ByVal reserva As ReservaClass)
        Try
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
            comando.Parameters.AddWithValue("@Retiro", reserva.Retiro)

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

            Dim comando As New SqlCommand("ReservaEliminar", conexion)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@id", Id)

            comando.ExecuteNonQuery()


        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try

    End Sub

    Public Sub ultimoid(ByVal txt As TextBox)
        Try
            Conectar()

            Dim comando As New SqlCommand("ReservaUltimoId", conexion)

            comando.CommandType = CommandType.StoredProcedure

            txt.Text = comando.ExecuteScalar


        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try

    End Sub

    Public Function FechaProxima(ByVal idalojamiento As Integer, ByVal FE As Date, ByVal FI As Date, ByVal idreserva As Integer) As Date

        Try
            Conectar()

            Dim comando As New SqlCommand("DisponibilidadDelAlojamiento", conexion)

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@idalojamiento", idalojamiento)
            comando.Parameters.AddWithValue("@FI", FI)
            comando.Parameters.AddWithValue("@FE", FE)
            comando.Parameters.AddWithValue("@idreserva", idreserva)

            Dim fechaing As Date = comando.ExecuteScalar

            Return fechaing

        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()

        End Try

    End Function
    Public Sub ReservasConfirmadas(ByVal dgv As DataGridView)
        Try
            Conectar()

            Dim comando As New SqlCommand("ReservasConfirmadas", conexion)

            comando.CommandType = CommandType.StoredProcedure

            Dim table As New Data.DataTable

            Dim adapter As New SqlDataAdapter(comando)

            adapter.Fill(table)

            dgv.DataSource = table

            ColumLstReservas(dgv)

            dgv.Columns("Pagado").Visible = False
      
            If dgv.Rows.Count > 0 Then

                dgv.Rows(0).Selected = False

            End If

        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try


    End Sub
    Public Sub ReservasSinConfirmar(ByVal dgv As DataGridView)
        Try
            Conectar()

            Dim comando As New SqlCommand("ReservasSinConfirmar", conexion)

            comando.CommandType = CommandType.StoredProcedure

            Dim table As New Data.DataTable

            Dim adapter As New SqlDataAdapter(comando)

            adapter.Fill(table)

            dgv.DataSource = table

            ColumLstReservas(dgv)

            dgv.Columns("Pagado").Visible = False
        
            If dgv.Rows.Count > 0 Then

                dgv.Rows(0).Selected = False

            End If

        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try


    End Sub
    Public Sub ReservasCanceladas(ByVal dgv As DataGridView)
        Try
            Conectar()

            Dim comando As New SqlCommand("ReservasCanceladas", conexion)

            comando.CommandType = CommandType.StoredProcedure

            Dim table As New Data.DataTable

            Dim adapter As New SqlDataAdapter(comando)

            adapter.Fill(table)

            dgv.DataSource = table

            ColumLstReservas(dgv)

            If dgv.Rows.Count > 0 Then

                dgv.Rows(0).Selected = False

            End If

        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try


    End Sub
    Public Sub SeRetiran(ByVal dgv As DataGridView)
        Try
            Conectar()

            Dim comando As New SqlCommand("ReservasARetirarse", conexion)

            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@Fecha", DateTime.Today)
            Dim table As New Data.DataTable

            Dim adapter As New SqlDataAdapter(comando)

            adapter.Fill(table)

            dgv.DataSource = table

            ColumLstReservas(dgv)

            If dgv.Rows.Count > 0 Then

                dgv.Rows(0).Selected = False

            End If

        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try

    End Sub

    Public Sub IngresanHoy(ByVal dgv As DataGridView)
        Try
            Conectar()

            Dim comando As New SqlCommand("ReservasIngresantes", conexion)

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@Fecha", DateTime.Today)

            Dim table As New Data.DataTable

            Dim adapter As New SqlDataAdapter(comando)

            adapter.Fill(table)

            dgv.DataSource = table

            ColumLstReservas(dgv)

            If dgv.Rows.Count > 0 Then

                dgv.Rows(0).Selected = False

            End If

        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try

    End Sub
    Public Sub ActualizarRetiro(ByVal reserva As ReservaClass)
        Try

            Conectar()

            Dim comando As New SqlCommand("ActualizarRetiro", conexion)

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@Retiro", reserva.Retiro)
            comando.Parameters.AddWithValue("@Id", reserva.Id)

            comando.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try
    End Sub
    Public Sub CancelarReserva(ByVal reserva As ReservaClass)
        Try

            Conectar()

            Dim comando As New SqlCommand("ReservaCancelar", conexion)

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@Cancelada", reserva.Cancelada)
            comando.Parameters.AddWithValue("@Id", reserva.Id)

            comando.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try
    End Sub
    Public Sub Buscar(ByVal Nombre As String, ByVal dgv As DataGridView)
        Try

            Conectar()

            Dim comando As New SqlCommand("ReservaBuscar", conexion)

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@Nombre", Nombre)
            Dim tabla As New Data.DataTable

            Dim lista As New SqlDataAdapter(comando)

            lista.Fill(tabla)

            dgv.DataSource = tabla

            If dgv.Rows.Count > 0 Then

                dgv.Rows(0).Selected = False
            End If

        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try

    End Sub

    Public Sub TraerOcupacion(ByVal dgv As DataGridView, ByVal FIng As Date, ByVal FEg As Date, ByVal Tipo As String)
        Try
            Conectar()

            Dim comando As New SqlCommand("AlojamientosOcupacion", conexion)

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@FI", FIng)

            comando.Parameters.AddWithValue("@FE", FEg)

            comando.Parameters.AddWithValue("@Tipo", Tipo)

            Dim table As New Data.DataTable

            Dim adapter As New SqlDataAdapter(comando)

            adapter.Fill(table)

            dgv.DataSource = table

            dgv.Columns("Id").Visible = False
            dgv.Columns("IdReserva").Visible = False
            dgv.Columns("Nombre").HeaderText = "Modalidad"
            dgv.Columns("FIngreso").HeaderText = "Ingreso"
            dgv.Columns("FEgreso").HeaderText = "Egreso"
            dgv.Columns("Numero").HeaderText = "N°"
            dgv.Columns("FIngreso").MinimumWidth = 100
            dgv.Columns("FEgreso").MinimumWidth = 100
            dgv.Columns("FIngreso").Width = 100
            dgv.Columns("FEgreso").Width = 100
            dgv.Columns("FEgreso").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.Columns("FIngreso").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.Columns("Numero").Width = 50
            dgv.Columns("Numero").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.Columns("Capacidad").HeaderText = "Capac."
            dgv.Columns("Capacidad").Width = 100
            dgv.Columns("Capacidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            colorearocupacion(dgv)

        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try


    End Sub

    Public Sub Importes(ByVal id As Integer, ByVal txtTot As TextBox, ByVal txtPag As TextBox, ByVal txtDeuda As TextBox, ByVal txtServ As TextBox)
        Try
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
                    txtServ.Text = (lista("Servicios"))
                End While

            End If


        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try

    End Sub

    Public Sub colorearocupacion(ByRef dgv As DataGridView)

        For Each Row As DataGridViewRow In dgv.Rows

            If IsDBNull(Row.Cells("IdReserva").Value) = False Then

                'alojamientos ocupados
                Row.DefaultCellStyle.BackColor = Color.FromArgb(255, 199, 48)

            

                If Row.Cells("FEgreso").Value = Date.Today Then
                    'se retiran hoy 255; 255; 128
                    Row.DefaultCellStyle.ForeColor = Color.Black
                    Row.DefaultCellStyle.BackColor = Color.LightGreen

                End If

                If Row.Cells("FIngreso").Value = Date.Today Then
                    'ingresan hoy
                    Row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 138)

                    Row.DefaultCellStyle.ForeColor = Color.Black

                End If

            End If

        Next

    End Sub

    Public Sub CantidadDeDias(ByRef txt As TextBox, ByVal Ingreso As DateTimePicker, ByVal Egreso As DateTimePicker)

        txt.Text = DateDiff(DateInterval.Day, CDate(Ingreso.Text), CDate(Egreso.Text))

    End Sub
    'eliminar registros de las listas de reserva
    'recorre el dgv y oculta los registros a eliminar
    Public Sub eliminarregistro(ByRef dgv As DataGridView)

        For Each row As DataGridViewRow In dgv.Rows

            If row.Cells("Accion").Value = "Eliminar" Then

                Dim pos As Integer = row.Index

                dgv.CurrentCell = Nothing

                dgv.Rows(pos).Visible = False

            End If
        Next

    End Sub

    Public Sub OcultarColumnas(ByRef dgv As DataGridView)

        dgv.Columns("IdReserva").Visible = False
        dgv.Columns("Id").Visible = False
        dgv.Columns("Accion").Visible = False
        dgv.Columns("intsecurity").Visible = False

        If dgv.Tag = "Alojamientos" Then

            dgv.Columns("IdAlojamiento").Visible = False
            dgv.Columns("N").Visible = False
            dgv.Columns("M").Visible = False
            dgv.Columns("C").Visible = False

        Else

            dgv.Columns("F").Visible = False
            dgv.Columns("D").Visible = False
            dgv.Columns("I").Visible = False

        End If
    End Sub
    'subtotalpagado y servicios
    Public Sub subtotal(ByVal dgv As DataGridView, ByVal txt As TextBox)

        If dgv.Rows.Count > 0 Then

            txt.Text = "0"

            For Each row In dgv.Rows
                If row.cells("accion").value <> "Eliminar" Then
                    txt.Text = CDec(txt.Text) + CDec(row.cells("importe").value)
                End If
            Next

        Else
            txt.Text = "0"

        End If
    End Sub

    Public Sub CalcularImportes(ByVal txtdias As TextBox, ByVal txtimpdia As TextBox, ByVal txtimpestadia As TextBox, ByVal txtTot As TextBox, ByVal txtPag As TextBox, ByVal txtDeuda As TextBox, ByVal txtServ As TextBox)

        If txtdias.Text <> "" And txtimpdia.Text <> "" Then

            txtimpestadia.Text = CDec(txtdias.Text) * CDec(txtimpdia.Text)

        End If

        txtTot.Text = CDec(txtimpestadia.Text) + CDec(txtServ.Text)

        txtDeuda.Text = CDec(txtTot.Text) - CDec(txtPag.Text)

    End Sub
 
End Class