Public Class detReserva

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
    Dim pago As New PagoClass
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
            pago.Traer(lstPagos, Reserva.Id)
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

        Close()

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

        If dgvAlojamientos.Rows.Count > 0 Then

            dgvAlojamientos.Rows(0).Selected = False

        End If

        eliminarregistro(dgvAlojamientos)

        dgvAlojamientos.Columns("IdReserva").Visible = False
        dgvAlojamientos.Columns("IdAlojamiento").Visible = False
        dgvAlojamientos.Columns("Id").Visible = False
        dgvAlojamientos.Columns("Conexion").Visible = False
        dgvAlojamientos.Columns("Accion").Visible = False

    End Sub
    'recorre el dgv y oculta los registros a eliminar
    Private Sub eliminarregistro(ByRef dgv As DataGridView)

        For Each row As DataGridViewRow In dgv.Rows

            If row.Cells("Accion").Value = "Eliminar" Then

                Dim pos As Integer = row.Index

                dgv.CurrentCell = Nothing

                dgv.Rows(pos).Visible = False

            End If
        Next

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

        If dgvPagos.Rows.Count > 0 Then

            dgvPagos.Rows(0).Selected = False

        End If

        eliminarregistro(dgvPagos)

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
    Private Sub btnServicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txtId.Text = "" Then

            MsgBox("Primero debe guardar la reserva")

            Exit Sub

        End If

        Dim s As New listServicios(txtId.Text)

        s.ShowDialog()

        Datos()

    End Sub

    Private Sub btnNuevServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevServ.Click

    End Sub

    Private Sub btnModServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModServ.Click

    End Sub

    Private Sub btnElimServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElimServ.Click

    End Sub
End Class