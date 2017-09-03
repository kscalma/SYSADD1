<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSignHome = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnHomeLogin = New System.Windows.Forms.Button()
        Me.picSM1 = New System.Windows.Forms.PictureBox()
        CType(Me.picSM1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Predictive Analytics"
        '
        'btnSignHome
        '
        Me.btnSignHome.Location = New System.Drawing.Point(233, 274)
        Me.btnSignHome.Name = "btnSignHome"
        Me.btnSignHome.Size = New System.Drawing.Size(83, 32)
        Me.btnSignHome.TabIndex = 12
        Me.btnSignHome.Text = "Sign-up"
        Me.btnSignHome.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(129, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Predictive Analytics"
        '
        'btnHomeLogin
        '
        Me.btnHomeLogin.Location = New System.Drawing.Point(82, 274)
        Me.btnHomeLogin.Name = "btnHomeLogin"
        Me.btnHomeLogin.Size = New System.Drawing.Size(83, 32)
        Me.btnHomeLogin.TabIndex = 10
        Me.btnHomeLogin.Text = "Login"
        Me.btnHomeLogin.UseVisualStyleBackColor = True
        '
        'picSM1
        '
        Me.picSM1.Image = CType(resources.GetObject("picSM1.Image"), System.Drawing.Image)
        Me.picSM1.Location = New System.Drawing.Point(103, 24)
        Me.picSM1.Name = "picSM1"
        Me.picSM1.Size = New System.Drawing.Size(197, 195)
        Me.picSM1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSM1.TabIndex = 9
        Me.picSM1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 330)
        Me.Controls.Add(Me.btnSignHome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnHomeLogin)
        Me.Controls.Add(Me.picSM1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picSM1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSignHome As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnHomeLogin As Button
    Friend WithEvents picSM1 As PictureBox
End Class
