<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_form))
        pnlTopSide = New Panel()
        Button1 = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        BindingSource1 = New BindingSource(components)
        pnlHeadphones = New Panel()
        pnlWht = New Panel()
        JBLWHT = New Label()
        buttHeadphones4 = New Button()
        pnlMono = New Panel()
        JBLMONO = New Label()
        buttHeadphones3 = New Button()
        pnlGry = New Panel()
        JBLGRY = New Label()
        buttHeadphones2 = New Button()
        pnlBlck = New Panel()
        JBLBLCK = New Label()
        buttHeadphones1 = New Button()
        pnlEarbuds = New Panel()
        pnlSkura = New Panel()
        JBLSKRA = New Label()
        buttEarbuds4 = New Button()
        pnlDark = New Panel()
        JBLDRK = New Label()
        buttEarbuds3 = New Button()
        pnlBlu = New Panel()
        JBLBLU = New Label()
        buttEarbuds2 = New Button()
        pnlTs = New Panel()
        JBLTS = New Label()
        buttEarbuds1 = New Button()
        pnlPowerbanks = New Panel()
        pnlDuo = New Panel()
        JBLDUO = New Label()
        buttPowerbanks4 = New Button()
        pnlBlw = New Panel()
        JBLBLW = New Label()
        buttPowerbanks3 = New Button()
        pnlRyker = New Panel()
        JBLRYKER = New Label()
        buttPowerbanks2 = New Button()
        pnlTnk = New Panel()
        JBLTNK = New Label()
        buttPowerbanks1 = New Button()
        pnlMyCart = New Panel()
        btnCheckout = New Button()
        btnClearCart = New Button()
        lblTotal = New Label()
        lblCartDisplay = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        btnHeadphones = New Button()
        OnButtonHeadphones = New Panel()
        btnEarbuds = New Button()
        OnButtonEarbuds = New Panel()
        btnPowerbanks = New Button()
        OnButtonPowerbanks = New Panel()
        btnMyCart = New Button()
        OnButtonMyCart = New Panel()
        BlackSideIcon = New Panel()
        GraySideIcon = New Panel()
        nameSportify = New Label()
        pnlLeftSide = New Panel()
        pnlTopSide.SuspendLayout()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        pnlHeadphones.SuspendLayout()
        pnlWht.SuspendLayout()
        pnlMono.SuspendLayout()
        pnlGry.SuspendLayout()
        pnlBlck.SuspendLayout()
        pnlEarbuds.SuspendLayout()
        pnlSkura.SuspendLayout()
        pnlDark.SuspendLayout()
        pnlBlu.SuspendLayout()
        pnlTs.SuspendLayout()
        pnlPowerbanks.SuspendLayout()
        pnlDuo.SuspendLayout()
        pnlBlw.SuspendLayout()
        pnlRyker.SuspendLayout()
        pnlTnk.SuspendLayout()
        pnlMyCart.SuspendLayout()
        pnlLeftSide.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlTopSide
        ' 
        pnlTopSide.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlTopSide.BackColor = Color.Lavender
        pnlTopSide.Controls.Add(Button1)
        pnlTopSide.Controls.Add(Panel1)
        pnlTopSide.Controls.Add(Panel2)
        pnlTopSide.Location = New Point(200, 0)
        pnlTopSide.Name = "pnlTopSide"
        pnlTopSide.Size = New Size(778, 82)
        pnlTopSide.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.DarkGray
        Button1.FlatAppearance.MouseOverBackColor = Color.LightGray
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(646, -1)
        Button1.Name = "Button1"
        Button1.Size = New Size(55, 26)
        Button1.TabIndex = 6
        Button1.Text = "x"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Center
        Panel1.Location = New Point(516, -3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(39, 37)
        Panel1.TabIndex = 13
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Center
        Panel2.Location = New Point(549, -3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(39, 37)
        Panel2.TabIndex = 12
        ' 
        ' pnlHeadphones
        ' 
        pnlHeadphones.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlHeadphones.BackgroundImage = CType(resources.GetObject("pnlHeadphones.BackgroundImage"), Image)
        pnlHeadphones.BackgroundImageLayout = ImageLayout.Stretch
        pnlHeadphones.Controls.Add(pnlWht)
        pnlHeadphones.Controls.Add(pnlMono)
        pnlHeadphones.Controls.Add(pnlGry)
        pnlHeadphones.Controls.Add(pnlBlck)
        pnlHeadphones.Location = New Point(200, 30)
        pnlHeadphones.Name = "pnlHeadphones"
        pnlHeadphones.Size = New Size(699, 511)
        pnlHeadphones.TabIndex = 2
        ' 
        ' pnlWht
        ' 
        pnlWht.BackColor = Color.Transparent
        pnlWht.Controls.Add(JBLWHT)
        pnlWht.Controls.Add(buttHeadphones4)
        pnlWht.Location = New Point(465, 328)
        pnlWht.Name = "pnlWht"
        pnlWht.Size = New Size(174, 174)
        pnlWht.TabIndex = 7
        ' 
        ' JBLWHT
        ' 
        JBLWHT.AutoSize = True
        JBLWHT.Font = New Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        JBLWHT.ForeColor = SystemColors.ActiveCaptionText
        JBLWHT.Location = New Point(16, 150)
        JBLWHT.Name = "JBLWHT"
        JBLWHT.Size = New Size(143, 21)
        JBLWHT.TabIndex = 1
        JBLWHT.Text = "WHTE Headphones"
        ' 
        ' buttHeadphones4
        ' 
        buttHeadphones4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        buttHeadphones4.BackgroundImage = CType(resources.GetObject("buttHeadphones4.BackgroundImage"), Image)
        buttHeadphones4.BackgroundImageLayout = ImageLayout.Zoom
        buttHeadphones4.FlatAppearance.BorderSize = 0
        buttHeadphones4.FlatStyle = FlatStyle.Flat
        buttHeadphones4.Location = New Point(4, 3)
        buttHeadphones4.Name = "buttHeadphones4"
        buttHeadphones4.Size = New Size(166, 147)
        buttHeadphones4.TabIndex = 0
        buttHeadphones4.UseVisualStyleBackColor = True
        ' 
        ' pnlMono
        ' 
        pnlMono.BackColor = Color.Transparent
        pnlMono.Controls.Add(JBLMONO)
        pnlMono.Controls.Add(buttHeadphones3)
        pnlMono.Location = New Point(147, 328)
        pnlMono.Name = "pnlMono"
        pnlMono.Size = New Size(174, 174)
        pnlMono.TabIndex = 4
        ' 
        ' JBLMONO
        ' 
        JBLMONO.AutoSize = True
        JBLMONO.Font = New Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        JBLMONO.ForeColor = SystemColors.ActiveCaptionText
        JBLMONO.Location = New Point(11, 150)
        JBLMONO.Name = "JBLMONO"
        JBLMONO.Size = New Size(151, 21)
        JBLMONO.TabIndex = 1
        JBLMONO.Text = "MONO Headphones"
        ' 
        ' buttHeadphones3
        ' 
        buttHeadphones3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        buttHeadphones3.BackgroundImage = CType(resources.GetObject("buttHeadphones3.BackgroundImage"), Image)
        buttHeadphones3.BackgroundImageLayout = ImageLayout.Zoom
        buttHeadphones3.FlatAppearance.BorderSize = 0
        buttHeadphones3.FlatStyle = FlatStyle.Flat
        buttHeadphones3.Location = New Point(5, 3)
        buttHeadphones3.Name = "buttHeadphones3"
        buttHeadphones3.Size = New Size(166, 147)
        buttHeadphones3.TabIndex = 0
        buttHeadphones3.UseVisualStyleBackColor = True
        ' 
        ' pnlGry
        ' 
        pnlGry.BackColor = Color.Transparent
        pnlGry.Controls.Add(JBLGRY)
        pnlGry.Controls.Add(buttHeadphones2)
        pnlGry.Location = New Point(465, 43)
        pnlGry.Name = "pnlGry"
        pnlGry.Size = New Size(174, 174)
        pnlGry.TabIndex = 3
        ' 
        ' JBLGRY
        ' 
        JBLGRY.AutoSize = True
        JBLGRY.Font = New Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        JBLGRY.ForeColor = SystemColors.ActiveCaptionText
        JBLGRY.Location = New Point(22, 150)
        JBLGRY.Name = "JBLGRY"
        JBLGRY.Size = New Size(131, 21)
        JBLGRY.TabIndex = 1
        JBLGRY.Text = "GRY Headphones"
        ' 
        ' buttHeadphones2
        ' 
        buttHeadphones2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        buttHeadphones2.BackgroundImage = CType(resources.GetObject("buttHeadphones2.BackgroundImage"), Image)
        buttHeadphones2.BackgroundImageLayout = ImageLayout.Zoom
        buttHeadphones2.FlatAppearance.BorderSize = 0
        buttHeadphones2.FlatStyle = FlatStyle.Flat
        buttHeadphones2.Location = New Point(5, 3)
        buttHeadphones2.Name = "buttHeadphones2"
        buttHeadphones2.Size = New Size(166, 147)
        buttHeadphones2.TabIndex = 0
        buttHeadphones2.UseVisualStyleBackColor = True
        ' 
        ' pnlBlck
        ' 
        pnlBlck.BackColor = Color.Transparent
        pnlBlck.Controls.Add(JBLBLCK)
        pnlBlck.Controls.Add(buttHeadphones1)
        pnlBlck.Location = New Point(147, 43)
        pnlBlck.Name = "pnlBlck"
        pnlBlck.Size = New Size(174, 174)
        pnlBlck.TabIndex = 0
        ' 
        ' JBLBLCK
        ' 
        JBLBLCK.AutoSize = True
        JBLBLCK.Font = New Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        JBLBLCK.ForeColor = SystemColors.ActiveCaptionText
        JBLBLCK.Location = New Point(24, 150)
        JBLBLCK.Name = "JBLBLCK"
        JBLBLCK.Size = New Size(124, 21)
        JBLBLCK.TabIndex = 1
        JBLBLCK.Text = "JBL Headphones"
        JBLBLCK.TextAlign = ContentAlignment.TopRight
        ' 
        ' buttHeadphones1
        ' 
        buttHeadphones1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        buttHeadphones1.BackgroundImage = CType(resources.GetObject("buttHeadphones1.BackgroundImage"), Image)
        buttHeadphones1.BackgroundImageLayout = ImageLayout.Zoom
        buttHeadphones1.FlatAppearance.BorderSize = 0
        buttHeadphones1.FlatStyle = FlatStyle.Flat
        buttHeadphones1.Location = New Point(5, 3)
        buttHeadphones1.Name = "buttHeadphones1"
        buttHeadphones1.Size = New Size(166, 147)
        buttHeadphones1.TabIndex = 0
        buttHeadphones1.UseVisualStyleBackColor = True
        ' 
        ' pnlEarbuds
        ' 
        pnlEarbuds.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlEarbuds.BackgroundImage = CType(resources.GetObject("pnlEarbuds.BackgroundImage"), Image)
        pnlEarbuds.BackgroundImageLayout = ImageLayout.Stretch
        pnlEarbuds.Controls.Add(pnlSkura)
        pnlEarbuds.Controls.Add(pnlDark)
        pnlEarbuds.Controls.Add(pnlBlu)
        pnlEarbuds.Controls.Add(pnlTs)
        pnlEarbuds.Location = New Point(200, 31)
        pnlEarbuds.Name = "pnlEarbuds"
        pnlEarbuds.Size = New Size(699, 511)
        pnlEarbuds.TabIndex = 3
        ' 
        ' pnlSkura
        ' 
        pnlSkura.BackColor = Color.Transparent
        pnlSkura.Controls.Add(JBLSKRA)
        pnlSkura.Controls.Add(buttEarbuds4)
        pnlSkura.Location = New Point(465, 328)
        pnlSkura.Name = "pnlSkura"
        pnlSkura.Size = New Size(174, 174)
        pnlSkura.TabIndex = 7
        ' 
        ' JBLSKRA
        ' 
        JBLSKRA.AutoSize = True
        JBLSKRA.Font = New Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        JBLSKRA.ForeColor = SystemColors.ActiveCaptionText
        JBLSKRA.Location = New Point(21, 150)
        JBLSKRA.Name = "JBLSKRA"
        JBLSKRA.Size = New Size(129, 21)
        JBLSKRA.TabIndex = 1
        JBLSKRA.Text = "SAKURA Earbuds"
        ' 
        ' buttEarbuds4
        ' 
        buttEarbuds4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        buttEarbuds4.BackgroundImage = CType(resources.GetObject("buttEarbuds4.BackgroundImage"), Image)
        buttEarbuds4.BackgroundImageLayout = ImageLayout.Zoom
        buttEarbuds4.FlatAppearance.BorderSize = 0
        buttEarbuds4.FlatStyle = FlatStyle.Flat
        buttEarbuds4.Location = New Point(4, 3)
        buttEarbuds4.Name = "buttEarbuds4"
        buttEarbuds4.Size = New Size(166, 145)
        buttEarbuds4.TabIndex = 0
        buttEarbuds4.UseVisualStyleBackColor = True
        ' 
        ' pnlDark
        ' 
        pnlDark.BackColor = Color.Transparent
        pnlDark.Controls.Add(JBLDRK)
        pnlDark.Controls.Add(buttEarbuds3)
        pnlDark.Location = New Point(147, 328)
        pnlDark.Name = "pnlDark"
        pnlDark.Size = New Size(174, 174)
        pnlDark.TabIndex = 4
        ' 
        ' JBLDRK
        ' 
        JBLDRK.AutoSize = True
        JBLDRK.Font = New Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        JBLDRK.ForeColor = SystemColors.ActiveCaptionText
        JBLDRK.Location = New Point(34, 150)
        JBLDRK.Name = "JBLDRK"
        JBLDRK.Size = New Size(100, 21)
        JBLDRK.TabIndex = 1
        JBLDRK.Text = "DRK Earbuds"
        ' 
        ' buttEarbuds3
        ' 
        buttEarbuds3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        buttEarbuds3.BackgroundImage = CType(resources.GetObject("buttEarbuds3.BackgroundImage"), Image)
        buttEarbuds3.BackgroundImageLayout = ImageLayout.Zoom
        buttEarbuds3.FlatAppearance.BorderSize = 0
        buttEarbuds3.FlatStyle = FlatStyle.Flat
        buttEarbuds3.Location = New Point(4, 3)
        buttEarbuds3.Name = "buttEarbuds3"
        buttEarbuds3.Size = New Size(166, 145)
        buttEarbuds3.TabIndex = 0
        buttEarbuds3.UseVisualStyleBackColor = True
        ' 
        ' pnlBlu
        ' 
        pnlBlu.BackColor = Color.Transparent
        pnlBlu.Controls.Add(JBLBLU)
        pnlBlu.Controls.Add(buttEarbuds2)
        pnlBlu.Location = New Point(465, 43)
        pnlBlu.Name = "pnlBlu"
        pnlBlu.Size = New Size(174, 174)
        pnlBlu.TabIndex = 3
        ' 
        ' JBLBLU
        ' 
        JBLBLU.AutoSize = True
        JBLBLU.Font = New Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        JBLBLU.ForeColor = SystemColors.ActiveCaptionText
        JBLBLU.Location = New Point(36, 150)
        JBLBLU.Name = "JBLBLU"
        JBLBLU.Size = New Size(98, 21)
        JBLBLU.TabIndex = 1
        JBLBLU.Text = "BLU Earbuds"
        ' 
        ' buttEarbuds2
        ' 
        buttEarbuds2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        buttEarbuds2.BackgroundImage = CType(resources.GetObject("buttEarbuds2.BackgroundImage"), Image)
        buttEarbuds2.BackgroundImageLayout = ImageLayout.Zoom
        buttEarbuds2.FlatAppearance.BorderSize = 0
        buttEarbuds2.FlatStyle = FlatStyle.Flat
        buttEarbuds2.Location = New Point(4, 3)
        buttEarbuds2.Name = "buttEarbuds2"
        buttEarbuds2.Size = New Size(166, 145)
        buttEarbuds2.TabIndex = 0
        buttEarbuds2.UseVisualStyleBackColor = True
        ' 
        ' pnlTs
        ' 
        pnlTs.BackColor = Color.Transparent
        pnlTs.Controls.Add(JBLTS)
        pnlTs.Controls.Add(buttEarbuds1)
        pnlTs.Location = New Point(147, 43)
        pnlTs.Name = "pnlTs"
        pnlTs.Size = New Size(174, 174)
        pnlTs.TabIndex = 0
        ' 
        ' JBLTS
        ' 
        JBLTS.AutoSize = True
        JBLTS.Font = New Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        JBLTS.ForeColor = SystemColors.ActiveCaptionText
        JBLTS.Location = New Point(40, 150)
        JBLTS.Name = "JBLTS"
        JBLTS.Size = New Size(87, 21)
        JBLTS.TabIndex = 1
        JBLTS.Text = "TS Earbuds"
        JBLTS.TextAlign = ContentAlignment.TopRight
        ' 
        ' buttEarbuds1
        ' 
        buttEarbuds1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        buttEarbuds1.BackgroundImage = CType(resources.GetObject("buttEarbuds1.BackgroundImage"), Image)
        buttEarbuds1.BackgroundImageLayout = ImageLayout.Zoom
        buttEarbuds1.FlatAppearance.BorderSize = 0
        buttEarbuds1.FlatStyle = FlatStyle.Flat
        buttEarbuds1.Location = New Point(4, 3)
        buttEarbuds1.Name = "buttEarbuds1"
        buttEarbuds1.Size = New Size(166, 145)
        buttEarbuds1.TabIndex = 0
        buttEarbuds1.UseVisualStyleBackColor = True
        ' 
        ' pnlPowerbanks
        ' 
        pnlPowerbanks.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlPowerbanks.BackgroundImage = CType(resources.GetObject("pnlPowerbanks.BackgroundImage"), Image)
        pnlPowerbanks.BackgroundImageLayout = ImageLayout.Stretch
        pnlPowerbanks.Controls.Add(pnlDuo)
        pnlPowerbanks.Controls.Add(pnlBlw)
        pnlPowerbanks.Controls.Add(pnlRyker)
        pnlPowerbanks.Controls.Add(pnlTnk)
        pnlPowerbanks.Location = New Point(200, 30)
        pnlPowerbanks.Name = "pnlPowerbanks"
        pnlPowerbanks.Size = New Size(699, 511)
        pnlPowerbanks.TabIndex = 4
        ' 
        ' pnlDuo
        ' 
        pnlDuo.BackColor = Color.Transparent
        pnlDuo.Controls.Add(JBLDUO)
        pnlDuo.Controls.Add(buttPowerbanks4)
        pnlDuo.Location = New Point(465, 328)
        pnlDuo.Name = "pnlDuo"
        pnlDuo.Size = New Size(174, 174)
        pnlDuo.TabIndex = 7
        ' 
        ' JBLDUO
        ' 
        JBLDUO.AutoSize = True
        JBLDUO.Font = New Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        JBLDUO.ForeColor = SystemColors.ActiveCaptionText
        JBLDUO.Location = New Point(28, 150)
        JBLDUO.Name = "JBLDUO"
        JBLDUO.Size = New Size(125, 21)
        JBLDUO.TabIndex = 1
        JBLDUO.Text = "DUO Powerbank"
        ' 
        ' buttPowerbanks4
        ' 
        buttPowerbanks4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        buttPowerbanks4.BackgroundImage = CType(resources.GetObject("buttPowerbanks4.BackgroundImage"), Image)
        buttPowerbanks4.BackgroundImageLayout = ImageLayout.Zoom
        buttPowerbanks4.FlatAppearance.BorderSize = 0
        buttPowerbanks4.FlatStyle = FlatStyle.Flat
        buttPowerbanks4.Location = New Point(4, 3)
        buttPowerbanks4.Name = "buttPowerbanks4"
        buttPowerbanks4.Size = New Size(166, 145)
        buttPowerbanks4.TabIndex = 0
        buttPowerbanks4.UseVisualStyleBackColor = True
        ' 
        ' pnlBlw
        ' 
        pnlBlw.BackColor = Color.Transparent
        pnlBlw.Controls.Add(JBLBLW)
        pnlBlw.Controls.Add(buttPowerbanks3)
        pnlBlw.Location = New Point(147, 328)
        pnlBlw.Name = "pnlBlw"
        pnlBlw.Size = New Size(174, 174)
        pnlBlw.TabIndex = 4
        ' 
        ' JBLBLW
        ' 
        JBLBLW.AutoSize = True
        JBLBLW.Font = New Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        JBLBLW.ForeColor = SystemColors.ActiveCaptionText
        JBLBLW.Location = New Point(30, 150)
        JBLBLW.Name = "JBLBLW"
        JBLBLW.Size = New Size(123, 21)
        JBLBLW.TabIndex = 1
        JBLBLW.Text = "BLW Powerbank"
        ' 
        ' buttPowerbanks3
        ' 
        buttPowerbanks3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        buttPowerbanks3.BackgroundImage = CType(resources.GetObject("buttPowerbanks3.BackgroundImage"), Image)
        buttPowerbanks3.BackgroundImageLayout = ImageLayout.Zoom
        buttPowerbanks3.FlatAppearance.BorderSize = 0
        buttPowerbanks3.FlatStyle = FlatStyle.Flat
        buttPowerbanks3.Location = New Point(4, 3)
        buttPowerbanks3.Name = "buttPowerbanks3"
        buttPowerbanks3.Size = New Size(166, 145)
        buttPowerbanks3.TabIndex = 0
        buttPowerbanks3.UseVisualStyleBackColor = True
        ' 
        ' pnlRyker
        ' 
        pnlRyker.BackColor = Color.Transparent
        pnlRyker.Controls.Add(JBLRYKER)
        pnlRyker.Controls.Add(buttPowerbanks2)
        pnlRyker.Location = New Point(465, 43)
        pnlRyker.Name = "pnlRyker"
        pnlRyker.Size = New Size(174, 174)
        pnlRyker.TabIndex = 3
        ' 
        ' JBLRYKER
        ' 
        JBLRYKER.AutoSize = True
        JBLRYKER.Font = New Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        JBLRYKER.ForeColor = SystemColors.ActiveCaptionText
        JBLRYKER.Location = New Point(19, 150)
        JBLRYKER.Name = "JBLRYKER"
        JBLRYKER.Size = New Size(137, 21)
        JBLRYKER.TabIndex = 1
        JBLRYKER.Text = "RYKER Powerbank"
        ' 
        ' buttPowerbanks2
        ' 
        buttPowerbanks2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        buttPowerbanks2.BackgroundImage = CType(resources.GetObject("buttPowerbanks2.BackgroundImage"), Image)
        buttPowerbanks2.BackgroundImageLayout = ImageLayout.Zoom
        buttPowerbanks2.FlatAppearance.BorderSize = 0
        buttPowerbanks2.FlatStyle = FlatStyle.Flat
        buttPowerbanks2.Location = New Point(4, 3)
        buttPowerbanks2.Name = "buttPowerbanks2"
        buttPowerbanks2.Size = New Size(166, 145)
        buttPowerbanks2.TabIndex = 0
        buttPowerbanks2.UseVisualStyleBackColor = True
        ' 
        ' pnlTnk
        ' 
        pnlTnk.BackColor = Color.Transparent
        pnlTnk.Controls.Add(JBLTNK)
        pnlTnk.Controls.Add(buttPowerbanks1)
        pnlTnk.Location = New Point(147, 43)
        pnlTnk.Name = "pnlTnk"
        pnlTnk.Size = New Size(174, 174)
        pnlTnk.TabIndex = 0
        ' 
        ' JBLTNK
        ' 
        JBLTNK.AutoSize = True
        JBLTNK.Font = New Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        JBLTNK.ForeColor = SystemColors.ActiveCaptionText
        JBLTNK.Location = New Point(22, 150)
        JBLTNK.Name = "JBLTNK"
        JBLTNK.Size = New Size(129, 21)
        JBLTNK.TabIndex = 1
        JBLTNK.Text = "TANK Powerbank"
        JBLTNK.TextAlign = ContentAlignment.TopRight
        ' 
        ' buttPowerbanks1
        ' 
        buttPowerbanks1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        buttPowerbanks1.BackgroundImage = CType(resources.GetObject("buttPowerbanks1.BackgroundImage"), Image)
        buttPowerbanks1.BackgroundImageLayout = ImageLayout.Zoom
        buttPowerbanks1.FlatAppearance.BorderSize = 0
        buttPowerbanks1.FlatStyle = FlatStyle.Flat
        buttPowerbanks1.Location = New Point(4, 3)
        buttPowerbanks1.Name = "buttPowerbanks1"
        buttPowerbanks1.Size = New Size(166, 145)
        buttPowerbanks1.TabIndex = 0
        buttPowerbanks1.UseVisualStyleBackColor = True
        ' 
        ' pnlMyCart
        ' 
        pnlMyCart.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlMyCart.BackgroundImage = CType(resources.GetObject("pnlMyCart.BackgroundImage"), Image)
        pnlMyCart.BackgroundImageLayout = ImageLayout.Stretch
        pnlMyCart.Controls.Add(btnCheckout)
        pnlMyCart.Controls.Add(btnClearCart)
        pnlMyCart.Controls.Add(lblTotal)
        pnlMyCart.Controls.Add(lblCartDisplay)
        pnlMyCart.Location = New Point(200, 30)
        pnlMyCart.Name = "pnlMyCart"
        pnlMyCart.Size = New Size(699, 511)
        pnlMyCart.TabIndex = 5
        ' 
        ' btnCheckout
        ' 
        btnCheckout.BackColor = Color.LimeGreen
        btnCheckout.FlatAppearance.BorderSize = 0
        btnCheckout.FlatStyle = FlatStyle.Flat
        btnCheckout.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCheckout.Location = New Point(499, 446)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.Size = New Size(119, 41)
        btnCheckout.TabIndex = 5
        btnCheckout.Text = "Checkout"
        btnCheckout.UseVisualStyleBackColor = False
        ' 
        ' btnClearCart
        ' 
        btnClearCart.BackColor = Color.IndianRed
        btnClearCart.FlatAppearance.BorderSize = 0
        btnClearCart.FlatStyle = FlatStyle.Flat
        btnClearCart.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClearCart.Location = New Point(80, 447)
        btnClearCart.Name = "btnClearCart"
        btnClearCart.Size = New Size(119, 41)
        btnClearCart.TabIndex = 4
        btnClearCart.Text = "Clear Cart"
        btnClearCart.UseVisualStyleBackColor = False
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.BackColor = Color.DeepSkyBlue
        lblTotal.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(308, 460)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(87, 18)
        lblTotal.TabIndex = 3
        lblTotal.Text = "Total: $0.00"
        ' 
        ' lblCartDisplay
        ' 
        lblCartDisplay.BackColor = Color.Transparent
        lblCartDisplay.Font = New Font("Dubai", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCartDisplay.Location = New Point(319, 14)
        lblCartDisplay.Name = "lblCartDisplay"
        lblCartDisplay.Size = New Size(87, 30)
        lblCartDisplay.TabIndex = 1
        lblCartDisplay.Text = "My Cart"
        ' 
        ' btnHeadphones
        ' 
        btnHeadphones.BackColor = Color.Transparent
        btnHeadphones.FlatAppearance.BorderSize = 0
        btnHeadphones.FlatStyle = FlatStyle.Flat
        btnHeadphones.Font = New Font("Arial", 12F)
        btnHeadphones.Image = My.Resources.Resources.icons8_headphones_16__1_
        btnHeadphones.Location = New Point(3, 73)
        btnHeadphones.Name = "btnHeadphones"
        btnHeadphones.Size = New Size(194, 50)
        btnHeadphones.TabIndex = 2
        btnHeadphones.Text = " Headphones"
        btnHeadphones.TextAlign = ContentAlignment.MiddleRight
        btnHeadphones.TextImageRelation = TextImageRelation.ImageBeforeText
        btnHeadphones.UseVisualStyleBackColor = False
        ' 
        ' OnButtonHeadphones
        ' 
        OnButtonHeadphones.BackColor = Color.DimGray
        OnButtonHeadphones.BorderStyle = BorderStyle.FixedSingle
        OnButtonHeadphones.Location = New Point(0, 71)
        OnButtonHeadphones.Name = "OnButtonHeadphones"
        OnButtonHeadphones.Size = New Size(16, 53)
        OnButtonHeadphones.TabIndex = 2
        ' 
        ' btnEarbuds
        ' 
        btnEarbuds.BackColor = Color.Transparent
        btnEarbuds.FlatAppearance.BorderSize = 0
        btnEarbuds.FlatStyle = FlatStyle.Flat
        btnEarbuds.Font = New Font("Arial", 12F)
        btnEarbuds.Image = CType(resources.GetObject("btnEarbuds.Image"), Image)
        btnEarbuds.Location = New Point(2, 149)
        btnEarbuds.Name = "btnEarbuds"
        btnEarbuds.Size = New Size(194, 50)
        btnEarbuds.TabIndex = 4
        btnEarbuds.Text = "  Earbuds"
        btnEarbuds.TextAlign = ContentAlignment.MiddleRight
        btnEarbuds.TextImageRelation = TextImageRelation.ImageBeforeText
        btnEarbuds.UseVisualStyleBackColor = False
        ' 
        ' OnButtonEarbuds
        ' 
        OnButtonEarbuds.BackColor = Color.DimGray
        OnButtonEarbuds.BorderStyle = BorderStyle.FixedSingle
        OnButtonEarbuds.Location = New Point(0, 148)
        OnButtonEarbuds.Name = "OnButtonEarbuds"
        OnButtonEarbuds.Size = New Size(16, 53)
        OnButtonEarbuds.TabIndex = 3
        ' 
        ' btnPowerbanks
        ' 
        btnPowerbanks.BackColor = Color.Transparent
        btnPowerbanks.FlatAppearance.BorderSize = 0
        btnPowerbanks.FlatStyle = FlatStyle.Flat
        btnPowerbanks.Font = New Font("Arial", 12F)
        btnPowerbanks.Image = CType(resources.GetObject("btnPowerbanks.Image"), Image)
        btnPowerbanks.Location = New Point(3, 226)
        btnPowerbanks.Name = "btnPowerbanks"
        btnPowerbanks.Size = New Size(194, 50)
        btnPowerbanks.TabIndex = 6
        btnPowerbanks.Text = " Powerbanks"
        btnPowerbanks.TextAlign = ContentAlignment.MiddleRight
        btnPowerbanks.TextImageRelation = TextImageRelation.ImageBeforeText
        btnPowerbanks.UseVisualStyleBackColor = False
        ' 
        ' OnButtonPowerbanks
        ' 
        OnButtonPowerbanks.BackColor = Color.DimGray
        OnButtonPowerbanks.BorderStyle = BorderStyle.FixedSingle
        OnButtonPowerbanks.Location = New Point(0, 225)
        OnButtonPowerbanks.Name = "OnButtonPowerbanks"
        OnButtonPowerbanks.Size = New Size(16, 53)
        OnButtonPowerbanks.TabIndex = 5
        ' 
        ' btnMyCart
        ' 
        btnMyCart.BackColor = Color.Transparent
        btnMyCart.FlatAppearance.BorderSize = 0
        btnMyCart.FlatStyle = FlatStyle.Flat
        btnMyCart.Font = New Font("Arial", 12F)
        btnMyCart.Image = CType(resources.GetObject("btnMyCart.Image"), Image)
        btnMyCart.Location = New Point(3, 296)
        btnMyCart.Name = "btnMyCart"
        btnMyCart.Size = New Size(194, 50)
        btnMyCart.TabIndex = 8
        btnMyCart.TextAlign = ContentAlignment.MiddleRight
        btnMyCart.TextImageRelation = TextImageRelation.ImageBeforeText
        btnMyCart.UseVisualStyleBackColor = False
        ' 
        ' OnButtonMyCart
        ' 
        OnButtonMyCart.BackColor = Color.DimGray
        OnButtonMyCart.BorderStyle = BorderStyle.FixedSingle
        OnButtonMyCart.Location = New Point(0, 295)
        OnButtonMyCart.Name = "OnButtonMyCart"
        OnButtonMyCart.Size = New Size(16, 53)
        OnButtonMyCart.TabIndex = 7
        ' 
        ' BlackSideIcon
        ' 
        BlackSideIcon.BackColor = Color.Transparent
        BlackSideIcon.BackgroundImage = CType(resources.GetObject("BlackSideIcon.BackgroundImage"), Image)
        BlackSideIcon.BackgroundImageLayout = ImageLayout.Center
        BlackSideIcon.Location = New Point(-1, 1)
        BlackSideIcon.Name = "BlackSideIcon"
        BlackSideIcon.Size = New Size(39, 37)
        BlackSideIcon.TabIndex = 10
        ' 
        ' GraySideIcon
        ' 
        GraySideIcon.BackColor = Color.Transparent
        GraySideIcon.BackgroundImage = CType(resources.GetObject("GraySideIcon.BackgroundImage"), Image)
        GraySideIcon.BackgroundImageLayout = ImageLayout.Center
        GraySideIcon.Location = New Point(31, 0)
        GraySideIcon.Name = "GraySideIcon"
        GraySideIcon.Size = New Size(39, 37)
        GraySideIcon.TabIndex = 11
        ' 
        ' nameSportify
        ' 
        nameSportify.AutoSize = True
        nameSportify.BackColor = Color.Transparent
        nameSportify.Font = New Font("Dubai Medium", 17.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        nameSportify.ForeColor = Color.DarkSlateGray
        nameSportify.Location = New Point(64, 1)
        nameSportify.Name = "nameSportify"
        nameSportify.Size = New Size(112, 40)
        nameSportify.TabIndex = 9
        nameSportify.Text = "SportiFy"
        ' 
        ' pnlLeftSide
        ' 
        pnlLeftSide.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        pnlLeftSide.BackColor = Color.DimGray
        pnlLeftSide.BackgroundImage = CType(resources.GetObject("pnlLeftSide.BackgroundImage"), Image)
        pnlLeftSide.BackgroundImageLayout = ImageLayout.Stretch
        pnlLeftSide.Controls.Add(nameSportify)
        pnlLeftSide.Controls.Add(GraySideIcon)
        pnlLeftSide.Controls.Add(BlackSideIcon)
        pnlLeftSide.Controls.Add(OnButtonMyCart)
        pnlLeftSide.Controls.Add(btnMyCart)
        pnlLeftSide.Controls.Add(OnButtonPowerbanks)
        pnlLeftSide.Controls.Add(btnPowerbanks)
        pnlLeftSide.Controls.Add(OnButtonEarbuds)
        pnlLeftSide.Controls.Add(btnEarbuds)
        pnlLeftSide.Controls.Add(OnButtonHeadphones)
        pnlLeftSide.Controls.Add(btnHeadphones)
        pnlLeftSide.Location = New Point(0, 0)
        pnlLeftSide.Name = "pnlLeftSide"
        pnlLeftSide.Size = New Size(200, 541)
        pnlLeftSide.TabIndex = 0
        ' 
        ' main_form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(897, 541)
        Controls.Add(pnlMyCart)
        Controls.Add(pnlPowerbanks)
        Controls.Add(pnlEarbuds)
        Controls.Add(pnlHeadphones)
        Controls.Add(pnlTopSide)
        Controls.Add(pnlLeftSide)
        FormBorderStyle = FormBorderStyle.None
        Name = "main_form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main"
        pnlTopSide.ResumeLayout(False)
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        pnlHeadphones.ResumeLayout(False)
        pnlWht.ResumeLayout(False)
        pnlWht.PerformLayout()
        pnlMono.ResumeLayout(False)
        pnlMono.PerformLayout()
        pnlGry.ResumeLayout(False)
        pnlGry.PerformLayout()
        pnlBlck.ResumeLayout(False)
        pnlBlck.PerformLayout()
        pnlEarbuds.ResumeLayout(False)
        pnlSkura.ResumeLayout(False)
        pnlSkura.PerformLayout()
        pnlDark.ResumeLayout(False)
        pnlDark.PerformLayout()
        pnlBlu.ResumeLayout(False)
        pnlBlu.PerformLayout()
        pnlTs.ResumeLayout(False)
        pnlTs.PerformLayout()
        pnlPowerbanks.ResumeLayout(False)
        pnlDuo.ResumeLayout(False)
        pnlDuo.PerformLayout()
        pnlBlw.ResumeLayout(False)
        pnlBlw.PerformLayout()
        pnlRyker.ResumeLayout(False)
        pnlRyker.PerformLayout()
        pnlTnk.ResumeLayout(False)
        pnlTnk.PerformLayout()
        pnlMyCart.ResumeLayout(False)
        pnlMyCart.PerformLayout()
        pnlLeftSide.ResumeLayout(False)
        pnlLeftSide.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlTopSide As Panel
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents pnlHeadphones As Panel
    Friend WithEvents pnlBlck As Panel
    Friend WithEvents JBLBLCK As Label
    Friend WithEvents buttHeadphones1 As Button
    Friend WithEvents pnlMono As Panel
    Friend WithEvents JBLMONO As Label
    Friend WithEvents buttHeadphones3 As Button
    Friend WithEvents pnlGry As Panel
    Friend WithEvents JBLGRY As Label
    Friend WithEvents buttHeadphones2 As Button
    Friend WithEvents pnlWht As Panel
    Friend WithEvents JBLWHT As Label
    Friend WithEvents buttHeadphones4 As Button
    Friend WithEvents pnlEarbuds As Panel
    Friend WithEvents pnlSkura As Panel
    Friend WithEvents JBLSKRA As Label
    Friend WithEvents buttEarbuds4 As Button
    Friend WithEvents pnlDark As Panel
    Friend WithEvents JBLDRK As Label
    Friend WithEvents buttEarbuds3 As Button
    Friend WithEvents pnlBlu As Panel
    Friend WithEvents JBLBLU As Label
    Friend WithEvents buttEarbuds2 As Button
    Friend WithEvents pnlTs As Panel
    Friend WithEvents JBLTS As Label
    Friend WithEvents buttEarbuds1 As Button
    Friend WithEvents pnlPowerbanks As Panel
    Friend WithEvents pnlDuo As Panel
    Friend WithEvents JBLDUO As Label
    Friend WithEvents buttPowerbanks4 As Button
    Friend WithEvents pnlBlw As Panel
    Friend WithEvents JBLBLW As Label
    Friend WithEvents buttPowerbanks3 As Button
    Friend WithEvents pnlRyker As Panel
    Friend WithEvents JBLRYKER As Label
    Friend WithEvents buttPowerbanks2 As Button
    Friend WithEvents pnlTnk As Panel
    Friend WithEvents JBLTNK As Label
    Friend WithEvents buttPowerbanks1 As Button
    Friend WithEvents pnlMyCart As Panel
    Friend WithEvents lblCartDisplay As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnClearCart As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnHeadphones As Button
    Friend WithEvents OnButtonHeadphones As Panel
    Friend WithEvents btnEarbuds As Button
    Friend WithEvents OnButtonEarbuds As Panel
    Friend WithEvents btnPowerbanks As Button
    Friend WithEvents OnButtonPowerbanks As Panel
    Friend WithEvents btnMyCart As Button
    Friend WithEvents OnButtonMyCart As Panel
    Friend WithEvents BlackSideIcon As Panel
    Friend WithEvents GraySideIcon As Panel
    Friend WithEvents nameSportify As Label
    Friend WithEvents pnlLeftSide As Panel
    Friend WithEvents Button1 As Button

End Class
