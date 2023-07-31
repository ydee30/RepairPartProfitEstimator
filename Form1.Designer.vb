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
        Me.components = New System.ComponentModel.Container()
        Me.PartInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.PartDescriptionTextbox = New System.Windows.Forms.TextBox()
        Me.PartIdentifierTextbox = New System.Windows.Forms.TextBox()
        Me.PartDescriptionLabel = New System.Windows.Forms.Label()
        Me.PartIndentifierLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NetProfitTextbox = New System.Windows.Forms.TextBox()
        Me.StorageTextbox = New System.Windows.Forms.TextBox()
        Me.GrossTextbox = New System.Windows.Forms.TextBox()
        Me.QuantityTextbox = New System.Windows.Forms.TextBox()
        Me.WholesaleTextbox = New System.Windows.Forms.TextBox()
        Me.RetailTextbox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComputeButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.TotalButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.WholeSaleTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PartInfoGroupBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PartInfoGroupBox
        '
        Me.PartInfoGroupBox.Controls.Add(Me.PartDescriptionTextbox)
        Me.PartInfoGroupBox.Controls.Add(Me.PartIdentifierTextbox)
        Me.PartInfoGroupBox.Controls.Add(Me.PartDescriptionLabel)
        Me.PartInfoGroupBox.Controls.Add(Me.PartIndentifierLabel)
        Me.PartInfoGroupBox.Location = New System.Drawing.Point(21, 27)
        Me.PartInfoGroupBox.Name = "PartInfoGroupBox"
        Me.PartInfoGroupBox.Size = New System.Drawing.Size(449, 87)
        Me.PartInfoGroupBox.TabIndex = 0
        Me.PartInfoGroupBox.TabStop = False
        Me.PartInfoGroupBox.Text = "Part Information "
        '
        'PartDescriptionTextbox
        '
        Me.PartDescriptionTextbox.Location = New System.Drawing.Point(122, 45)
        Me.PartDescriptionTextbox.Name = "PartDescriptionTextbox"
        Me.PartDescriptionTextbox.Size = New System.Drawing.Size(310, 20)
        Me.PartDescriptionTextbox.TabIndex = 7
        '
        'PartIdentifierTextbox
        '
        Me.PartIdentifierTextbox.Location = New System.Drawing.Point(122, 19)
        Me.PartIdentifierTextbox.Name = "PartIdentifierTextbox"
        Me.PartIdentifierTextbox.Size = New System.Drawing.Size(310, 20)
        Me.PartIdentifierTextbox.TabIndex = 6
        '
        'PartDescriptionLabel
        '
        Me.PartDescriptionLabel.AutoSize = True
        Me.PartDescriptionLabel.Location = New System.Drawing.Point(6, 52)
        Me.PartDescriptionLabel.Name = "PartDescriptionLabel"
        Me.PartDescriptionLabel.Size = New System.Drawing.Size(85, 13)
        Me.PartDescriptionLabel.TabIndex = 1
        Me.PartDescriptionLabel.Text = "Part &Description:"
        '
        'PartIndentifierLabel
        '
        Me.PartIndentifierLabel.AutoSize = True
        Me.PartIndentifierLabel.Location = New System.Drawing.Point(6, 26)
        Me.PartIndentifierLabel.Name = "PartIndentifierLabel"
        Me.PartIndentifierLabel.Size = New System.Drawing.Size(78, 13)
        Me.PartIndentifierLabel.TabIndex = 0
        Me.PartIndentifierLabel.Text = "&Part Indentifier:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NetProfitTextbox)
        Me.GroupBox2.Controls.Add(Me.StorageTextbox)
        Me.GroupBox2.Controls.Add(Me.GrossTextbox)
        Me.GroupBox2.Controls.Add(Me.QuantityTextbox)
        Me.GroupBox2.Controls.Add(Me.WholesaleTextbox)
        Me.GroupBox2.Controls.Add(Me.RetailTextbox)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 269)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Price, Cost, Storage, Profit"
        '
        'NetProfitTextbox
        '
        Me.NetProfitTextbox.Location = New System.Drawing.Point(146, 207)
        Me.NetProfitTextbox.Name = "NetProfitTextbox"
        Me.NetProfitTextbox.ReadOnly = True
        Me.NetProfitTextbox.Size = New System.Drawing.Size(164, 20)
        Me.NetProfitTextbox.TabIndex = 11
        Me.NetProfitTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'StorageTextbox
        '
        Me.StorageTextbox.Location = New System.Drawing.Point(146, 181)
        Me.StorageTextbox.Name = "StorageTextbox"
        Me.StorageTextbox.ReadOnly = True
        Me.StorageTextbox.Size = New System.Drawing.Size(164, 20)
        Me.StorageTextbox.TabIndex = 10
        Me.StorageTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GrossTextbox
        '
        Me.GrossTextbox.Location = New System.Drawing.Point(146, 150)
        Me.GrossTextbox.Name = "GrossTextbox"
        Me.GrossTextbox.ReadOnly = True
        Me.GrossTextbox.Size = New System.Drawing.Size(164, 20)
        Me.GrossTextbox.TabIndex = 9
        Me.GrossTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'QuantityTextbox
        '
        Me.QuantityTextbox.Location = New System.Drawing.Point(238, 117)
        Me.QuantityTextbox.Name = "QuantityTextbox"
        Me.QuantityTextbox.Size = New System.Drawing.Size(72, 20)
        Me.QuantityTextbox.TabIndex = 8
        Me.QuantityTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.WholeSaleTooltip.SetToolTip(Me.QuantityTextbox, "Enter the number of items to purchase")
        '
        'WholesaleTextbox
        '
        Me.WholesaleTextbox.Location = New System.Drawing.Point(146, 88)
        Me.WholesaleTextbox.Name = "WholesaleTextbox"
        Me.WholesaleTextbox.Size = New System.Drawing.Size(164, 20)
        Me.WholesaleTextbox.TabIndex = 7
        Me.WholesaleTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.WholeSaleTooltip.SetToolTip(Me.WholesaleTextbox, "Enter the wholesale cost of the item")
        '
        'RetailTextbox
        '
        Me.RetailTextbox.Location = New System.Drawing.Point(146, 53)
        Me.RetailTextbox.Name = "RetailTextbox"
        Me.RetailTextbox.Size = New System.Drawing.Size(164, 20)
        Me.RetailTextbox.TabIndex = 6
        Me.RetailTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.WholeSaleTooltip.SetToolTip(Me.RetailTextbox, "Enter the price of the item")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Net Profit: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Storage Charges:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Gross Profit: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "&Quantity:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "&Wholesale Cost:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "R&etail Price:"
        '
        'ComputeButton
        '
        Me.ComputeButton.Location = New System.Drawing.Point(370, 167)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.Size = New System.Drawing.Size(100, 45)
        Me.ComputeButton.TabIndex = 2
        Me.ComputeButton.Text = "&Compute"
        Me.ComputeButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ResetButton.Enabled = False
        Me.ResetButton.Location = New System.Drawing.Point(370, 234)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(100, 42)
        Me.ResetButton.TabIndex = 3
        Me.ResetButton.Text = "&Reset Form"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'TotalButton
        '
        Me.TotalButton.Location = New System.Drawing.Point(370, 296)
        Me.TotalButton.Name = "TotalButton"
        Me.TotalButton.Size = New System.Drawing.Size(100, 44)
        Me.TotalButton.TabIndex = 4
        Me.TotalButton.Text = "&Total Net " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Profit"
        Me.TotalButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(370, 353)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(100, 43)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.ComputeButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ResetButton
        Me.ClientSize = New System.Drawing.Size(498, 430)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.TotalButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.ComputeButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PartInfoGroupBox)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Reapair Part Profit Estimator"
        Me.PartInfoGroupBox.ResumeLayout(False)
        Me.PartInfoGroupBox.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PartInfoGroupBox As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComputeButton As Button
    Friend WithEvents PartDescriptionLabel As Label
    Friend WithEvents PartIndentifierLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ResetButton As Button
    Friend WithEvents TotalButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents PartDescriptionTextbox As TextBox
    Friend WithEvents PartIdentifierTextbox As TextBox
    Friend WithEvents NetProfitTextbox As TextBox
    Friend WithEvents StorageTextbox As TextBox
    Friend WithEvents GrossTextbox As TextBox
    Friend WithEvents QuantityTextbox As TextBox
    Friend WithEvents WholesaleTextbox As TextBox
    Friend WithEvents RetailTextbox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents WholeSaleTooltip As ToolTip
End Class
