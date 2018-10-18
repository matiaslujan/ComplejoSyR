Public Class detModalidad

    Private operacion_ As String

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property
    Private funcion_ As New Funciones
    Public Property funcion() As Funciones
        Get
            Return funcion_
        End Get
        Set(ByVal value As Funciones)
            funcion_ = value
        End Set
    End Property

    Dim modalidad_ As New ModalidadClass

    Public Property modalidad() As ModalidadClass
        Get
            Return modalidad_
        End Get
        Set(ByVal value As ModalidadClass)
            modalidad_ = value

        End Set
    End Property

    Public Sub New(ByVal modal As ModalidadClass)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        modalidad = modal

        operacion = "M"

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        operacion = "A"

    End Sub


    Private Sub detModalidad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If operacion = "M" Then

            Me.Text = "Modificar " + CStr(Me.Text)

            txtId.Text = modalidad.Id

            txtNombre.Text = modalidad.Nombre

            cbTipo.SelectedItem = modalidad.Tipo

        Else

            Me.Text = "Nueva " + CStr(Me.Text)

        End If
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If funcion.ValidarCampos(Me.Controls, ErrorProvider1) Then

            modalidad.Nombre = txtNombre.Text

            modalidad.Tipo = cbTipo.SelectedItem

            If operacion = "M" Then

                modalidad.Id = txtId.Text

                modalidad.Modificar(modalidad)

            Else

                modalidad.Agregar(modalidad)

            End If

            Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Close()

    End Sub
End Class