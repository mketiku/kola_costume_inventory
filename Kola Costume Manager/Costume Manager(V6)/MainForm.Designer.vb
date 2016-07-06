<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxBarcodeID = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCostumeDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbCostumeType = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cbxColor = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxPattern = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gbxCostumeItem = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbxSubType = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.cbxUse = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbxLocation = New System.Windows.Forms.ComboBox()
        Me.cbxEra = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbxGeneralSize = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxSource = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ComboBox10 = New System.Windows.Forms.ComboBox()
        Me.cbxGender = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbxCondition = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbxHeel = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxSleeveStrap = New System.Windows.Forms.ComboBox()
        Me.cbxFiber = New System.Windows.Forms.ComboBox()
        Me.cbxWeight = New System.Windows.Forms.ComboBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxShape = New System.Windows.Forms.ComboBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.cbxLength = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.cbxBrim = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cbxHip = New System.Windows.Forms.ComboBox()
        Me.cbxWaist = New System.Windows.Forms.ComboBox()
        Me.cbxChest = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.cbxShoeSize = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbxMaterials = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.cbxFabric = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Characteristics = New System.Windows.Forms.GroupBox()
        Me.gbxCostumeItem.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Characteristics.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Barcode:"
        '
        'cbxBarcodeID
        '
        Me.cbxBarcodeID.FormattingEnabled = True
        Me.cbxBarcodeID.Items.AddRange(New Object() {"0022320", "0202020", "0302003", "7747828"})
        Me.cbxBarcodeID.Location = New System.Drawing.Point(75, 20)
        Me.cbxBarcodeID.Name = "cbxBarcodeID"
        Me.cbxBarcodeID.Size = New System.Drawing.Size(128, 21)
        Me.cbxBarcodeID.Sorted = True
        Me.cbxBarcodeID.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(217, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Description:"
        '
        'txtCostumeDescription
        '
        Me.txtCostumeDescription.Location = New System.Drawing.Point(286, 73)
        Me.txtCostumeDescription.Multiline = True
        Me.txtCostumeDescription.Name = "txtCostumeDescription"
        Me.txtCostumeDescription.Size = New System.Drawing.Size(128, 103)
        Me.txtCostumeDescription.TabIndex = 5
        Me.txtCostumeDescription.Text = " "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Type:"
        '
        'cmbCostumeType
        '
        Me.cmbCostumeType.FormattingEnabled = True
        Me.cmbCostumeType.Items.AddRange(New Object() {"Belts", "Blouses", "Cape", "Cardigan", "Cloak", "Crewneck", "Dresses", "Gloves", "Handbags", "Hat", "Hoodie", "Jackets and Blazers", "Jumpsuit", "Outerwear", "Pants", "Pullover", "Scarves and Shawls", "Shirt", "Shorts", "Skirts", "Suit", "Vest"})
        Me.cmbCostumeType.Location = New System.Drawing.Point(77, 73)
        Me.cmbCostumeType.Name = "cmbCostumeType"
        Me.cmbCostumeType.Size = New System.Drawing.Size(128, 21)
        Me.cmbCostumeType.Sorted = True
        Me.cmbCostumeType.TabIndex = 7
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(145, 19)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(78, 23)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cbxColor
        '
        Me.cbxColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxColor.FormattingEnabled = True
        Me.cbxColor.Items.AddRange(New Object() {"Black", "Blue", "Brown/Tan", "Cool", "Green", "Multi", "Neutral ", "Orange", "Pink", "Purple", "Red", "Warm", "White", "Yellow"})
        Me.cbxColor.Location = New System.Drawing.Point(75, 17)
        Me.cbxColor.Name = "cbxColor"
        Me.cbxColor.Size = New System.Drawing.Size(128, 21)
        Me.cbxColor.Sorted = True
        Me.cbxColor.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Color:"
        '
        'cbxPattern
        '
        Me.cbxPattern.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxPattern.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxPattern.FormattingEnabled = True
        Me.cbxPattern.Items.AddRange(New Object() {"Floral", "Geometric", "Plaid", "Stripes", "Dots", "Paisley", "Asymmetric ", "Distressed", "N/A"})
        Me.cbxPattern.Location = New System.Drawing.Point(283, 17)
        Me.cbxPattern.Name = "cbxPattern"
        Me.cbxPattern.Size = New System.Drawing.Size(128, 21)
        Me.cbxPattern.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(230, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = " Pattern:"
        '
        'gbxCostumeItem
        '
        Me.gbxCostumeItem.Controls.Add(Me.PictureBox1)
        Me.gbxCostumeItem.Controls.Add(Me.cbxSubType)
        Me.gbxCostumeItem.Controls.Add(Me.Label41)
        Me.gbxCostumeItem.Controls.Add(Me.cbxUse)
        Me.gbxCostumeItem.Controls.Add(Me.Label38)
        Me.gbxCostumeItem.Controls.Add(Me.Label22)
        Me.gbxCostumeItem.Controls.Add(Me.cbxLocation)
        Me.gbxCostumeItem.Controls.Add(Me.cbxEra)
        Me.gbxCostumeItem.Controls.Add(Me.Label10)
        Me.gbxCostumeItem.Controls.Add(Me.txtCostumeDescription)
        Me.gbxCostumeItem.Controls.Add(Me.Label3)
        Me.gbxCostumeItem.Controls.Add(Me.Label1)
        Me.gbxCostumeItem.Controls.Add(Me.cbxBarcodeID)
        Me.gbxCostumeItem.Controls.Add(Me.Label4)
        Me.gbxCostumeItem.Controls.Add(Me.cmbCostumeType)
        Me.gbxCostumeItem.Location = New System.Drawing.Point(9, 67)
        Me.gbxCostumeItem.Name = "gbxCostumeItem"
        Me.gbxCostumeItem.Size = New System.Drawing.Size(644, 182)
        Me.gbxCostumeItem.TabIndex = 20
        Me.gbxCostumeItem.TabStop = False
        Me.gbxCostumeItem.Text = "Costume Item: (Clothing and Accessories)"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.ImageLocation = "https://goo.gl/6qnox8"
        Me.PictureBox1.Location = New System.Drawing.Point(468, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'cbxSubType
        '
        Me.cbxSubType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbxSubType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxSubType.FormattingEnabled = True
        Me.cbxSubType.Items.AddRange(New Object() {"", " Beret", " Homburg", "Academic Hats", "Athletic", "Athletic Sandal", "Backpack", "Balaclava Hat", "Ballet Slipper", "Baseball Hat", "Bedroom Slipper", "Biretta Hat", "Boat Shoes", "Boaters Hat", "Bowlers Hat", "Bucket Hats", "Button Front", "Cadet Caps", "Character Shoe", "Chukkas Boot", "Clippy Hats", "Clutch", "Coifs", "Combat Boot", "Cowboy Boot", "Cross Body", "Dance Shoe", "Derby", "Driving Caps/Newsboys", "Drover Hat", "Espadrille", "Ethnic Hats", "Fantasy Hats", "Fedoras", "Fez", "Flip Flop", "Gladiator Sandal", "Greek Fisherman Hats", "Heeled Boot", "Hood", "Jazz Shoe", "Jeans", "Knit Hats", "Loafer", "Mary Jane", "Messenger", "Military", "Monkstrap", "Mortarboard Hat", "Mule", "Not Collared", "Occupational Hat", "Open Front", "Other", "Oxfords", "Peep Toe", "Platform", "Pointe Shoe", "Pork Pie Hat", "Pullover", "Pump", "Religious Hats", "Ring Hats", "Saltwater Sandal", "Slingback", "Slip-ons Sneaker", "Sneakers/Athletic", "T-Strap", "Top hat", "Toques/Beanies", "Tote", "Tricorn/Bicorn", "Trilby", "Trucker Hat", "Turban", "Turtleneck", "Velcro Sneaker", "Walking Hat", "Wedding Veil", "Wellington Boot", "Wingtip", "Woven  Collared Wing Tip", "Woven Collared Button Down", "Woven Collared Mandarin", "Zip Front"})
        Me.cbxSubType.Location = New System.Drawing.Point(286, 19)
        Me.cbxSubType.Name = "cbxSubType"
        Me.cbxSubType.Size = New System.Drawing.Size(128, 21)
        Me.cbxSubType.Sorted = True
        Me.cbxSubType.TabIndex = 52
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(224, 22)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(56, 13)
        Me.Label41.TabIndex = 51
        Me.Label41.Text = "Sub Type:"
        '
        'cbxUse
        '
        Me.cbxUse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxUse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxUse.FormattingEnabled = True
        Me.cbxUse.Items.AddRange(New Object() {"Athletic", "Casual", "Everyday", "Fashion", "Formal ", "Occupational", "Utility", "Winter"})
        Me.cbxUse.Location = New System.Drawing.Point(77, 99)
        Me.cbxUse.Name = "cbxUse"
        Me.cbxUse.Size = New System.Drawing.Size(128, 21)
        Me.cbxUse.Sorted = True
        Me.cbxUse.TabIndex = 50
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(43, 103)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(29, 13)
        Me.Label38.TabIndex = 49
        Me.Label38.Text = "Use:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(226, 49)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(54, 13)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = " Location:"
        '
        'cbxLocation
        '
        Me.cbxLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxLocation.FormattingEnabled = True
        Me.cbxLocation.Items.AddRange(New Object() {"Storage"})
        Me.cbxLocation.Location = New System.Drawing.Point(286, 46)
        Me.cbxLocation.Name = "cbxLocation"
        Me.cbxLocation.Size = New System.Drawing.Size(128, 21)
        Me.cbxLocation.TabIndex = 48
        '
        'cbxEra
        '
        Me.cbxEra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxEra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxEra.FormattingEnabled = True
        Me.cbxEra.Items.AddRange(New Object() {"Fantasy", "Ancient (greeks/romans/celts)", " Medieval/Renaissance (1200-1500)", "Tudor/Elizabethan (1500-1600)", "Cavalier (1600-1700)", "Colonial (1700-1800)", " Regency/Empire (1800-1820)", "Civil War/ Early Victorian (1830-1860)", "High Victorian(1860-1890)", " 1900s", "1910s", "1920s", "1930s", "1940s", "1950s", "1960s", "1970s", " 1980s", "Contemporary", "Non-Western (Asian, Indian, Balinese, African, South American, European)", "N/A"})
        Me.cbxEra.Location = New System.Drawing.Point(76, 44)
        Me.cbxEra.Name = "cbxEra"
        Me.cbxEra.Size = New System.Drawing.Size(128, 21)
        Me.cbxEra.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(46, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Era:"
        '
        'cbxGeneralSize
        '
        Me.cbxGeneralSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxGeneralSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxGeneralSize.FormattingEnabled = True
        Me.cbxGeneralSize.Items.AddRange(New Object() {"S", "M", "L", "XL", "XXL"})
        Me.cbxGeneralSize.Location = New System.Drawing.Point(491, 20)
        Me.cbxGeneralSize.Name = "cbxGeneralSize"
        Me.cbxGeneralSize.Size = New System.Drawing.Size(128, 21)
        Me.cbxGeneralSize.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(415, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "General Size:"
        '
        'cbxSource
        '
        Me.cbxSource.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxSource.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxSource.FormattingEnabled = True
        Me.cbxSource.Location = New System.Drawing.Point(283, 69)
        Me.cbxSource.Name = "cbxSource"
        Me.cbxSource.Size = New System.Drawing.Size(128, 21)
        Me.cbxSource.TabIndex = 46
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(496, 69)
        Me.DateTimePicker1.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1855, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(128, 20)
        Me.DateTimePicker1.TabIndex = 41
        Me.DateTimePicker1.Value = New Date(2015, 12, 15, 13, 27, 11, 0)
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(431, 73)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 13)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = " Acquired:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(233, 73)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 13)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Source:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 13)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Designer:"
        '
        'ComboBox10
        '
        Me.ComboBox10.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox10.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox10.FormattingEnabled = True
        Me.ComboBox10.Location = New System.Drawing.Point(75, 70)
        Me.ComboBox10.Name = "ComboBox10"
        Me.ComboBox10.Size = New System.Drawing.Size(128, 21)
        Me.ComboBox10.TabIndex = 36
        '
        'cbxGender
        '
        Me.cbxGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxGender.FormattingEnabled = True
        Me.cbxGender.Items.AddRange(New Object() {"Male", "Female ", "Unisex"})
        Me.cbxGender.Location = New System.Drawing.Point(496, 17)
        Me.cbxGender.Name = "cbxGender"
        Me.cbxGender.Size = New System.Drawing.Size(128, 21)
        Me.cbxGender.TabIndex = 34
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(441, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Gender:"
        '
        'cbxCondition
        '
        Me.cbxCondition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxCondition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxCondition.FormattingEnabled = True
        Me.cbxCondition.Items.AddRange(New Object() {"New", "Used", "Needs Repair"})
        Me.cbxCondition.Location = New System.Drawing.Point(283, 42)
        Me.cbxCondition.Name = "cbxCondition"
        Me.cbxCondition.Size = New System.Drawing.Size(128, 21)
        Me.cbxCondition.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(223, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Condition:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbxHeel)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.cbxGeneralSize)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cbxSleeveStrap)
        Me.GroupBox3.Controls.Add(Me.cbxFiber)
        Me.GroupBox3.Controls.Add(Me.cbxWeight)
        Me.GroupBox3.Controls.Add(Me.Label43)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.cbxShape)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label40)
        Me.GroupBox3.Controls.Add(Me.cbxLength)
        Me.GroupBox3.Controls.Add(Me.Label39)
        Me.GroupBox3.Controls.Add(Me.cbxBrim)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.cbxHip)
        Me.GroupBox3.Controls.Add(Me.cbxWaist)
        Me.GroupBox3.Controls.Add(Me.cbxChest)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.cbxShoeSize)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 361)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(643, 142)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Measurements:"
        '
        'cbxHeel
        '
        Me.cbxHeel.FormattingEnabled = True
        Me.cbxHeel.Items.AddRange(New Object() {"0-1""", "2-3""", "4-5""", "5""+"})
        Me.cbxHeel.Location = New System.Drawing.Point(76, 101)
        Me.cbxHeel.Name = "cbxHeel"
        Me.cbxHeel.Size = New System.Drawing.Size(128, 21)
        Me.cbxHeel.TabIndex = 57
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Heel Height:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(206, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Sleeve/Strap:"
        '
        'cbxSleeveStrap
        '
        Me.cbxSleeveStrap.FormattingEnabled = True
        Me.cbxSleeveStrap.Items.AddRange(New Object() {"Halter Strap", "Strapless", "One Shoulder", "Long Sleeve", "Short Sleeve", "Polo Sleeve", "Short Cap Sleeve", "Short Flutter Sleeve", "Short Normal Sleeve", "Sleeveless"})
        Me.cbxSleeveStrap.Location = New System.Drawing.Point(282, 106)
        Me.cbxSleeveStrap.Name = "cbxSleeveStrap"
        Me.cbxSleeveStrap.Size = New System.Drawing.Size(128, 21)
        Me.cbxSleeveStrap.TabIndex = 53
        '
        'cbxFiber
        '
        Me.cbxFiber.FormattingEnabled = True
        Me.cbxFiber.Items.AddRange(New Object() {"Wooly", "Silky", "Cottony", "Polarfleece"})
        Me.cbxFiber.Location = New System.Drawing.Point(491, 106)
        Me.cbxFiber.Name = "cbxFiber"
        Me.cbxFiber.Size = New System.Drawing.Size(128, 21)
        Me.cbxFiber.TabIndex = 51
        '
        'cbxWeight
        '
        Me.cbxWeight.FormattingEnabled = True
        Me.cbxWeight.Items.AddRange(New Object() {"Lightweight", "Heavy Weight"})
        Me.cbxWeight.Location = New System.Drawing.Point(282, 79)
        Me.cbxWeight.Name = "cbxWeight"
        Me.cbxWeight.Size = New System.Drawing.Size(128, 21)
        Me.cbxWeight.TabIndex = 55
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(420, 106)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(60, 13)
        Me.Label43.TabIndex = 50
        Me.Label43.Text = "Fiber Type:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(238, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Weight:"
        '
        'cbxShape
        '
        Me.cbxShape.FormattingEnabled = True
        Me.cbxShape.Items.AddRange(New Object() {"Mermaid", "Ball Gown", "A-Line", "Wraparound", "Bodycon", "Bubble", "Pleated", "Pencil", "Tiered", "Yoked ", "Circle", "Asymmetric", "Paneled", "Godet", "Tulip", "Triangular", "Rectangular", "Square", "Oddball"})
        Me.cbxShape.Location = New System.Drawing.Point(282, 49)
        Me.cbxShape.Name = "cbxShape"
        Me.cbxShape.Size = New System.Drawing.Size(128, 21)
        Me.cbxShape.TabIndex = 47
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(241, 47)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(41, 13)
        Me.Label40.TabIndex = 46
        Me.Label40.Text = "Shape:"
        '
        'cbxLength
        '
        Me.cbxLength.FormattingEnabled = True
        Me.cbxLength.Items.AddRange(New Object() {"Tea Length", "Knee Length", "Waist Length", "Full Length", "Opera Length", "Elbow Length", "Wrist Length"})
        Me.cbxLength.Location = New System.Drawing.Point(282, 22)
        Me.cbxLength.Name = "cbxLength"
        Me.cbxLength.Size = New System.Drawing.Size(128, 21)
        Me.cbxLength.TabIndex = 45
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(239, 24)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(43, 13)
        Me.Label39.TabIndex = 44
        Me.Label39.Text = "Length:"
        '
        'cbxBrim
        '
        Me.cbxBrim.FormattingEnabled = True
        Me.cbxBrim.Items.AddRange(New Object() {"Brimless", "1-2""", "3-4""", "4+"""})
        Me.cbxBrim.Location = New System.Drawing.Point(491, 79)
        Me.cbxBrim.Name = "cbxBrim"
        Me.cbxBrim.Size = New System.Drawing.Size(128, 21)
        Me.cbxBrim.TabIndex = 32
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(447, 79)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(30, 13)
        Me.Label32.TabIndex = 9
        Me.Label32.Text = "Brim:"
        '
        'cbxHip
        '
        Me.cbxHip.FormattingEnabled = True
        Me.cbxHip.Items.AddRange(New Object() {"24-26""", "27-29""", "30-32""", "32-34""", "35-37""", "38-40""", "40-42""", "43-45""", "46-48""", "49-51""", "52-54""", "55-57""", "58-60""", "61-63""", "64""+", "N/A" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.cbxHip.Location = New System.Drawing.Point(74, 74)
        Me.cbxHip.Name = "cbxHip"
        Me.cbxHip.Size = New System.Drawing.Size(128, 21)
        Me.cbxHip.TabIndex = 35
        '
        'cbxWaist
        '
        Me.cbxWaist.FormattingEnabled = True
        Me.cbxWaist.Items.AddRange(New Object() {"24-26""", "27-29""", "30-32""", "32-34""", "35-37""", "38-40""", "40-42""", "43-45""", "46-48""", "49-51""", "52-54""", "55-57""", "58-60""", "61-63""", "64""+", "N/A"})
        Me.cbxWaist.Location = New System.Drawing.Point(74, 47)
        Me.cbxWaist.Name = "cbxWaist"
        Me.cbxWaist.Size = New System.Drawing.Size(128, 21)
        Me.cbxWaist.TabIndex = 34
        '
        'cbxChest
        '
        Me.cbxChest.FormattingEnabled = True
        Me.cbxChest.Items.AddRange(New Object() {"24-26""", "27-29""", "30-32""", "32-34""", "35-37""", "38-40""", "40-42""", "43-45""", "46-48""", "49-51""", "52-54""", "55-57""", "58-60""", "61-63""", "64""+", "N/A"})
        Me.cbxChest.Location = New System.Drawing.Point(75, 20)
        Me.cbxChest.Name = "cbxChest"
        Me.cbxChest.Size = New System.Drawing.Size(128, 21)
        Me.cbxChest.TabIndex = 30
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(427, 47)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(58, 13)
        Me.Label35.TabIndex = 12
        Me.Label35.Text = "Shoe Size:"
        '
        'cbxShoeSize
        '
        Me.cbxShoeSize.FormattingEnabled = True
        Me.cbxShoeSize.Items.AddRange(New Object() {"Men’s 6/6.5  ", "Men’s 7/7.5 ", "Men’s 8/8.5  ", "Men’s 9/9.5 ", "Men’s 10/10.5", "Men’s 11/11.5", "Men’s 12/12.5", "Men’s 13/13.5", "Men’s 14/14.5", "Men’s 15/15.5", "Women’s 5/5.5", "Women’s 6/6.5", "Women’s 7/7.5", "Women’s 8/8.5", "Women’s 9/9.5", "Women’s 10/10.5", "Women’s 11/11.5"})
        Me.cbxShoeSize.Location = New System.Drawing.Point(491, 46)
        Me.cbxShoeSize.Name = "cbxShoeSize"
        Me.cbxShoeSize.Size = New System.Drawing.Size(128, 21)
        Me.cbxShoeSize.TabIndex = 33
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(37, 79)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(31, 13)
        Me.Label26.TabIndex = 3
        Me.Label26.Text = "Hips:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(31, 49)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(37, 13)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Waist:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(31, 20)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(37, 13)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Chest:"
        '
        'cbxMaterials
        '
        Me.cbxMaterials.FormattingEnabled = True
        Me.cbxMaterials.Items.AddRange(New Object() {"Straw", "Leather", "Felt", "Fabric", "Fur", "Vinyl", "Flowers/Foliage", "Feathers", "Plastic", "Metal", "Gemstones (?)", "Webbing"})
        Me.cbxMaterials.Location = New System.Drawing.Point(76, 43)
        Me.cbxMaterials.Name = "cbxMaterials"
        Me.cbxMaterials.Size = New System.Drawing.Size(128, 21)
        Me.cbxMaterials.TabIndex = 49
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(21, 44)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(52, 13)
        Me.Label42.TabIndex = 48
        Me.Label42.Text = "Materials:"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(427, 19)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(78, 23)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(521, 19)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 23)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(51, 19)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(78, 23)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(239, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(78, 23)
        Me.btnSave.TabIndex = 27
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnPrint)
        Me.GroupBox4.Controls.Add(Me.btnExit)
        Me.GroupBox4.Controls.Add(Me.btnSave)
        Me.GroupBox4.Controls.Add(Me.btnSearch)
        Me.GroupBox4.Controls.Add(Me.btnAdd)
        Me.GroupBox4.Controls.Add(Me.btnClear)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 1)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(644, 60)
        Me.GroupBox4.TabIndex = 28
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tool Box"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(333, 19)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(78, 23)
        Me.btnPrint.TabIndex = 28
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'cbxFabric
        '
        Me.cbxFabric.FormattingEnabled = True
        Me.cbxFabric.Items.AddRange(New Object() {"Knit", "Woven"})
        Me.cbxFabric.Location = New System.Drawing.Point(496, 42)
        Me.cbxFabric.Name = "cbxFabric"
        Me.cbxFabric.Size = New System.Drawing.Size(128, 21)
        Me.cbxFabric.TabIndex = 57
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(447, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Fabric:"
        '
        'Characteristics
        '
        Me.Characteristics.Controls.Add(Me.cbxGender)
        Me.Characteristics.Controls.Add(Me.cbxFabric)
        Me.Characteristics.Controls.Add(Me.Label7)
        Me.Characteristics.Controls.Add(Me.Label9)
        Me.Characteristics.Controls.Add(Me.cbxColor)
        Me.Characteristics.Controls.Add(Me.Label8)
        Me.Characteristics.Controls.Add(Me.ComboBox10)
        Me.Characteristics.Controls.Add(Me.cbxPattern)
        Me.Characteristics.Controls.Add(Me.Label17)
        Me.Characteristics.Controls.Add(Me.cbxMaterials)
        Me.Characteristics.Controls.Add(Me.Label11)
        Me.Characteristics.Controls.Add(Me.cbxCondition)
        Me.Characteristics.Controls.Add(Me.Label42)
        Me.Characteristics.Controls.Add(Me.Label16)
        Me.Characteristics.Controls.Add(Me.cbxSource)
        Me.Characteristics.Controls.Add(Me.Label18)
        Me.Characteristics.Controls.Add(Me.DateTimePicker1)
        Me.Characteristics.Controls.Add(Me.Label19)
        Me.Characteristics.Location = New System.Drawing.Point(12, 255)
        Me.Characteristics.Name = "Characteristics"
        Me.Characteristics.Size = New System.Drawing.Size(644, 100)
        Me.Characteristics.TabIndex = 29
        Me.Characteristics.TabStop = False
        Me.Characteristics.Text = "Characteristics:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(665, 505)
        Me.Controls.Add(Me.Characteristics)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbxCostumeItem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmMain"
        Me.Text = "Costume Inventory Manager"
        Me.gbxCostumeItem.ResumeLayout(False)
        Me.gbxCostumeItem.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.Characteristics.ResumeLayout(False)
        Me.Characteristics.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxBarcodeID As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCostumeDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbCostumeType As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cbxColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbxPattern As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gbxCostumeItem As System.Windows.Forms.GroupBox
    Friend WithEvents cbxCondition As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbxEra As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbxGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbxLocation As System.Windows.Forms.ComboBox
    Friend WithEvents cbxSource As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ComboBox10 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cbxHip As System.Windows.Forms.ComboBox
    Friend WithEvents cbxWaist As System.Windows.Forms.ComboBox
    Friend WithEvents cbxShoeSize As System.Windows.Forms.ComboBox
    Friend WithEvents cbxBrim As System.Windows.Forms.ComboBox
    Friend WithEvents cbxChest As System.Windows.Forms.ComboBox
    Friend WithEvents cbxUse As System.Windows.Forms.ComboBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents cbxShape As System.Windows.Forms.ComboBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents cbxLength As System.Windows.Forms.ComboBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents cbxSubType As ComboBox
    Friend WithEvents Label41 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents cbxFiber As ComboBox
    Friend WithEvents Label43 As Label
    Friend WithEvents cbxMaterials As ComboBox
    Friend WithEvents Label42 As Label
    Friend WithEvents cbxGeneralSize As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxSleeveStrap As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbxWeight As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxFabric As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Characteristics As GroupBox
    Friend WithEvents cbxHeel As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
