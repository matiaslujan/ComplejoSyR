Public Class detServicio

    Private lstServicios_ As List(Of ServicioClass)
    Public Property lstServicios() As List(Of ServicioClass)
        Get
            Return lstServicios_
        End Get
        Set(ByVal value As List(Of ServicioClass))
            lstServicios_ = value
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
    Private Servicio_ As New ServicioClass
    Public Property Servicio() As ServicioClass
        Get
            Return Servicio_
        End Get
        Set(ByVal value As ServicioClass)
            Servicio_ = value
        End Set
    End Property

    'Dim servicio As New ServicioClass
    Dim posicion As Integer
    Public Sub New(ByRef lst As List(Of ServicioClass))

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        servicio.accion = "Agregar"
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lstServicios = lst

    End Sub
    Public Sub New(ByRef lst As List(Of ServicioClass), ByVal s As ServicioClass, ByVal pos As Integer)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lstServicios = lst

        servicio = s

        posicion = pos
    End Sub


    Private Sub detServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If servicio.Accion = "Modificar" Or servicio.Accion = "MA" Then

            txtId.Text = servicio.Id

            txtIdReserva.Text = servicio.IdReserva

            txtDescripcion.Text = servicio.Descripcion

            txtImporte.Text = servicio.Importe

            dtpFecha.Text = servicio.Fecha

        End If
    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If funcion.ValidarCampos(Me.Controls, ErrorProvider1) Then

            Select Case servicio.Accion

                Case "Agregar"
                    Datos()
                    lstServicios.Add(servicio)

                Case "Modificar"

                    Datos()

                    lstServicios(posicion) = servicio


                Case "MA"

                    servicio.Accion = "Agregar"

                    Datos()

                    lstServicios(posicion) = servicio

            End Select
            Close()
        End If

    End Sub
    Private Sub Datos()
        servicio.Importe = txtImporte.Text
        servicio.Descripcion = txtDescripcion.Text
        servicio.Fecha = dtpFecha.Text
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()

    End Sub
End Class