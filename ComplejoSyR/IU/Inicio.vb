Public Class Inicio
    Private Sub listareservas()

        Dim lst As New listReservas

        lst.ShowDialog()

        Ocupacion()

    End Sub
    Private Sub btnReservas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservas.Click

        listareservas()

    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        listareservas()

    End Sub

    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientes.Click

        Dim lst As New listClientes

        lst.ShowDialog()

    End Sub
    Private Sub btnAdministracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdministracion.Click

        Dim a As New Administracion

        a.ShowDialog()

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
        If dgvOcupacion.CurrentRow Is Nothing Then

            MsgBox("Seleccione un alojamiento")

            Exit Sub

        End If

        Dim alojres As New AlojamientoReservaClass

        alojres.IdAlojamiento = dgvOcupacion.CurrentRow.Cells("Id").Value
        alojres.numero = dgvOcupacion.CurrentRow.Cells("numero").Value
        alojres.modalidad = dgvOcupacion.CurrentRow.Cells("nombre").Value
        alojres.capacidad = dgvOcupacion.CurrentRow.Cells("capacidad").Value
        alojres.accion = "Agregar"

        Dim det As New detReserva(Calendario.SelectionRange.Start.ToString, Calendario.SelectionRange.End.ToString, alojres)

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

            Try
                'det.idreserva = res.Id

                det.ShowDialog()

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

            Ocupacion()

        End If


    End Sub

    Private Sub dgvOcupacion_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvOcupacion.ColumnHeaderMouseClick

        Dim r As New ReservaClass

        r.colorear(dgvOcupacion)


    End Sub

End Class
