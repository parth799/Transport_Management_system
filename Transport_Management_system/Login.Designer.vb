<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.button3 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.PasswordTb = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.UNameTb = New System.Windows.Forms.TextBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox4
        '
        Me.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pictureBox4.Image = CType(resources.GetObject("pictureBox4.Image"), System.Drawing.Image)
        Me.pictureBox4.Location = New System.Drawing.Point(519, 13)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(35, 33)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox4.TabIndex = 61
        Me.pictureBox4.TabStop = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Arial Black", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.label2.Location = New System.Drawing.Point(254, 501)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(93, 32)
        Me.label2.TabIndex = 60
        Me.label2.Text = "Admin"
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.ForestGreen
        Me.button3.FlatAppearance.BorderSize = 0
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.button3.Location = New System.Drawing.Point(235, 440)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(126, 41)
        Me.button3.TabIndex = 59
        Me.button3.Text = "Login"
        Me.button3.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.label1.Location = New System.Drawing.Point(113, 360)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(141, 27)
        Me.label1.TabIndex = 57
        Me.label1.Text = "Password  :"
        '
        'PasswordTb
        '
        Me.PasswordTb.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PasswordTb.Location = New System.Drawing.Point(260, 357)
        Me.PasswordTb.Name = "PasswordTb"
        Me.PasswordTb.Size = New System.Drawing.Size(266, 30)
        Me.PasswordTb.TabIndex = 58
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.label9.Location = New System.Drawing.Point(49, 304)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(207, 27)
        Me.label9.TabIndex = 55
        Me.label9.Text = "Customer Name  :"
        '
        'UNameTb
        '
        Me.UNameTb.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UNameTb.Location = New System.Drawing.Point(260, 301)
        Me.UNameTb.Name = "UNameTb"
        Me.UNameTb.Size = New System.Drawing.Size(266, 30)
        Me.UNameTb.TabIndex = 56
        '
        'pictureBox3
        '
        Me.pictureBox3.BackColor = System.Drawing.SystemColors.Control
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.Location = New System.Drawing.Point(205, 54)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(190, 197)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox3.TabIndex = 54
        Me.pictureBox3.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 548)
        Me.Controls.Add(Me.pictureBox4)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.PasswordTb)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.UNameTb)
        Me.Controls.Add(Me.pictureBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents label2 As Label
    Private WithEvents button3 As Button
    Private WithEvents label1 As Label
    Private WithEvents PasswordTb As TextBox
    Private WithEvents label9 As Label
    Private WithEvents UNameTb As TextBox
    Private WithEvents pictureBox3 As PictureBox
End Class
