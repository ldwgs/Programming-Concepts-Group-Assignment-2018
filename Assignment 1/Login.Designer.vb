<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLogin
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.lblStudentUsername = New System.Windows.Forms.Label()
        Me.lblStudentPassword = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblKDULogo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(209, 196)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 20)
        Me.TextBox1.TabIndex = 0
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(209, 222)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(132, 20)
        Me.MaskedTextBox1.TabIndex = 1
        '
        'lblStudentUsername
        '
        Me.lblStudentUsername.AutoSize = True
        Me.lblStudentUsername.Location = New System.Drawing.Point(107, 199)
        Me.lblStudentUsername.Name = "lblStudentUsername"
        Me.lblStudentUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblStudentUsername.TabIndex = 2
        Me.lblStudentUsername.Text = "Username:"
        '
        'lblStudentPassword
        '
        Me.lblStudentPassword.AutoSize = True
        Me.lblStudentPassword.Location = New System.Drawing.Point(107, 221)
        Me.lblStudentPassword.Name = "lblStudentPassword"
        Me.lblStudentPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblStudentPassword.TabIndex = 3
        Me.lblStudentPassword.Text = "Password:"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(324, 282)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblKDULogo
        '
        Me.lblKDULogo.Image = Global.Assignment_1.My.Resources.Resources.logo
        Me.lblKDULogo.Location = New System.Drawing.Point(110, 9)
        Me.lblKDULogo.Name = "lblKDULogo"
        Me.lblKDULogo.Size = New System.Drawing.Size(231, 160)
        Me.lblKDULogo.TabIndex = 5
        '
        'formLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 352)
        Me.Controls.Add(Me.lblKDULogo)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblStudentPassword)
        Me.Controls.Add(Me.lblStudentUsername)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "formLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents lblStudentUsername As Label
    Friend WithEvents lblStudentPassword As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblKDULogo As Label
End Class
