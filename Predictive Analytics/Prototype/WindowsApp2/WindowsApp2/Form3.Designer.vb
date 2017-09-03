<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.picSM2 = New System.Windows.Forms.PictureBox()
        Me.btnSign3 = New System.Windows.Forms.Button()
        Me.btnLogin3 = New System.Windows.Forms.Button()
        Me.lblLname3 = New System.Windows.Forms.Label()
        Me.lblFname3 = New System.Windows.Forms.Label()
        Me.txtFname3 = New System.Windows.Forms.TextBox()
        Me.txtLname3 = New System.Windows.Forms.TextBox()
        Me.lblUN3 = New System.Windows.Forms.Label()
        Me.txtUN3 = New System.Windows.Forms.TextBox()
        Me.lblPass3 = New System.Windows.Forms.Label()
        Me.txtPass3 = New System.Windows.Forms.TextBox()
        Me.btnEnter3 = New System.Windows.Forms.Button()
        CType(Me.picSM2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSM2
        '
        Me.picSM2.Image = CType(resources.GetObject("picSM2.Image"), System.Drawing.Image)
        Me.picSM2.Location = New System.Drawing.Point(137, 12)
        Me.picSM2.Name = "picSM2"
        Me.picSM2.Size = New System.Drawing.Size(128, 100)
        Me.picSM2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSM2.TabIndex = 7
        Me.picSM2.TabStop = False
        '
        'btnSign3
        '
        Me.btnSign3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSign3.Location = New System.Drawing.Point(198, 140)
        Me.btnSign3.Name = "btnSign3"
        Me.btnSign3.Size = New System.Drawing.Size(83, 32)
        Me.btnSign3.TabIndex = 14
        Me.btnSign3.Text = "Sign-up"
        Me.btnSign3.UseVisualStyleBackColor = False
        '
        'btnLogin3
        '
        Me.btnLogin3.Location = New System.Drawing.Point(118, 140)
        Me.btnLogin3.Name = "btnLogin3"
        Me.btnLogin3.Size = New System.Drawing.Size(83, 32)
        Me.btnLogin3.TabIndex = 15
        Me.btnLogin3.Text = "Login"
        Me.btnLogin3.UseVisualStyleBackColor = True
        '
        'lblLname3
        '
        Me.lblLname3.AutoSize = True
        Me.lblLname3.Location = New System.Drawing.Point(194, 200)
        Me.lblLname3.Name = "lblLname3"
        Me.lblLname3.Size = New System.Drawing.Size(61, 13)
        Me.lblLname3.TabIndex = 16
        Me.lblLname3.Text = "Last Name:"
        '
        'lblFname3
        '
        Me.lblFname3.AutoSize = True
        Me.lblFname3.Location = New System.Drawing.Point(12, 200)
        Me.lblFname3.Name = "lblFname3"
        Me.lblFname3.Size = New System.Drawing.Size(60, 13)
        Me.lblFname3.TabIndex = 17
        Me.lblFname3.Text = "First Name:"
        '
        'txtFname3
        '
        Me.txtFname3.Location = New System.Drawing.Point(78, 197)
        Me.txtFname3.Name = "txtFname3"
        Me.txtFname3.Size = New System.Drawing.Size(110, 20)
        Me.txtFname3.TabIndex = 18
        '
        'txtLname3
        '
        Me.txtLname3.Location = New System.Drawing.Point(261, 197)
        Me.txtLname3.Name = "txtLname3"
        Me.txtLname3.Size = New System.Drawing.Size(110, 20)
        Me.txtLname3.TabIndex = 19
        '
        'lblUN3
        '
        Me.lblUN3.AutoSize = True
        Me.lblUN3.Location = New System.Drawing.Point(12, 237)
        Me.lblUN3.Name = "lblUN3"
        Me.lblUN3.Size = New System.Drawing.Size(58, 13)
        Me.lblUN3.TabIndex = 20
        Me.lblUN3.Text = "Username:"
        Me.lblUN3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtUN3
        '
        Me.txtUN3.Location = New System.Drawing.Point(78, 234)
        Me.txtUN3.Name = "txtUN3"
        Me.txtUN3.Size = New System.Drawing.Size(110, 20)
        Me.txtUN3.TabIndex = 21
        '
        'lblPass3
        '
        Me.lblPass3.AutoSize = True
        Me.lblPass3.Location = New System.Drawing.Point(194, 237)
        Me.lblPass3.Name = "lblPass3"
        Me.lblPass3.Size = New System.Drawing.Size(56, 13)
        Me.lblPass3.TabIndex = 22
        Me.lblPass3.Text = "Password:"
        '
        'txtPass3
        '
        Me.txtPass3.Location = New System.Drawing.Point(261, 234)
        Me.txtPass3.Name = "txtPass3"
        Me.txtPass3.Size = New System.Drawing.Size(110, 20)
        Me.txtPass3.TabIndex = 23
        '
        'btnEnter3
        '
        Me.btnEnter3.Location = New System.Drawing.Point(306, 272)
        Me.btnEnter3.Name = "btnEnter3"
        Me.btnEnter3.Size = New System.Drawing.Size(65, 34)
        Me.btnEnter3.TabIndex = 24
        Me.btnEnter3.Text = "Enter"
        Me.btnEnter3.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 330)
        Me.Controls.Add(Me.btnEnter3)
        Me.Controls.Add(Me.txtPass3)
        Me.Controls.Add(Me.lblPass3)
        Me.Controls.Add(Me.txtUN3)
        Me.Controls.Add(Me.lblUN3)
        Me.Controls.Add(Me.txtLname3)
        Me.Controls.Add(Me.txtFname3)
        Me.Controls.Add(Me.lblFname3)
        Me.Controls.Add(Me.lblLname3)
        Me.Controls.Add(Me.btnLogin3)
        Me.Controls.Add(Me.btnSign3)
        Me.Controls.Add(Me.picSM2)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.picSM2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSM2 As PictureBox
    Friend WithEvents btnSign3 As Button
    Friend WithEvents btnLogin3 As Button
    Friend WithEvents lblLname3 As Label
    Friend WithEvents lblFname3 As Label
    Friend WithEvents txtFname3 As TextBox
    Friend WithEvents txtLname3 As TextBox
    Friend WithEvents lblUN3 As Label
    Friend WithEvents txtUN3 As TextBox
    Friend WithEvents lblPass3 As Label
    Friend WithEvents txtPass3 As TextBox
    Friend WithEvents btnEnter3 As Button
End Class
