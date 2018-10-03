Public Class AlojamientosDeReserva

    '------------------------------------------------------

    Private lstAlojamientos_ As New List(Of AlojamientoReservaClass)
    Public Property lstAlojamientos() As List(Of AlojamientoReservaClass)
        Get
            Return lstAlojamientos_
        End Get
        Set(ByVal value As List(Of AlojamientoReservaClass))
            lstAlojamientos_ = value
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
    '-----------------------------------------------------
    Public Sub New(ByRef lst As List(Of AlojamientoReservaClass), ByVal FI As Date, ByVal FE As Date) 'Este constructor carga nuevos registros.
        InitializeComponent()

        FIn = FI

        FEg = FE

        lstAlojamientos = lst

    End Sub

    Private Sub AlojamientoReserva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim aloj As New AlojamientoClass

        aloj.AlojDisponibles(dgvAlojRes, FIn, FEg)

    End Sub

    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click

        For Each row In dgvAlojRes.Rows

            If row.selected = True Then

                Dim alojres As New AlojamientoReservaClass
                alojres.IdAlojamiento = row.Cells("Id").Value
                alojres.numero = row.Cells("numero").Value
                alojres.modalidad = row.Cells("modalidad").Value
                alojres.capacidad = row.Cells("capacidad").Value
                alojres.accion = "Agregar"
                lstAlojamientos.Add(alojres)

            End If

        Next

        Close()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Close()

    End Sub
End Class