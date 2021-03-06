﻿Public Class detPago
    Private lstPagos_ As New List(Of PagoClass)

    Public Property lstPagos() As List(Of PagoClass)
        Get
            Return lstPagos_
        End Get
        Set(ByVal value As List(Of PagoClass))
            lstPagos_ = value
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
    Private deuda_ As Decimal
    Public Property deuda() As Decimal
        Get
            Return deuda_
        End Get
        Set(ByVal value As Decimal)
            deuda_ = value
        End Set
    End Property
    Dim pago As New PagoClass
    Dim posicion As Integer
    Dim importeanterior As Decimal
    Public Sub New(ByRef lst As List(Of PagoClass))

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        pago.accion = "Agregar"
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lstPagos = lst

    End Sub

    Public Sub New(ByRef lst As List(Of PagoClass), ByVal p As PagoClass, ByVal pos As Integer)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lstPagos = lst

        pago = p

        posicion = pos
    End Sub
    Private Sub Pagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If pago.accion = "Modificar" Or pago.accion = "MA" Then

            txtId.Text = pago.Id
            txtIdReserva.Text = pago.IdReserva
            txtIImporte.Text = pago.Importe
            dtpFecha.Text = pago.Fecha
            txtDescripcion.Text = pago.Descripcion
            importeanterior = pago.Importe

        End If

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If funcion.ValidarCampos(Me.Controls, ErrorProvider1) Then

            If pago.accion = "Agregar" Then

                If CDec(txtIImporte.Text) > deuda Then

                    MsgBox("El importe ingresado supera la deuda actual de: $" + CStr(deuda))

                    Exit Sub

                End If

            Else
                If deuda = 0 Then

                    If CDec(txtIImporte.Text) > importeanterior Then

                        MsgBox("El importe ingresado supera el importe anterior de: ($" + CStr(importeanterior) + "),siendo la deuda actual de : ($00,00)")

                        Exit Sub

                    End If
                Else

                    If CDec(txtIImporte.Text) > (deuda + importeanterior) Then

                        MsgBox("El importe ingresado supera la deuda actual de: $" + CStr(deuda))

                        Exit Sub

                    End If
                End If
            End If

       

            Select Case pago.accion

                Case "Agregar"
                    Datos()
                    lstPagos.Add(pago)

                Case "Modificar"

                    Datos()

                    lstPagos(posicion) = pago


                Case "MA"

                    pago.accion = "Agregar"

                    Datos()

                    lstPagos(posicion) = pago

            End Select

            Close()

        End If

    End Sub
    Private Sub Datos()

        pago.Importe = txtIImporte.Text
        pago.Descripcion = txtDescripcion.Text
        pago.Fecha = dtpFecha.Text

    End Sub
    Private Sub txtImporte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIImporte.KeyPress

        funcion.IngresoSoloNumeros(e)

    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Close()

    End Sub
End Class