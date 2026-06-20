<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Panel2 = New Panel()
        Label3 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        LinkLabel1 = New LinkLabel()
        btn_login = New Button()
        txt_password = New TextBox()
        txt_email = New TextBox()
        Label1 = New Label()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.DarkGray
        Button1.FlatAppearance.MouseOverBackColor = Color.LightGray
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(537, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(55, 26)
        Button1.TabIndex = 1
        Button1.Text = "x"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(213), CByte(202), CByte(189))
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(LinkLabel1)
        Panel2.Controls.Add(btn_login)
        Panel2.Controls.Add(txt_password)
        Panel2.Controls.Add(txt_email)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Button1)
        Panel2.Location = New Point(183, -2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(587, 484)
        Panel2.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(204, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(177, 17)
        Label3.TabIndex = 15
        Label3.Text = "your all in one gadgets store"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DarkSlateGray
        Label4.Location = New Point(253, 232)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 15)
        Label4.TabIndex = 14
        Label4.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(268, 182)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 12
        Label2.Text = "Email"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.Blue
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Century Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabel1.LinkColor = Color.Black
        LinkLabel1.Location = New Point(199, 438)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(185, 18)
        LinkLabel1.TabIndex = 10
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Create a new account?"
        ' 
        ' btn_login
        ' 
        btn_login.BackColor = Color.MidnightBlue
        btn_login.FlatAppearance.BorderSize = 0
        btn_login.FlatStyle = FlatStyle.Flat
        btn_login.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_login.ForeColor = Color.White
        btn_login.Location = New Point(215, 292)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(151, 30)
        btn_login.TabIndex = 9
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = False
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(155, 252)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(272, 23)
        txt_password.TabIndex = 8
        ' 
        ' txt_email
        ' 
        txt_email.Location = New Point(155, 202)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(272, 23)
        txt_email.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Dubai Medium", 26.2499962F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkSlateGray
        Label1.Location = New Point(200, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(187, 60)
        Label1.TabIndex = 6
        Label1.Text = "SPORTIFY"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(78), CByte(131), CByte(151))
        ClientSize = New Size(766, 482)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_login As Button
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
