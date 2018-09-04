Public Class detReserva

    Dim nuevo As Boolean
    Private Reserva_ As New ReservaClass


    Public Property Reserva() As ReservaClass
        Get
            Return Reserva_
        End Get
        Set(ByVal value As ReservaClass)
            Reserva_ = value
        End Set
    End Property

    Private Operacion_ As String

    Public Property Operacion() As String
        Get
            Return Operacion_
        End Get
        Set(ByVal value As String)
            Operacion_ = value
        End Set
    End Property
    'agregar con fechas seleccionadas
    Public Sub New(ByVal FI As Date, ByVal FE As Date)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Reserva.FEgreso = FE
        Reserva.FIngreso = FI

        ' Add any initialization after the InitializeComponent() call.
        Operacion = "AF"

    End Sub
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Reserva = Nothing
        ' Add any initialization after the InitializeComponent() call.
        Operacion = "A"



    End Sub

    Public Sub New(ByVal res As ReservaClass)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Reserva = res

        Operacion = "M"

        ' Add any initialization after the InitializeComponent() call.


    End Sub


    Private Sub detReserva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cliente As New ClienteClass

        cliente.cargarCombo(cbClientes)

        If Operacion = "M" Then

            Datos()

        ElseIf Operacion = "AF" Then

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
        Dim Aloj As New AlojamientoReservaClass

        Aloj.TraerAlojamiento(Reserva.Id, dgvAlojamientos)
        Dim p As New PagoClass

        p.Traer(dgvPagos, Reserva.Id)
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click


        Dim reserva As New ReservaClass

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

        If Operacion = "M" Then

            reserva.Id = txtId.Text

            reserva.Modificar(reserva)

            MsgBox("Cambios guardados")


        Else

            reserva.Agregar(reserva)

            reserva.ultimoid(txtId)

            MsgBox("Datos Cargados")

            Operacion = "M"
         
        End If


    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Close()

    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click

        txtImpEstadia.Text = txtCantDia.Text * txtImpDia.Text

    End Sub

    Private Sub dtpFechaEgreso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaEgreso.ValueChanged

        txtCantDia.Text = DateDiff(DateInterval.Day, CDate(dtpFechaIngreso.Text), CDate(dtpFechaEgreso.Text))

    End Sub
    Private Sub dtpFechaIngreso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaIngreso.ValueChanged

        txtCantDia.Text = DateDiff(DateInterval.Day, CDate(dtpFechaIngreso.Text), CDate(dtpFechaEgreso.Text))

    End Sub
    'agregar nuevo cliente

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Dim det As New detCliente(cbClientes)

        det.ShowDialog()


    End Sub
    'ir a lista de servicios
    Private Sub btnServicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServicios.Click

        Dim s As New listServicios(txtId.Text)

        s.ShowDialog()

        Datos()

    End Sub
    'agregar alojamiento, mostrar solo los disponibles
    Private Sub btnAgregarAloj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarAloj.Click
        If Aviso() = 1 Then Exit Sub

        Dim det As New AlojamientosDeReserva(txtId.Text, dtpFechaIngreso.Text, dtpFechaEgreso.Text)

        det.ShowDialog()

        Dim res As New ReservaClass
        res.Id = txtId.Text
        res.Datos(res)
        Reserva = res
        Datos()

    End Sub

    Private Sub btnEliminarAloj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarAloj.Click

        Dim aloj As New AlojamientoReservaClass

        aloj.Id = dgvAlojamientos.CurrentRow.Cells("Id").Value

        aloj.Eliminar(aloj.Id)

        Datos()

    End Sub
    '----------------------------PAGOS--------------------------------
    '-----------------------------------------------------------------
    Private Sub btnAgregarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPago.Click
        ' Aviso()

        Dim det As New detPago(txtId.Text)

        det.ShowDialog()

        Datos()
    End Sub
    Private Function Aviso() As Integer

        If txtId.Text = "" Then

            MsgBox("Primero debe guardar la reserva")

            Return 1

        End If

    End Function
    Private Sub ModificarPago()

        Dim p As New PagoClass

        p.Id = dgvPagos.CurrentRow.Cells("Id").Value
        p.IdReserva = dgvPagos.CurrentRow.Cells("IdReserva").Value
        p.Importe = dgvPagos.CurrentRow.Cells("Importe").Value
        p.Fecha = dgvPagos.CurrentRow.Cells("Fecha").Value
        p.Descripcion = dgvPagos.CurrentRow.Cells("Descripcion").Value
        Dim det As New detPago(p)

        det.ShowDialog()

        Datos()

    End Sub

    Private Sub btnModificarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPago.Click

        ModificarPago()

    End Sub
    Private Sub dgvPagos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPagos.CellDoubleClick

        ModificarPago()

    End Sub

    Private Sub btnEliminarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarPago.Click

        Dim P As New PagoClass

        P.Id = dgvPagos.CurrentRow.Cells("Id").Value

        P.Eliminar(P.Id)

        Datos()

    End Sub
    '------------------------------------------------------------------------------------------------------------
    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click
        Dim det As New AlojamientoReservaClass
        'det.idArqueo = arq.id

        Dim formdet As New AlojamientosDeReserva(Reserva.detalle, det, dtpFechaIngreso.Text, dtpFechaEgreso.Text)

        formdet.ShowDialog()

        ' Dim frmDetalleArqueo As New AlojamientosDeReserva(Reserva.detalle, det)
        ' Dim frmDetalleArqueo As New AlojamientosDeReserva(Reserva.detalle)

        ' frmDetalleArqueo.ShowDialog()
        Reserva.actualizarTabla(dgvAlojamientos, Reserva.detalle)

        'Datos()

    End Sub


    Private Sub guardar()
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
        If nuevo = True Then
            Reserva.Agregar(Reserva)
            Reserva.ultimoid(txtId)
            Reserva.Id = txtId.Text
        Else
            Reserva.Modificar(Reserva)
        End If
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        guardar()
        Reserva.actualizarDetalle(Reserva)
    End Sub
End Class