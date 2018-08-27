Public Class detPago
    Private pago_ As PagoClass

    Public Property pago() As PagoClass
        Get
            Return pago_
        End Get
        Set(ByVal value As PagoClass)
            pago_ = value
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

    Private IdReserva_ As Integer
    Public Property IdReserva() As Integer
        Get
            Return IdReserva_
        End Get
        Set(ByVal value As Integer)
            IdReserva_ = value
        End Set
    End Property
    Public Sub New(ByVal id As Integer)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        operacion = "A"
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        IdReserva = id

    End Sub

    Public Sub New(ByVal p As PagoClass)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        pago = p

        operacion = "M"

    End Sub
    Private Sub Pagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If operacion = "M" Then
            txtId.Text = pago.Id
            txtIdReserva.Text = pago.IdReserva
            txtIImporte.Text = pago.Importe
            dtpFecha.Text = pago.Fecha
            txtDescripcion.Text = pago.Descripcion

        Else

            txtIdReserva.Text = IdReserva

        End If

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Dim pago As New PagoClass

        pago.IdReserva = txtIdReserva.Text
        pago.Importe = txtIImporte.Text
        pago.Descripcion = txtDescripcion.Text
        pago.Fecha = dtpFecha.Text

        If operacion = "M" Then

            pago.Id = txtId.Text

            pago.Modificar(pago)

        Else

            pago.Agregar(pago)

        End If

        Close()

    End Sub

End Class