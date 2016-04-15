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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.txtIntro = New System.Windows.Forms.TextBox()
        Me.PictureBoxFolder = New System.Windows.Forms.PictureBox()
        Me.txtCmd = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxFolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Image = Global.WindowsLockscreenDL.My.Resources.Resources.DaleLogo1
        Me.PictureBoxLogo.Location = New System.Drawing.Point(208, 12)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(114, 130)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogo.TabIndex = 0
        Me.PictureBoxLogo.TabStop = False
        '
        'txtIntro
        '
        Me.txtIntro.BackColor = System.Drawing.Color.Black
        Me.txtIntro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtIntro.Location = New System.Drawing.Point(-3, 148)
        Me.txtIntro.Multiline = True
        Me.txtIntro.Name = "txtIntro"
        Me.txtIntro.Size = New System.Drawing.Size(503, 31)
        Me.txtIntro.TabIndex = 2
        Me.txtIntro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBoxFolder
        '
        Me.PictureBoxFolder.Location = New System.Drawing.Point(389, 50)
        Me.PictureBoxFolder.Name = "PictureBoxFolder"
        Me.PictureBoxFolder.Size = New System.Drawing.Size(82, 80)
        Me.PictureBoxFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxFolder.TabIndex = 3
        Me.PictureBoxFolder.TabStop = False
        '
        'txtCmd
        '
        Me.txtCmd.BackColor = System.Drawing.Color.Black
        Me.txtCmd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCmd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCmd.Location = New System.Drawing.Point(66, 27)
        Me.txtCmd.Multiline = True
        Me.txtCmd.Name = "txtCmd"
        Me.txtCmd.Size = New System.Drawing.Size(356, 149)
        Me.txtCmd.TabIndex = 4
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(498, 182)
        Me.Controls.Add(Me.PictureBoxFolder)
        Me.Controls.Add(Me.txtCmd)
        Me.Controls.Add(Me.txtIntro)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows Lockscreen DL"
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxFolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents txtIntro As TextBox
    Friend WithEvents PictureBoxFolder As PictureBox
    Friend WithEvents txtCmd As TextBox
    Friend WithEvents Timer1 As Timer
End Class
