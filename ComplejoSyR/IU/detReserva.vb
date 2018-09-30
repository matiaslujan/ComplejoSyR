Public Class detReserva

    Dim f As New Funciones

    Dim Reserva As New ReservaClass
    Dim Aloj As New AlojamientoReservaClass
    Dim lstAlojamientos As New List(Of AlojamientoReservaClass)
    Dim pago As New PagoClass
    Dim lstPagos As New List(Of PagoClass)
    Dim servicio As New ServicioClass
    Dim lstServicios As New List(Of ServicioClass)

    'agregar con fechas seleccionadas

    Public Sub New(ByVal FI As Date, ByVal FE As Date)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Reserva.FEgreso = FE
        Reserva.FIngreso = FI

        ' Add any initialization after the InitializeComponent() call.
        Reserva.Accion = "AgregarF"

    End Sub
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Reserva.Accion = "Agregar"



    End Sub

    Public Sub New(ByVal res As ReservaClass)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Reserva = res

        Reserva.Accion = "Modificar"

        ' Add any initialization after the InitializeComponent() call.


    End Sub


    Private Sub detReserva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cliente As New ClienteClass

        cliente.cargarCombo(cbClientes)
        cbClientes.SelectedIndex = -1
        txtPagado.Text = "0"
        If Reserva.Accion = "Modificar" Then

            Aloj.TraerAlojamiento(Reserva.Id, lstAlojamientos)
            pago.Traer(lstPagos, Reserva.Id)
            servicio.Traer(lstServicios, Reserva.Id)

            Datos()

        ElseIf Reserva.Accion = "AgregarF" Then

            dtpFechaEgreso.Text = Reserva.FEgreso

            dtpFechaIngreso.Text = Reserva.FIngreso


        End If
    End Sub
    Private Sub Datos()

        txtId.Text = Reserva.Id
        txtCantDia.Text = Reserva.CantDias
        txtCantPer.Text = Reserva.CantPersonas
        txtImpEstadia.Text = Reserva.ImpTotal
        txtImpDia.Text = Reserva.ImpDia
        dtpFecha.Text = Reserva.Fecha
        dtpFechaEgreso.Text = Reserva.FEgreso
        dtpFechaIngreso.Text = Reserva.FIngreso
        cbClientes.SelectedValue = Reserva.IdCliente
        txtDescripcion.Text = Reserva.Descripcion
        CbxCancelada.Checked = Reserva.Cancelada

        Reserva.Importes(Reserva.Id, txtTotal, txtPagado, txtDeuda)

        alojamientos()
        pagos()
        servicios()

    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If f.ValidarCampos(TableLayoutPanel13.Controls, ErrorProvider1) Then

            Reserva.IdCliente = cbClientes.SelectedValue
            Reserva.FIngreso = CDate(dtpFechaIngreso.Text)
            Reserva.FEgreso = CDate(dtpFechaEgreso.Text)
            Reserva.Fecha = CDate(dtpFecha.Text)
            Reserva.CantDias = txtCantDia.Text
            Reserva.CantPersonas = txtCantPer.Text
            Reserva.ImpDia = txtImpDia.Text
            Reserva.ImpTotal = txtImpEstadia.Text
            Reserva.Descripcion = txtDescripcion.Text
            Reserva.Cancelada = CbxCancelada.Checked
            If lstAlojamientos.Count = 0 Then
                MsgBox("Agrege un alojamiento")
                Exit Sub
            End If
            If Reserva.Accion = "Modificar" Then

                Reserva.Id = txtId.Text

                Reserva.Modificar(Reserva)

            Else

                Reserva.Agregar(Reserva)

                Reserva.ultimoid(txtId)

                Reserva.Id = txtId.Text

            End If


            If lstAlojamientos.Count > 0 Then

                For Each row In lstAlojamientos

                    If row.accion = "Agregar" Then

                        row.IdReserva = Reserva.Id

                    End If

                Next

                Aloj.Actualizar(lstAlojamientos)

            End If

            If lstPagos.Count > 0 Then

                For Each row In lstPagos

                    If row.accion = "Agregar" Then

                        row.IdReserva = Reserva.Id

                    End If

                Next

                pago.Actualizar(lstPagos)

            End If


            If lstServicios.Count > 0 Then

                For Each row In lstServicios

                    If row.Accion = "Agregar" Then

                        row.IdReserva = Reserva.Id

                    End If

                Next

                servicio.actualizar(lstServicios)

            End If

            Close()
        End If
    End Sub
    Private Function filaseleccionada(ByVal dgv As DataGridView) As Boolean

        If dgv.CurrentRow Is Nothing Then

            MsgBox("Seleccione un registro")

            Return True

        End If
    End Function
    Private Sub alojamientos()

        dgvAlojamientos.DataSource = ""

        dgvAlojamientos.DataSource = lstAlojamientos

        Reserva.eliminarregistro(dgvAlojamientos)

        dgvAlojamientos.Columns("IdReserva").Visible = False
        dgvAlojamientos.Columns("IdAlojamiento").Visible = False
        dgvAlojamientos.Columns("Id").Visible = False
        dgvAlojamientos.Columns("Conexion").Visible = False
        dgvAlojamientos.Columns("Accion").Visible = False

    End Sub

    'agregar alojamiento, mostrar solo los disponibles
    Private Sub btnAgregarAloj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarAloj.Click

        Dim det As New AlojamientosDeReserva(lstAlojamientos, dtpFechaIngreso.Text, dtpFechaEgreso.Text)

        det.ShowDialog()

        alojamientos()

    End Sub

    Private Sub btnEliminarAloj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarAloj.Click

        If filaseleccionada(dgvAlojamientos) Then Exit Sub


        If dgvAlojamientos.CurrentRow.Cells("Accion").Value = "Agregar" Then

            Dim pos As Integer = dgvAlojamientos.CurrentRow.Index

            lstAlojamientos.RemoveAt(pos)

        Else

            dgvAlojamientos.CurrentRow.Cells("Accion").Value = "Eliminar"

        End If

        alojamientos()

    End Sub
    '----------------------------PAGOS--------------------------------
    '-----------------------------------------------------------------
    Private Sub pagos()

        dgvPagos.DataSource = ""

        dgvPagos.DataSource = lstPagos

        Reserva.eliminarregistro(dgvPagos)

        dgvPagos.Columns("IdReserva").Visible = False
        dgvPagos.Columns("Id").Visible = False
        dgvPagos.Columns("Accion").Visible = False
        dgvPagos.Columns("Conexion").Visible = False

    End Sub

    Private Sub btnAgregarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPago.Click

        Dim det As New detPago(lstPagos)

        det.ShowDialog()

        pagos()

    End Sub

    Private Sub ModificarPago()
        filaseleccionada(dgvPagos)
        Dim p As New PagoClass
        p.Id = dgvPagos.CurrentRow.Cells("Id").Value
        p.IdReserva = dgvPagos.CurrentRow.Cells("IdReserva").Value
        p.Importe = dgvPagos.CurrentRow.Cells("Importe").Value
        p.Fecha = dgvPagos.CurrentRow.Cells("Fecha").Value
        p.Descripcion = dgvPagos.CurrentRow.Cells("Descripcion").Value

        'si el pago a sido agregado pero no almacenado, se lo modifica y la accion seguira siendo Agregar
        If dgvPagos.CurrentRow.Cells("accion").Value = "Agregar" Then

            p.accion = "MA"

        Else

            p.accion = "Modificar"

        End If

        'obtiene posicion de la fila a modificar
        Dim pos As Integer = dgvPagos.CurrentRow.Index

        Dim det As New detPago(lstPagos, p, pos)

        det.ShowDialog()

        pagos()

    End Sub

    Private Sub btnModificarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPago.Click

        ModificarPago()

    End Sub
    Private Sub dgvPagos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPagos.CellDoubleClick

        ModificarPago()

    End Sub

    Private Sub btnEliminarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarPago.Click
        If filaseleccionada(dgvPagos) Then Exit Sub

        If dgvPagos.CurrentRow.Cells("Accion").Value = "Agregar" Then

            Dim pos As Integer = dgvPagos.CurrentRow.Index

            lstPagos.RemoveAt(pos)

        Else

            dgvPagos.CurrentRow.Cells("Accion").Value = "Eliminar"

        End If

        pagos()

    End Sub
    '-----------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click


        Close()

    End Sub
    Private Sub txtCantDia_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantDia.TextChanged
        Calcular()
    End Sub
    Private Sub txtImpDia_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImpDia.TextChanged
        Calcular()
    End Sub
    Private Sub Calcular()
        If txtCantDia.Text <> "" And txtImpDia.Text <> "" Then

            txtImpEstadia.Text = txtCantDia.Text * txtImpDia.Text

        End If

    End Sub

    Private Sub dtpFechaEgreso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaEgreso.ValueChanged

        Reserva.CantidadDeDias(txtCantDia, dtpFechaIngreso, dtpFechaEgreso)

    End Sub
    Private Sub dtpFechaIngreso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaIngreso.ValueChanged

        Reserva.CantidadDeDias(txtCantDia, dtpFechaIngreso, dtpFechaEgreso)

    End Sub

    'agregar nuevo cliente

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim det As New detCliente(cbClientes)

        det.ShowDialog()

        Dim c As New ClienteClass

        c.ultimoid(c)

        cbClientes.SelectedValue = c.Id

    End Sub

    '--------------------------------------SERVICIOS-----------------------------------------------------
    '----------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------

    Private Sub btnNuevServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevServ.Click

        Dim det As New detServicio(lstServicios)

        det.ShowDialog()

        servicios()

    End Sub
    Private Sub modificarservicio()
        filaseleccionada(dgvServicios)

        Dim s As New ServicioClass

        s.Id = dgvServicios.CurrentRow.Cells("Id").Value
        s.IdReserva = dgvServicios.CurrentRow.Cells("IdReserva").Value
        s.Importe = dgvServicios.CurrentRow.Cells("Importe").Value
        s.Fecha = dgvServicios.CurrentRow.Cells("Fecha").Value
        s.Descripcion = dgvServicios.CurrentRow.Cells("Descripcion").Value

        'si el pago a sido agregado pero no almacenado, se lo modifica y la accion seguira siendo Agregar
        If dgvServicios.CurrentRow.Cells("accion").Value = "Agregar" Then

            s.Accion = "MA"

        Else

            s.Accion = "Modificar"

        End If

        'obtiene posicion de la fila a modificar
        Dim pos As Integer = dgvServicios.CurrentRow.Index

        Dim det As New detServicio(lstServicios, s, pos)

        det.ShowDialog()

        servicios()


    End Sub
    Private Sub btnModServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModServ.Click

        modificarservicio()

    End Sub

    Private Sub btnElimServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElimServ.Click

        If filaseleccionada(dgvServicios) Then Exit Sub

        If dgvServicios.CurrentRow.Cells("Accion").Value = "Agregar" Then

            Dim pos As Integer = dgvServicios.CurrentRow.Index

            lstServicios.RemoveAt(pos)

        Else

            dgvServicios.CurrentRow.Cells("Accion").Value = "Eliminar"

        End If

        servicios()

    End Sub

    Private Sub dgvServicios_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvServicios.CellDoubleClick

        modificarservicio()

    End Sub
    Private Sub servicios()

        dgvServicios.DataSource = ""

        dgvServicios.DataSource = lstServicios

        Reserva.eliminarregistro(dgvServicios)

        dgvServicios.Columns("IdReserva").Visible = False
        dgvServicios.Columns("Id").Visible = False
        dgvServicios.Columns("Accion").Visible = False
        dgvServicios.Columns("Conexion").Visible = False

    End Sub

 
End Class