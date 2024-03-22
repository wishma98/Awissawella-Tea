<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddGradings
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
        Button1 = New Button()
        gradingsDataGrid = New DataGridView()
        Label6 = New Label()
        Label7 = New Label()
        Label2 = New Label()
        txtGName = New TextBox()
        CType(gradingsDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 18F)
        Button1.Location = New Point(12, 126)
        Button1.Name = "Button1"
        Button1.Size = New Size(264, 38)
        Button1.TabIndex = 18
        Button1.Text = "Add to list"
        Button1.TextAlign = ContentAlignment.TopCenter
        Button1.UseVisualStyleBackColor = True
        ' 
        ' gradingsDataGrid
        ' 
        gradingsDataGrid.AllowUserToOrderColumns = True
        gradingsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gradingsDataGrid.Location = New Point(12, 193)
        gradingsDataGrid.Name = "gradingsDataGrid"
        gradingsDataGrid.Size = New Size(264, 355)
        gradingsDataGrid.TabIndex = 19
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(74, 86)
        Label6.Name = "Label6"
        Label6.Size = New Size(12, 15)
        Label6.TabIndex = 14
        Label6.Text = "*"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(12, 21)
        Label7.Name = "Label7"
        Label7.Size = New Size(250, 32)
        Label7.TabIndex = 10
        Label7.Text = "ADD TEA GRADINGS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 11
        Label2.Text = "Grad Name"
        ' 
        ' txtGName
        ' 
        txtGName.Location = New Point(143, 86)
        txtGName.Name = "txtGName"
        txtGName.Size = New Size(133, 23)
        txtGName.TabIndex = 13
        ' 
        ' AddGradings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(296, 560)
        Controls.Add(Button1)
        Controls.Add(gradingsDataGrid)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label2)
        Controls.Add(txtGName)
        Name = "AddGradings"
        Text = "Add Gradings"
        CType(gradingsDataGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents gradingsDataGrid As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGName As TextBox
End Class
