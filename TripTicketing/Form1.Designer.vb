<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Panel2 = New Panel()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        IconButton3 = New FontAwesome.Sharp.IconButton()
        IconButton6 = New FontAwesome.Sharp.IconButton()
        Panel1 = New Panel()
        IconButton5 = New FontAwesome.Sharp.IconButton()
        IconButton4 = New FontAwesome.Sharp.IconButton()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        Panel3 = New Panel()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(233, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1360, 54)
        Panel2.TabIndex = 1
        ' 
        ' IconButton2
        ' 
        IconButton2.BackColor = Color.White
        IconButton2.FlatAppearance.BorderColor = Color.Black
        IconButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        IconButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        IconButton2.FlatStyle = FlatStyle.Flat
        IconButton2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.CalendarDay
        IconButton2.IconColor = Color.Black
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton2.ImageAlign = ContentAlignment.MiddleLeft
        IconButton2.Location = New Point(12, 153)
        IconButton2.Name = "IconButton2"
        IconButton2.Size = New Size(204, 69)
        IconButton2.TabIndex = 1
        IconButton2.Text = "Scheduled Trip"
        IconButton2.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton2.UseVisualStyleBackColor = False
        ' 
        ' IconButton3
        ' 
        IconButton3.BackColor = Color.White
        IconButton3.FlatAppearance.BorderColor = Color.Black
        IconButton3.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        IconButton3.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        IconButton3.FlatStyle = FlatStyle.Flat
        IconButton3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        IconButton3.IconChar = FontAwesome.Sharp.IconChar.Cancel
        IconButton3.IconColor = Color.Black
        IconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton3.ImageAlign = ContentAlignment.MiddleLeft
        IconButton3.Location = New Point(12, 241)
        IconButton3.Name = "IconButton3"
        IconButton3.Size = New Size(204, 69)
        IconButton3.TabIndex = 2
        IconButton3.Text = "Cancelled Trip"
        IconButton3.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton3.UseVisualStyleBackColor = False
        ' 
        ' IconButton6
        ' 
        IconButton6.BackColor = Color.White
        IconButton6.FlatAppearance.BorderColor = Color.Black
        IconButton6.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        IconButton6.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        IconButton6.FlatStyle = FlatStyle.Flat
        IconButton6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        IconButton6.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek
        IconButton6.IconColor = Color.Black
        IconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton6.ImageAlign = ContentAlignment.MiddleLeft
        IconButton6.Location = New Point(12, 522)
        IconButton6.Name = "IconButton6"
        IconButton6.Size = New Size(204, 69)
        IconButton6.TabIndex = 5
        IconButton6.Text = "Monthly Consumption Report"
        IconButton6.TextAlign = ContentAlignment.MiddleLeft
        IconButton6.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton6.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(233, 60)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1348, 788)
        Panel1.TabIndex = 6
        ' 
        ' IconButton5
        ' 
        IconButton5.BackColor = Color.White
        IconButton5.FlatAppearance.BorderColor = Color.Black
        IconButton5.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        IconButton5.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        IconButton5.FlatStyle = FlatStyle.Flat
        IconButton5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        IconButton5.IconChar = FontAwesome.Sharp.IconChar.Bus
        IconButton5.IconColor = Color.Black
        IconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton5.ImageAlign = ContentAlignment.MiddleLeft
        IconButton5.Location = New Point(12, 427)
        IconButton5.Name = "IconButton5"
        IconButton5.Size = New Size(204, 69)
        IconButton5.TabIndex = 4
        IconButton5.Text = "Dispatch"
        IconButton5.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton5.UseVisualStyleBackColor = False
        ' 
        ' IconButton4
        ' 
        IconButton4.BackColor = Color.White
        IconButton4.FlatAppearance.BorderColor = Color.Black
        IconButton4.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        IconButton4.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        IconButton4.FlatStyle = FlatStyle.Flat
        IconButton4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        IconButton4.IconChar = FontAwesome.Sharp.IconChar.Ticket
        IconButton4.IconColor = Color.Black
        IconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton4.ImageAlign = ContentAlignment.MiddleLeft
        IconButton4.Location = New Point(12, 334)
        IconButton4.Name = "IconButton4"
        IconButton4.Size = New Size(204, 69)
        IconButton4.TabIndex = 3
        IconButton4.Text = "Trip Ticket"
        IconButton4.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton4.UseVisualStyleBackColor = False
        ' 
        ' IconButton1
        ' 
        IconButton1.BackColor = Color.White
        IconButton1.FlatAppearance.BorderColor = Color.Black
        IconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        IconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.File
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.ImageAlign = ContentAlignment.MiddleLeft
        IconButton1.Location = New Point(12, 68)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(204, 69)
        IconButton1.TabIndex = 0
        IconButton1.Text = "Request for Vehicle"
        IconButton1.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(233, 860)
        Panel3.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1593, 860)
        Controls.Add(IconButton1)
        Controls.Add(Panel1)
        Controls.Add(IconButton6)
        Controls.Add(Panel2)
        Controls.Add(IconButton4)
        Controls.Add(IconButton5)
        Controls.Add(IconButton2)
        Controls.Add(IconButton3)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel

End Class
