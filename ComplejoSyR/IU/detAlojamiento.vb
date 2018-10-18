Public Class detAlojamiento
    Private funcion_ As New Funciones
    Public Property funcion() As Funciones
        Get
            Return funcion_
        End Get
        Set(ByVal value As Funciones)
            funcion_ = value
        End Set
    End Property
    Private alojamiento_ As New AlojamientoClass

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


    Public Sub New()

        InitializeComponent()

        alojamiento = Nothing

        operacion = "A"



    End Sub

    Public Sub New(ByVal aloj As AlojamientoClass)

        InitializeComponent()

        alojamiento = aloj

        operacion = "M"


    End Sub
    Private Sub detAlojamiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
        If operacion = "M" Then

            Me.Text = "Modificar " + CStr(Me.Text)

            modalidades.CargarCombo(comboModalidad)

            txtId.Text = alojamiento.id

            txtNumero.Text = alojamiento.Numero

            txtCapacidad.Text = alojamiento.Capacidad

            comboModalidad.SelectedValue = alojamiento.idModalidad

            comboSector.SelectedItem = alojamiento.Sector

        Else

            Me.Text = "Nuevo " + CStr(Me.Text)

            modalidades.CargarCombo(comboModalidad)

            comboModalidad.SelectedIndex = 0

            comboSector.SelectedIndex = 0
        End If


    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If funcion.ValidarCampos(Me.Controls, ErrorProvider1) Then

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

            Close()
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Close()

    End Sub

    Private Sub txtCapacidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCapacidad.KeyPress
        funcion.IngresoSoloNumeros(e)
    End Sub

    Private Sub txtNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        funcion.IngresoSoloNumeros(e)
    End Sub
End Class