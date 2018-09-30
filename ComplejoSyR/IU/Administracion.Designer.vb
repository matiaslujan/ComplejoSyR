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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administracion))
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
        'tabModalidades
        '
        Me.tabModalidades.BackColor = System.Drawing.Color.LightSkyBlue
        Me.tabModalidades.Controls.Add(Me.dgvModalidades)
        Me.tabModalidades.Controls.Add(Me.btnDelMod)
        Me.tabModalidades.Controls.Add(Me.btnUpdMod)
        Me.tabModalidades.Controls.Add(Me.btnAddMod)
        Me.tabModalidades.Location = New System.Drawing.Point(4, 29)
        Me.tabModalidades.Name = "tabModalidades"
        Me.tabModalidades.Size = New System.Drawing.Size(634, 282)
        Me.tabModalidades.TabIndex = 2
        Me.tabModalidades.Text = "Modalidades"
        '
        'dgvModalidades
        '
        Me.dgvModalidades.AllowUserToAddRows = False
        Me.dgvModalidades.AllowUserToDeleteRows = False
        Me.dgvModalidades.AllowUserToResizeColumns = False
        Me.dgvModalidades.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvModalidades.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvModalidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvModalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvModalidades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvModalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModalidades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvModalidades.Location = New System.Drawing.Point(0, 0)
        Me.dgvModalidades.MultiSelect = False
        Me.dgvModalidades.Name = "dgvModalidades"
        Me.dgvModalidades.ReadOnly = True
        Me.dgvModalidades.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvModalidades.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvModalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvModalidades.Size = New System.Drawing.Size(634, 237)
        Me.dgvModalidades.TabIndex = 9
        '
        'btnDelMod
        '
        Me.btnDelMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelMod.BackColor = System.Drawing.Color.White
        Me.btnDelMod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelMod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelMod.FlatAppearance.BorderSize = 2
        Me.btnDelMod.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelMod.Location = New System.Drawing.Point(193, 243)
        Me.btnDelMod.Name = "btnDelMod"
        Me.btnDelMod.Size = New System.Drawing.Size(87, 32)
        Me.btnDelMod.TabIndex = 8
        Me.btnDelMod.Text = "Eliminar"
        Me.btnDelMod.UseVisualStyleBackColor = False
        '
        'btnUpdMod
        '
        Me.btnUpdMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUpdMod.BackColor = System.Drawing.Color.White
        Me.btnUpdMod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdMod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdMod.FlatAppearance.BorderSize = 2
        Me.btnUpdMod.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdMod.Location = New System.Drawing.Point(100, 243)
        Me.btnUpdMod.Name = "btnUpdMod"
        Me.btnUpdMod.Size = New System.Drawing.Size(87, 32)
        Me.btnUpdMod.TabIndex = 7
        Me.btnUpdMod.Text = "Modificar"
        Me.btnUpdMod.UseVisualStyleBackColor = False
        '
        'btnAddMod
        '
        Me.btnAddMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAddMod.BackColor = System.Drawing.Color.White
        Me.btnAddMod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddMod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddMod.FlatAppearance.BorderSize = 2
        Me.btnAddMod.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMod.Location = New System.Drawing.Point(8, 243)
        Me.btnAddMod.Name = "btnAddMod"
        Me.btnAddMod.Size = New System.Drawing.Size(87, 32)
        Me.btnAddMod.TabIndex = 6
        Me.btnAddMod.Text = "Agregar"
        Me.btnAddMod.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabAlojamientos)
        Me.TabControl1.Controls.Add(Me.tabModalidades)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(642, 315)
        Me.TabControl1.TabIndex = 1
        '
        'tabAlojamientos
        '
        Me.tabAlojamientos.BackColor = System.Drawing.Color.LightSkyBlue
        Me.tabAlojamientos.Controls.Add(Me.dgvAlojamientos)
        Me.tabAlojamientos.Controls.Add(Me.btnDeletAloj)
        Me.tabAlojamientos.Controls.Add(Me.btnModAloj)
        Me.tabAlojamientos.Controls.Add(Me.btnAddAloj)
        Me.tabAlojamientos.Location = New System.Drawing.Point(4, 29)
        Me.tabAlojamientos.Name = "tabAlojamientos"
        Me.tabAlojamientos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAlojamientos.Size = New System.Drawing.Size(634, 282)
        Me.tabAlojamientos.TabIndex = 0
        Me.tabAlojamientos.Text = "Alojamientos"
        '
        'dgvAlojamientos
        '
        Me.dgvAlojamientos.AllowUserToAddRows = False
        Me.dgvAlojamientos.AllowUserToResizeColumns = False
        Me.dgvAlojamientos.AllowUserToResizeRows = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvAlojamientos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvAlojamientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAlojamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAlojamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlojamientos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvAlojamientos.Location = New System.Drawing.Point(3, 3)
        Me.dgvAlojamientos.MultiSelect = False
        Me.dgvAlojamientos.Name = "dgvAlojamientos"
        Me.dgvAlojamientos.ReadOnly = True
        Me.dgvAlojamientos.RowHeadersVisible = False
        Me.dgvAlojamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlojamientos.Size = New System.Drawing.Size(628, 237)
        Me.dgvAlojamientos.TabIndex = 14
        '
        'btnDeletAloj
        '
        Me.btnDeletAloj.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDeletAloj.BackColor = System.Drawing.Color.White
        Me.btnDeletAloj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeletAloj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeletAloj.FlatAppearance.BorderSize = 2
        Me.btnDeletAloj.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeletAloj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeletAloj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeletAloj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletAloj.Location = New System.Drawing.Point(202, 245)
        Me.btnDeletAloj.Name = "btnDeletAloj"
        Me.btnDeletAloj.Size = New System.Drawing.Size(87, 32)
        Me.btnDeletAloj.TabIndex = 12
        Me.btnDeletAloj.Text = "Eliminar"
        Me.btnDeletAloj.UseVisualStyleBackColor = False
        '
        'btnModAloj
        '
        Me.btnModAloj.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModAloj.BackColor = System.Drawing.Color.White
        Me.btnModAloj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModAloj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnModAloj.FlatAppearance.BorderSize = 2
        Me.btnModAloj.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnModAloj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnModAloj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnModAloj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModAloj.Location = New System.Drawing.Point(105, 245)
        Me.btnModAloj.Name = "btnModAloj"
        Me.btnModAloj.Size = New System.Drawing.Size(87, 32)
        Me.btnModAloj.TabIndex = 11
        Me.btnModAloj.Text = "Modificar"
        Me.btnModAloj.UseVisualStyleBackColor = False
        '
        'btnAddAloj
        '
        Me.btnAddAloj.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAddAloj.BackColor = System.Drawing.Color.White
        Me.btnAddAloj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddAloj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddAloj.FlatAppearance.BorderSize = 2
        Me.btnAddAloj.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddAloj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddAloj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddAloj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAloj.Location = New System.Drawing.Point(8, 245)
        Me.btnAddAloj.Name = "btnAddAloj"
        Me.btnAddAloj.Size = New System.Drawing.Size(87, 32)
        Me.btnAddAloj.TabIndex = 10
        Me.btnAddAloj.Text = "Agregar"
        Me.btnAddAloj.UseVisualStyleBackColor = False
        '
        'Administracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(642, 315)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(658, 354)
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
