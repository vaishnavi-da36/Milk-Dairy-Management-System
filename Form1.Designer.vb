<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        dgvMilkEntries = New DataGridView()
        txtMilkRate = New Label()
        txtRate = New TextBox()
        Label4 = New Label()
        txtTotalAmount = New TextBox()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        txtSearch = New TextBox()
        btnSearch = New Button()
        lblTotalMilk = New Label()
        lblTotalAmount = New Label()
        lblTotalEntries = New Label()
        lblMonth = New Label()
        cmbMonth = New ComboBox()
        lblMonthlyMilk = New Label()
        lblMonthlyAmount = New Label()
        lblFarmerSummary = New Label()
        dgvFarmerSummary = New DataGridView()
        pnlDashboard = New Panel()
        lblDashboardRateValue = New Label()
        lblDashboardRate = New Label()
        lblDashboardFarmersValue = New Label()
        lblDashboardFarmers = New Label()
        lblDashboardEntriesValue = New Label()
        lblDashboardEntries = New Label()
        lblDashboardAmountValue = New Label()
        lblDashboardAmount = New Label()
        lblDashboardMilkValue = New Label()
        lblDashboardMilk = New Label()
        lblDashboardTitle = New Label()
        CType(dgvMilkEntries, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvFarmerSummary, ComponentModel.ISupportInitialize).BeginInit()
        pnlDashboard.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(454, 242)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 20)
        Label1.TabIndex = 0
        Label1.Text = "Farmer Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(632, 239)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(454, 295)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 20)
        Label2.TabIndex = 2
        Label2.Text = "Milk Quantity (Litres)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(837, 242)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 20)
        Label3.TabIndex = 3
        Label3.Text = "Date"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(632, 295)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(936, 242)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(294, 462)
        Button1.Name = "Button1"
        Button1.Size = New Size(125, 29)
        Button1.TabIndex = 6
        Button1.Text = "Save Milk Entry"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' dgvMilkEntries
        ' 
        dgvMilkEntries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMilkEntries.Location = New Point(654, 684)
        dgvMilkEntries.Name = "dgvMilkEntries"
        dgvMilkEntries.RowHeadersWidth = 51
        dgvMilkEntries.Size = New Size(711, 160)
        dgvMilkEntries.TabIndex = 7
        ' 
        ' txtMilkRate
        ' 
        txtMilkRate.AutoSize = True
        txtMilkRate.Location = New Point(454, 351)
        txtMilkRate.Name = "txtMilkRate"
        txtMilkRate.Size = New Size(128, 20)
        txtMilkRate.TabIndex = 8
        txtMilkRate.Text = "Milk Rate (₹/Litre)"
        ' 
        ' txtRate
        ' 
        txtRate.Location = New Point(632, 349)
        txtRate.Name = "txtRate"
        txtRate.Size = New Size(125, 27)
        txtRate.TabIndex = 9
        txtRate.Text = "50"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(454, 398)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 20)
        Label4.TabIndex = 10
        Label4.Text = "Total Amount (₹)"
        ' 
        ' txtTotalAmount
        ' 
        txtTotalAmount.Location = New Point(632, 398)
        txtTotalAmount.Name = "txtTotalAmount"
        txtTotalAmount.ReadOnly = True
        txtTotalAmount.Size = New Size(125, 27)
        txtTotalAmount.TabIndex = 11
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(475, 462)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(145, 29)
        btnUpdate.TabIndex = 12
        btnUpdate.Text = "Update Milk Entry"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(881, 462)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(131, 29)
        btnDelete.TabIndex = 13
        btnDelete.Text = "Delete Milk Entry"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(701, 462)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 14
        btnClear.Text = "Clear All"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(1055, 651)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(125, 27)
        txtSearch.TabIndex = 15
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(1206, 653)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(94, 29)
        btnSearch.TabIndex = 16
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' lblTotalMilk
        ' 
        lblTotalMilk.AutoSize = True
        lblTotalMilk.Location = New Point(234, 527)
        lblTotalMilk.Name = "lblTotalMilk"
        lblTotalMilk.Size = New Size(127, 20)
        lblTotalMilk.TabIndex = 17
        lblTotalMilk.Text = "Today's Total Milk"
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.AutoSize = True
        lblTotalAmount.Location = New Point(234, 565)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(152, 20)
        lblTotalAmount.TabIndex = 18
        lblTotalAmount.Text = "Today's Total Amount"
        ' 
        ' lblTotalEntries
        ' 
        lblTotalEntries.AutoSize = True
        lblTotalEntries.Location = New Point(234, 607)
        lblTotalEntries.Name = "lblTotalEntries"
        lblTotalEntries.Size = New Size(106, 20)
        lblTotalEntries.TabIndex = 19
        lblTotalEntries.Text = "Today's Entries"
        ' 
        ' lblMonth
        ' 
        lblMonth.AutoSize = True
        lblMonth.Location = New Point(689, 661)
        lblMonth.Name = "lblMonth"
        lblMonth.Size = New Size(96, 20)
        lblMonth.TabIndex = 20
        lblMonth.Text = "Select Month"
        ' 
        ' cmbMonth
        ' 
        cmbMonth.FormattingEnabled = True
        cmbMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        cmbMonth.Location = New Point(819, 653)
        cmbMonth.Name = "cmbMonth"
        cmbMonth.Size = New Size(151, 28)
        cmbMonth.TabIndex = 21
        ' 
        ' lblMonthlyMilk
        ' 
        lblMonthlyMilk.AutoSize = True
        lblMonthlyMilk.Location = New Point(701, 527)
        lblMonthlyMilk.Name = "lblMonthlyMilk"
        lblMonthlyMilk.Size = New Size(132, 20)
        lblMonthlyMilk.TabIndex = 22
        lblMonthlyMilk.Text = "Monthly Total Milk"
        ' 
        ' lblMonthlyAmount
        ' 
        lblMonthlyAmount.AutoSize = True
        lblMonthlyAmount.Location = New Point(701, 565)
        lblMonthlyAmount.Name = "lblMonthlyAmount"
        lblMonthlyAmount.Size = New Size(157, 20)
        lblMonthlyAmount.TabIndex = 23
        lblMonthlyAmount.Text = "Monthly Total Amount"
        ' 
        ' lblFarmerSummary
        ' 
        lblFarmerSummary.AutoSize = True
        lblFarmerSummary.Location = New Point(0, 640)
        lblFarmerSummary.Name = "lblFarmerSummary"
        lblFarmerSummary.Size = New Size(120, 20)
        lblFarmerSummary.TabIndex = 25
        lblFarmerSummary.Text = "Farmer Summary"
        ' 
        ' dgvFarmerSummary
        ' 
        dgvFarmerSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFarmerSummary.Location = New Point(24, 684)
        dgvFarmerSummary.Name = "dgvFarmerSummary"
        dgvFarmerSummary.RowHeadersWidth = 51
        dgvFarmerSummary.Size = New Size(558, 134)
        dgvFarmerSummary.TabIndex = 26
        ' 
        ' pnlDashboard
        ' 
        pnlDashboard.Controls.Add(lblDashboardRateValue)
        pnlDashboard.Controls.Add(lblDashboardRate)
        pnlDashboard.Controls.Add(lblDashboardFarmersValue)
        pnlDashboard.Controls.Add(lblDashboardFarmers)
        pnlDashboard.Controls.Add(lblDashboardEntriesValue)
        pnlDashboard.Controls.Add(lblDashboardEntries)
        pnlDashboard.Controls.Add(lblDashboardAmountValue)
        pnlDashboard.Controls.Add(lblDashboardAmount)
        pnlDashboard.Controls.Add(lblDashboardMilkValue)
        pnlDashboard.Controls.Add(lblDashboardMilk)
        pnlDashboard.Controls.Add(lblDashboardTitle)
        pnlDashboard.Location = New Point(262, 8)
        pnlDashboard.Name = "pnlDashboard"
        pnlDashboard.Size = New Size(822, 216)
        pnlDashboard.TabIndex = 27
        ' 
        ' lblDashboardRateValue
        ' 
        lblDashboardRateValue.AutoSize = True
        lblDashboardRateValue.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboardRateValue.Location = New Point(656, 104)
        lblDashboardRateValue.Name = "lblDashboardRateValue"
        lblDashboardRateValue.Size = New Size(143, 31)
        lblDashboardRateValue.TabIndex = 10
        lblDashboardRateValue.Text = "₹0.00 / Litre"
        ' 
        ' lblDashboardRate
        ' 
        lblDashboardRate.AutoSize = True
        lblDashboardRate.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboardRate.Location = New Point(650, 65)
        lblDashboardRate.Name = "lblDashboardRate"
        lblDashboardRate.Size = New Size(169, 25)
        lblDashboardRate.TabIndex = 9
        lblDashboardRate.Text = "Average Milk Rate"
        ' 
        ' lblDashboardFarmersValue
        ' 
        lblDashboardFarmersValue.AutoSize = True
        lblDashboardFarmersValue.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboardFarmersValue.Location = New Point(527, 100)
        lblDashboardFarmersValue.Name = "lblDashboardFarmersValue"
        lblDashboardFarmersValue.Size = New Size(27, 31)
        lblDashboardFarmersValue.TabIndex = 8
        lblDashboardFarmersValue.Text = "0"
        ' 
        ' lblDashboardFarmers
        ' 
        lblDashboardFarmers.AutoSize = True
        lblDashboardFarmers.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboardFarmers.Location = New Point(491, 64)
        lblDashboardFarmers.Name = "lblDashboardFarmers"
        lblDashboardFarmers.Size = New Size(125, 25)
        lblDashboardFarmers.TabIndex = 7
        lblDashboardFarmers.Text = "Total Farmers"
        ' 
        ' lblDashboardEntriesValue
        ' 
        lblDashboardEntriesValue.AutoSize = True
        lblDashboardEntriesValue.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboardEntriesValue.Location = New Point(360, 100)
        lblDashboardEntriesValue.Name = "lblDashboardEntriesValue"
        lblDashboardEntriesValue.Size = New Size(27, 31)
        lblDashboardEntriesValue.TabIndex = 6
        lblDashboardEntriesValue.Text = "0"
        ' 
        ' lblDashboardEntries
        ' 
        lblDashboardEntries.AutoSize = True
        lblDashboardEntries.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboardEntries.Location = New Point(327, 64)
        lblDashboardEntries.Name = "lblDashboardEntries"
        lblDashboardEntries.Size = New Size(117, 25)
        lblDashboardEntries.TabIndex = 5
        lblDashboardEntries.Text = "Total Entries"
        ' 
        ' lblDashboardAmountValue
        ' 
        lblDashboardAmountValue.AutoSize = True
        lblDashboardAmountValue.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboardAmountValue.Location = New Point(183, 99)
        lblDashboardAmountValue.Name = "lblDashboardAmountValue"
        lblDashboardAmountValue.Size = New Size(72, 31)
        lblDashboardAmountValue.TabIndex = 4
        lblDashboardAmountValue.Text = "₹0.00"
        ' 
        ' lblDashboardAmount
        ' 
        lblDashboardAmount.AutoSize = True
        lblDashboardAmount.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboardAmount.Location = New Point(153, 61)
        lblDashboardAmount.Name = "lblDashboardAmount"
        lblDashboardAmount.Size = New Size(128, 25)
        lblDashboardAmount.TabIndex = 3
        lblDashboardAmount.Text = "Total Amount"
        ' 
        ' lblDashboardMilkValue
        ' 
        lblDashboardMilkValue.AutoSize = True
        lblDashboardMilkValue.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboardMilkValue.Location = New Point(3, 97)
        lblDashboardMilkValue.Name = "lblDashboardMilkValue"
        lblDashboardMilkValue.Size = New Size(92, 31)
        lblDashboardMilkValue.TabIndex = 2
        lblDashboardMilkValue.Text = "0 Litres"
        ' 
        ' lblDashboardMilk
        ' 
        lblDashboardMilk.AutoSize = True
        lblDashboardMilk.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboardMilk.Location = New Point(3, 61)
        lblDashboardMilk.Name = "lblDashboardMilk"
        lblDashboardMilk.Size = New Size(96, 25)
        lblDashboardMilk.TabIndex = 1
        lblDashboardMilk.Text = "Total Milk"
        ' 
        ' lblDashboardTitle
        ' 
        lblDashboardTitle.AutoSize = True
        lblDashboardTitle.Font = New Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboardTitle.ForeColor = SystemColors.Highlight
        lblDashboardTitle.Location = New Point(64, 0)
        lblDashboardTitle.Name = "lblDashboardTitle"
        lblDashboardTitle.Size = New Size(536, 37)
        lblDashboardTitle.TabIndex = 0
        lblDashboardTitle.Text = ChrW(55358) & ChrW(56667) & " Milk Dairy Management Dashboard"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1318, 753)
        Controls.Add(pnlDashboard)
        Controls.Add(dgvFarmerSummary)
        Controls.Add(lblFarmerSummary)
        Controls.Add(lblMonthlyAmount)
        Controls.Add(lblMonthlyMilk)
        Controls.Add(cmbMonth)
        Controls.Add(lblMonth)
        Controls.Add(lblTotalEntries)
        Controls.Add(lblTotalAmount)
        Controls.Add(lblTotalMilk)
        Controls.Add(btnSearch)
        Controls.Add(dgvMilkEntries)
        Controls.Add(txtSearch)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(txtTotalAmount)
        Controls.Add(Label4)
        Controls.Add(txtRate)
        Controls.Add(txtMilkRate)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Milk Dairy Management System"
        CType(dgvMilkEntries, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvFarmerSummary, ComponentModel.ISupportInitialize).EndInit()
        pnlDashboard.ResumeLayout(False)
        pnlDashboard.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvMilkEntries As DataGridView
    Friend WithEvents txtMilkRate As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblTotalMilk As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblTotalEntries As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents lblMonthlyMilk As Label
    Friend WithEvents lblMonthlyAmount As Label
    Friend WithEvents lblFarmerSummary As Label
    Friend WithEvents dgvFarmerSummary As DataGridView
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents lblDashboardTitle As Label
    Friend WithEvents lblDashboardMilk As Label
    Friend WithEvents lblDashboardMilkValue As Label
    Friend WithEvents lblDashboardAmount As Label
    Friend WithEvents lblDashboardAmountValue As Label
    Friend WithEvents lblDashboardEntries As Label
    Friend WithEvents lblDashboardFarmersValue As Label
    Friend WithEvents lblDashboardFarmers As Label
    Friend WithEvents lblDashboardEntriesValue As Label
    Friend WithEvents lblDashboardRateValue As Label
    Friend WithEvents lblDashboardRate As Label
End Class
