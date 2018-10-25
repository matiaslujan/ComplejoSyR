Public Class listReservas

    Dim f As New Funciones
    Dim res As New ReservaClass
    Private Sub TraerReservas()

        If cbFiltros.SelectedItem <> "Se retiran hoy" Then

            GroupRetiro.Visible = False

        Else

            GroupRetiro.Visible = True

        End If

        Select Case cbFiltros.SelectedItem

            Case "Todas"

                res.Traer(dgvReservas)

            Case "Sin Señar"

                res.ReservasSinConfirmar(dgvReservas)

            Case "Confirmadas"

                res.ReservasConfirmadas(dgvReservas)

            Case "Canceladas"

                res.ReservasCanceladas(dgvReservas)

            Case "Se retiran hoy"
                res.SeRetiran(dgvReservas)
                dgvReservas.ReadOnly = False
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

    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        txtBuscar.BackColor = Color.White

    End Sub
    Private Sub txtBuscar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.LostFocus
        txtBuscar.BackColor = Color.Gainsboro

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged

        res.Buscar(txtBuscar.Text, dgvReservas)

    End Sub

    Private Sub cbFiltros_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFiltros.SelectedIndexChanged

        TraerReservas()

    End Sub

    Private Sub dgvReservas_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvReservas.ColumnHeaderMouseClick
        If cbFiltros.SelectedItem = "Se retiran hoy" Then

            res.colorearretiro(dgvReservas)

        End If
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click

        For Each row In dgvReservas.Rows

            res.Id = row.cells("Id").value
            res.Retiro = row.cells("Retiro").value
            res.ActualizarRetiro(res)

        Next

        res.SeRetiran(dgvReservas)
    End Sub
End Class