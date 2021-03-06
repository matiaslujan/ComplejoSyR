﻿Public Class detCliente
    Private funcion_ As New Funciones
    Public Property funcion() As Funciones
        Get
            Return funcion_
        End Get
        Set(ByVal value As Funciones)
            funcion_ = value
        End Set
    End Property
    Private Cliente_ As New ClienteClass
    Public Property Cliente() As ClienteClass
        Get
            Return Cliente_

        End Get
        Set(ByVal value As ClienteClass)
            Cliente_ = value
        End Set
    End Property

    Private Operacion_ As String

    Public Property Operacion() As String
        Get
            Return Operacion_
        End Get
        Set(ByVal value As String)
            Operacion_ = value
        End Set
    End Property

    Private Combo_ As ComboBox

    Public Property Combo() As ComboBox
        Get
            Return Combo_
        End Get
        Set(ByVal value As ComboBox)
            Combo_ = value
        End Set
    End Property
    'agregar cliente desd rsrva y cargar combo
    Public Sub New(ByVal com As ComboBox)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        Operacion = "AC"
        Combo = com
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        Operacion = "A"

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New(ByVal id As Integer)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Cliente.Id = id
        Cliente.Datos(Cliente)
        Operacion = "M"

    End Sub

    Private Sub detCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cbProvincia.SelectedIndex = 0

        If Operacion = "M" Then

            Me.Text = "Modificar " + CStr(Me.Text)

            txtId.Text = Cliente.Id
            txtNombre.Text = Cliente.Nombre
            txtDomicilio.Text = Cliente.Domicilio
            txtTelefono.Text = Cliente.Telefono
            txtCorreo.Text = Cliente.Correo
            cbProvincia.SelectedItem = Cliente.Provincia
            txtVehiculo.Text = Cliente.Vehiculo
            txtPatente.Text = Cliente.Patente

        Else
            Me.Text = "Nuevo " + CStr(Me.Text)
            btnHistory.Visible = False
        End If

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If funcion.ValidarCampos(Me.Controls, ErrorProvider1) Then

            Cliente.Nombre = txtNombre.Text
            Cliente.Telefono = txtTelefono.Text
            Cliente.Correo = txtCorreo.Text
            Cliente.Domicilio = txtDomicilio.Text
            Cliente.Provincia = cbProvincia.SelectedItem
            Cliente.Vehiculo = txtVehiculo.Text
            Cliente.Patente = txtPatente.Text

            Select Case Operacion
                Case "A"
                    Cliente.Agregar(Cliente)
                    Close()
                Case "M"
                    Cliente.Id = txtId.Text
                    Cliente.Modificar(Cliente)
                    Close()
                Case "AC"
                    Cliente.Agregar(Cliente)
                    Cliente.cargarCombo(Combo)
                    Close()
                    Exit Sub
            End Select

        End If

    End Sub

   
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Close()

    End Sub

    Private Sub btnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistory.Click

        Dim his As New Historial(txtId.Text)

        his.ShowDialog()

    End Sub
End Class