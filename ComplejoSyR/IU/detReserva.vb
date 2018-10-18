Public Class detReserva

    Dim f As New Funciones
    Private reserva_ As New ReservaClass
    Public Property reserva() As ReservaClass
        Get
            Return reserva_
        End Get
        Set(ByVal value As ReservaClass)
            reserva_ = value
        End Set
    End Property

    Dim Aloj As New AlojamientoReservaClass
    Dim lstAlojamientos As New List(Of AlojamientoReservaClass)
    Dim pago As New PagoClass
    Dim lstPagos As New List(Of PagoClass)
    Dim servicio As New ServicioClass
    Dim lstServicios As New List(Of ServicioClass)

    'agregar con fechas seleccionadas

    Public Sub New(ByVal FI As Date, ByVal FE As Date, ByVal alojres As AlojamientoReservaClass)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        reserva.FEgreso = FE
        reserva.FIngreso = FI

        ' Add any initialization after the InitializeComponent() call.
        reserva.Accion = "AgregarF"

        lstAlojamientos.Add(alojres)

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

    Private Sub agregarcolumnas(ByRef dgv As DataGridView)

        If dgv.Tag = "Alojamientos" Then

            dgv.Columns.Add("N", "Numero")
            dgv.Columns.Add("M", "Modalidad")
            dgv.Columns.Add("C", "Capacidad")

        Else
            dgv.Columns.Add("F", "Fecha")
            dgv.Columns.Add("D", "Descripcion")
            dgv.Columns.Add("I", "Importe")
        End If

    End Sub
    Private Sub Datos()

        txtId.Text = reserva.Id
        txtCantPer.Text = reserva.CantPersonas
        txtImpEstadia.Text = reserva.ImpTotal
        reserva.Importes(reserva.Id, txtTotal, txtPagado, txtDeuda, txtImpServ)
        txtImpDia.Text = reserva.ImpDia
        dtpFecha.Text = reserva.Fecha
        dtpFechaEgreso.Text = reserva.FEgreso
        dtpFechaIngreso.Text = reserva.FIngreso
        txtCantDia.Text = reserva.CantDias
        cbClientes.SelectedValue = reserva.IdCliente
        txtDescripcion.Text = reserva.Descripcion
        CbxCancelada.Checked = reserva.Cancelada


        alojamientos()

    End Sub
    Private Sub Calcular()

        reserva.CalcularImportes(txtCantDia, txtImpDia, txtImpEstadia, txtTotal, txtPagado, txtDeuda, txtImpServ)

        If reserva.Accion = "Modificar" Then

            If CDec(txtDeuda.Text) = 0 Then

                btnAgregarPago.Enabled = False

            Else

                btnAgregarPago.Enabled = True

            End If

        Else
            If CDec(txtTotal.Text) = 0 Then

                btnAgregarPago.Enabled = False

            Else

                btnAgregarPago.Enabled = True

            End If
        End If

    End Sub
    Private Sub ControlBotones()


        If dgvPagos.RowCount = 0 Then

            btnModificarPago.Enabled = False
            btnEliminarPago.Enabled = False

        Else

            btnModificarPago.Enabled = True
            btnEliminarPago.Enabled = True

        End If

        If dgvServicios.RowCount = 0 Then

            btnModServ.Enabled = False
            btnElimServ.Enabled = False

        Else

            btnModServ.Enabled = True
            btnElimServ.Enabled = True

        End If
    End Sub

    Private Sub detReserva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cliente As New ClienteClass

        cliente.cargarCombo(cbClientes)

        cbClientes.SelectedIndex = -1

        txtPagado.Text = "0"
        txtDeuda.Text = "0"
        txtTotal.Text = "0"
        txtImpEstadia.Text = "0"
        txtImpServ.Text = "0"
        txtImpDia.Text = "0"

        agregarcolumnas(dgvPagos)
        agregarcolumnas(dgvServicios)
        agregarcolumnas(dgvAlojamientos)

        If lstAlojamientos.Count > 0 Then

            dgvAlojamientos.DataSource = lstAlojamientos

            reserva.OcultarColumnas(dgvAlojamientos)

        End If

        If reserva.Accion = "Modificar" Then

            Me.Text = "Modificar " + CStr(Me.Text)

            Aloj.TraerAlojamiento(reserva.Id, lstAlojamientos)

            If pago.Traer(lstPagos, reserva.Id) Then

                dgvPagos.DataSource = lstPagos

                reserva.OcultarColumnas(dgvPagos)

            End If

            If servicio.Traer(lstServicios, reserva.Id) Then

                dgvServicios.DataSource = lstServicios

                reserva.OcultarColumnas(dgvServicios)

            End If

            Datos()

        ElseIf reserva.Accion = "AgregarF" Then

            Me.Text = "Nueva " + CStr(Me.Text)

            dtpFechaEgreso.Text = reserva.FEgreso

            dtpFechaIngreso.Text = reserva.FIngreso

        Else

            Me.Text = "Nueva " + CStr(Me.Text)

        End If

        ControlBotones()

    End Sub

    Private Sub txtCantDia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantDia.KeyPress
        f.IngresoSoloNumeros(e)
    End Sub


    Private Sub txtCantDia_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantDia.TextChanged
        Calcular()
    End Sub

    Private Sub txtImpDia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImpDia.KeyPress

        f.IngresoSoloNumeros(e)

    End Sub
    Private Sub txtImpDia_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImpDia.TextChanged
        Calcular()
    End Sub


    Private Sub dtpFechaEgreso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaEgreso.ValueChanged

        reserva.CantidadDeDias(txtCantDia, dtpFechaIngreso, dtpFechaEgreso)

    End Sub
    Private Sub dtpFechaIngreso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaIngreso.ValueChanged

        reserva.CantidadDeDias(txtCantDia, dtpFechaIngreso, dtpFechaEgreso)

    End Sub

    'agregar nuevo cliente

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Dim det As New detCliente(cbClientes)

        det.ShowDialog()

        Dim c As New ClienteClass

        c.ultimoid(c)

        cbClientes.SelectedValue = c.Id

    End Sub
    '--------------------------------------------ALOJAMIENTOS---------------------------------------------
    Private Sub alojamientos()

        dgvAlojamientos.DataSource = ""

        dgvAlojamientos.DataSource = lstAlojamientos

        reserva.eliminarregistro(dgvAlojamientos)

        reserva.OcultarColumnas(dgvAlojamientos)


    End Sub

    'agregar alojamiento, mostrar solo los disponibles
    Private Sub btnAgregarAloj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarAloj.Click

        Dim det As New AlojamientosDeReserva(lstAlojamientos, dtpFechaIngreso.Text, dtpFechaEgreso.Text)

        det.ShowDialog()

        alojamientos()

    End Sub

    Private Sub btnEliminarAloj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarAloj.Click

        If f.filanoseleccionada(dgvAlojamientos) Then Exit Sub

        'si el registro aun no ha sido agregado a la ase de datos, se lo elimina de la lista
        'sino se marca para eliminarlo posteriormente 

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

        dgvPagos.DataSource = Nothing

        dgvPagos.DataSource = lstPagos

        reserva.eliminarregistro(dgvPagos)

        reserva.subtotal(dgvPagos, txtPagado)

        Calcular()

        reserva.OcultarColumnas(dgvPagos)

    End Sub

    Private Sub btnAgregarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPago.Click

        Dim det As New detPago(lstPagos)

        det.deuda = CDec(txtDeuda.Text)

        det.ShowDialog()

        pagos()

        ControlBotones()

    End Sub

    Private Sub ModificarPago()

        If f.filanoseleccionada(dgvPagos) Then Exit Sub

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

        det.deuda = CDec(txtDeuda.Text)

        det.ShowDialog()

        pagos()

        ControlBotones()

    End Sub

    Private Sub btnModificarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPago.Click

        ModificarPago()

    End Sub
    Private Sub dgvPagos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPagos.CellDoubleClick

        ModificarPago()

    End Sub

    Private Sub btnEliminarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarPago.Click
        If f.filanoseleccionada(dgvPagos) Then Exit Sub

        If dgvPagos.CurrentRow.Cells("Accion").Value = "Agregar" Then

            Dim pos As Integer = dgvPagos.CurrentRow.Index

            lstPagos.RemoveAt(pos)

        Else

            dgvPagos.CurrentRow.Cells("Accion").Value = "Eliminar"

        End If

        pagos()

    End Sub

    '--------------------------------------SERVICIOS-----------------------------------------------------


    Private Sub btnNuevServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevServ.Click

        Dim det As New detServicio(lstServicios)

        det.ShowDialog()

        servicios()

        ControlBotones()

    End Sub
    Private Sub modificarservicio()

        If f.filanoseleccionada(dgvServicios) Then Exit Sub

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

        ControlBotones()

    End Sub
    Private Sub btnModServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModServ.Click

        modificarservicio()

    End Sub

    Private Sub btnElimServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElimServ.Click

        If f.filanoseleccionada(dgvServicios) Then Exit Sub

        If dgvServicios.CurrentRow.Cells("Accion").Value = "Agregar" Then

            Dim pos As Integer = dgvServicios.CurrentRow.Index

            lstServicios.RemoveAt(pos)

        Else

            dgvServicios.CurrentRow.Cells("Accion").Value = "Eliminar"

        End If

        servicios()

        ControlBotones()
    End Sub

    Private Sub dgvServicios_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvServicios.CellDoubleClick

        modificarservicio()

    End Sub
    Private Sub servicios()

        dgvServicios.DataSource = ""

        dgvServicios.DataSource = lstServicios

        reserva.eliminarregistro(dgvServicios)

        reserva.subtotal(dgvServicios, txtImpServ)

        Calcular()

        reserva.OcultarColumnas(dgvServicios)


    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If f.ValidarCamposReserva(TableLayoutPanel13.Controls, ErrorProvider1) Then

            reserva.IdCliente = cbClientes.SelectedValue
            reserva.FIngreso = CDate(dtpFechaIngreso.Text)
            reserva.FEgreso = CDate(dtpFechaEgreso.Text)
            reserva.Fecha = CDate(dtpFecha.Text)
            reserva.CantDias = txtCantDia.Text
            reserva.CantPersonas = txtCantPer.Text
            reserva.ImpDia = txtImpDia.Text
            reserva.ImpTotal = txtImpEstadia.Text
            reserva.Descripcion = txtDescripcion.Text
            reserva.Cancelada = CbxCancelada.Checked

            If lstAlojamientos.Count = 0 Then

                MsgBox("Agrege un alojamiento")

                Exit Sub

            End If

            If reserva.Accion = "Modificar" Then

                reserva.Id = txtId.Text

                reserva.Modificar(reserva)

            Else

                reserva.Agregar(reserva)

                reserva.ultimoid(txtId)

                reserva.Id = txtId.Text

            End If


            If lstAlojamientos.Count > 0 Then

                For Each row In lstAlojamientos

                    If row.accion = "Agregar" Then

                        row.IdReserva = reserva.Id

                    End If

                Next

                Aloj.Actualizar(lstAlojamientos)

            End If

            If lstPagos.Count > 0 Then

                For Each row In lstPagos

                    If row.accion = "Agregar" Then

                        row.IdReserva = reserva.Id

                    End If

                Next

                pago.Actualizar(lstPagos)

            End If


            If lstServicios.Count > 0 Then

                For Each row In lstServicios

                    If row.Accion = "Agregar" Then

                        row.IdReserva = reserva.Id

                    End If

                Next

                servicio.actualizar(lstServicios)

            End If

            Close()

        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Close()

    End Sub

    Private Sub txtCantPer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantPer.KeyPress
        f.IngresoSoloNumeros(e)
    End Sub


End Class