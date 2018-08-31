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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.btnReservas = New System.Windows.Forms.ToolStripMenuItem
        Me.btnClientes = New System.Windows.Forms.ToolStripMenuItem
        Me.btnAdministracion = New System.Windows.Forms.ToolStripMenuItem
        Me.Calendario = New System.Windows.Forms.MonthCalendar
        Me.dgvOcupacion = New System.Windows.Forms.DataGridView
        Me.btnNuevaReserva = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvOcupacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnReservas, Me.btnClientes, Me.btnAdministracion})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(861, 40)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnReservas
        '
        Me.btnReservas.BackColor = System.Drawing.Color.Transparent
        Me.btnReservas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReservas.Checked = True
        Me.btnReservas.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.btnReservas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservas.ForeColor = System.Drawing.SystemColors.ControlText
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
        Me.btnClientes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Padding = New System.Windows.Forms.Padding(4)
        Me.btnClientes.Size = New System.Drawing.Size(89, 36)
        Me.btnClientes.Text = "Clientes"
        '
        'btnAdministracion
        '
        Me.btnAdministracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdministracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdministracion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAdministracion.Name = "btnAdministracion"
        Me.btnAdministracion.Padding = New System.Windows.Forms.Padding(4)
        Me.btnAdministracion.Size = New System.Drawing.Size(146, 36)
        Me.btnAdministracion.Text = "Administracion"
        '
        'Calendario
        '
        Me.Calendario.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Calendario.CalendarDimensions = New System.Drawing.Size(2, 2)
        Me.Calendario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Calendario.Dock = System.Windows.Forms.DockStyle.Top
        Me.Calendario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calendario.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Calendario.Location = New System.Drawing.Point(0, 0)
        Me.Calendario.MaxSelectionCount = 30
        Me.Calendario.Name = "Calendario"
        Me.Calendario.TabIndex = 6
        Me.Calendario.TitleBackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Calendario.TitleForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Calendario.TrailingForeColor = System.Drawing.SystemColors.Desktop
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOcupacion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvOcupacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOcupacion.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOcupacion.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvOcupacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvOcupacion.Location = New System.Drawing.Point(0, 339)
        Me.dgvOcupacion.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.dgvOcupacion.MultiSelect = False
        Me.dgvOcupacion.Name = "dgvOcupacion"
        Me.dgvOcupacion.RowHeadersVisible = False
        Me.dgvOcupacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOcupacion.Size = New System.Drawing.Size(504, 186)
        Me.dgvOcupacion.TabIndex = 5
        '
        'btnNuevaReserva
        '
        Me.btnNuevaReserva.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevaReserva.BackColor = System.Drawing.Color.White
        Me.btnNuevaReserva.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevaReserva.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnNuevaReserva.FlatAppearance.BorderSize = 3
        Me.btnNuevaReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnNuevaReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevaReserva.Location = New System.Drawing.Point(57, 78)
        Me.btnNuevaReserva.Name = "btnNuevaReserva"
        Me.btnNuevaReserva.Size = New System.Drawing.Size(250, 34)
        Me.btnNuevaReserva.TabIndex = 131
        Me.btnNuevaReserva.Text = "Nueva Reserva"
        Me.btnNuevaReserva.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnBuscar.FlatAppearance.BorderSize = 3
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(57, 206)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(250, 34)
        Me.btnBuscar.TabIndex = 130
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Image = Global.ComplejoSyR.My.Resources.Resources.inci
        Me.PictureBox1.Location = New System.Drawing.Point(0, 298)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(353, 227)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 132
        Me.PictureBox1.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 40)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Calendario)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvOcupacion)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnNuevaReserva)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnBuscar)
        Me.SplitContainer1.Size = New System.Drawing.Size(861, 525)
        Me.SplitContainer1.SplitterDistance = 504
        Me.SplitContainer1.TabIndex = 133
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(861, 565)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(877, 604)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvOcupacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btnReservas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents dgvOcupacion As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdministracion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnNuevaReserva As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer

End Class
