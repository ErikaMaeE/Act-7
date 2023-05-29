<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.Export2Excel1 = New System.Windows.Forms.Button()
        Me.Backup1 = New System.Windows.Forms.Button()
        Me.LoadDataGrid1 = New System.Windows.Forms.Button()
        Me.DataGridViewGrade1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete1 = New System.Windows.Forms.Button()
        Me.Update1 = New System.Windows.Forms.Button()
        Me.Add1 = New System.Windows.Forms.Button()
        Me.RankTxt = New System.Windows.Forms.TextBox()
        Me.GradeTxt = New System.Windows.Forms.TextBox()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.idTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridViewGrade1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Export2Excel1
        '
        Me.Export2Excel1.BackgroundImage = CType(resources.GetObject("Export2Excel1.BackgroundImage"), System.Drawing.Image)
        Me.Export2Excel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Export2Excel1.Location = New System.Drawing.Point(875, 92)
        Me.Export2Excel1.Name = "Export2Excel1"
        Me.Export2Excel1.Size = New System.Drawing.Size(53, 50)
        Me.Export2Excel1.TabIndex = 49
        Me.Export2Excel1.UseVisualStyleBackColor = True
        '
        'Backup1
        '
        Me.Backup1.BackgroundImage = CType(resources.GetObject("Backup1.BackgroundImage"), System.Drawing.Image)
        Me.Backup1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Backup1.Location = New System.Drawing.Point(806, 92)
        Me.Backup1.Name = "Backup1"
        Me.Backup1.Size = New System.Drawing.Size(53, 50)
        Me.Backup1.TabIndex = 48
        Me.Backup1.UseVisualStyleBackColor = True
        '
        'LoadDataGrid1
        '
        Me.LoadDataGrid1.BackgroundImage = CType(resources.GetObject("LoadDataGrid1.BackgroundImage"), System.Drawing.Image)
        Me.LoadDataGrid1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LoadDataGrid1.Location = New System.Drawing.Point(738, 92)
        Me.LoadDataGrid1.Name = "LoadDataGrid1"
        Me.LoadDataGrid1.Size = New System.Drawing.Size(53, 50)
        Me.LoadDataGrid1.TabIndex = 47
        Me.LoadDataGrid1.UseVisualStyleBackColor = True
        '
        'DataGridViewGrade1
        '
        Me.DataGridViewGrade1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewGrade1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridViewGrade1.GridColor = System.Drawing.SystemColors.ControlText
        Me.DataGridViewGrade1.Location = New System.Drawing.Point(426, 162)
        Me.DataGridViewGrade1.Name = "DataGridViewGrade1"
        Me.DataGridViewGrade1.Size = New System.Drawing.Size(502, 337)
        Me.DataGridViewGrade1.TabIndex = 46
        '
        'Column1
        '
        Me.Column1.HeaderText = "id_number"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 120
        '
        'Column2
        '
        Me.Column2.HeaderText = "name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 180
        '
        'Column3
        '
        Me.Column3.HeaderText = "grade"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 80
        '
        'Column4
        '
        Me.Column4.HeaderText = "ranks"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 80
        '
        'Delete1
        '
        Me.Delete1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Delete1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete1.Location = New System.Drawing.Point(239, 467)
        Me.Delete1.Name = "Delete1"
        Me.Delete1.Size = New System.Drawing.Size(154, 32)
        Me.Delete1.TabIndex = 45
        Me.Delete1.Text = "Delete"
        Me.Delete1.UseVisualStyleBackColor = False
        '
        'Update1
        '
        Me.Update1.BackColor = System.Drawing.Color.Olive
        Me.Update1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update1.Location = New System.Drawing.Point(69, 467)
        Me.Update1.Name = "Update1"
        Me.Update1.Size = New System.Drawing.Size(154, 32)
        Me.Update1.TabIndex = 44
        Me.Update1.Text = "Update"
        Me.Update1.UseVisualStyleBackColor = False
        '
        'Add1
        '
        Me.Add1.BackColor = System.Drawing.Color.Green
        Me.Add1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add1.Location = New System.Drawing.Point(69, 429)
        Me.Add1.Name = "Add1"
        Me.Add1.Size = New System.Drawing.Size(324, 32)
        Me.Add1.TabIndex = 43
        Me.Add1.Text = "Add to Database"
        Me.Add1.UseVisualStyleBackColor = False
        '
        'RankTxt
        '
        Me.RankTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RankTxt.Location = New System.Drawing.Point(69, 372)
        Me.RankTxt.Multiline = True
        Me.RankTxt.Name = "RankTxt"
        Me.RankTxt.Size = New System.Drawing.Size(324, 36)
        Me.RankTxt.TabIndex = 42
        '
        'GradeTxt
        '
        Me.GradeTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeTxt.Location = New System.Drawing.Point(69, 283)
        Me.GradeTxt.Multiline = True
        Me.GradeTxt.Name = "GradeTxt"
        Me.GradeTxt.Size = New System.Drawing.Size(324, 36)
        Me.GradeTxt.TabIndex = 41
        '
        'NameTxt
        '
        Me.NameTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTxt.Location = New System.Drawing.Point(69, 198)
        Me.NameTxt.Multiline = True
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(324, 36)
        Me.NameTxt.TabIndex = 40
        '
        'idTxt
        '
        Me.idTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idTxt.Location = New System.Drawing.Point(69, 114)
        Me.idTxt.Multiline = True
        Me.idTxt.Name = "idTxt"
        Me.idTxt.Size = New System.Drawing.Size(324, 36)
        Me.idTxt.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 19)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Rank :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 19)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Grade :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Id Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(366, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 36)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "GRADE-2 FORM"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 35)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(973, 528)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Export2Excel1)
        Me.Controls.Add(Me.Backup1)
        Me.Controls.Add(Me.LoadDataGrid1)
        Me.Controls.Add(Me.DataGridViewGrade1)
        Me.Controls.Add(Me.Delete1)
        Me.Controls.Add(Me.Update1)
        Me.Controls.Add(Me.Add1)
        Me.Controls.Add(Me.RankTxt)
        Me.Controls.Add(Me.GradeTxt)
        Me.Controls.Add(Me.NameTxt)
        Me.Controls.Add(Me.idTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form8"
        CType(Me.DataGridViewGrade1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Export2Excel1 As Button
    Friend WithEvents Backup1 As Button
    Friend WithEvents LoadDataGrid1 As Button
    Friend WithEvents DataGridViewGrade1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Delete1 As Button
    Friend WithEvents Update1 As Button
    Friend WithEvents Add1 As Button
    Friend WithEvents RankTxt As TextBox
    Friend WithEvents GradeTxt As TextBox
    Friend WithEvents NameTxt As TextBox
    Friend WithEvents idTxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button1 As Button
End Class
