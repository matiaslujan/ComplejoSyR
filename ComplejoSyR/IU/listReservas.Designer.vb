﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listReservas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listReservas))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvReservas = New System.Windows.Forms.DataGridView
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.cbFiltros = New System.Windows.Forms.ComboBox
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupRetiro = New System.Windows.Forms.GroupBox
        Me.btnConfirmar = New System.Windows.Forms.Button
        Me.btnCancelarReserva = New System.Windows.Forms.Button
        CType(Me.dgvReservas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupRetiro.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvReservas
        '
        Me.dgvReservas.AllowUserToAddRows = False
        Me.dgvReservas.AllowUserToDeleteRows = False
        Me.dgvReservas.AllowUserToResizeColumns = False
        Me.dgvReservas.AllowUserToResizeRows = False
        resources.ApplyResources(Me.dgvReservas, "dgvReservas")
        Me.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReservas.BackgroundColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReservas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReservas.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReservas.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvReservas.MultiSelect = False
        Me.dgvReservas.Name = "dgvReservas"
        Me.dgvReservas.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReservas.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvReservas.RowHeadersVisible = False
        Me.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate
        Me.btnAgregar.FlatAppearance.BorderSize = 2
        resources.ApplyResources(Me.btnAgregar, "btnAgregar")
        Me.btnAgregar.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate
        Me.btnEliminar.FlatAppearance.BorderSize = 2
        resources.ApplyResources(Me.btnEliminar, "btnEliminar")
        Me.btnEliminar.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate
        Me.btnModificar.FlatAppearance.BorderSize = 2
        resources.ApplyResources(Me.btnModificar, "btnModificar")
        Me.btnModificar.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label1.Name = "Label1"
        '
        'txtBuscar
        '
        resources.ApplyResources(Me.txtBuscar, "txtBuscar")
        Me.txtBuscar.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBuscar.Name = "txtBuscar"
        '
        'cbFiltros
        '
        resources.ApplyResources(Me.cbFiltros, "cbFiltros")
        Me.cbFiltros.FormattingEnabled = True
        Me.cbFiltros.Items.AddRange(New Object() {resources.GetString("cbFiltros.Items"), resources.GetString("cbFiltros.Items1"), resources.GetString("cbFiltros.Items2"), resources.GetString("cbFiltros.Items3"), resources.GetString("cbFiltros.Items4")})
        Me.cbFiltros.Name = "cbFiltros"
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate
        Me.btnImprimir.FlatAppearance.BorderSize = 2
        resources.ApplyResources(Me.btnImprimir, "btnImprimir")
        Me.btnImprimir.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Name = "Label3"
        '
        'GroupRetiro
        '
        resources.ApplyResources(Me.GroupRetiro, "GroupRetiro")
        Me.GroupRetiro.BackColor = System.Drawing.Color.Transparent
        Me.GroupRetiro.Controls.Add(Me.btnConfirmar)
        Me.GroupRetiro.Controls.Add(Me.btnImprimir)
        Me.GroupRetiro.Controls.Add(Me.Label3)
        Me.GroupRetiro.Controls.Add(Me.Label2)
        Me.GroupRetiro.Name = "GroupRetiro"
        Me.GroupRetiro.TabStop = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate
        Me.btnConfirmar.FlatAppearance.BorderSize = 2
        resources.ApplyResources(Me.btnConfirmar, "btnConfirmar")
        Me.btnConfirmar.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'btnCancelarReserva
        '
        Me.btnCancelarReserva.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancelarReserva.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelarReserva.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate
        Me.btnCancelarReserva.FlatAppearance.BorderSize = 2
        resources.ApplyResources(Me.btnCancelarReserva, "btnCancelarReserva")
        Me.btnCancelarReserva.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnCancelarReserva.Name = "btnCancelarReserva"
        Me.btnCancelarReserva.UseVisualStyleBackColor = False
        '
        'listReservas
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Controls.Add(Me.GroupRetiro)
        Me.Controls.Add(Me.cbFiltros)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dgvReservas)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancelarReserva)
        Me.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Name = "listReservas"
        CType(Me.dgvReservas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupRetiro.ResumeLayout(False)
        Me.GroupRetiro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvReservas As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cbFiltros As System.Windows.Forms.ComboBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupRetiro As System.Windows.Forms.GroupBox
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnCancelarReserva As System.Windows.Forms.Button
End Class
