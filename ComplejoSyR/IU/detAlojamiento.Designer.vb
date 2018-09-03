<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detAlojamiento
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(detAlojamiento))
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtId = New System.Windows.Forms.TextBox
        Me.comboSector = New System.Windows.Forms.ComboBox
        Me.comboModalidad = New System.Windows.Forms.ComboBox
        Me.txtCapacidad = New System.Windows.Forms.TextBox
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Id"
        Me.Label5.Visible = False
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(104, 16)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 35
        Me.txtId.Visible = False
        '
        'comboSector
        '
        Me.comboSector.FormattingEnabled = True
        Me.comboSector.Items.AddRange(New Object() {"PB", "PA"})
        Me.comboSector.Location = New System.Drawing.Point(296, 86)
        Me.comboSector.Name = "comboSector"
        Me.comboSector.Size = New System.Drawing.Size(121, 21)
        Me.comboSector.TabIndex = 39
        '
        'comboModalidad
        '
        Me.comboModalidad.FormattingEnabled = True
        Me.comboModalidad.Location = New System.Drawing.Point(104, 86)
        Me.comboModalidad.Name = "comboModalidad"
        Me.comboModalidad.Size = New System.Drawing.Size(121, 21)
        Me.comboModalidad.TabIndex = 38
        '
        'txtCapacidad
        '
        Me.txtCapacidad.Location = New System.Drawing.Point(296, 43)
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCapacidad.TabIndex = 37
        Me.txtCapacidad.Tag = "Validar"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(104, 43)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 36
        Me.txtNumero.Tag = "Validar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(251, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Sector"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Modalidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(231, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Capacidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Numero"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(251, 137)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(114, 24)
        Me.btnCancelar.TabIndex = 86
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Location = New System.Drawing.Point(92, 137)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(114, 24)
        Me.btnAceptar.TabIndex = 85
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'detAlojamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(456, 184)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.comboSector)
        Me.Controls.Add(Me.comboModalidad)
        Me.Controls.Add(Me.txtCapacidad)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "detAlojamiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Validar"
        Me.Text = "Alojamiento"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents comboSector As System.Windows.Forms.ComboBox
    Friend WithEvents comboModalidad As System.Windows.Forms.ComboBox
    Friend WithEvents txtCapacidad As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
