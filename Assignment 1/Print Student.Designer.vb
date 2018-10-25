<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPrintStudent
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
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.comboCourse = New System.Windows.Forms.ComboBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(12, 12)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(74, 26)
        Me.btnMainMenu.TabIndex = 8
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(49, 173)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblUsername.TabIndex = 27
        Me.lblUsername.Text = "Username:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(168, 170)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(193, 20)
        Me.txtUsername.TabIndex = 24
        '
        'comboCourse
        '
        Me.comboCourse.FormattingEnabled = True
        Me.comboCourse.Location = New System.Drawing.Point(168, 143)
        Me.comboCourse.Name = "comboCourse"
        Me.comboCourse.Size = New System.Drawing.Size(193, 21)
        Me.comboCourse.TabIndex = 23
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(49, 146)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(43, 13)
        Me.lblCourse.TabIndex = 22
        Me.lblCourse.Text = "Course:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(168, 117)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(193, 20)
        Me.txtID.TabIndex = 21
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(168, 91)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(193, 20)
        Me.txtName.TabIndex = 20
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(327, 222)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Print"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(49, 120)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 13)
        Me.lblID.TabIndex = 18
        Me.lblID.Text = "ID:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(49, 94)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 17
        Me.lblName.Text = "Name:"
        '
        'formPrintStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 279)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.comboCourse)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Name = "formPrintStudent"
        Me.Text = "Print Student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMainMenu As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents comboCourse As ComboBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblID As Label
    Friend WithEvents lblName As Label
End Class
