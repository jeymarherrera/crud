<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmContactos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgvContactos = New System.Windows.Forms.DataGridView()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxGenero = New System.Windows.Forms.ComboBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtID.Location = New System.Drawing.Point(23, 43)
        Me.txtID.Name = "txtID"
        Me.txtID.PlaceholderText = "Ingrese Identificacion"
        Me.txtID.Size = New System.Drawing.Size(405, 25)
        Me.txtID.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNombre.Location = New System.Drawing.Point(23, 74)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PlaceholderText = "Ingrese Nombre"
        Me.txtNombre.Size = New System.Drawing.Size(405, 25)
        Me.txtNombre.TabIndex = 7
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtApellido.Location = New System.Drawing.Point(23, 105)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.PlaceholderText = "Ingrese Apellido"
        Me.txtApellido.Size = New System.Drawing.Size(405, 25)
        Me.txtApellido.TabIndex = 8
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtFecha.Location = New System.Drawing.Point(23, 136)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.PlaceholderText = "Fecha de Nacimiento (yyyy-mm-dd)"
        Me.txtFecha.Size = New System.Drawing.Size(405, 25)
        Me.txtFecha.TabIndex = 9
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNuevo.Location = New System.Drawing.Point(597, 118)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(148, 30)
        Me.btnNuevo.TabIndex = 11
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAgregar.Location = New System.Drawing.Point(597, 154)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(148, 30)
        Me.btnAgregar.TabIndex = 12
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnModificar.Location = New System.Drawing.Point(597, 190)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(148, 30)
        Me.btnModificar.TabIndex = 13
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEliminar.Location = New System.Drawing.Point(597, 226)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(148, 30)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'dgvContactos
        '
        Me.dgvContactos.AllowUserToAddRows = False
        Me.dgvContactos.AllowUserToDeleteRows = False
        Me.dgvContactos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvContactos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactos.Location = New System.Drawing.Point(29, 434)
        Me.dgvContactos.Name = "dgvContactos"
        Me.dgvContactos.ReadOnly = True
        Me.dgvContactos.RowTemplate.Height = 25
        Me.dgvContactos.Size = New System.Drawing.Size(742, 292)
        Me.dgvContactos.TabIndex = 15
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(29, 396)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.PlaceholderText = "Ingrese Dato de Contacto a Buscar"
        Me.txtBusqueda.Size = New System.Drawing.Size(742, 23)
        Me.txtBusqueda.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(249, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(361, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "SISTEMA DE REGISTRO DE CONTACTOS"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.cbxGenero)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Location = New System.Drawing.Point(79, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 271)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Contacto"
        '
        'cbxGenero
        '
        Me.cbxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxGenero.FormattingEnabled = True
        Me.cbxGenero.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.cbxGenero.Location = New System.Drawing.Point(23, 167)
        Me.cbxGenero.Name = "cbxGenero"
        Me.cbxGenero.Size = New System.Drawing.Size(405, 23)
        Me.cbxGenero.TabIndex = 13
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDireccion.Location = New System.Drawing.Point(23, 227)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.PlaceholderText = "Ingrese Direccion"
        Me.txtDireccion.Size = New System.Drawing.Size(405, 25)
        Me.txtDireccion.TabIndex = 12
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtTelefono.Location = New System.Drawing.Point(23, 196)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.PlaceholderText = "Ingrese Telefono"
        Me.txtTelefono.Size = New System.Drawing.Size(405, 25)
        Me.txtTelefono.TabIndex = 11
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnGuardar.Location = New System.Drawing.Point(597, 262)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(148, 30)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSalir.Location = New System.Drawing.Point(597, 297)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(148, 30)
        Me.btnSalir.TabIndex = 21
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(380, 366)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 21)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "CONTACTOS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(814, 749)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.dgvContactos)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Name = "Form1"
        Me.Text = "Sistema de Registros"
        CType(Me.dgvContactos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents dgvContactos As DataGridView
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbxGenero As ComboBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label1 As Label
End Class
