<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.picSM2 = New System.Windows.Forms.PictureBox()
        Me.lblPass2 = New System.Windows.Forms.Label()
        Me.lblUN2 = New System.Windows.Forms.Label()
        Me.btnEnter2 = New System.Windows.Forms.Button()
        Me.txtUN2 = New System.Windows.Forms.TextBox()
        Me.txtPass2 = New System.Windows.Forms.TextBox()
        Me.btnLogin2 = New System.Windows.Forms.Button()
        Me.btnSign2 = New System.Windows.Forms.Button()
        CType(Me.picSM2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSM2
        '
        Me.picSM2.Image = CType(resources.GetObject("picSM2.Image"), System.Drawing.Image)
        Me.picSM2.Location = New System.Drawing.Point(132, 12)
        Me.picSM2.Name = "picSM2"
        Me.picSM2.Size = New System.Drawing.Size(128, 100)
        Me.picSM2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSM2.TabIndex = 6
        Me.picSM2.TabStop = False
        '
        'lblPass2
        '
        Me.lblPass2.AutoSize = True
        Me.lblPass2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass2.Location = New System.Drawing.Point(23, 237)
        Me.lblPass2.Name = "lblPass2"
        Me.lblPass2.Size = New System.Drawing.Size(73, 17)
        Me.lblPass2.TabIndex = 8
        Me.lblPass2.Text = "Password:"
        '
        'lblUN2
        '
        Me.lblUN2.AutoSize = True
        Me.lblUN2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUN2.Location = New System.Drawing.Point(19, 197)
        Me.lblUN2.Name = "lblUN2"
        Me.lblUN2.Size = New System.Drawing.Size(77, 17)
        Me.lblUN2.TabIndex = 7
        Me.lblUN2.Text = "Username:"
        '
        'btnEnter2
        '
        Me.btnEnter2.Location = New System.Drawing.Point(328, 215)
        Me.btnEnter2.Name = "btnEnter2"
        Me.btnEnter2.Size = New System.Drawing.Size(50, 23)
        Me.btnEnter2.TabIndex = 11
        Me.btnEnter2.Text = "Enter"
        Me.btnEnter2.UseVisualStyleBackColor = True
        '
        'txtUN2
        '
        Me.txtUN2.Location = New System.Drawing.Point(102, 197)
        Me.txtUN2.Name = "txtUN2"
        Me.txtUN2.Size = New System.Drawing.Size(208, 20)
        Me.txtUN2.TabIndex = 10
        '
        'txtPass2
        '
        Me.txtPass2.Location = New System.Drawing.Point(102, 236)
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass2.Size = New System.Drawing.Size(208, 20)
        Me.txtPass2.TabIndex = 9
        '
        'btnLogin2
        '
        Me.btnLogin2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnLogin2.Location = New System.Drawing.Point(116, 133)
        Me.btnLogin2.Name = "btnLogin2"
        Me.btnLogin2.Size = New System.Drawing.Size(83, 32)
        Me.btnLogin2.TabIndex = 12
        Me.btnLogin2.Text = "Login"
        Me.btnLogin2.UseVisualStyleBackColor = False
        '
        'btnSign2
        '
        Me.btnSign2.Location = New System.Drawing.Point(196, 133)
        Me.btnSign2.Name = "btnSign2"
        Me.btnSign2.Size = New System.Drawing.Size(83, 32)
        Me.btnSign2.TabIndex = 13
        Me.btnSign2.Text = "Sign-up"
        Me.btnSign2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 330)
        Me.Controls.Add(Me.btnSign2)
        Me.Controls.Add(Me.btnLogin2)
        Me.Controls.Add(Me.btnEnter2)
        Me.Controls.Add(Me.txtUN2)
        Me.Controls.Add(Me.txtPass2)
        Me.Controls.Add(Me.lblPass2)
        Me.Controls.Add(Me.lblUN2)
        Me.Controls.Add(Me.picSM2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.picSM2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSM2 As PictureBox
    Friend WithEvents lblPass2 As Label
    Friend WithEvents lblUN2 As Label
    Friend WithEvents btnEnter2 As Button
    Friend WithEvents txtUN2 As TextBox
    Friend WithEvents txtPass2 As TextBox
    Friend WithEvents btnLogin2 As Button
    Friend WithEvents btnSign2 As Button
End Class
