<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMainMenu
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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnPrintStudent = New System.Windows.Forms.Button()
        Me.btnSearchStudent = New System.Windows.Forms.Button()
        Me.btnViewStudent = New System.Windows.Forms.Button()
        Me.btnDeleteStudent = New System.Windows.Forms.Button()
        Me.btnEditStudent = New System.Windows.Forms.Button()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(404, 12)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(108, 51)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnPrintStudent
        '
        Me.btnPrintStudent.Image = Global.Assignment_1.My.Resources.Resources.print_student
        Me.btnPrintStudent.Location = New System.Drawing.Point(333, 335)
        Me.btnPrintStudent.Name = "btnPrintStudent"
        Me.btnPrintStudent.Size = New System.Drawing.Size(108, 90)
        Me.btnPrintStudent.TabIndex = 5
        Me.btnPrintStudent.UseVisualStyleBackColor = True
        '
        'btnSearchStudent
        '
        Me.btnSearchStudent.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearchStudent.Image = Global.Assignment_1.My.Resources.Resources.search_student
        Me.btnSearchStudent.Location = New System.Drawing.Point(97, 335)
        Me.btnSearchStudent.Name = "btnSearchStudent"
        Me.btnSearchStudent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSearchStudent.Size = New System.Drawing.Size(108, 90)
        Me.btnSearchStudent.TabIndex = 4
        Me.btnSearchStudent.UseVisualStyleBackColor = True
        '
        'btnViewStudent
        '
        Me.btnViewStudent.Image = Global.Assignment_1.My.Resources.Resources.view_student
        Me.btnViewStudent.Location = New System.Drawing.Point(333, 218)
        Me.btnViewStudent.Name = "btnViewStudent"
        Me.btnViewStudent.Size = New System.Drawing.Size(108, 90)
        Me.btnViewStudent.TabIndex = 3
        Me.btnViewStudent.UseVisualStyleBackColor = True
        '
        'btnDeleteStudent
        '
        Me.btnDeleteStudent.Image = Global.Assignment_1.My.Resources.Resources.delete_student
        Me.btnDeleteStudent.Location = New System.Drawing.Point(97, 218)
        Me.btnDeleteStudent.Name = "btnDeleteStudent"
        Me.btnDeleteStudent.Size = New System.Drawing.Size(108, 90)
        Me.btnDeleteStudent.TabIndex = 2
        Me.btnDeleteStudent.UseVisualStyleBackColor = True
        '
        'btnEditStudent
        '
        Me.btnEditStudent.Image = Global.Assignment_1.My.Resources.Resources.edit_student
        Me.btnEditStudent.Location = New System.Drawing.Point(333, 100)
        Me.btnEditStudent.Name = "btnEditStudent"
        Me.btnEditStudent.Size = New System.Drawing.Size(108, 90)
        Me.btnEditStudent.TabIndex = 1
        Me.btnEditStudent.UseVisualStyleBackColor = True
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Image = Global.Assignment_1.My.Resources.Resources.new_student
        Me.btnAddStudent.Location = New System.Drawing.Point(97, 100)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(108, 90)
        Me.btnAddStudent.TabIndex = 0
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'formMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 473)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnPrintStudent)
        Me.Controls.Add(Me.btnSearchStudent)
        Me.Controls.Add(Me.btnViewStudent)
        Me.Controls.Add(Me.btnDeleteStudent)
        Me.Controls.Add(Me.btnEditStudent)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Name = "formMainMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddStudent As Button
    Friend WithEvents btnEditStudent As Button
    Friend WithEvents btnDeleteStudent As Button
    Friend WithEvents btnViewStudent As Button
    Friend WithEvents btnSearchStudent As Button
    Friend WithEvents btnPrintStudent As Button
    Friend WithEvents btnLogout As Button
End Class
