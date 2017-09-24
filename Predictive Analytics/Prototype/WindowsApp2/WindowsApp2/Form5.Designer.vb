<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.picSM2 = New System.Windows.Forms.PictureBox()
        Me.btnHome5 = New System.Windows.Forms.Button()
        Me.btnMcr5 = New System.Windows.Forms.Button()
        Me.btnCpr5 = New System.Windows.Forms.Button()
        Me.btnGet5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblReportname5 = New System.Windows.Forms.Label()
        Me.lblSample1 = New System.Windows.Forms.Label()
        Me.lblDate1 = New System.Windows.Forms.Label()
        Me.btnInspect5 = New System.Windows.Forms.Button()
        CType(Me.picSM2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picSM2
        '
        Me.picSM2.Image = CType(resources.GetObject("picSM2.Image"), System.Drawing.Image)
        Me.picSM2.Location = New System.Drawing.Point(318, 12)
        Me.picSM2.Name = "picSM2"
        Me.picSM2.Size = New System.Drawing.Size(69, 58)
        Me.picSM2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSM2.TabIndex = 8
        Me.picSM2.TabStop = False
        '
        'btnHome5
        '
        Me.btnHome5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnHome5.Location = New System.Drawing.Point(7, 81)
        Me.btnHome5.Name = "btnHome5"
        Me.btnHome5.Size = New System.Drawing.Size(98, 40)
        Me.btnHome5.TabIndex = 9
        Me.btnHome5.Text = "Home"
        Me.btnHome5.UseVisualStyleBackColor = False
        '
        'btnMcr5
        '
        Me.btnMcr5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnMcr5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMcr5.Location = New System.Drawing.Point(199, 81)
        Me.btnMcr5.Name = "btnMcr5"
        Me.btnMcr5.Size = New System.Drawing.Size(98, 40)
        Me.btnMcr5.TabIndex = 10
        Me.btnMcr5.Text = "Manage Created Report"
        Me.btnMcr5.UseVisualStyleBackColor = False
        '
        'btnCpr5
        '
        Me.btnCpr5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.btnCpr5.Location = New System.Drawing.Point(104, 81)
        Me.btnCpr5.Name = "btnCpr5"
        Me.btnCpr5.Size = New System.Drawing.Size(98, 40)
        Me.btnCpr5.TabIndex = 12
        Me.btnCpr5.Text = "Create Prediction Report"
        Me.btnCpr5.UseVisualStyleBackColor = True
        '
        'btnGet5
        '
        Me.btnGet5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnGet5.Location = New System.Drawing.Point(294, 81)
        Me.btnGet5.Name = "btnGet5"
        Me.btnGet5.Size = New System.Drawing.Size(98, 40)
        Me.btnGet5.TabIndex = 14
        Me.btnGet5.Text = "Get Reports"
        Me.btnGet5.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(183, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Date"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.08955!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.91045!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblDate1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSample1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblReportname5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnInspect5, 2, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(30, 146)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.83333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.16667!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(333, 48)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'lblReportname5
        '
        Me.lblReportname5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblReportname5.AutoSize = True
        Me.lblReportname5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportname5.Location = New System.Drawing.Point(27, 3)
        Me.lblReportname5.Name = "lblReportname5"
        Me.lblReportname5.Size = New System.Drawing.Size(92, 15)
        Me.lblReportname5.TabIndex = 0
        Me.lblReportname5.Text = "Report Name"
        '
        'lblSample1
        '
        Me.lblSample1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSample1.AutoSize = True
        Me.lblSample1.Location = New System.Drawing.Point(30, 28)
        Me.lblSample1.Name = "lblSample1"
        Me.lblSample1.Size = New System.Drawing.Size(86, 13)
        Me.lblSample1.TabIndex = 21
        Me.lblSample1.Text = "Sample Report 1"
        '
        'lblDate1
        '
        Me.lblDate1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDate1.AutoSize = True
        Me.lblDate1.Location = New System.Drawing.Point(165, 28)
        Me.lblDate1.Name = "lblDate1"
        Me.lblDate1.Size = New System.Drawing.Size(74, 13)
        Me.lblDate1.TabIndex = 21
        Me.lblDate1.Text = "Aug. 31, 2017"
        '
        'btnInspect5
        '
        Me.btnInspect5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnInspect5.Location = New System.Drawing.Point(269, 24)
        Me.btnInspect5.Name = "btnInspect5"
        Me.btnInspect5.Size = New System.Drawing.Size(51, 21)
        Me.btnInspect5.TabIndex = 21
        Me.btnInspect5.Text = "Inspect"
        Me.btnInspect5.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(399, 330)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnGet5)
        Me.Controls.Add(Me.btnCpr5)
        Me.Controls.Add(Me.btnMcr5)
        Me.Controls.Add(Me.btnHome5)
        Me.Controls.Add(Me.picSM2)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.picSM2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picSM2 As PictureBox
    Friend WithEvents btnHome5 As Button
    Friend WithEvents btnMcr5 As Button
    Friend WithEvents btnCpr5 As Button
    Friend WithEvents btnGet5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblReportname5 As Label
    Friend WithEvents lblDate1 As Label
    Friend WithEvents lblSample1 As Label
    Friend WithEvents btnInspect5 As Button
End Class
