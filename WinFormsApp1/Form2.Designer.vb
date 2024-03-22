<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStaff
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
        txtId = New TextBox()
        txtFName = New TextBox()
        txtLName = New TextBox()
        TextBox4 = New TextBox()
        txtMobileNo = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        staffDataGrid = New DataGridView()
        Button1 = New Button()
        CType(staffDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(152, 96)
        txtId.Name = "txtId"
        txtId.Size = New Size(99, 23)
        txtId.TabIndex = 0
        ' 
        ' txtFName
        ' 
        txtFName.Location = New Point(152, 140)
        txtFName.Name = "txtFName"
        txtFName.Size = New Size(133, 23)
        txtFName.TabIndex = 1
        ' 
        ' txtLName
        ' 
        txtLName.Location = New Point(152, 191)
        txtLName.Name = "txtLName"
        txtLName.Size = New Size(133, 23)
        txtLName.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(152, 243)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(133, 23)
        TextBox4.TabIndex = 0
        ' 
        ' txtMobileNo
        ' 
        txtMobileNo.Location = New Point(152, 243)
        txtMobileNo.MaxLength = 10
        txtMobileNo.Name = "txtMobileNo"
        txtMobileNo.Size = New Size(133, 23)
        txtMobileNo.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 1
        Label1.Text = "StaffId"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 143)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 1
        Label2.Text = "First Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 194)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 15)
        Label3.TabIndex = 1
        Label3.Text = "Last Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(21, 246)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 15)
        Label4.TabIndex = 1
        Label4.Text = "Mobile Number"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(58, 96)
        Label5.Name = "Label5"
        Label5.Size = New Size(12, 15)
        Label5.TabIndex = 2
        Label5.Text = "*"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(83, 140)
        Label6.Name = "Label6"
        Label6.Size = New Size(12, 15)
        Label6.TabIndex = 2
        Label6.Text = "*"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(21, 23)
        Label7.Name = "Label7"
        Label7.Size = New Size(240, 32)
        Label7.TabIndex = 1
        Label7.Text = "ADD STAFF DETAILS"
        ' 
        ' staffDataGrid
        ' 
        staffDataGrid.AllowUserToOrderColumns = True
        staffDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        staffDataGrid.Location = New Point(475, 23)
        staffDataGrid.Name = "staffDataGrid"
        staffDataGrid.Size = New Size(534, 243)
        staffDataGrid.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 24F)
        Button1.Location = New Point(351, 153)
        Button1.Name = "Button1"
        Button1.Size = New Size(74, 56)
        Button1.TabIndex = 4
        Button1.Text = ">>"
        Button1.TextAlign = ContentAlignment.TopCenter
        Button1.UseVisualStyleBackColor = True
        ' 
        ' AddStaff
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1021, 283)
        Controls.Add(Button1)
        Controls.Add(staffDataGrid)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label7)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtMobileNo)
        Controls.Add(TextBox4)
        Controls.Add(txtLName)
        Controls.Add(txtFName)
        Controls.Add(txtId)
        Name = "AddStaff"
        Text = "Add Staff Member"
        CType(staffDataGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtId As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents txtMobileNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents staffDataGrid As DataGridView
    Friend WithEvents Button1 As Button
End Class
