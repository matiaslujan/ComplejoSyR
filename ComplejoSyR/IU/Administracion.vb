Public Class Administracion

    ' MODALIDADES
    Private Sub tabModalidades_Entr(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabModalidades.Enter

        Dim m As New ModalidadClass

        m.Traer(dgvModalidades)


    End Sub

    'agregar
    Private Sub btnAddMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMod.Click

        Dim detalle As New detModalidad(dgvModalidades)


        detalle.ShowDialog()


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

        If seleccion(dgvModalidades) Then Exit Sub

        Dim modalidad As New ModalidadClass

        modalidad.Id = dgvModalidades.CurrentRow.Cells("Id").Value

        modalidad.Nombre = dgvModalidades.CurrentRow.Cells("Nombre").Value

        modalidad.Tipo = dgvModalidades.CurrentRow.Cells("Tipo").Value

        Dim detalle As New detModalidad(modalidad, dgvModalidades)

        detalle.ShowDialog()

    End Sub

    'eliminar
    Private Sub btnDelMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelMod.Click

        If seleccion(dgvModalidades) Then Exit Sub

        Dim modalidad As New ModalidadClass

        modalidad.Id = dgvModalidades.CurrentRow.Cells("Id").Value

        modalidad.Eliminar(modalidad.Id)

        modalidad.Traer(dgvModalidades)

    End Sub

    'ALOJAMIENTOS

    Private Sub tabAlojamientos_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabAlojamientos.Enter
        Dim a As New AlojamientoClass
        a.Traer(dgvAlojamientos)
    End Sub

    'agregar

    Private Sub btnAddAloj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAloj.Click

        Dim detalle As New detAlojamiento(dgvAlojamientos)

        detalle.ShowDialog()

    End Sub

    'modificar

    Private Sub dgvAlojamientos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAlojamientos.CellDoubleClick

        modificarAlojamiento()

    End Sub

    'btnmodificar
    Private Sub btnModAloj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModAloj.Click

        modificarAlojamiento()

    End Sub

    Private Function seleccion(ByVal dgv As DataGridView) As Boolean

        If dgv.SelectedRows.Count < 1 Then

            MsgBox("Seleccione un Registro")
            Return True

        End If

    End Function
    'llenar formdetalle y abrir para modificar

    Public Sub modificarAlojamiento()

        If Seleccion(dgvAlojamientos) Then Exit Sub


        Dim alojamiento As New AlojamientoClass

        alojamiento.id = dgvAlojamientos.CurrentRow.Cells("id").Value
        alojamiento.Numero = dgvAlojamientos.CurrentRow.Cells("numero").Value
        alojamiento.Capacidad = dgvAlojamientos.CurrentRow.Cells("capacidad").Value
        alojamiento.idModalidad = dgvAlojamientos.CurrentRow.Cells("idmodalidad").Value
        alojamiento.Sector = dgvAlojamientos.CurrentRow.Cells("sector").Value

        Dim detalle As New detAlojamiento(alojamiento, dgvAlojamientos)

        detalle.ShowDialog()

    End Sub

    'eliminar
    Private Sub btnDeletAloj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletAloj.Click

        If seleccion(dgvAlojamientos) Then Exit Sub

        Dim alojamiento As New AlojamientoClass

        alojamiento.id = dgvAlojamientos.CurrentRow.Cells("Id").Value

        alojamiento.Eliminar(alojamiento.id)

        alojamiento.Traer(dgvAlojamientos)

    End Sub

End Class