<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CancelledTrip
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
        IconButton1 = New FontAwesome.Sharp.IconButton()
        IconButton9 = New FontAwesome.Sharp.IconButton()
        IconButton7 = New FontAwesome.Sharp.IconButton()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewLinkColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' IconButton1
        ' 
        IconButton1.BackColor = Color.Silver
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.Location = New Point(910, 684)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(134, 50)
        IconButton1.TabIndex = 64
        IconButton1.Text = "Save As"
        IconButton1.UseVisualStyleBackColor = False
        ' 
        ' IconButton9
        ' 
        IconButton9.BackColor = Color.Silver
        IconButton9.FlatStyle = FlatStyle.Flat
        IconButton9.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        IconButton9.IconChar = FontAwesome.Sharp.IconChar.Save
        IconButton9.IconColor = Color.Black
        IconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton9.ImageAlign = ContentAlignment.MiddleLeft
        IconButton9.Location = New Point(1050, 684)
        IconButton9.Name = "IconButton9"
        IconButton9.Size = New Size(122, 50)
        IconButton9.TabIndex = 63
        IconButton9.Text = "Save"
        IconButton9.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton9.UseVisualStyleBackColor = False
        ' 
        ' IconButton7
        ' 
        IconButton7.BackColor = Color.Silver
        IconButton7.FlatStyle = FlatStyle.Flat
        IconButton7.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        IconButton7.IconChar = FontAwesome.Sharp.IconChar.Print
        IconButton7.IconColor = Color.Black
        IconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton7.ImageAlign = ContentAlignment.MiddleLeft
        IconButton7.Location = New Point(777, 684)
        IconButton7.Name = "IconButton7"
        IconButton7.Size = New Size(127, 50)
        IconButton7.TabIndex = 62
        IconButton7.Text = "Print"
        IconButton7.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton7.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(454, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(200, 28)
        Label1.TabIndex = 49
        Label1.Text = "CANCELLED TRIP"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9})
        DataGridView1.GridColor = Color.White
        DataGridView1.Location = New Point(214, 119)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(756, 542)
        DataGridView1.TabIndex = 65
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.DividerWidth = 1
        Column1.HeaderText = "Date of Request"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 107
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.DividerWidth = 1
        Column2.HeaderText = "Date of Travel"
        Column2.MinimumWidth = 10
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 96
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Place of Travel"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 98
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Time"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Office"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 64
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Purpose of Travel"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 85
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "Plate No."
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 74
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column8.HeaderText = "Driver"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 63
        ' 
        ' Column9
        ' 
        Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column9.HeaderText = "Cancelled"
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 65
        ' 
        ' CancelledTrip
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1199, 755)
        Controls.Add(DataGridView1)
        Controls.Add(IconButton1)
        Controls.Add(IconButton9)
        Controls.Add(IconButton7)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "CancelledTrip"
        Text = "CancelledTrip"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton9 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton7 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewLinkColumn
End Class
