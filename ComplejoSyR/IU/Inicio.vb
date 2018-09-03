Public Class Inicio
    Private Sub btnReservas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservas.Click

        listReservas.ShowDialog()

    End Sub

    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientes.Click
        listClientes.ShowDialog()

    End Sub
    Private Sub btnAdministracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdministracion.Click
        Dim a As New Administracion

        a.ShowDialog()

    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim b As New listReservas

        b.ShowDialog()

    End Sub
    '------------------------------------------------------------------------------------------------------------------------------
    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario.DateChanged
        Ocupacion()
    End Sub
    Private Sub Inicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Ocupacion()

    End Sub
    Private Sub Ocupacion()
        Dim r As New ReservaClass

        r.TraerOcupacion(dgvOcupacion, Calendario.SelectionRange.Start.ToString, Calendario.SelectionRange.End.ToString)

    End Sub
    Public Sub NuevaReserva()

        Dim det As New detReserva(Calendario.SelectionRange.Start.ToString,  Calendario.SelectionRange.End.ToString)

        det.ShowDialog()

        Ocupacion()
    End Sub

    Private Sub btnNuevaReserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaReserva.Click

        NuevaReserva()

    End Sub

    Private Sub dgvOcupacion_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOcupacion.CellDoubleClick

        If IsDBNull(dgvOcupacion.CurrentRow.Cells("IdReserva").Value) = True Then

            NuevaReserva()

        Else

            Dim res As New ReservaClass

            res.Id = dgvOcupacion.CurrentRow.Cells("IdReserva").Value

            'con el id se recuperan todos los datos de la reserva
            res.Datos(res)

            Dim det As New detReserva(res)

            det.ShowDialog()
            Ocupacion()
        End If


    End Sub

    'Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario.DateSelected
    '    Ocupacion()
    'End Sub
End Class
