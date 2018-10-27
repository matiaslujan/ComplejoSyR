<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.btnReservas = New System.Windows.Forms.ToolStripMenuItem
        Me.btnClientes = New System.Windows.Forms.ToolStripMenuItem
        Me.btnAdministracion = New System.Windows.Forms.ToolStripMenuItem
        Me.cbTipo = New System.Windows.Forms.ToolStripComboBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.dgvOcupacion = New System.Windows.Forms.DataGridView
        Me.Calendario = New System.Windows.Forms.MonthCalendar
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.btnNuevaReserva = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.btnSeRetiran = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOcupacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnReservas, Me.btnClientes, Me.btnAdministracion, Me.cbTipo})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(876, 40)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnReservas
        '
        Me.btnReservas.BackColor = System.Drawing.Color.Transparent
        Me.btnReservas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReservas.Checked = True
        Me.btnReservas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btnReservas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservas.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnReservas.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.btnReservas.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.btnReservas.Name = "btnReservas"
        Me.btnReservas.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded
        Me.btnReservas.Padding = New System.Windows.Forms.Padding(4)
        Me.btnReservas.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.btnReservas.Size = New System.Drawing.Size(100, 36)
        Me.btnReservas.Text = "Reservas"
        '
        'btnClientes
        '
        Me.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Padding = New System.Windows.Forms.Padding(4)
        Me.btnClientes.Size = New System.Drawing.Size(89, 36)
        Me.btnClientes.Text = "Clientes"
        '
        'btnAdministracion
        '
        Me.btnAdministracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdministracion.Checked = True
        Me.btnAdministracion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btnAdministracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdministracion.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnAdministracion.Name = "btnAdministracion"
        Me.btnAdministracion.Padding = New System.Windows.Forms.Padding(4)
        Me.btnAdministracion.Size = New System.Drawing.Size(146, 36)
        Me.btnAdministracion.Text = "Administracion"
        '
        'cbTipo
        '
        Me.cbTipo.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.cbTipo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cbTipo.BackColor = System.Drawing.Color.LemonChiffon
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTipo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.Items.AddRange(New Object() {"Camping", "Habitacional"})
        Me.cbTipo.Margin = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(121, 36)
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.ComplejoSolYRio.My.Resources.Resources.iniciolog
        Me.PictureBox1.Location = New System.Drawing.Point(526, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(344, 519)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 132
        Me.PictureBox1.TabStop = False
        '
        'dgvOcupacion
        '
        Me.dgvOcupacion.AllowUserToAddRows = False
        Me.dgvOcupacion.AllowUserToDeleteRows = False
        Me.dgvOcupacion.AllowUserToResizeColumns = False
        Me.dgvOcupacion.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvOcupacion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOcupacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOcupacion.BackgroundColor = System.Drawing.Color.White
        Me.dgvOcupacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvOcupacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOcupacion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvOcupacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOcupacion.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOcupacion.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvOcupacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOcupacion.Location = New System.Drawing.Point(3, 176)
        Me.dgvOcupacion.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.dgvOcupacion.MultiSelect = False
        Me.dgvOcupacion.Name = "dgvOcupacion"
        Me.dgvOcupacion.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOcupacion.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvOcupacion.RowHeadersVisible = False
        Me.dgvOcupacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOcupacion.Size = New System.Drawing.Size(511, 262)
        Me.dgvOcupacion.TabIndex = 5
        '
        'Calendario
        '
        Me.Calendario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Calendario.BackColor = System.Drawing.SystemColors.Desktop
        Me.Calendario.CalendarDimensions = New System.Drawing.Size(2, 1)
        Me.Calendario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Calendario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calendario.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Calendario.Location = New System.Drawing.Point(9, 9)
        Me.Calendario.MaxSelectionCount = 30
        Me.Calendario.Name = "Calendario"
        Me.Calendario.TabIndex = 6
        Me.Calendario.TitleBackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Calendario.TitleForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Calendario.TrailingForeColor = System.Drawing.SystemColors.Desktop
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 40)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 525)
        Me.Splitter1.TabIndex = 134
        Me.Splitter1.TabStop = False
        '
        'btnNuevaReserva
        '
        Me.btnNuevaReserva.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevaReserva.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnNuevaReserva.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevaReserva.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate
        Me.btnNuevaReserva.FlatAppearance.BorderSize = 0
        Me.btnNuevaReserva.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnNuevaReserva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnNuevaReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnNuevaReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevaReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaReserva.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnNuevaReserva.Location = New System.Drawing.Point(3, 30)
        Me.btnNuevaReserva.Name = "btnNuevaReserva"
        Me.btnNuevaReserva.Size = New System.Drawing.Size(249, 32)
        Me.btnNuevaReserva.TabIndex = 133
        Me.btnNuevaReserva.Text = "Nueva Reserva"
        Me.btnNuevaReserva.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnBuscar.Location = New System.Drawing.Point(258, 30)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(250, 32)
        Me.btnBuscar.TabIndex = 132
        Me.btnBuscar.Text = "Buscar Reserva"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.OldLace
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 40)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(873, 525)
        Me.TableLayoutPanel1.TabIndex = 135
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Calendario, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dgvOcupacion, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.63135!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.36865!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(517, 519)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnNuevaReserva, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btnBuscar, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btnSeRetiran, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Button1, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 451)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(511, 65)
        Me.TableLayoutPanel3.TabIndex = 7
        '
        'btnSeRetiran
        '
        Me.btnSeRetiran.BackColor = System.Drawing.Color.YellowGreen
        Me.btnSeRetiran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSeRetiran.FlatAppearance.BorderSize = 0
        Me.btnSeRetiran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeRetiran.Location = New System.Drawing.Point(3, 3)
        Me.btnSeRetiran.Name = "btnSeRetiran"
        Me.btnSeRetiran.Size = New System.Drawing.Size(249, 21)
        Me.btnSeRetiran.TabIndex = 134
        Me.btnSeRetiran.Text = "Se retiran hoy"
        Me.btnSeRetiran.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(258, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 21)
        Me.Button1.TabIndex = 135
        Me.Button1.Text = "Ingresan Hoy"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(876, 565)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(892, 604)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOcupacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btnReservas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAdministracion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvOcupacion As System.Windows.Forms.DataGridView
    Friend WithEvents Calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnNuevaReserva As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cbTipo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents btnSeRetiran As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
