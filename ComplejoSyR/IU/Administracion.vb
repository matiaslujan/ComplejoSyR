Public Class Administracion
    Dim f As New Funciones
    Dim m As New ModalidadClass
    Dim a As New AlojamientoClass
    ' MODALIDADES
    Private Sub tabModalidades_Entr(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabModalidades.Enter

        m.Traer(dgvModalidades)

    End Sub

    'agregar
    Private Sub btnAddMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMod.Click

        'Dim detalle As New detModalidad(dgvModalidades)
        Dim detalle As New detModalidad()

        detalle.ShowDialog()

        m.Traer(dgvModalidades)

    End Sub

    'doble click en una fila de la tabla modalidades
    Private Sub dgvModalidades_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvModalidades.CellDoubleClick

        modificarModalidad()

    End Sub

    'btnmodificar

    Private Sub btnUpdMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdMod.Click

        modificarModalidad()

    End Sub

    'llenar formdetalle y abrir para modificar

    Private Sub modificarModalidad()

        If f.filanoseleccionada(dgvModalidades) Then Exit Sub

        m.Id = dgvModalidades.CurrentRow.Cells("Id").Value

        m.Nombre = dgvModalidades.CurrentRow.Cells("Nombre").Value

        m.Tipo = dgvModalidades.CurrentRow.Cells("Tipo").Value

        'Dim detalle As New detModalidad(m, dgvModalidades)
        Dim detalle As New detModalidad(m)

        detalle.ShowDialog()

        m.Traer(dgvModalidades)
    End Sub

    'eliminar
    Private Sub btnDelMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelMod.Click

        If f.filanoseleccionada(dgvModalidades) Then Exit Sub

        m.Id = dgvModalidades.CurrentRow.Cells("Id").Value

        m.Eliminar(m.Id)

        m.Traer(dgvModalidades)

    End Sub
    'ALOJAMIENTOS
    Private Sub tabAlojamientos_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabAlojamientos.Enter

        a.Traer(dgvAlojamientos)

    End Sub
    'agregar
    Private Sub btnAddAloj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAloj.Click

        Dim detalle As New detAlojamiento()

        detalle.ShowDialog()

        a.Traer(dgvAlojamientos)

    End Sub

    'modificar

    Private Sub dgvAlojamientos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAlojamientos.CellDoubleClick

        modificarAlojamiento()

    End Sub

    'btnmodificar
    Private Sub btnModAloj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModAloj.Click

        modificarAlojamiento()

    End Sub

    'llenar formdetalle y abrir para modificar

    Public Sub modificarAlojamiento()

        If f.filanoseleccionada(dgvAlojamientos) Then Exit Sub

        a.id = dgvAlojamientos.CurrentRow.Cells("id").Value
        a.Numero = dgvAlojamientos.CurrentRow.Cells("numero").Value
        a.Capacidad = dgvAlojamientos.CurrentRow.Cells("capacidad").Value
        a.idModalidad = dgvAlojamientos.CurrentRow.Cells("idmodalidad").Value
        a.Sector = dgvAlojamientos.CurrentRow.Cells("sector").Value

        Dim detalle As New detAlojamiento(a)

        detalle.ShowDialog()

        a.Traer(dgvAlojamientos)

    End Sub

    'eliminar
    Private Sub btnDeletAloj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletAloj.Click

        If f.filanoseleccionada(dgvAlojamientos) Then Exit Sub

        a.id = dgvAlojamientos.CurrentRow.Cells("Id").Value

        a.Eliminar(a.id)

        a.Traer(dgvAlojamientos)

    End Sub

End Class