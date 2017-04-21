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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnorigen = New System.Windows.Forms.Button()
        Me.txtdestino = New System.Windows.Forms.TextBox()
        Me.txtorigen = New System.Windows.Forms.TextBox()
        Me.lbldestino = New System.Windows.Forms.Label()
        Me.lblorigen = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.btndestino = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblcantidadarchivos = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtprefijo = New System.Windows.Forms.TextBox()
        Me.cbofolio = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsufijo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtext = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btngenerar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtiniciosecuencia = New System.Windows.Forms.NumericUpDown()
        Me.progreso = New System.Windows.Forms.ProgressBar()
        Me.chksobreescribir = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtiniciosecuencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblcantidadarchivos)
        Me.GroupBox1.Controls.Add(Me.btndestino)
        Me.GroupBox1.Controls.Add(Me.btnorigen)
        Me.GroupBox1.Controls.Add(Me.txtdestino)
        Me.GroupBox1.Controls.Add(Me.txtorigen)
        Me.GroupBox1.Controls.Add(Me.lbldestino)
        Me.GroupBox1.Controls.Add(Me.lblorigen)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(641, 127)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Directorios"
        '
        'btnorigen
        '
        Me.btnorigen.Location = New System.Drawing.Point(499, 31)
        Me.btnorigen.Name = "btnorigen"
        Me.btnorigen.Size = New System.Drawing.Size(136, 23)
        Me.btnorigen.TabIndex = 5
        Me.btnorigen.Text = "Seleccionar directorio"
        Me.btnorigen.UseVisualStyleBackColor = True
        '
        'txtdestino
        '
        Me.txtdestino.Enabled = False
        Me.txtdestino.Location = New System.Drawing.Point(56, 62)
        Me.txtdestino.Name = "txtdestino"
        Me.txtdestino.Size = New System.Drawing.Size(437, 20)
        Me.txtdestino.TabIndex = 4
        '
        'txtorigen
        '
        Me.txtorigen.Enabled = False
        Me.txtorigen.Location = New System.Drawing.Point(56, 31)
        Me.txtorigen.Name = "txtorigen"
        Me.txtorigen.Size = New System.Drawing.Size(437, 20)
        Me.txtorigen.TabIndex = 3
        '
        'lbldestino
        '
        Me.lbldestino.AutoSize = True
        Me.lbldestino.Location = New System.Drawing.Point(6, 65)
        Me.lbldestino.Name = "lbldestino"
        Me.lbldestino.Size = New System.Drawing.Size(43, 13)
        Me.lbldestino.TabIndex = 2
        Me.lbldestino.Text = "Destino"
        '
        'lblorigen
        '
        Me.lblorigen.AutoSize = True
        Me.lblorigen.Location = New System.Drawing.Point(7, 34)
        Me.lblorigen.Name = "lblorigen"
        Me.lblorigen.Size = New System.Drawing.Size(38, 13)
        Me.lblorigen.TabIndex = 1
        Me.lblorigen.Text = "Origen"
        '
        'btndestino
        '
        Me.btndestino.Location = New System.Drawing.Point(499, 60)
        Me.btndestino.Name = "btndestino"
        Me.btndestino.Size = New System.Drawing.Size(136, 23)
        Me.btndestino.TabIndex = 6
        Me.btndestino.Text = "Seleccionar directorio"
        Me.btndestino.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.chksobreescribir)
        Me.GroupBox2.Controls.Add(Me.txtiniciosecuencia)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtext)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtsufijo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cbofolio)
        Me.GroupBox2.Controls.Add(Me.txtprefijo)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(635, 163)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nombre de archivos"
        '
        'lblcantidadarchivos
        '
        Me.lblcantidadarchivos.AutoSize = True
        Me.lblcantidadarchivos.Location = New System.Drawing.Point(9, 103)
        Me.lblcantidadarchivos.Name = "lblcantidadarchivos"
        Me.lblcantidadarchivos.Size = New System.Drawing.Size(122, 13)
        Me.lblcantidadarchivos.TabIndex = 7
        Me.lblcantidadarchivos.Text = "Cantidad de archivos : 0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prefijo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(249, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sufijo"
        '
        'txtprefijo
        '
        Me.txtprefijo.Location = New System.Drawing.Point(10, 44)
        Me.txtprefijo.Name = "txtprefijo"
        Me.txtprefijo.Size = New System.Drawing.Size(108, 20)
        Me.txtprefijo.TabIndex = 3
        '
        'cbofolio
        '
        Me.cbofolio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofolio.FormattingEnabled = True
        Me.cbofolio.Items.AddRange(New Object() {"Con 0", "Sin 0"})
        Me.cbofolio.Location = New System.Drawing.Point(125, 44)
        Me.cbofolio.Name = "cbofolio"
        Me.cbofolio.Size = New System.Drawing.Size(121, 21)
        Me.cbofolio.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(122, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Folio"
        '
        'txtsufijo
        '
        Me.txtsufijo.Location = New System.Drawing.Point(252, 45)
        Me.txtsufijo.Name = "txtsufijo"
        Me.txtsufijo.Size = New System.Drawing.Size(108, 20)
        Me.txtsufijo.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(366, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "."
        '
        'txtext
        '
        Me.txtext.Location = New System.Drawing.Point(382, 45)
        Me.txtext.Name = "txtext"
        Me.txtext.Size = New System.Drawing.Size(79, 20)
        Me.txtext.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(379, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Ext."
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(510, 314)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(137, 23)
        Me.btngenerar.TabIndex = 3
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(496, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Inicio de la secuencia"
        '
        'txtiniciosecuencia
        '
        Me.txtiniciosecuencia.Location = New System.Drawing.Point(499, 45)
        Me.txtiniciosecuencia.Name = "txtiniciosecuencia"
        Me.txtiniciosecuencia.Size = New System.Drawing.Size(107, 20)
        Me.txtiniciosecuencia.TabIndex = 11
        '
        'progreso
        '
        Me.progreso.Location = New System.Drawing.Point(12, 314)
        Me.progreso.Name = "progreso"
        Me.progreso.Size = New System.Drawing.Size(334, 23)
        Me.progreso.TabIndex = 4
        '
        'chksobreescribir
        '
        Me.chksobreescribir.AutoSize = True
        Me.chksobreescribir.Checked = True
        Me.chksobreescribir.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chksobreescribir.Location = New System.Drawing.Point(10, 71)
        Me.chksobreescribir.Name = "chksobreescribir"
        Me.chksobreescribir.Size = New System.Drawing.Size(293, 17)
        Me.chksobreescribir.TabIndex = 12
        Me.chksobreescribir.Text = "Sobreescribir archivos existentes en directorio de destino"
        Me.chksobreescribir.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(10, 94)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 349)
        Me.Controls.Add(Me.progreso)
        Me.Controls.Add(Me.btngenerar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Copiar y Renombrar Archivos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtiniciosecuencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnorigen As Button
    Friend WithEvents txtdestino As TextBox
    Friend WithEvents txtorigen As TextBox
    Friend WithEvents lbldestino As Label
    Friend WithEvents lblorigen As Label
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents btndestino As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblcantidadarchivos As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtext As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtsufijo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbofolio As ComboBox
    Friend WithEvents txtprefijo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btngenerar As Button
    Friend WithEvents txtiniciosecuencia As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents progreso As ProgressBar
    Friend WithEvents chksobreescribir As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
