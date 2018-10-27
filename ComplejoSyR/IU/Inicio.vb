Public Class Inicio
    'traer ocupacion en un periodo determinado
    Private Sub Ocupacion()

        Dim r As New ReservaClass

        r.TraerOcupacion(dgvOcupacion, Calendario.SelectionRange.Start.ToString, Calendario.SelectionRange.End.ToString, cbTipo.SelectedItem)


    End Sub
    'mostrar todas las reservas
    Private Sub listareservas()

        Dim lst As New listReservas

        lst.ShowDialog()

        Ocupacion()

    End Sub

    'al iniciar se trae la ocupacion actual del tipo habitacional
    Private Sub Inicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        cbTipo.SelectedIndex = 1


        Ocupacion()

    End Sub
    '------------------------------------------------------------------------------------------------------------------------------
    'ocupacion en fechas seleccionadas
    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario.DateChanged

        Ocupacion()

    End Sub
    Private Sub btnReservas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservas.Click

        listareservas()

    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        listareservas()

    End Sub
    'mostrar clientes
    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientes.Click

        Dim lst As New listClientes

        lst.ShowDialog()

        Ocupacion()

    End Sub
    'acceder al sector administracion (alojamientos y modalidades)
    Private Sub btnAdministracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdministracion.Click

        Dim a As New Administracion

        a.ShowDialog()

        Ocupacion()

    End Sub
    'seleccionar el tipo alojamiento (camping o habitacional) y traer su ocupacion - disponibilidad)
    Private Sub cbTipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipo.SelectedIndexChanged
        Ocupacion()

    End Sub
    'si se selecciona una fila disponible se realiza una nueva reserva y se carga el alojamiento seleccionado
    Public Sub NuevaReserva()

        If dgvOcupacion.CurrentRow Is Nothing Then

            MsgBox("Seleccione un alojamiento")

            Exit Sub

        End If

        Dim alojres As New AlojamientoReservaClass

        alojres.IdAlojamiento = dgvOcupacion.CurrentRow.Cells("Id").Value
        alojres.Numero = dgvOcupacion.CurrentRow.Cells("numero").Value
        alojres.Modalidad = dgvOcupacion.CurrentRow.Cells("nombre").Value
        alojres.Capacidad = dgvOcupacion.CurrentRow.Cells("capacidad").Value
        alojres.accion = "Agregar"

        Dim det As New detReserva(Calendario.SelectionRange.Start.ToString, Calendario.SelectionRange.End.ToString, alojres)

        det.ShowDialog()

        Ocupacion()

    End Sub

    Private Sub btnNuevaReserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaReserva.Click
        'si la fila esta disponible accede a nuevareserva
        'If IsDBNull(dgvOcupacion.CurrentRow.Cells("IdReserva").Value) = True Or dgvOcupacion.CurrentRow.Cells("FEgreso").Value = Date.Today Then
        
        Dim det As New detReserva

        det.ShowDialog()
     
    End Sub

    Private Sub dgvOcupacion_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOcupacion.CellDoubleClick

        RESERVA()

    End Sub
    'al hacer dobleclick en un item de la lista si este esta ocupado se accedde al detalle e esta reserva
    'sino se realiza una nueva reserva
    Private Sub RESERVA()

        If IsDBNull(dgvOcupacion.CurrentRow.Cells("IdReserva").Value) = True Then

            NuevaReserva()

        Else

            Dim res As New ReservaClass

            res.Id = dgvOcupacion.CurrentRow.Cells("IdReserva").Value

            'con el id se recuperan todos los datos de la reserva
            res.Datos(res)

            Dim det As New detReserva(res)

            ' Try

            det.ShowDialog()

            'Catch ex As Exception

            '    MsgBox(ex.Message)

            'End Try

            Ocupacion()

        End If
    End Sub
    'al reordenar la lista se colorea segun su disponibilidad
    Private Sub dgvOcupacion_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvOcupacion.ColumnHeaderMouseClick

        Dim r As New ReservaClass

        r.colorearocupacion(dgvOcupacion)


    End Sub

  
    Private Sub btnSeRetiran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeRetiran.Click

        Dim lst As New listReservas

        lst.filtro = "Se retiran hoy"

        lst.ShowDialog()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim lst As New listReservas

        lst.filtro = "Ingresan hoy"

        lst.ShowDialog()

    End Sub
End Class
