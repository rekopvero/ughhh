Imports System.Data.OleDb



Public Class main_form


    Public currentUserEmail As String

    Public loggedInUserEmail As String

    Public Class Product
        Public Property ID As String
        Public Property Name As String
        Public Property Price As Decimal
        Public Property Category As String
        Public Property Description As String
        Public Property ImagePath As String
        Public Property StockQuantity As Integer

        Public Sub New(id As String, name As String, price As Decimal, category As String,
                      Optional description As String = "", Optional imagePath As String = "",
                      Optional stockQuantity As Integer = 10)
            Me.ID = id
            Me.Name = name
            Me.Price = price
            Me.Category = category
            Me.Description = description
            Me.ImagePath = imagePath
            Me.StockQuantity = stockQuantity
        End Sub

        Public Function GetDisplayText() As String
            Return $"{Name} - ${Price:F2}"
        End Function
    End Class


    Public Class CartItem
        Public Property Product As Product
        Public Property Quantity As Integer
        Public Property ColorVariant As String
        Public Property ProductName As String
        Public Property Price As Decimal

        Public Sub New(product As Product, quantity As Integer, Optional colorVariant As String = "")
            Me.Product = product
            Me.Quantity = quantity
            Me.ColorVariant = colorVariant
        End Sub

        Public Function GetSubtotal() As Decimal
            Return Product.Price * Quantity
        End Function

        Public Function GetDisplayText() As String
            Dim colorText As String = If(String.IsNullOrEmpty(ColorVariant), "", $" ({ColorVariant})")
            Return $"{Product.Name}{colorText} | Qty: {Quantity} | ${GetSubtotal():F2}"
        End Function
    End Class


    Private cart As New List(Of CartItem)
    Private products As New Dictionary(Of String, Product)
    Private selectedColor As String = ""


    Private Sub InitializeProducts()

        products.Add("HEADPHONE_1", New Product("HP1", "JBL Wireless Headphones", 89.99D, "Headphones", "Premium wireless headphones with noise cancellation", "jbl_headphones.jpg"))
        products.Add("HEADPHONE_2", New Product("HP2", "GRY Headphones", 299.99D, "Headphones", "Industry-leading noise canceling", "gry_headphones.jpg"))
        products.Add("HEADPHONE_3", New Product("HP3", "MONO Headphones", 199.99D, "Headphones", "High-performance wireless headphones", "mono_headphones.jpg"))
        products.Add("HEADPHONE_4", New Product("HP4", "WHT Headphones", 149.99D, "Headphones", "Professional studio monitor headphones", "wht_headphones.jpg"))


        products.Add("POWERBANK_1", New Product("PB1", "TNK Power Bank", 29.99D, "Powerbanks", "Ultra-compact 10000mAh portable charger", "tank_powerbank.png"))
        products.Add("POWERBANK_2", New Product("PB2", "RYKER Power Bank", 39.99D, "Powerbanks", "High-capacity fast charging power bank", "ryker_powerbank.png"))
        products.Add("POWERBANK_3", New Product("PB3", "BLW Power Bank", 49.99D, "Powerbanks", "Power Delivery fast charging", "blw_powerbank.png"))
        products.Add("POWERBANK_4", New Product("PB4", "DUO Power Bank", 24.99D, "Powerbanks", "20000mAh high capacity power bank", "duo_powerbank.png"))


        products.Add("EARBUD_1", New Product("EB1", "TS Earbuds", 249.99D, "Earbuds", "Active noise cancellation earbuds", "ts_earbuds.png"))
        products.Add("EARBUD_2", New Product("EB2", "BLU Earbuds", 149.99D, "Earbuds", "True wireless earbuds with ANC", "blu_earbuds.png"))
        products.Add("EARBUD_3", New Product("EB3", "DRK Earbuds", 179.99D, "Earbuds", "Advanced noise cancelling earbuds", "drk_earbuds.png"))
        products.Add("EARBUD_4", New Product("EB4", "SKRA Earbuds", 279.99D, "Earbuds", "Industry-leading noise canceling truly wireless", "sakura_earbuds.png"))
    End Sub


    Private Sub ShowPanel(panelToShow As Panel)

        pnlHeadphones.Visible = False
        pnlPowerbanks.Visible = False
        pnlEarbuds.Visible = False
        pnlMyCart.Visible = False


        panelToShow.Visible = True


        ResetButtonStyles()


        If panelToShow Is pnlHeadphones Then
            btnHeadphones.BackColor = Color.Gray
        ElseIf panelToShow Is pnlPowerbanks Then
            btnPowerbanks.BackColor = Color.Gray
        ElseIf panelToShow Is pnlEarbuds Then
            btnEarbuds.BackColor = Color.Gray
        ElseIf panelToShow Is pnlMyCart Then
            btnMyCart.BackColor = Color.Gray
            RefreshCartDisplay()
        End If
    End Sub


    Private Sub ResetButtonStyles()
        btnHeadphones.BackColor = Color.Transparent
        btnPowerbanks.BackColor = Color.Transparent
        btnEarbuds.BackColor = Color.Transparent
        btnMyCart.BackColor = Color.Transparent
    End Sub


    Private Sub main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeProducts()
        ShowPanel(pnlHeadphones)
        UpdateCartCounter()


        ConnectAllProductButtons()
    End Sub


    Private Sub ConnectAllProductButtons()

        ConnectSpecificButtons("buttHeadphones", "HEADPHONE_", 4)


        ConnectSpecificButtons("buttPowerbanks", "POWERBANK_", 4)


        ConnectSpecificButtons("buttEarbuds", "EARBUD_", 4)
    End Sub


    Private Sub ConnectSpecificButtons(buttonNamePrefix As String, productKeyPrefix As String, buttonCount As Integer)
        For i As Integer = 1 To buttonCount
            Dim buttonName As String = buttonNamePrefix & i.ToString()
            Dim productKey As String = productKeyPrefix & i.ToString()


            Dim foundButton As Button = FindButtonByName(Me, buttonName)

            If foundButton IsNot Nothing Then

                RemoveHandler foundButton.Click, AddressOf ProductButton_Click


                AddHandler foundButton.Click, AddressOf ProductButton_Click


                foundButton.Tag = productKey

                Console.WriteLine($"Connected button: {buttonName} to product: {productKey}")
            Else
                Console.WriteLine($"Button not found: {buttonName}")
            End If
        Next
    End Sub


    Private Function FindButtonByName(parent As Control, buttonName As String) As Button
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is Button AndAlso ctrl.Name = buttonName Then
                Return DirectCast(ctrl, Button)
            ElseIf ctrl.HasChildren Then
                Dim found As Button = FindButtonByName(ctrl, buttonName)
                If found IsNot Nothing Then Return found
            End If
        Next
        Return Nothing
    End Function


    Private Sub ProductButton_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim productKey As String = btn.Tag?.ToString()

        Console.WriteLine($"Button clicked: {btn.Name}, Product Key: {productKey}")

        If Not String.IsNullOrEmpty(productKey) AndAlso products.ContainsKey(productKey) Then
            AddProductToCart(productKey)
        Else
            MessageBox.Show($"Product not found for button: {btn.Name}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Add product to cart
    Private Sub AddProductToCart(productKey As String)
        If Not products.ContainsKey(productKey) Then Return

        Dim product As Product = products(productKey)

        ' Check if item already exists in cart 
        Dim existingItem As CartItem = cart.FirstOrDefault(Function(item) item.Product.ID = product.ID AndAlso item.ColorVariant = selectedColor)

        If existingItem IsNot Nothing Then
            ' Increase quantity of existing item
            existingItem.Quantity += 1
        Else
            ' Add new item to cart
            cart.Add(New CartItem(product, 1, selectedColor))
        End If

        ' Show success message
        Dim colorText As String = If(String.IsNullOrEmpty(selectedColor), "", $" ({selectedColor})")
        MessageBox.Show($"✓ Added {product.Name}{colorText} to cart!",
                       "Product Added", MessageBoxButtons.OK, MessageBoxIcon.Information)


        UpdateCartCounter()
        ResetColorSelection()


        Dim result As DialogResult = MessageBox.Show("View cart now?", "Go to Cart?",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ShowPanel(pnlMyCart)
        End If
    End Sub


    Private Sub UpdateCartCounter()
        Dim totalItems As Integer = 0
        For Each item As CartItem In cart
            totalItems += item.Quantity
        Next
        btnMyCart.Text = $"My Cart ({totalItems})"
    End Sub


    Private Sub RefreshCartDisplay()
        ' Clear existing cart display
        ClearCartImageDisplay()

        If cart.Count = 0 Then
            ' Show empty message if no products were chosen, yet.
            Dim cartItemsPanel As Panel = GetOrCreateCartItemsPanel()
            Dim lblEmpty As New Label With {
            .Text = "Your cart is empty vroo! Add some products. make us rich..",
            .Location = New Point(170, 90),
            .Size = New Size(350, 40),
            .TextAlign = ContentAlignment.MiddleCenter,
            .ForeColor = Color.Gray
        }
            cartItemsPanel.Controls.Add(lblEmpty)
        Else

            CreateCartImageDisplay()
        End If


        UpdateCartTotal()
    End Sub


    Private Sub CreateCartImageDisplay()
        If pnlMyCart Is Nothing Then Return


        Dim cartItemsPanel As Panel = GetOrCreateCartItemsPanel()


        ClearCartImageDisplay()


        Dim yOffset As Integer = 10
        For i As Integer = 0 To cart.Count - 1
            Dim cartItem As CartItem = cart(i)
            Dim itemPanel As Panel = CreateCartItemPanel(cartItem, i, yOffset)
            cartItemsPanel.Controls.Add(itemPanel)
            yOffset += 120
        Next


        cartItemsPanel.AutoScrollMinSize = New Size(0, yOffset + 20)
    End Sub


    Private Function GetOrCreateCartItemsPanel() As Panel

        For Each ctrl As Control In pnlMyCart.Controls
            If TypeOf ctrl Is Panel AndAlso ctrl.Name = "pnlCartItems" Then
                Return DirectCast(ctrl, Panel)
            End If
        Next


        Dim cartItemsPanel As New Panel With {
            .Name = "pnlCartItems",
            .Location = New Point(10, 50),
            .Size = New Size(pnlMyCart.Width - 20, pnlMyCart.Height - 150),
            .AutoScroll = True,
            .BorderStyle = BorderStyle.FixedSingle
        }
        pnlMyCart.Controls.Add(cartItemsPanel)
        Return cartItemsPanel
    End Function


    Private Function CreateCartItemPanel(cartItem As CartItem, index As Integer, yPos As Integer) As Panel
        Dim itemPanel As New Panel With {
            .Size = New Size(400, 100),
            .Location = New Point(10, yPos),
            .BorderStyle = BorderStyle.FixedSingle,
            .BackColor = Color.White
        }


        Dim imgProduct As New PictureBox With {
            .Size = New Size(80, 80),
            .Location = New Point(10, 10),
            .SizeMode = PictureBoxSizeMode.StretchImage,
            .BorderStyle = BorderStyle.FixedSingle,
            .Cursor = Cursors.Hand
        }


        Try

            Dim imagePath As String = Application.StartupPath & "\Images\" & cartItem.Product.ImagePath
            If System.IO.File.Exists(imagePath) Then
                imgProduct.Image = Image.FromFile(imagePath)
            Else
                imgProduct.BackColor = Color.LightGray
            End If
        Catch
            imgProduct.BackColor = Color.LightGray
        End Try

        ' Make image clickable
        imgProduct.Tag = index
        AddHandler imgProduct.Click, AddressOf CartImage_Click

        ' Product details
        Dim lblName As New Label With {
            .Text = cartItem.Product.Name,
            .Location = New Point(100, 10),
            .Size = New Size(200, 20),
            .Font = New Font("Arial", 10, FontStyle.Bold)
        }

        Dim lblPrice As New Label With {
            .Text = $"${cartItem.Product.Price:F2}",
            .Location = New Point(100, 35),
            .Size = New Size(100, 20),
            .Font = New Font("Arial", 9)
        }

        Dim lblQuantity As New Label With {
            .Text = $"Qty: {cartItem.Quantity}",
            .Location = New Point(100, 60),
            .Size = New Size(100, 20),
            .Font = New Font("Arial", 9)
        }

        Dim lblSubtotal As New Label With {
            .Text = $"Subtotal: ${cartItem.GetSubtotal():F2}",
            .Location = New Point(200, 45),
            .Size = New Size(120, 20),
            .Font = New Font("Arial", 9, FontStyle.Bold),
            .ForeColor = Color.DarkGreen
        }

        ' Remove button
        Dim btnRemove As New Button With {
            .Text = "Remove",
            .Location = New Point(330, 40),
            .Size = New Size(60, 25),
            .BackColor = Color.LightCoral,
            .ForeColor = Color.White,
            .Tag = index
        }
        AddHandler btnRemove.Click, AddressOf RemoveCartItem_Click


        itemPanel.Controls.AddRange({imgProduct, lblName, lblPrice, lblQuantity, lblSubtotal, btnRemove})

        Return itemPanel
    End Function


    Private Sub CartImage_Click(sender As Object, e As EventArgs)
        Dim img As PictureBox = DirectCast(sender, PictureBox)
        Dim index As Integer = CInt(img.Tag)

        If index >= 0 AndAlso index < cart.Count Then
            Dim cartItem As CartItem = cart(index)
            MessageBox.Show($"Product: {cartItem.Product.Name}" & Environment.NewLine &
                           $"Price: ${cartItem.Product.Price:F2}" & Environment.NewLine &
                           $"Description: {cartItem.Product.Description}",
                           "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub RemoveCartItem_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim index As Integer = CInt(btn.Tag)

        If index >= 0 AndAlso index < cart.Count Then
            Dim cartItem As CartItem = cart(index)
            Dim result As DialogResult = MessageBox.Show($"Remove {cartItem.Product.Name} from cart?",
                                                        "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                cart.RemoveAt(index)
                RefreshCartDisplay()
                UpdateCartCounter()
            End If
        End If
    End Sub


    Private Sub ClearCartImageDisplay()
        Dim cartItemsPanel As Panel = Nothing
        For Each ctrl As Control In pnlMyCart.Controls
            If TypeOf ctrl Is Panel AndAlso ctrl.Name = "pnlCartItems" Then
                cartItemsPanel = DirectCast(ctrl, Panel)
                Exit For
            End If
        Next

        If cartItemsPanel IsNot Nothing Then
            cartItemsPanel.Controls.Clear()
        End If
    End Sub


    Private Sub UpdateCartTotal()
        If lblTotal IsNot Nothing Then
            Dim total As Decimal = 0
            For Each item As CartItem In cart
                total += item.GetSubtotal()
            Next
            lblTotal.Text = $"Total: ${total:F2}"
            lblTotal.Font = New Font(lblTotal.Font, FontStyle.Bold)
        End If
    End Sub


    Private Sub btnHeadphones_Click(sender As Object, e As EventArgs) Handles btnHeadphones.Click
        ShowPanel(pnlHeadphones)
    End Sub

    Private Sub btnPowerbanks_Click(sender As Object, e As EventArgs) Handles btnPowerbanks.Click
        ShowPanel(pnlPowerbanks)
    End Sub

    Private Sub btnEarbuds_Click(sender As Object, e As EventArgs) Handles btnEarbuds.Click
        ShowPanel(pnlEarbuds)
    End Sub

    Private Sub btnMyCart_Click(sender As Object, e As EventArgs) Handles btnMyCart.Click
        ShowPanel(pnlMyCart)
    End Sub


    Private Sub JBLBLCK_Click(sender As Object, e As EventArgs) Handles JBLBLCK.Click
        SelectColor("Black")
    End Sub

    Private Sub JBLGRY_Click(sender As Object, e As EventArgs) Handles JBLGRY.Click
        SelectColor("Gray")
    End Sub

    Private Sub JBLWHT_Click(sender As Object, e As EventArgs) Handles JBLWHT.Click
        SelectColor("White")
    End Sub

    Private Sub SelectColor(color As String)
        selectedColor = color
        UpdateColorDisplay()
        MessageBox.Show($"Selected color: {color}", "Color Selected",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub UpdateColorDisplay()

        ResetColorSelection()

        ' Highlight selected color
        Select Case selectedColor
            Case "Black"
                If pnlBlck IsNot Nothing Then pnlBlck.BorderStyle = BorderStyle.Fixed3D
            Case "Gray"
                If pnlGry IsNot Nothing Then pnlGry.BorderStyle = BorderStyle.Fixed3D
            Case "White"

        End Select
    End Sub


    Private Sub ResetColorSelection()
        selectedColor = ""
        If pnlBlck IsNot Nothing Then pnlBlck.BorderStyle = BorderStyle.None
        If pnlGry IsNot Nothing Then pnlGry.BorderStyle = BorderStyle.None
    End Sub




    Private Sub btnClearCart_Click(sender As Object, e As EventArgs) Handles btnClearCart.Click
        If cart.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Clear entire cart?", "Clear Cart",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                cart.Clear()
                RefreshCartDisplay()
                UpdateCartCounter()
                MessageBox.Show("Cart cleared!", "Cart Empty", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        If cart.Count = 0 Then
            MessageBox.Show("Your cart is empty! Add some products first.", "Empty Cart",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim total As Decimal = 0
        Dim itemCount As Integer = 0
        For Each item As CartItem In cart
            total += item.GetSubtotal()
            itemCount += item.Quantity
        Next

        Dim message As String = $"Checkout Summary:{Environment.NewLine}" &
                            $"Items: {itemCount}{Environment.NewLine}" &
                            $"Total: ${total:F2}{Environment.NewLine}{Environment.NewLine}" &
                            $"Proceed with checkout?"

        Dim result As DialogResult = MessageBox.Show(message, "Checkout Confirmation",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=system.accdb")
                conn.Open()

                For Each item As CartItem In cart
                    Dim productName As String = item.Product.Name
                    Dim quantity As Integer = Convert.ToInt32(item.Quantity)
                    Dim price As Decimal = Convert.ToDecimal(item.Product.Price)
                    Dim totalPrice As Decimal = quantity * price
                    Dim orderDate As Date = Date.Now




                    Dim cmd As New OleDbCommand("INSERT INTO orders (user_email, product_name, quantity, price, total_price, order_date) VALUES (?, ?, ?, ?, ?, ?)", conn)

                    cmd.Parameters.Add("user_email", OleDbType.VarChar).Value = currentUserEmail
                    cmd.Parameters.Add("product_name", OleDbType.VarChar).Value = productName
                    cmd.Parameters.Add("quantity", OleDbType.Integer).Value = quantity
                    cmd.Parameters.Add("price", OleDbType.Currency).Value = price
                    cmd.Parameters.Add("total_price", OleDbType.Currency).Value = totalPrice
                    cmd.Parameters.Add("order_date", OleDbType.Date).Value = orderDate

                    cmd.ExecuteNonQuery()
                Next

                conn.Close()

                cart.Clear()
                RefreshCartDisplay()
                UpdateCartCounter()

                MessageBox.Show("🎉 Order placed successfully!" & Environment.NewLine &
                            "Thank you for your purchase!", "Order Confirmed",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("An error occurred while placing the order: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub





    Private Sub pnlBlck_Paint(sender As Object, e As PaintEventArgs) Handles pnlBlck.Paint

    End Sub

    Private Sub pnlGry_Paint(sender As Object, e As PaintEventArgs) Handles pnlGry.Paint

    End Sub

    Private Sub pnlHeadphones_Paint(sender As Object, e As PaintEventArgs) Handles pnlHeadphones.Paint

    End Sub

    Private Sub lblCartDisplay_Click(sender As Object, e As EventArgs) Handles lblCartDisplay.Click
        ShowPanel(pnlMyCart)
    End Sub

    Private Sub nameSportify_Click(sender As Object, e As EventArgs) Handles nameSportify.Click



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub
End Class