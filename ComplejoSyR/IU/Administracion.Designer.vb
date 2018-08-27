<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administracion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabCuentas = New System.Windows.Forms.TabPage
        Me.tabModalidades = New System.Windows.Forms.TabPage
        Me.dgvModalidades = New System.Windows.Forms.DataGridView
        Me.btnDelMod = New System.Windows.Forms.Button
        Me.btnUpdMod = New System.Windows.Forms.Button
        Me.btnAddMod = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabAlojamientos = New System.Windows.Forms.TabPage
        Me.dgvAlojamientos = New System.Windows.Forms.DataGridView
        Me.btnDeletAloj = New System.Windows.Forms.Button
        Me.btnModAloj = New System.Windows.Forms.Button
        Me.btnAddAloj = New System.Windows.Forms.Button
        Me.tabModalidades.SuspendLayout()
        CType(Me.dgvModalidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabAlojamientos.SuspendLayout()
        CType(Me.dgvAlojamientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabCuentas
        '
        Me.tabCuentas.Location = New System.Drawing.Point(4, 22)
        Me.tabCuentas.Name = "tabCuentas"
        Me.tabCuentas.Size = New System.Drawing.Size(621, 266)
        Me.tabCuentas.TabIndex = 3
        Me.tabCuentas.Text = "Cuentas"
        Me.tabCuentas.UseVisualStyleBackColor = True
        '
        'tabModalidades
        '
        Me.tabModalidades.Controls.Add(Me.dgvModalidades)
        Me.tabModalidades.Controls.Add(Me.btnDelMod)
        Me.tabModalidades.Controls.Add(Me.btnUpdMod)
        Me.tabModalidades.Controls.Add(Me.btnAddMod)
        Me.tabModalidades.Location = New System.Drawing.Point(4, 22)
        Me.tabModalidades.Name = "tabModalidades"
        Me.tabModalidades.Size = New System.Drawing.Size(621, 266)
        Me.tabModalidades.TabIndex = 2
        Me.tabModalidades.Text = "Modalidades"
        Me.tabModalidades.UseVisualStyleBackColor = True
        '
        'dgvModalidades
        '
        Me.dgvModalidades.AllowUserToAddRows = False
        Me.dgvModalidades.AllowUserToDeleteRows = False
        Me.dgvModalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvModalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModalidades.Location = New System.Drawing.Point(0, 0)
        Me.dgvModalidades.MultiSelect = False
        Me.dgvModalidades.Name = "dgvModalidades"
        Me.dgvModalidades.ReadOnly = True
        Me.dgvModalidades.RowHeadersVisible = False
        Me.dgvModalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvModalidades.Size = New System.Drawing.Size(621, 237)
        Me.dgvModalidades.TabIndex = 9
        '
        'btnDelMod
        '
        Me.btnDelMod.Location = New System.Drawing.Point(162, 243)
        Me.btnDelMod.Name = "btnDelMod"
        Me.btnDelMod.Size = New System.Drawing.Size(75, 23)
        Me.btnDelMod.TabIndex = 8
        Me.btnDelMod.Text = "Eliminar"
        Me.btnDelMod.UseVisualStyleBackColor = True
        '
        'btnUpdMod
        '
        Me.btnUpdMod.Location = New System.Drawing.Point(81, 243)
        Me.btnUpdMod.Name = "btnUpdMod"
        Me.btnUpdMod.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdMod.TabIndex = 7
        Me.btnUpdMod.Text = "Modificar"
        Me.btnUpdMod.UseVisualStyleBackColor = True
        '
        'btnAddMod
        '
        Me.btnAddMod.Location = New System.Drawing.Point(0, 243)
        Me.btnAddMod.Name = "btnAddMod"
        Me.btnAddMod.Size = New System.Drawing.Size(75, 23)
        Me.btnAddMod.TabIndex = 6
        Me.btnAddMod.Text = "Agregar"
        Me.btnAddMod.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabAlojamientos)
        Me.TabControl1.Controls.Add(Me.tabModalidades)
        Me.TabControl1.Controls.Add(Me.tabCuentas)
        Me.TabControl1.Location = New System.Drawing.Point(1, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(629, 292)
        Me.TabControl1.TabIndex = 1
        '
        'tabAlojamientos
        '
        Me.tabAlojamientos.Controls.Add(Me.dgvAlojamientos)
        Me.tabAlojamientos.Controls.Add(Me.btnDeletAloj)
        Me.tabAlojamientos.Controls.Add(Me.btnModAloj)
        Me.tabAlojamientos.Controls.Add(Me.btnAddAloj)
        Me.tabAlojamientos.Location = New System.Drawing.Point(4, 22)
        Me.tabAlojamientos.Name = "tabAlojamientos"
        Me.tabAlojamientos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAlojamientos.Size = New System.Drawing.Size(621, 266)
        Me.tabAlojamientos.TabIndex = 0
        Me.tabAlojamientos.Text = "Alojamientos"
        Me.tabAlojamientos.UseVisualStyleBackColor = True
        '
        'dgvAlojamientos
        '
        Me.dgvAlojamientos.AllowUserToAddRows = False
        Me.dgvAlojamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAlojamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlojamientos.Location = New System.Drawing.Point(0, 0)
        Me.dgvAlojamientos.MultiSelect = False
        Me.dgvAlojamientos.Name = "dgvAlojamientos"
        Me.dgvAlojamientos.ReadOnly = True
        Me.dgvAlojamientos.RowHeadersVisible = False
        Me.dgvAlojamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlojamientos.Size = New System.Drawing.Size(623, 237)
        Me.dgvAlojamientos.TabIndex = 14
        '
        'btnDeletAloj
        '
        Me.btnDeletAloj.Location = New System.Drawing.Point(162, 243)
        Me.btnDeletAloj.Name = "btnDeletAloj"
        Me.btnDeletAloj.Size = New System.Drawing.Size(75, 23)
        Me.btnDeletAloj.TabIndex = 12
        Me.btnDeletAloj.Text = "Eliminar"
        Me.btnDeletAloj.UseVisualStyleBackColor = True
        '
        'btnModAloj
        '
        Me.btnModAloj.Location = New System.Drawing.Point(81, 243)
        Me.btnModAloj.Name = "btnModAloj"
        Me.btnModAloj.Size = New System.Drawing.Size(75, 23)
        Me.btnModAloj.TabIndex = 11
        Me.btnModAloj.Text = "Modificar"
        Me.btnModAloj.UseVisualStyleBackColor = True
        '
        'btnAddAloj
        '
        Me.btnAddAloj.Location = New System.Drawing.Point(0, 243)
        Me.btnAddAloj.Name = "btnAddAloj"
        Me.btnAddAloj.Size = New System.Drawing.Size(75, 23)
        Me.btnAddAloj.TabIndex = 10
        Me.btnAddAloj.Text = "Agregar"
        Me.btnAddAloj.UseVisualStyleBackColor = True
        '
        'Administracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 292)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Administracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administracion"
        Me.tabModalidades.ResumeLayout(False)
        CType(Me.dgvModalidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabAlojamientos.ResumeLayout(False)
        CType(Me.dgvAlojamientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabCuentas As System.Windows.Forms.TabPage
    Friend WithEvents tabModalidades As System.Windows.Forms.TabPage
    Friend WithEvents dgvModalidades As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelMod As System.Windows.Forms.Button
    Friend WithEvents btnUpdMod As System.Windows.Forms.Button
    Friend WithEvents btnAddMod As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabAlojamientos As System.Windows.Forms.TabPage
    Friend WithEvents dgvAlojamientos As System.Windows.Forms.DataGridView
    Friend WithEvents btnDeletAloj As System.Windows.Forms.Button
    Friend WithEvents btnModAloj As System.Windows.Forms.Button
    Friend WithEvents btnAddAloj As System.Windows.Forms.Button
End Class
