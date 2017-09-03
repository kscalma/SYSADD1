<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.btnHome4 = New System.Windows.Forms.Button()
        Me.lblWelcome4 = New System.Windows.Forms.Label()
        Me.picSM2 = New System.Windows.Forms.PictureBox()
        Me.btnStore4 = New System.Windows.Forms.Button()
        Me.btnMcr4 = New System.Windows.Forms.Button()
        Me.btnGet4 = New System.Windows.Forms.Button()
        Me.btnCpr4 = New System.Windows.Forms.Button()
        CType(Me.picSM2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHome4
        '
        Me.btnHome4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnHome4.Location = New System.Drawing.Point(12, 12)
        Me.btnHome4.Name = "btnHome4"
        Me.btnHome4.Size = New System.Drawing.Size(75, 23)
        Me.btnHome4.TabIndex = 0
        Me.btnHome4.Text = "Home"
        Me.btnHome4.UseVisualStyleBackColor = False
        '
        'lblWelcome4
        '
        Me.lblWelcome4.AutoSize = True
        Me.lblWelcome4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome4.Location = New System.Drawing.Point(145, 68)
        Me.lblWelcome4.Name = "lblWelcome4"
        Me.lblWelcome4.Size = New System.Drawing.Size(101, 25)
        Me.lblWelcome4.TabIndex = 1
        Me.lblWelcome4.Text = "Welcome"
        '
        'picSM2
        '
        Me.picSM2.Image = CType(resources.GetObject("picSM2.Image"), System.Drawing.Image)
        Me.picSM2.Location = New System.Drawing.Point(318, 12)
        Me.picSM2.Name = "picSM2"
        Me.picSM2.Size = New System.Drawing.Size(69, 58)
        Me.picSM2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSM2.TabIndex = 7
        Me.picSM2.TabStop = False
        '
        'btnStore4
        '
        Me.btnStore4.Location = New System.Drawing.Point(140, 136)
        Me.btnStore4.Name = "btnStore4"
        Me.btnStore4.Size = New System.Drawing.Size(106, 41)
        Me.btnStore4.TabIndex = 8
        Me.btnStore4.Text = "Store Data"
        Me.btnStore4.UseVisualStyleBackColor = True
        '
        'btnMcr4
        '
        Me.btnMcr4.Location = New System.Drawing.Point(140, 223)
        Me.btnMcr4.Name = "btnMcr4"
        Me.btnMcr4.Size = New System.Drawing.Size(106, 41)
        Me.btnMcr4.TabIndex = 9
        Me.btnMcr4.Text = "Manage Created Reports"
        Me.btnMcr4.UseVisualStyleBackColor = True
        '
        'btnGet4
        '
        Me.btnGet4.Location = New System.Drawing.Point(140, 268)
        Me.btnGet4.Name = "btnGet4"
        Me.btnGet4.Size = New System.Drawing.Size(106, 41)
        Me.btnGet4.TabIndex = 10
        Me.btnGet4.Text = "Get Reports"
        Me.btnGet4.UseVisualStyleBackColor = True
        '
        'btnCpr4
        '
        Me.btnCpr4.Location = New System.Drawing.Point(140, 179)
        Me.btnCpr4.Name = "btnCpr4"
        Me.btnCpr4.Size = New System.Drawing.Size(106, 41)
        Me.btnCpr4.TabIndex = 11
        Me.btnCpr4.Text = "Create Prediction Report"
        Me.btnCpr4.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 330)
        Me.Controls.Add(Me.btnCpr4)
        Me.Controls.Add(Me.btnGet4)
        Me.Controls.Add(Me.btnMcr4)
        Me.Controls.Add(Me.btnStore4)
        Me.Controls.Add(Me.picSM2)
        Me.Controls.Add(Me.lblWelcome4)
        Me.Controls.Add(Me.btnHome4)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.picSM2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHome4 As Button
    Friend WithEvents lblWelcome4 As Label
    Friend WithEvents picSM2 As PictureBox
    Friend WithEvents btnStore4 As Button
    Friend WithEvents btnMcr4 As Button
    Friend WithEvents btnGet4 As Button
    Friend WithEvents btnCpr4 As Button
End Class
