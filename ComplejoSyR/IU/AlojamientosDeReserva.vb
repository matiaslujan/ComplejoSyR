Public Class AlojamientosDeReserva
    Private AlojRes_ As New AlojamientoReservaClass

    Public Property AlojRes() As AlojamientoReservaClass
        Get
            Return AlojRes_

        End Get
        Set(ByVal value As AlojamientoReservaClass)
            AlojRes_ = value
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

    Private idres_ As Integer
    Public Property idres() As Integer
        Get
            Return idres_
        End Get
        Set(ByVal value As Integer)
            idres_ = value
        End Set
    End Property

    Private FIn_, FEg_ As Date

    Public Property FIn() As Date
        Get
            Return FIn_
        End Get
        Set(ByVal value As Date)
            FIn_ = value
        End Set
    End Property
    Public Property FEg() As Date
        Get
            Return FEg_
        End Get
        Set(ByVal value As Date)
            FEg_ = value
        End Set
    End Property
    Public Sub New(ByVal id As Integer, ByVal FI As Date, ByVal FE As Date)

        InitializeComponent()

        operacion = "A"

        idres = id

        FIn = FI

        FEg = FE
    End Sub
    Private Sub AlojamientoReserva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim aloj As New AlojamientoClass

        aloj.AlojDisponibles(dgvAlojRes, FIn, FEg)

    End Sub

    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click

        Dim alojres As New AlojamientoReservaClass

        alojres.IdReserva = idres
   
        alojres.Agregar(alojres.IdReserva, dgvAlojRes)

        Close()

    End Sub
End Class