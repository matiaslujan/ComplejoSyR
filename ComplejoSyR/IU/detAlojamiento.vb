Public Class detAlojamiento
    Private alojamiento_ As AlojamientoClass

    Public Property alojamiento() As AlojamientoClass
        Get

            Return alojamiento_

        End Get
        Set(ByVal value As AlojamientoClass)

            alojamiento_ = value

        End Set

    End Property
    Private modalidades_ As New ModalidadClass

    Public Property modalidades() As ModalidadClass
        Get
            Return modalidades_

        End Get
        Set(ByVal value As ModalidadClass)
            modalidades_ = value
        End Set
    End Property
    Private operacion_ As String

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value

        End Set
    End Property

    Private tablaDGV_ As DataGridView
    Public Property tablaDGV() As DataGridView
        Get
            Return tablaDGV_
        End Get
        Set(ByVal value As DataGridView)
            tablaDGV_ = value
        End Set
    End Property
    Public Sub New(ByVal tabla As DataGridView)

        InitializeComponent()

        alojamiento = Nothing

        operacion = "A"

        tablaDGV = tabla

    End Sub

    Public Sub New(ByVal aloj As AlojamientoClass, ByVal tabla As DataGridView)

        InitializeComponent()

        alojamiento = aloj

        operacion = "M"

        tablaDGV = tabla

    End Sub
    Private Sub detAlojamiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If operacion = "M" Then

            modalidades.CargarCombo(comboModalidad)

            txtId.Text = alojamiento.id

            txtNumero.Text = alojamiento.Numero

            txtCapacidad.Text = alojamiento.Capacidad

            comboModalidad.SelectedValue = alojamiento.idModalidad

            comboSector.SelectedItem = alojamiento.Sector

        Else

            modalidades.CargarCombo(comboModalidad)

            comboModalidad.SelectedValue = ""

        End If
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Dim alojamiento As New AlojamientoClass

        alojamiento.Numero = txtNumero.Text

        alojamiento.Capacidad = txtCapacidad.Text

        alojamiento.idModalidad = comboModalidad.SelectedValue

        alojamiento.Sector = comboSector.SelectedItem


        If operacion = "M" Then

            alojamiento.id = txtId.Text

            alojamiento.Modificar(alojamiento)

        Else

            alojamiento.Agregar(alojamiento)

        End If

        alojamiento.Traer(tablaDGV)

        Close()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Close()

    End Sub
End Class