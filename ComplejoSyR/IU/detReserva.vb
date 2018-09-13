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

    Dim Aloj As New AlojamientoReservaClass
    Dim lstAlojamientos As New List(Of AlojamientoReservaClass)
    Dim lstPagos As New List(Of PagoClass)

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

        Reserva = Nothing
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

        If Reserva.Accion = "Modificar" Then

            Aloj.TraerAlojamiento(Reserva.Id, lstAlojamientos)

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


        Dim p As New PagoClass

        p.Traer(dgvPagos, Reserva.Id)
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

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

        If Reserva.Accion = "Modificar" Then

            Reserva.Id = txtId.Text

            Reserva.Modificar(Reserva)

        Else

            Reserva.Agregar(Reserva)

            Reserva.ultimoid(txtId)

            Reserva.Id = txtId.Text

            Reserva.Accion = "Modificar"

        End If


        If lstAlojamientos.Count > 0 Then

            For Each row In lstAlojamientos

                If row.accion = "agregar" Then

                    row.IdReserva = Reserva.Id

                End If

            Next

            Aloj.Actualizar(lstAlojamientos)

        End If

        Close()

    End Sub

 
    'ir a lista de servicios
    Private Sub btnServicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServicios.Click

        Dim s As New listServicios(txtId.Text)

        s.ShowDialog()

        Datos()

    End Sub
    Private Sub alojamientos()

        dgvAlojamientos.DataSource = ""

        dgvAlojamientos.DataSource = lstAlojamientos

        dgvAlojamientos.Columns("IdReserva").Visible = False

        dgvAlojamientos.Columns("IdAlojamiento").Visible = False

        dgvAlojamientos.Columns("Conexion").Visible = False

    End Sub
    'agregar alojamiento, mostrar solo los disponibles
    Private Sub btnAgregarAloj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarAloj.Click

        Dim det As New AlojamientosDeReserva(lstAlojamientos, dtpFechaIngreso.Text, dtpFechaEgreso.Text)

        det.ShowDialog()



    End Sub

    Private Sub btnEliminarAloj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarAloj.Click

        If dgvAlojamientos.CurrentRow.Cells("accion").Value = "A" Then

            Dim pos As Integer = dgvAlojamientos.CurrentRow.Index

            lstAlojamientos.RemoveAt(pos)

        Else

            dgvAlojamientos.CurrentRow.Cells("accion").Value = "E"

        End If

    End Sub
    '----------------------------PAGOS--------------------------------
    '-----------------------------------------------------------------
    Private Sub btnAgregarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPago.Click

        Dim det As New detPago(txtId.Text)

        det.ShowDialog()

        Datos()

    End Sub

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
    '-----------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------

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
End Class