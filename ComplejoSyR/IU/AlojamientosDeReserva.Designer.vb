<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlojamientosDeReserva
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnCargar = New System.Windows.Forms.Button
        Me.dgvAlojRes = New System.Windows.Forms.DataGridView
        Me.cbTipo = New System.Windows.Forms.ComboBox
        CType(Me.dgvAlojRes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate
        Me.btnSalir.FlatAppearance.BorderSize = 2
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnSalir.Location = New System.Drawing.Point(243, 289)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(83, 31)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnCargar
        '
        Me.btnCargar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCargar.BackColor = System.Drawing.Color.White
        Me.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate
        Me.btnCargar.FlatAppearance.BorderSize = 2
        Me.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargar.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnCargar.Location = New System.Drawing.Point(100, 289)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(83, 31)
        Me.btnCargar.TabIndex = 4
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = False
        '
        'dgvAlojRes
        '
        Me.dgvAlojRes.AllowUserToAddRows = False
        Me.dgvAlojRes.AllowUserToDeleteRows = False
        Me.dgvAlojRes.AllowUserToResizeColumns = False
        Me.dgvAlojRes.AllowUserToResizeRows = False
        Me.dgvAlojRes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAlojRes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAlojRes.BackgroundColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAlojRes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvAlojRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAlojRes.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvAlojRes.Location = New System.Drawing.Point(12, 39)
        Me.dgvAlojRes.Name = "dgvAlojRes"
        Me.dgvAlojRes.ReadOnly = True
        Me.dgvAlojRes.RowHeadersVisible = False
        Me.dgvAlojRes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlojRes.Size = New System.Drawing.Size(397, 240)
        Me.dgvAlojRes.TabIndex = 3
        '
        'cbTipo
        '
        Me.cbTipo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"Camping", "Habitacional"})
        Me.cbTipo.Location = New System.Drawing.Point(132, 12)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(163, 21)
        Me.cbTipo.TabIndex = 6
        '
        'AlojamientosDeReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(421, 332)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.dgvAlojRes)
        Me.MinimumSize = New System.Drawing.Size(437, 358)
        Me.Name = "AlojamientosDeReserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alojamientos Disponibles"
        CType(Me.dgvAlojRes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents dgvAlojRes As System.Windows.Forms.DataGridView
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
End Class
