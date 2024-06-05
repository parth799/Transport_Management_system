<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminLogin))
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.button3 = New System.Windows.Forms.Button()
        Me.label9 = New System.Windows.Forms.Label()
        Me.PasswordTbl = New System.Windows.Forms.TextBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox4
        '
        Me.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pictureBox4.Image = CType(resources.GetObject("pictureBox4.Image"), System.Drawing.Image)
        Me.pictureBox4.Location = New System.Drawing.Point(538, 29)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(35, 33)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox4.TabIndex = 60
        Me.pictureBox4.TabStop = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Arial Black", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.label2.Location = New System.Drawing.Point(279, 433)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(77, 32)
        Me.label2.TabIndex = 59
        Me.label2.Text = "Back"
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.ForestGreen
        Me.button3.FlatAppearance.BorderSize = 0
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Font = New System.Drawing.Font("Arial Black", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.button3.Location = New System.Drawing.Point(260, 359)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(126, 54)
        Me.button3.TabIndex = 58
        Me.button3.Text = "Login"
        Me.button3.UseVisualStyleBackColor = False
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.label9.Location = New System.Drawing.Point(70, 279)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(219, 27)
        Me.label9.TabIndex = 56
        Me.label9.Text = "Admin Password  :"
        '
        'PasswordTbl
        '
        Me.PasswordTbl.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PasswordTbl.Location = New System.Drawing.Point(285, 278)
        Me.PasswordTbl.Name = "PasswordTbl"
        Me.PasswordTbl.Size = New System.Drawing.Size(266, 30)
        Me.PasswordTbl.TabIndex = 57
        '
        'pictureBox3
        '
        Me.pictureBox3.BackColor = System.Drawing.SystemColors.Control
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.Location = New System.Drawing.Point(226, 29)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(190, 197)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox3.TabIndex = 55
        Me.pictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 622)
        Me.Controls.Add(Me.pictureBox4)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.PasswordTbl)
        Me.Controls.Add(Me.pictureBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents label2 As Label
    Private WithEvents button3 As Button
    Private WithEvents label9 As Label
    Private WithEvents PasswordTbl As TextBox
    Private WithEvents pictureBox3 As PictureBox
End Class
