Public Class listReservas

    Dim f As New Funciones
    Dim res As New ReservaClass
    Private Sub TraerReservas()

        Select Case cbFiltros.SelectedItem

            Case "Todas"

                res.Traer(dgvReservas)

            Case "Sin Señar"

                res.ReservasSinConfirmar(dgvReservas)

            Case "Confirmadas"

                res.ReservasConfirmadas(dgvReservas)

            Case "Canceladas"

                res.ReservasCanceladas(dgvReservas)

        End Select
    End Sub
    Private Sub listReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cbFiltros.SelectedIndex = 0

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim det As New detReserva()

        det.ShowDialog()

        cbFiltros.SelectedIndex = 0


    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        modificar()

    End Sub
    Private Sub dgvReservas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReservas.CellDoubleClick

        modificar()

    End Sub
    Private Sub modificar()

        If f.filanoseleccionada(dgvReservas) Then Exit Sub

        res.Id = dgvReservas.CurrentRow.Cells("Id").Value
        'con el id se recuperan todos los datos de la reserva
        res.Datos(res)

        Dim det As New detReserva(res)

        det.ShowDialog()

        TraerReservas()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If f.filanoseleccionada(dgvReservas) Then Exit Sub

        res.Id = dgvReservas.CurrentRow.Cells("Id").Value

        res.Eliminar(res.Id)

        TraerReservas()

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged

        res.Buscar(txtBuscar.Text, dgvReservas)

    End Sub

    Private Sub cbFiltros_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFiltros.SelectedIndexChanged

        TraerReservas()

    End Sub

End Class