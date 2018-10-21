Public Class listClientes
    Dim f As New Funciones
    Dim cliente As New ClienteClass
    Private Sub listClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cliente.Traer(dgvClientes)

    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If f.filanoseleccionada(dgvClientes) Then Exit Sub

        cliente.Id = dgvClientes.CurrentRow.Cells("Id").Value

        cliente.Eliminar(cliente.Id)

        cliente.Traer(dgvClientes)

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged

        cliente.Buscar(txtBuscar.Text, dgvClientes)

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim det As New detCliente()
        det.ShowDialog()
        cliente.Traer(dgvClientes)

    End Sub
    Private Sub Modificar()
        If f.filanoseleccionada(dgvClientes) Then Exit Sub

        cliente.Id = dgvClientes.CurrentRow.Cells("Id").Value

        cliente.Datos(cliente)
        'cliente.Nombre = dgvClientes.CurrentRow.Cells("Nombre").Value
        'cliente.Domicilio = dgvClientes.CurrentRow.Cells("Domicilio").Value
        'cliente.Correo = dgvClientes.CurrentRow.Cells("Correo").Value
        'cliente.Telefono = dgvClientes.CurrentRow.Cells("Telefono").Value
        'cliente.Provincia = dgvClientes.CurrentRow.Cells("Provincia").Value
        'cliente.Vehiculo = dgvClientes.CurrentRow.Cells("Vehiculo").Value
        'cliente.Patente = dgvClientes.CurrentRow.Cells("Patente").Value

        Dim det As New detCliente(cliente)

        det.ShowDialog()

        cliente.Traer(dgvClientes)

    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Modificar()

    End Sub

    Private Sub dgvClientes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick

        Modificar()

    End Sub

    Private Sub btnHistorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistorial.Click

        If f.filanoseleccionada(dgvClientes) Then Exit Sub

        Dim id As Integer = dgvClientes.CurrentRow.Cells("Id").Value

        Dim h As New Historial(id)

        h.ShowDialog()

        cliente.Traer(dgvClientes)

    End Sub
End Class