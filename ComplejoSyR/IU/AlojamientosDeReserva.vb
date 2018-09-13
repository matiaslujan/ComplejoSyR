﻿Public Class AlojamientosDeReserva

    '------------------------------------------------------
    Dim alojres As New AlojamientoReservaClass
    Private lstAlojamientos_ As New List(Of AlojamientoReservaClass)
    Public Property lstAlojamientos() As List(Of AlojamientoReservaClass)
        Get
            Return lstAlojamientos_
        End Get
        Set(ByVal value As List(Of AlojamientoReservaClass))
            lstAlojamientos_ = value
        End Set
    End Property

    Dim nuevo As Boolean
    Private operacion_ As String

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value

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

        alojres.accion = "Agregar"

        FIn = FI

        FEg = FE

        lstAlojamientos = lst

        nuevo = True
    End Sub

    Private Sub AlojamientoReserva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim aloj As New AlojamientoClass

        aloj.AlojDisponibles(dgvAlojRes, FIn, FEg)

    End Sub

    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click

        If nuevo = True Then

            For Each row In dgvAlojRes.Rows

                If row.selected = True Then

                    alojres.IdAlojamiento = dgvAlojRes.CurrentRow.Cells("Id").Value
                    alojres.numero = dgvAlojRes.CurrentRow.Cells("numero").Value
                    alojres.nombre = dgvAlojRes.CurrentRow.Cells("nombre").Value
                    alojres.capacidad = dgvAlojRes.CurrentRow.Cells("capacidad").Value
                    lstAlojamientos.Add(alojres)

                End If
            Next

        End If

        Close()

    End Sub
End Class