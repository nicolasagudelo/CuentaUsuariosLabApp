<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.UsuarioEnLab = New System.Windows.Forms.TabPage()
        Me.UsuariosNoEnLab = New System.Windows.Forms.TabPage()
        Me.LblInfo = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblNumero = New System.Windows.Forms.Label()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.UsuarioEnLab.SuspendLayout()
        Me.UsuariosNoEnLab.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.UsuarioEnLab)
        Me.TabControl1.Controls.Add(Me.UsuariosNoEnLab)
        Me.TabControl1.Location = New System.Drawing.Point(1, 31)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(640, 321)
        Me.TabControl1.TabIndex = 0
        '
        'UsuarioEnLab
        '
        Me.UsuarioEnLab.BackColor = System.Drawing.SystemColors.Control
        Me.UsuarioEnLab.Controls.Add(Me.Panel1)
        Me.UsuarioEnLab.Location = New System.Drawing.Point(23, 4)
        Me.UsuarioEnLab.Name = "UsuarioEnLab"
        Me.UsuarioEnLab.Padding = New System.Windows.Forms.Padding(3)
        Me.UsuarioEnLab.Size = New System.Drawing.Size(613, 313)
        Me.UsuarioEnLab.TabIndex = 0
        Me.UsuarioEnLab.Text = "Personas en el Lab"
        '
        'UsuariosNoEnLab
        '
        Me.UsuariosNoEnLab.BackColor = System.Drawing.SystemColors.Control
        Me.UsuariosNoEnLab.Controls.Add(Me.Panel2)
        Me.UsuariosNoEnLab.Location = New System.Drawing.Point(23, 4)
        Me.UsuariosNoEnLab.Name = "UsuariosNoEnLab"
        Me.UsuariosNoEnLab.Padding = New System.Windows.Forms.Padding(3)
        Me.UsuariosNoEnLab.Size = New System.Drawing.Size(613, 313)
        Me.UsuariosNoEnLab.TabIndex = 1
        Me.UsuariosNoEnLab.Text = "Personas fuera del Lab"
        '
        'LblInfo
        '
        Me.LblInfo.AutoSize = True
        Me.LblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblInfo.Location = New System.Drawing.Point(21, 9)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(219, 20)
        Me.LblInfo.TabIndex = 1
        Me.LblInfo.Text = "Personas en el laboratorio"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'LblNumero
        '
        Me.LblNumero.AutoSize = True
        Me.LblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumero.ForeColor = System.Drawing.Color.Red
        Me.LblNumero.Location = New System.Drawing.Point(241, 9)
        Me.LblNumero.Name = "LblNumero"
        Me.LblNumero.Size = New System.Drawing.Size(21, 20)
        Me.LblNumero.TabIndex = 2
        Me.LblNumero.Text = "N"
        '
        'LabelTime
        '
        Me.LabelTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTime.ForeColor = System.Drawing.Color.Red
        Me.LabelTime.Location = New System.Drawing.Point(447, 9)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(194, 13)
        Me.LabelTime.TabIndex = 3
        Me.LabelTime.Text = "Tiempo para actualizar: 00:00:30"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(607, 307)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(607, 307)
        Me.Panel2.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(653, 364)
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.LblNumero)
        Me.Controls.Add(Me.LblInfo)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Personas en el Lab"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.UsuarioEnLab.ResumeLayout(False)
        Me.UsuariosNoEnLab.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents UsuarioEnLab As TabPage
    Friend WithEvents UsuariosNoEnLab As TabPage
    Friend WithEvents LblInfo As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LblNumero As Label
    Friend WithEvents LabelTime As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
