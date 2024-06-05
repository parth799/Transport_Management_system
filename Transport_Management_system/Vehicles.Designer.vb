<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vehicles
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vehicles))
        Me.VYearCb = New System.Windows.Forms.ComboBox()
        Me.MarkCb = New System.Windows.Forms.ComboBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.DriverCb = New System.Windows.Forms.ComboBox()
        Me.VehicleDGV = New System.Windows.Forms.DataGridView()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.VNumLbl = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TypeCb = New System.Windows.Forms.ComboBox()
        Me.label22 = New System.Windows.Forms.Label()
        Me.MilleageTb = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.pictureBox6 = New System.Windows.Forms.PictureBox()
        Me.label21 = New System.Windows.Forms.Label()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ColorTb = New System.Windows.Forms.TextBox()
        Me.EngTypeCb = New System.Windows.Forms.ComboBox()
        Me.label20 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.pictureBox8 = New System.Windows.Forms.PictureBox()
        Me.BookedCb = New System.Windows.Forms.ComboBox()
        Me.ModelTb = New System.Windows.Forms.TextBox()
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.pictureBox7 = New System.Windows.Forms.PictureBox()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.pictureBox9 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label13 = New System.Windows.Forms.Label()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.LPlateTb = New System.Windows.Forms.TextBox()
        Me.panel5 = New System.Windows.Forms.Panel()
        Me.pictureBox5 = New System.Windows.Forms.PictureBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.panel6 = New System.Windows.Forms.Panel()
        Me.label5 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panel3 = New System.Windows.Forms.Panel()
        CType(Me.VehicleDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel7.SuspendLayout()
        CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel4.SuspendLayout()
        Me.panel5.SuspendLayout()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel6.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'VYearCb
        '
        Me.VYearCb.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.VYearCb.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.VYearCb.FormattingEnabled = True
        Me.VYearCb.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023"})
        Me.VYearCb.Location = New System.Drawing.Point(819, 140)
        Me.VYearCb.Name = "VYearCb"
        Me.VYearCb.Size = New System.Drawing.Size(121, 32)
        Me.VYearCb.TabIndex = 23
        '
        'MarkCb
        '
        Me.MarkCb.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MarkCb.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.MarkCb.FormattingEnabled = True
        Me.MarkCb.Items.AddRange(New Object() {"Volvo", "Marcopolo", "Scania", "Audi", "Nissan", "Tata", "Toyota"})
        Me.MarkCb.Location = New System.Drawing.Point(298, 142)
        Me.MarkCb.Name = "MarkCb"
        Me.MarkCb.Size = New System.Drawing.Size(210, 32)
        Me.MarkCb.TabIndex = 16
        Me.MarkCb.Text = "Mark"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Arial Black", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label14.ForeColor = System.Drawing.Color.Red
        Me.label14.Location = New System.Drawing.Point(1334, 177)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(113, 32)
        Me.label14.TabIndex = 72
        Me.label14.Text = "Resume"
        '
        'DriverCb
        '
        Me.DriverCb.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DriverCb.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.DriverCb.FormattingEnabled = True
        Me.DriverCb.Items.AddRange(New Object() {"Volvo", "Marcopolo", "Scania", "Audi", "Nissan", "Tata", "Toyota"})
        Me.DriverCb.Location = New System.Drawing.Point(952, 228)
        Me.DriverCb.Name = "DriverCb"
        Me.DriverCb.Size = New System.Drawing.Size(210, 32)
        Me.DriverCb.TabIndex = 37
        Me.DriverCb.Text = "Drivers"
        '
        'VehicleDGV
        '
        Me.VehicleDGV.BackgroundColor = System.Drawing.SystemColors.Control
        Me.VehicleDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Linen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VehicleDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.VehicleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VehicleDGV.GridColor = System.Drawing.SystemColors.HotTrack
        Me.VehicleDGV.Location = New System.Drawing.Point(5, 353)
        Me.VehicleDGV.Name = "VehicleDGV"
        Me.VehicleDGV.RowHeadersWidth = 51
        Me.VehicleDGV.RowTemplate.Height = 29
        Me.VehicleDGV.Size = New System.Drawing.Size(1183, 539)
        Me.VehicleDGV.TabIndex = 36
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.label11.Location = New System.Drawing.Point(815, 114)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(136, 24)
        Me.label11.TabIndex = 17
        Me.label11.Text = "Vehicles Year"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.label10.Location = New System.Drawing.Point(556, 116)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(67, 24)
        Me.label10.TabIndex = 14
        Me.label10.Text = "Model"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.label9.Location = New System.Drawing.Point(37, 118)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(136, 24)
        Me.label9.TabIndex = 13
        Me.label9.Text = "Licence Plate"
        '
        'VNumLbl
        '
        Me.VNumLbl.AutoSize = True
        Me.VNumLbl.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.VNumLbl.ForeColor = System.Drawing.Color.Red
        Me.VNumLbl.Location = New System.Drawing.Point(1350, 324)
        Me.VNumLbl.Name = "VNumLbl"
        Me.VNumLbl.Size = New System.Drawing.Size(62, 28)
        Me.VNumLbl.TabIndex = 73
        Me.VNumLbl.Text = "Num"
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label16.ForeColor = System.Drawing.Color.DarkOrange
        Me.label16.Location = New System.Drawing.Point(1334, 279)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(90, 28)
        Me.label16.TabIndex = 74
        Me.label16.Text = "Travels"
        '
        'pictureBox4
        '
        Me.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pictureBox4.Image = CType(resources.GetObject("pictureBox4.Image"), System.Drawing.Image)
        Me.pictureBox4.Location = New System.Drawing.Point(1337, 5)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(35, 33)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox4.TabIndex = 71
        Me.pictureBox4.TabStop = False
        '
        'TypeCb
        '
        Me.TypeCb.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TypeCb.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TypeCb.FormattingEnabled = True
        Me.TypeCb.Items.AddRange(New Object() {"Bus", "Minibus", "Truck", "SUV", "Sedan", "Citybus"})
        Me.TypeCb.Location = New System.Drawing.Point(298, 230)
        Me.TypeCb.Name = "TypeCb"
        Me.TypeCb.Size = New System.Drawing.Size(210, 32)
        Me.TypeCb.TabIndex = 34
        Me.TypeCb.Text = "Type"
        '
        'label22
        '
        Me.label22.AutoSize = True
        Me.label22.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label22.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.label22.Location = New System.Drawing.Point(557, 207)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(87, 24)
        Me.label22.TabIndex = 32
        Me.label22.Text = "Milleage"
        '
        'MilleageTb
        '
        Me.MilleageTb.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MilleageTb.Location = New System.Drawing.Point(557, 230)
        Me.MilleageTb.Name = "MilleageTb"
        Me.MilleageTb.Size = New System.Drawing.Size(176, 30)
        Me.MilleageTb.TabIndex = 33
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label3.ForeColor = System.Drawing.Color.Black
        Me.label3.Location = New System.Drawing.Point(19, 267)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(86, 19)
        Me.label3.TabIndex = 60
        Me.label3.Text = "Customer"
        '
        'pictureBox6
        '
        Me.pictureBox6.Image = CType(resources.GetObject("pictureBox6.Image"), System.Drawing.Image)
        Me.pictureBox6.Location = New System.Drawing.Point(40, 429)
        Me.pictureBox6.Name = "pictureBox6"
        Me.pictureBox6.Size = New System.Drawing.Size(45, 44)
        Me.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox6.TabIndex = 63
        Me.pictureBox6.TabStop = False
        '
        'label21
        '
        Me.label21.AutoSize = True
        Me.label21.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label21.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.label21.Location = New System.Drawing.Point(758, 206)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(61, 24)
        Me.label21.TabIndex = 30
        Me.label21.Text = "Color"
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(29, 105)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(0, 0)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox2.TabIndex = 59
        Me.pictureBox2.TabStop = False
        '
        'ColorTb
        '
        Me.ColorTb.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ColorTb.Location = New System.Drawing.Point(758, 228)
        Me.ColorTb.Name = "ColorTb"
        Me.ColorTb.Size = New System.Drawing.Size(163, 30)
        Me.ColorTb.TabIndex = 31
        '
        'EngTypeCb
        '
        Me.EngTypeCb.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EngTypeCb.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.EngTypeCb.FormattingEnabled = True
        Me.EngTypeCb.Items.AddRange(New Object() {"Diesel", "Petrol"})
        Me.EngTypeCb.Location = New System.Drawing.Point(967, 139)
        Me.EngTypeCb.Name = "EngTypeCb"
        Me.EngTypeCb.Size = New System.Drawing.Size(121, 32)
        Me.EngTypeCb.TabIndex = 29
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.label20.Location = New System.Drawing.Point(964, 113)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(127, 24)
        Me.label20.TabIndex = 28
        Me.label20.Text = "Engine Type"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label6.ForeColor = System.Drawing.Color.Black
        Me.label6.Location = New System.Drawing.Point(16, 579)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(95, 19)
        Me.label6.TabIndex = 61
        Me.label6.Text = "Dashboard"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label7.ForeColor = System.Drawing.SystemColors.InfoText
        Me.label7.Location = New System.Drawing.Point(38, 735)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(37, 19)
        Me.label7.TabIndex = 70
        Me.label7.Text = "exit"
        '
        'pictureBox8
        '
        Me.pictureBox8.Image = CType(resources.GetObject("pictureBox8.Image"), System.Drawing.Image)
        Me.pictureBox8.Location = New System.Drawing.Point(34, 680)
        Me.pictureBox8.Name = "pictureBox8"
        Me.pictureBox8.Size = New System.Drawing.Size(47, 52)
        Me.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox8.TabIndex = 69
        Me.pictureBox8.TabStop = False
        '
        'BookedCb
        '
        Me.BookedCb.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BookedCb.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.BookedCb.FormattingEnabled = True
        Me.BookedCb.Items.AddRange(New Object() {"YES", "NO"})
        Me.BookedCb.Location = New System.Drawing.Point(37, 232)
        Me.BookedCb.Name = "BookedCb"
        Me.BookedCb.Size = New System.Drawing.Size(210, 32)
        Me.BookedCb.TabIndex = 35
        '
        'ModelTb
        '
        Me.ModelTb.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ModelTb.Location = New System.Drawing.Point(557, 141)
        Me.ModelTb.Name = "ModelTb"
        Me.ModelTb.Size = New System.Drawing.Size(210, 30)
        Me.ModelTb.TabIndex = 15
        '
        'panel7
        '
        Me.panel7.Controls.Add(Me.pictureBox7)
        Me.panel7.Location = New System.Drawing.Point(26, 513)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(73, 88)
        Me.panel7.TabIndex = 68
        '
        'pictureBox7
        '
        Me.pictureBox7.Image = CType(resources.GetObject("pictureBox7.Image"), System.Drawing.Image)
        Me.pictureBox7.Location = New System.Drawing.Point(14, 18)
        Me.pictureBox7.Name = "pictureBox7"
        Me.pictureBox7.Size = New System.Drawing.Size(45, 46)
        Me.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox7.TabIndex = 8
        Me.pictureBox7.TabStop = False
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.Red
        Me.DeleteBtn.FlatAppearance.BorderSize = 0
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeleteBtn.Location = New System.Drawing.Point(582, 284)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(104, 32)
        Me.DeleteBtn.TabIndex = 27
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'pictureBox9
        '
        Me.pictureBox9.Image = CType(resources.GetObject("pictureBox9.Image"), System.Drawing.Image)
        Me.pictureBox9.Location = New System.Drawing.Point(14, 18)
        Me.pictureBox9.Name = "pictureBox9"
        Me.pictureBox9.Size = New System.Drawing.Size(45, 43)
        Me.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox9.TabIndex = 12
        Me.pictureBox9.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.Location = New System.Drawing.Point(4, 64)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(66, 19)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Drivers"
        '
        'pictureBox3
        '
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.Location = New System.Drawing.Point(14, 13)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(45, 44)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox3.TabIndex = 4
        Me.pictureBox3.TabStop = False
        '
        'EditBtn
        '
        Me.EditBtn.BackColor = System.Drawing.Color.ForestGreen
        Me.EditBtn.FlatAppearance.BorderSize = 0
        Me.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EditBtn.Location = New System.Drawing.Point(374, 285)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(104, 32)
        Me.EditBtn.TabIndex = 26
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = False
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.SaveBtn.FlatAppearance.BorderSize = 0
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SaveBtn.Location = New System.Drawing.Point(128, 284)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(104, 32)
        Me.SaveBtn.TabIndex = 25
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.button1.FlatAppearance.BorderSize = 0
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.button1.Location = New System.Drawing.Point(223, 294)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(0, 0)
        Me.button1.TabIndex = 24
        Me.button1.Text = "Save"
        Me.button1.UseVisualStyleBackColor = False
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label13.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.label13.Location = New System.Drawing.Point(35, 210)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(82, 24)
        Me.label13.TabIndex = 22
        Me.label13.Text = "Booked"
        '
        'panel4
        '
        Me.panel4.Controls.Add(Me.pictureBox3)
        Me.panel4.Location = New System.Drawing.Point(0, 0)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(73, 86)
        Me.panel4.TabIndex = 5
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.label2.Location = New System.Drawing.Point(8, 64)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(57, 19)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Driver"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label4.ForeColor = System.Drawing.SystemColors.InfoText
        Me.label4.Location = New System.Drawing.Point(0, 62)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(73, 19)
        Me.label4.TabIndex = 2
        Me.label4.Text = "Vehicles"
        '
        'LPlateTb
        '
        Me.LPlateTb.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LPlateTb.Location = New System.Drawing.Point(37, 144)
        Me.LPlateTb.Name = "LPlateTb"
        Me.LPlateTb.Size = New System.Drawing.Size(210, 30)
        Me.LPlateTb.TabIndex = 13
        '
        'panel5
        '
        Me.panel5.Controls.Add(Me.label4)
        Me.panel5.Controls.Add(Me.pictureBox5)
        Me.panel5.Location = New System.Drawing.Point(26, 301)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(73, 85)
        Me.panel5.TabIndex = 67
        '
        'pictureBox5
        '
        Me.pictureBox5.Image = CType(resources.GetObject("pictureBox5.Image"), System.Drawing.Image)
        Me.pictureBox5.Location = New System.Drawing.Point(10, 13)
        Me.pictureBox5.Name = "pictureBox5"
        Me.pictureBox5.Size = New System.Drawing.Size(45, 46)
        Me.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox5.TabIndex = 66
        Me.pictureBox5.TabStop = False
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.label8.Location = New System.Drawing.Point(423, 59)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(248, 32)
        Me.label8.TabIndex = 12
        Me.label8.Text = "Manage Vehicles"
        '
        'panel6
        '
        Me.panel6.Controls.Add(Me.label5)
        Me.panel6.Location = New System.Drawing.Point(26, 412)
        Me.panel6.Name = "panel6"
        Me.panel6.Size = New System.Drawing.Size(73, 86)
        Me.panel6.TabIndex = 65
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label5.ForeColor = System.Drawing.Color.Black
        Me.label5.Location = New System.Drawing.Point(-4, 64)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(83, 19)
        Me.label5.TabIndex = 2
        Me.label5.Text = "Bookings"
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.pictureBox9)
        Me.panel2.Controls.Add(Me.label1)
        Me.panel2.Location = New System.Drawing.Point(26, 100)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(73, 86)
        Me.panel2.TabIndex = 62
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(22, 17)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(51, 48)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 58
        Me.pictureBox1.TabStop = False
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.Control
        Me.panel1.Controls.Add(Me.DriverCb)
        Me.panel1.Controls.Add(Me.VehicleDGV)
        Me.panel1.Controls.Add(Me.BookedCb)
        Me.panel1.Controls.Add(Me.TypeCb)
        Me.panel1.Controls.Add(Me.label22)
        Me.panel1.Controls.Add(Me.MilleageTb)
        Me.panel1.Controls.Add(Me.label21)
        Me.panel1.Controls.Add(Me.ColorTb)
        Me.panel1.Controls.Add(Me.EngTypeCb)
        Me.panel1.Controls.Add(Me.label20)
        Me.panel1.Controls.Add(Me.DeleteBtn)
        Me.panel1.Controls.Add(Me.EditBtn)
        Me.panel1.Controls.Add(Me.SaveBtn)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.VYearCb)
        Me.panel1.Controls.Add(Me.label13)
        Me.panel1.Controls.Add(Me.label11)
        Me.panel1.Controls.Add(Me.MarkCb)
        Me.panel1.Controls.Add(Me.label10)
        Me.panel1.Controls.Add(Me.ModelTb)
        Me.panel1.Controls.Add(Me.label9)
        Me.panel1.Controls.Add(Me.LPlateTb)
        Me.panel1.Controls.Add(Me.label8)
        Me.panel1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.panel1.Location = New System.Drawing.Point(119, 16)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1191, 811)
        Me.panel1.TabIndex = 57
        '
        'panel3
        '
        Me.panel3.Controls.Add(Me.panel4)
        Me.panel3.Controls.Add(Me.label2)
        Me.panel3.Location = New System.Drawing.Point(26, 204)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(73, 86)
        Me.panel3.TabIndex = 64
        '
        'Vehicles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(1449, 838)
        Me.Controls.Add(Me.label14)
        Me.Controls.Add(Me.VNumLbl)
        Me.Controls.Add(Me.label16)
        Me.Controls.Add(Me.pictureBox4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.pictureBox6)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.pictureBox8)
        Me.Controls.Add(Me.panel7)
        Me.Controls.Add(Me.panel5)
        Me.Controls.Add(Me.panel6)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Vehicles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehicles"
        CType(Me.VehicleDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel7.ResumeLayout(False)
        CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel4.ResumeLayout(False)
        Me.panel5.ResumeLayout(False)
        Me.panel5.PerformLayout()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel6.ResumeLayout(False)
        Me.panel6.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents VYearCb As ComboBox
    Private WithEvents MarkCb As ComboBox
    Private WithEvents label14 As Label
    Private WithEvents DriverCb As ComboBox
    Private WithEvents VehicleDGV As DataGridView
    Private WithEvents label11 As Label
    Private WithEvents label10 As Label
    Private WithEvents label9 As Label
    Private WithEvents VNumLbl As Label
    Private WithEvents label16 As Label
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents TypeCb As ComboBox
    Private WithEvents label22 As Label
    Private WithEvents MilleageTb As TextBox
    Private WithEvents label3 As Label
    Private WithEvents pictureBox6 As PictureBox
    Private WithEvents label21 As Label
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents ColorTb As TextBox
    Private WithEvents EngTypeCb As ComboBox
    Private WithEvents label20 As Label
    Private WithEvents label6 As Label
    Private WithEvents label7 As Label
    Private WithEvents pictureBox8 As PictureBox
    Private WithEvents BookedCb As ComboBox
    Private WithEvents ModelTb As TextBox
    Private WithEvents panel7 As Panel
    Private WithEvents pictureBox7 As PictureBox
    Private WithEvents DeleteBtn As Button
    Private WithEvents pictureBox9 As PictureBox
    Private WithEvents label1 As Label
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents EditBtn As Button
    Private WithEvents SaveBtn As Button
    Private WithEvents button1 As Button
    Private WithEvents label13 As Label
    Private WithEvents panel4 As Panel
    Private WithEvents label2 As Label
    Private WithEvents label4 As Label
    Private WithEvents LPlateTb As TextBox
    Private WithEvents panel5 As Panel
    Private WithEvents pictureBox5 As PictureBox
    Private WithEvents label8 As Label
    Private WithEvents panel6 As Panel
    Private WithEvents label5 As Label
    Private WithEvents panel2 As Panel
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents panel1 As Panel
    Private WithEvents panel3 As Panel
End Class
