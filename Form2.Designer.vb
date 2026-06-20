<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Panel2 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        LinkLabel2 = New LinkLabel()
        Button1 = New Button()
        su_password = New TextBox()
        su_username = New TextBox()
        su_email = New TextBox()
        Label1 = New Label()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(78), CByte(131), CByte(151))
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(LinkLabel2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(su_password)
        Panel2.Controls.Add(su_username)
        Panel2.Controls.Add(su_email)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(0, -1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(582, 485)
        Panel2.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(273, 253)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 18)
        Label4.TabIndex = 13
        Label4.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(273, 204)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 18)
        Label3.TabIndex = 12
        Label3.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(283, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 18)
        Label2.TabIndex = 11
        Label2.Text = "Email"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.ActiveLinkColor = Color.MidnightBlue
        LinkLabel2.AutoSize = True
        LinkLabel2.Font = New Font("Century Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LinkLabel2.ForeColor = Color.White
        LinkLabel2.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabel2.LinkColor = Color.WhiteSmoke
        LinkLabel2.Location = New Point(207, 427)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(204, 18)
        LinkLabel2.TabIndex = 10
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Already have an account?"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.MidnightBlue
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(229, 311)
        Button1.Name = "Button1"
        Button1.Size = New Size(163, 33)
        Button1.TabIndex = 4
        Button1.Text = "SignUp"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' su_password
        ' 
        su_password.BackColor = Color.White
        su_password.Location = New Point(162, 273)
        su_password.Name = "su_password"
        su_password.Size = New Size(290, 23)
        su_password.TabIndex = 3
        ' 
        ' su_username
        ' 
        su_username.Location = New Point(162, 225)
        su_username.Name = "su_username"
        su_username.Size = New Size(290, 23)
        su_username.TabIndex = 2
        ' 
        ' su_email
        ' 
        su_email.BackColor = Color.White
        su_email.Location = New Point(162, 173)
        su_email.Name = "su_email"
        su_email.Size = New Size(290, 23)
        su_email.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Dubai Light", 17.9999981F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(146, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(335, 40)
        Label1.TabIndex = 0
        Label1.Text = "Register your SPORTIFY account"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(213), CByte(202), CByte(189))
        ClientSize = New Size(766, 482)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents su_password As TextBox
    Friend WithEvents su_username As TextBox
    Friend WithEvents su_email As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
