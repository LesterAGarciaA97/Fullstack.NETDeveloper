<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.grdUsuarios = New System.Windows.Forms.DataGridView()
        Me.grdContactos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.BtnNuevoContacto = New System.Windows.Forms.ToolStripButton()
        Me.BtnGuardarContacto = New System.Windows.Forms.ToolStripButton()
        Me.BtnEliminarContacto = New System.Windows.Forms.ToolStripButton()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grdTelefonos = New System.Windows.Forms.DataGridView()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.BtnAgregarTelefono = New System.Windows.Forms.ToolStripButton()
        Me.BtnEliminarTelefono = New System.Windows.Forms.ToolStripButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.txtDescripcionEmail = New System.Windows.Forms.TextBox()
        Me.txtEmailContacto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grdEmail = New System.Windows.Forms.DataGridView()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.BtnAgregarEmail = New System.Windows.Forms.ToolStripButton()
        Me.BtnEliminarEmail = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip5 = New System.Windows.Forms.ToolStrip()
        Me.BtnAgregarDireccion = New System.Windows.Forms.ToolStripButton()
        Me.BtnEliminarDireccion = New System.Windows.Forms.ToolStripButton()
        CType(Me.grdUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.grdTelefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.grdEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip4.SuspendLayout()
        Me.ToolStrip5.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdUsuarios
        '
        Me.grdUsuarios.AllowUserToAddRows = False
        Me.grdUsuarios.AllowUserToDeleteRows = False
        Me.grdUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdUsuarios.Location = New System.Drawing.Point(12, 147)
        Me.grdUsuarios.Name = "grdUsuarios"
        Me.grdUsuarios.ReadOnly = True
        Me.grdUsuarios.Size = New System.Drawing.Size(528, 220)
        Me.grdUsuarios.TabIndex = 0
        '
        'grdContactos
        '
        Me.grdContactos.AllowUserToAddRows = False
        Me.grdContactos.AllowUserToDeleteRows = False
        Me.grdContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdContactos.Location = New System.Drawing.Point(4, 16)
        Me.grdContactos.Name = "grdContactos"
        Me.grdContactos.ReadOnly = True
        Me.grdContactos.Size = New System.Drawing.Size(414, 177)
        Me.grdContactos.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Login"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Email"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(114, 12)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(411, 20)
        Me.txtNombre.TabIndex = 6
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(114, 40)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.ReadOnly = True
        Me.txtLogin.Size = New System.Drawing.Size(411, 20)
        Me.txtLogin.TabIndex = 7
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(114, 68)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(411, 20)
        Me.txtPassword.TabIndex = 8
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(114, 95)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(411, 20)
        Me.txtEmail.TabIndex = 9
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 374)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(980, 25)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton1.Text = "Nuevo"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripButton2.Text = "Guardar"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripButton3.Text = "Eliminar"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(78, 22)
        Me.ToolStripButton4.Text = "Modificar"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(79, 22)
        Me.ToolStripButton5.Text = "Actualizar"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(81, 22)
        Me.ToolStripButton6.Text = "Contactos"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(546, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(432, 356)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ToolStrip2)
        Me.TabPage2.Controls.Add(Me.txtApellidos)
        Me.TabPage2.Controls.Add(Me.txtNombres)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.grdContactos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(424, 330)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Contactos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNuevoContacto, Me.BtnGuardarContacto, Me.BtnEliminarContacto})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 302)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(418, 25)
        Me.ToolStrip2.TabIndex = 6
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'BtnNuevoContacto
        '
        Me.BtnNuevoContacto.Image = CType(resources.GetObject("BtnNuevoContacto.Image"), System.Drawing.Image)
        Me.BtnNuevoContacto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNuevoContacto.Name = "BtnNuevoContacto"
        Me.BtnNuevoContacto.Size = New System.Drawing.Size(62, 22)
        Me.BtnNuevoContacto.Text = "Nuevo"
        '
        'BtnGuardarContacto
        '
        Me.BtnGuardarContacto.Enabled = False
        Me.BtnGuardarContacto.Image = CType(resources.GetObject("BtnGuardarContacto.Image"), System.Drawing.Image)
        Me.BtnGuardarContacto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnGuardarContacto.Name = "BtnGuardarContacto"
        Me.BtnGuardarContacto.Size = New System.Drawing.Size(69, 22)
        Me.BtnGuardarContacto.Text = "Guardar"
        '
        'BtnEliminarContacto
        '
        Me.BtnEliminarContacto.Image = CType(resources.GetObject("BtnEliminarContacto.Image"), System.Drawing.Image)
        Me.BtnEliminarContacto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEliminarContacto.Name = "BtnEliminarContacto"
        Me.BtnEliminarContacto.Size = New System.Drawing.Size(70, 22)
        Me.BtnEliminarContacto.Text = "Eliminar"
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(105, 240)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.ReadOnly = True
        Me.txtApellidos.Size = New System.Drawing.Size(298, 20)
        Me.txtApellidos.TabIndex = 5
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(105, 212)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.ReadOnly = True
        Me.txtNombres.Size = New System.Drawing.Size(298, 20)
        Me.txtNombres.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Apellidos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nombres"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtDescripcion)
        Me.TabPage1.Controls.Add(Me.txtNumero)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.grdTelefonos)
        Me.TabPage1.Controls.Add(Me.ToolStrip3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(424, 330)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Teléfonos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(105, 240)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(298, 20)
        Me.txtDescripcion.TabIndex = 6
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(105, 212)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(298, 20)
        Me.txtNumero.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Descripción"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Número"
        '
        'grdTelefonos
        '
        Me.grdTelefonos.AllowUserToAddRows = False
        Me.grdTelefonos.AllowUserToDeleteRows = False
        Me.grdTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTelefonos.Location = New System.Drawing.Point(4, 16)
        Me.grdTelefonos.Name = "grdTelefonos"
        Me.grdTelefonos.ReadOnly = True
        Me.grdTelefonos.Size = New System.Drawing.Size(414, 177)
        Me.grdTelefonos.TabIndex = 2
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAgregarTelefono, Me.BtnEliminarTelefono})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 305)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(424, 25)
        Me.ToolStrip3.TabIndex = 0
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'BtnAgregarTelefono
        '
        Me.BtnAgregarTelefono.Image = CType(resources.GetObject("BtnAgregarTelefono.Image"), System.Drawing.Image)
        Me.BtnAgregarTelefono.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAgregarTelefono.Name = "BtnAgregarTelefono"
        Me.BtnAgregarTelefono.Size = New System.Drawing.Size(69, 22)
        Me.BtnAgregarTelefono.Text = "Agregar"
        '
        'BtnEliminarTelefono
        '
        Me.BtnEliminarTelefono.Image = CType(resources.GetObject("BtnEliminarTelefono.Image"), System.Drawing.Image)
        Me.BtnEliminarTelefono.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEliminarTelefono.Name = "BtnEliminarTelefono"
        Me.BtnEliminarTelefono.Size = New System.Drawing.Size(70, 22)
        Me.BtnEliminarTelefono.Text = "Eliminar"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ToolStrip4)
        Me.TabPage3.Controls.Add(Me.txtDescripcionEmail)
        Me.TabPage3.Controls.Add(Me.txtEmailContacto)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.grdEmail)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(424, 330)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Email"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ToolStrip5)
        Me.TabPage4.Controls.Add(Me.TextBox3)
        Me.TabPage4.Controls.Add(Me.TextBox4)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.DataGridView1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(424, 330)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "Direcciones"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'txtDescripcionEmail
        '
        Me.txtDescripcionEmail.Location = New System.Drawing.Point(105, 240)
        Me.txtDescripcionEmail.Name = "txtDescripcionEmail"
        Me.txtDescripcionEmail.ReadOnly = True
        Me.txtDescripcionEmail.Size = New System.Drawing.Size(298, 20)
        Me.txtDescripcionEmail.TabIndex = 11
        '
        'txtEmailContacto
        '
        Me.txtEmailContacto.Location = New System.Drawing.Point(105, 212)
        Me.txtEmailContacto.Name = "txtEmailContacto"
        Me.txtEmailContacto.ReadOnly = True
        Me.txtEmailContacto.Size = New System.Drawing.Size(298, 20)
        Me.txtEmailContacto.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Descripción"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Email"
        '
        'grdEmail
        '
        Me.grdEmail.AllowUserToAddRows = False
        Me.grdEmail.AllowUserToDeleteRows = False
        Me.grdEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEmail.Location = New System.Drawing.Point(4, 16)
        Me.grdEmail.Name = "grdEmail"
        Me.grdEmail.ReadOnly = True
        Me.grdEmail.Size = New System.Drawing.Size(414, 177)
        Me.grdEmail.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(105, 240)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(298, 20)
        Me.TextBox3.TabIndex = 16
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(105, 212)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(298, 20)
        Me.TextBox4.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(36, 240)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Descripción"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(36, 212)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Email"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(4, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(414, 177)
        Me.DataGridView1.TabIndex = 12
        '
        'ToolStrip4
        '
        Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAgregarEmail, Me.BtnEliminarEmail})
        Me.ToolStrip4.Location = New System.Drawing.Point(0, 305)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(424, 25)
        Me.ToolStrip4.TabIndex = 12
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'BtnAgregarEmail
        '
        Me.BtnAgregarEmail.Image = CType(resources.GetObject("BtnAgregarEmail.Image"), System.Drawing.Image)
        Me.BtnAgregarEmail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAgregarEmail.Name = "BtnAgregarEmail"
        Me.BtnAgregarEmail.Size = New System.Drawing.Size(69, 22)
        Me.BtnAgregarEmail.Text = "Agregar"
        '
        'BtnEliminarEmail
        '
        Me.BtnEliminarEmail.Image = CType(resources.GetObject("BtnEliminarEmail.Image"), System.Drawing.Image)
        Me.BtnEliminarEmail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEliminarEmail.Name = "BtnEliminarEmail"
        Me.BtnEliminarEmail.Size = New System.Drawing.Size(70, 22)
        Me.BtnEliminarEmail.Text = "Eliminar"
        '
        'ToolStrip5
        '
        Me.ToolStrip5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAgregarDireccion, Me.BtnEliminarDireccion})
        Me.ToolStrip5.Location = New System.Drawing.Point(3, 302)
        Me.ToolStrip5.Name = "ToolStrip5"
        Me.ToolStrip5.Size = New System.Drawing.Size(418, 25)
        Me.ToolStrip5.TabIndex = 17
        Me.ToolStrip5.Text = "ToolStrip5"
        '
        'BtnAgregarDireccion
        '
        Me.BtnAgregarDireccion.Image = CType(resources.GetObject("BtnAgregarDireccion.Image"), System.Drawing.Image)
        Me.BtnAgregarDireccion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAgregarDireccion.Name = "BtnAgregarDireccion"
        Me.BtnAgregarDireccion.Size = New System.Drawing.Size(69, 22)
        Me.BtnAgregarDireccion.Text = "Agregar"
        '
        'BtnEliminarDireccion
        '
        Me.BtnEliminarDireccion.Image = CType(resources.GetObject("BtnEliminarDireccion.Image"), System.Drawing.Image)
        Me.BtnEliminarDireccion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEliminarDireccion.Name = "BtnEliminarDireccion"
        Me.BtnEliminarDireccion.Size = New System.Drawing.Size(70, 22)
        Me.BtnEliminarDireccion.Text = "Eliminar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 399)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdUsuarios)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.grdUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdContactos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.grdTelefonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.grdEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.ToolStrip5.ResumeLayout(False)
        Me.ToolStrip5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdUsuarios As DataGridView
    Friend WithEvents grdContactos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents BtnNuevoContacto As ToolStripButton
    Friend WithEvents BtnGuardarContacto As ToolStripButton
    Friend WithEvents BtnEliminarContacto As ToolStripButton
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents grdTelefonos As DataGridView
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents BtnAgregarTelefono As ToolStripButton
    Friend WithEvents BtnEliminarTelefono As ToolStripButton
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ToolStrip4 As ToolStrip
    Friend WithEvents BtnAgregarEmail As ToolStripButton
    Friend WithEvents BtnEliminarEmail As ToolStripButton
    Friend WithEvents txtDescripcionEmail As TextBox
    Friend WithEvents txtEmailContacto As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents grdEmail As DataGridView
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ToolStrip5 As ToolStrip
    Friend WithEvents BtnAgregarDireccion As ToolStripButton
    Friend WithEvents BtnEliminarDireccion As ToolStripButton
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
