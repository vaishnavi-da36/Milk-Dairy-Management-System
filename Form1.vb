Imports Microsoft.Data.Sqlite
Imports System.Data
Imports System.Globalization

Public Class Form1

    Private connectionString As String = "Data Source=milk_dairy.db"

    Private selectedID As Integer = 0


    '==============================
    ' FORM LOAD
    '==============================
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            Dim createTableQuery As String =
                "CREATE TABLE IF NOT EXISTS milk_entries (" &
                "id INTEGER PRIMARY KEY AUTOINCREMENT, " &
                "farmer_name TEXT NOT NULL, " &
                "milk_quantity REAL NOT NULL, " &
                "entry_date TEXT NOT NULL)"

            Using command As New SqliteCommand(createTableQuery, connection)
                command.ExecuteNonQuery()
            End Using

            Try
                Dim query As String =
                    "ALTER TABLE milk_entries " &
                    "ADD COLUMN milk_rate REAL NOT NULL DEFAULT 50"

                Using command As New SqliteCommand(query, connection)
                    command.ExecuteNonQuery()
                End Using
            Catch ex As SqliteException
            End Try

            Try
                Dim query As String =
                    "ALTER TABLE milk_entries " &
                    "ADD COLUMN total_amount REAL NOT NULL DEFAULT 0"

                Using command As New SqliteCommand(query, connection)
                    command.ExecuteNonQuery()
                End Using
            Catch ex As SqliteException
            End Try

            Dim updateQuery As String =
                "UPDATE milk_entries " &
                "SET total_amount = milk_quantity * milk_rate " &
                "WHERE total_amount = 0"

            Using command As New SqliteCommand(updateQuery, connection)
                command.ExecuteNonQuery()
            End Using

        End Using

        LoadMilkEntries()
        LoadDailySummary()

        'Select current month automatically
        cmbMonth.SelectedIndex = DateTime.Now.Month - 1

        'Load Farmer Summary
        LoadFarmerSummary()

        'Load Dashboard Summary
        LoadDashboardSummary()

    End Sub


    '==============================
    ' CALCULATE TOTAL AMOUNT
    '==============================
    Private Sub CalculateTotalAmount()

        Dim quantity As Double
        Dim rate As Double

        If Double.TryParse(TextBox2.Text, quantity) AndAlso
           Double.TryParse(txtRate.Text, rate) Then

            txtTotalAmount.Text =
                (quantity * rate).ToString("0.00")

        Else

            txtTotalAmount.Clear()

        End If

    End Sub


    '==============================
    ' QUANTITY CHANGED
    '==============================
    Private Sub TextBox2_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles TextBox2.TextChanged

        CalculateTotalAmount()

    End Sub


    '==============================
    ' RATE CHANGED
    '==============================
    Private Sub txtRate_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtRate.TextChanged

        CalculateTotalAmount()

    End Sub


    '==============================
    ' DATE VALIDATION
    '==============================
    Private Function IsValidDate(
        dateText As String,
        ByRef validDate As DateTime
    ) As Boolean

        Return DateTime.TryParseExact(
            dateText,
            "dd-MM-yyyy",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            validDate)

    End Function


    '==============================
    ' SAVE MILK ENTRY
    '==============================
    Private Sub Button1_Click(
        sender As Object,
        e As EventArgs
    ) Handles Button1.Click

        Dim farmerName As String =
            TextBox1.Text.Trim()

        Dim milkQuantity As Double
        Dim milkRate As Double
        Dim totalAmount As Double

        Dim entryDate As String =
            TextBox3.Text.Trim()

        Dim parsedDate As DateTime


        If farmerName = "" Then

            MessageBox.Show(
                "Please enter Farmer Name")

            Exit Sub

        End If


        If Not Double.TryParse(
            TextBox2.Text,
            milkQuantity) Then

            MessageBox.Show(
                "Please enter a valid milk quantity")

            Exit Sub

        End If


        If milkQuantity <= 0 Then

            MessageBox.Show(
                "Milk quantity must be greater than 0")

            Exit Sub

        End If


        If Not Double.TryParse(
            txtRate.Text,
            milkRate) Then

            MessageBox.Show(
                "Please enter a valid milk rate")

            Exit Sub

        End If


        If milkRate <= 0 Then

            MessageBox.Show(
                "Milk rate must be greater than 0")

            Exit Sub

        End If


        If Not IsValidDate(
            entryDate,
            parsedDate) Then

            MessageBox.Show(
                "Please enter a valid date in DD-MM-YYYY format." &
                vbCrLf &
                "Example: 11-09-2026")

            Exit Sub

        End If


        entryDate =
            parsedDate.ToString("dd-MM-yyyy")


        totalAmount =
            milkQuantity * milkRate


        Using connection As New SqliteConnection(
            connectionString)

            connection.Open()

            Dim query As String =
                "INSERT INTO milk_entries " &
                "(farmer_name, milk_quantity, milk_rate, " &
                "total_amount, entry_date) " &
                "VALUES " &
                "(@farmerName, @milkQuantity, @milkRate, " &
                "@totalAmount, @entryDate)"


            Using command As New SqliteCommand(
                query,
                connection)

                command.Parameters.AddWithValue(
                    "@farmerName",
                    farmerName)

                command.Parameters.AddWithValue(
                    "@milkQuantity",
                    milkQuantity)

                command.Parameters.AddWithValue(
                    "@milkRate",
                    milkRate)

                command.Parameters.AddWithValue(
                    "@totalAmount",
                    totalAmount)

                command.Parameters.AddWithValue(
                    "@entryDate",
                    entryDate)

                command.ExecuteNonQuery()

            End Using

        End Using


        MessageBox.Show(
            "Milk Entry Saved Successfully!" &
            vbCrLf &
            "Total Amount: ₹" &
            totalAmount.ToString("0.00"))


        selectedID = 0

        ClearFields()

        LoadMilkEntries()
        LoadDailySummary()
        LoadMonthlySummary()
        LoadFarmerSummary()
        LoadDashboardSummary()

    End Sub


    '==============================
    ' DATAGRIDVIEW CELL CLICK
    '==============================
    Private Sub dgvMilkEntries_CellClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles dgvMilkEntries.CellClick

        If e.RowIndex < 0 Then
            Exit Sub
        End If


        Dim row As DataGridViewRow =
            dgvMilkEntries.Rows(e.RowIndex)


        selectedID =
            Convert.ToInt32(
                row.Cells("ID").Value)


        TextBox1.Text =
            row.Cells("Farmer Name").Value.ToString()


        TextBox2.Text =
            row.Cells(
                "Milk Quantity (Litres)"
            ).Value.ToString()


        txtRate.Text =
            row.Cells(
                "Milk Rate (₹/Litre)"
            ).Value.ToString()


        txtTotalAmount.Text =
            row.Cells(
                "Total Amount (₹)"
            ).Value.ToString()


        TextBox3.Text =
            row.Cells("Date").Value.ToString()

    End Sub


    '==============================
    ' UPDATE MILK ENTRY
    '==============================
    Private Sub btnUpdate_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnUpdate.Click

        If selectedID = 0 Then

            MessageBox.Show(
                "Please select a record from the table first.")

            Exit Sub

        End If


        Dim farmerName As String =
            TextBox1.Text.Trim()

        Dim milkQuantity As Double
        Dim milkRate As Double
        Dim totalAmount As Double

        Dim entryDate As String =
            TextBox3.Text.Trim()

        Dim parsedDate As DateTime


        If farmerName = "" Then

            MessageBox.Show(
                "Please enter Farmer Name")

            Exit Sub

        End If


        If Not Double.TryParse(
            TextBox2.Text,
            milkQuantity) OrElse
           milkQuantity <= 0 Then

            MessageBox.Show(
                "Please enter a valid milk quantity")

            Exit Sub

        End If


        If Not Double.TryParse(
            txtRate.Text,
            milkRate) OrElse
           milkRate <= 0 Then

            MessageBox.Show(
                "Please enter a valid milk rate")

            Exit Sub

        End If


        If Not IsValidDate(
            entryDate,
            parsedDate) Then

            MessageBox.Show(
                "Please enter a valid date in DD-MM-YYYY format." &
                vbCrLf &
                "Example: 11-09-2026")

            Exit Sub

        End If


        entryDate =
            parsedDate.ToString("dd-MM-yyyy")


        totalAmount =
            milkQuantity * milkRate


        Using connection As New SqliteConnection(
            connectionString)

            connection.Open()


            Dim query As String =
                "UPDATE milk_entries SET " &
                "farmer_name = @farmerName, " &
                "milk_quantity = @milkQuantity, " &
                "milk_rate = @milkRate, " &
                "total_amount = @totalAmount, " &
                "entry_date = @entryDate " &
                "WHERE id = @id"


            Using command As New SqliteCommand(
                query,
                connection)

                command.Parameters.AddWithValue(
                    "@farmerName",
                    farmerName)

                command.Parameters.AddWithValue(
                    "@milkQuantity",
                    milkQuantity)

                command.Parameters.AddWithValue(
                    "@milkRate",
                    milkRate)

                command.Parameters.AddWithValue(
                    "@totalAmount",
                    totalAmount)

                command.Parameters.AddWithValue(
                    "@entryDate",
                    entryDate)

                command.Parameters.AddWithValue(
                    "@id",
                    selectedID)

                command.ExecuteNonQuery()

            End Using

        End Using


        MessageBox.Show(
            "Milk Entry Updated Successfully!")


        selectedID = 0

        ClearFields()

        LoadMilkEntries()
        LoadDailySummary()
        LoadMonthlySummary()
        LoadFarmerSummary()
        LoadDashboardSummary()

    End Sub


    '==============================
    ' DELETE MILK ENTRY
    '==============================
    Private Sub btnDelete_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDelete.Click

        If selectedID = 0 Then

            MessageBox.Show(
                "Please select a record from the table first.")

            Exit Sub

        End If


        Dim result As DialogResult =
            MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)


        If result = DialogResult.No Then
            Exit Sub
        End If


        Using connection As New SqliteConnection(
            connectionString)

            connection.Open()


            Dim query As String =
                "DELETE FROM milk_entries " &
                "WHERE id = @id"


            Using command As New SqliteCommand(
                query,
                connection)

                command.Parameters.AddWithValue(
                    "@id",
                    selectedID)

                command.ExecuteNonQuery()

            End Using

        End Using


        MessageBox.Show(
            "Milk Entry Deleted Successfully!")


        selectedID = 0

        ClearFields()

        LoadMilkEntries()
        LoadDailySummary()
        LoadMonthlySummary()
        LoadFarmerSummary()
        LoadDashboardSummary()

    End Sub


    '==============================
    ' CLEAR ALL
    '==============================
    Private Sub btnClear_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnClear.Click

        selectedID = 0

        ClearFields()

    End Sub


    '==============================
    ' CLEAR FIELDS
    '==============================
    Private Sub ClearFields()

        TextBox1.Clear()

        TextBox2.Clear()

        TextBox3.Clear()

        txtRate.Text = "50"

        txtTotalAmount.Clear()

    End Sub


    '==============================
    ' LOAD DATA
    '==============================
    Private Sub LoadMilkEntries()

        Using connection As New SqliteConnection(
            connectionString)

            connection.Open()


            Dim query As String =
                "SELECT " &
                "id AS ID, " &
                "farmer_name AS 'Farmer Name', " &
                "milk_quantity AS 'Milk Quantity (Litres)', " &
                "milk_rate AS 'Milk Rate (₹/Litre)', " &
                "total_amount AS 'Total Amount (₹)', " &
                "entry_date AS Date " &
                "FROM milk_entries " &
                "ORDER BY id DESC"


            Using command As New SqliteCommand(
                query,
                connection)

                Using reader As SqliteDataReader =
                    command.ExecuteReader()

                    Dim table As New DataTable()

                    table.Load(reader)

                    dgvMilkEntries.DataSource =
                        table

                End Using

            End Using

        End Using

    End Sub


    '==============================
    ' DAILY SUMMARY
    '==============================
    Private Sub LoadDailySummary()

        Dim today As String =
            DateTime.Now.ToString("dd-MM-yyyy")

        Dim totalMilk As Double = 0
        Dim totalAmount As Double = 0
        Dim totalEntries As Integer = 0


        Using connection As New SqliteConnection(
            connectionString)

            connection.Open()


            Dim query As String =
                "SELECT " &
                "COALESCE(SUM(milk_quantity), 0), " &
                "COALESCE(SUM(total_amount), 0), " &
                "COUNT(*) " &
                "FROM milk_entries " &
                "WHERE entry_date = @today"


            Using command As New SqliteCommand(
                query,
                connection)

                command.Parameters.AddWithValue(
                    "@today",
                    today)


                Using reader As SqliteDataReader =
                    command.ExecuteReader()

                    If reader.Read() Then

                        totalMilk =
                            Convert.ToDouble(reader.GetValue(0))

                        totalAmount =
                            Convert.ToDouble(reader.GetValue(1))

                        totalEntries =
                            Convert.ToInt32(reader.GetValue(2))

                    End If

                End Using

            End Using

        End Using


        lblTotalMilk.Text =
            "Today's Total Milk: " &
            totalMilk.ToString("0.00") &
            " Litres"


        lblTotalAmount.Text =
            "Today's Total Amount: ₹" &
            totalAmount.ToString("0.00")


        lblTotalEntries.Text =
            "Today's Entries: " &
            totalEntries.ToString()

    End Sub


    '==============================
    ' MONTH SELECTION
    '==============================
    Private Sub cmbMonth_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cmbMonth.SelectedIndexChanged

        LoadMonthlySummary()

    End Sub


    '==============================
    ' MONTHLY SUMMARY
    '==============================
    Private Sub LoadMonthlySummary()

        If cmbMonth.SelectedIndex < 0 Then
            Exit Sub
        End If


        Dim selectedMonth As Integer =
            cmbMonth.SelectedIndex + 1

        Dim totalMilk As Double = 0
        Dim totalAmount As Double = 0


        Using connection As New SqliteConnection(
            connectionString)

            connection.Open()


            Dim query As String =
                "SELECT " &
                "COALESCE(SUM(milk_quantity), 0), " &
                "COALESCE(SUM(total_amount), 0) " &
                "FROM milk_entries " &
                "WHERE substr(entry_date, 4, 2) = @month"


            Using command As New SqliteCommand(
                query,
                connection)

                command.Parameters.AddWithValue(
                    "@month",
                    selectedMonth.ToString("00"))


                Using reader As SqliteDataReader =
                    command.ExecuteReader()

                    If reader.Read() Then

                        totalMilk =
                            Convert.ToDouble(reader.GetValue(0))

                        totalAmount =
                            Convert.ToDouble(reader.GetValue(1))

                    End If

                End Using

            End Using

        End Using


        lblMonthlyMilk.Text =
            "Monthly Total Milk: " &
            totalMilk.ToString("0.00") &
            " Litres"


        lblMonthlyAmount.Text =
            "Monthly Total Amount: ₹" &
            totalAmount.ToString("0.00")

    End Sub


    '==============================
    ' SEARCH
    '==============================
    Private Sub btnSearch_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSearch.Click

        Dim searchText As String =
            txtSearch.Text.Trim()


        If searchText = "" Then

            LoadMilkEntries()

            Exit Sub

        End If


        Using connection As New SqliteConnection(
            connectionString)

            connection.Open()


            Dim query As String =
                "SELECT " &
                "id AS ID, " &
                "farmer_name AS 'Farmer Name', " &
                "milk_quantity AS 'Milk Quantity (Litres)', " &
                "milk_rate AS 'Milk Rate (₹/Litre)', " &
                "total_amount AS 'Total Amount (₹)', " &
                "entry_date AS Date " &
                "FROM milk_entries " &
                "WHERE farmer_name LIKE @search " &
                "ORDER BY id DESC"


            Using command As New SqliteCommand(
                query,
                connection)

                command.Parameters.AddWithValue(
                    "@search",
                    "%" & searchText & "%")


                Using reader As SqliteDataReader =
                    command.ExecuteReader()

                    Dim table As New DataTable()

                    table.Load(reader)

                    dgvMilkEntries.DataSource =
                        table

                End Using

            End Using

        End Using

    End Sub


    '==============================
    ' FARMER SUMMARY
    '==============================
    Private Sub LoadFarmerSummary()

        Using connection As New SqliteConnection(
            connectionString)

            connection.Open()

            Dim query As String =
                "SELECT " &
                "farmer_name AS 'Farmer Name', " &
                "SUM(milk_quantity) AS 'Total Milk (Litres)', " &
                "SUM(total_amount) AS 'Total Amount (₹)', " &
                "COUNT(*) AS 'Total Entries' " &
                "FROM milk_entries " &
                "GROUP BY farmer_name " &
                "ORDER BY farmer_name"

            Using command As New SqliteCommand(
                query,
                connection)

                Using reader As SqliteDataReader =
                    command.ExecuteReader()

                    Dim table As New DataTable()

                    table.Load(reader)

                    dgvFarmerSummary.DataSource =
                        table

                End Using

            End Using

        End Using

    End Sub


    '==============================
    ' DASHBOARD PANEL PAINT
    '==============================
    Private Sub pnlDashboard_Paint(
        sender As Object,
        e As PaintEventArgs
    ) Handles pnlDashboard.Paint

    End Sub


    '==============================
    ' DASHBOARD SUMMARY
    '==============================
    Private Sub LoadDashboardSummary()

        Dim totalMilk As Double = 0
        Dim totalAmount As Double = 0
        Dim totalEntries As Integer = 0
        Dim totalFarmers As Integer = 0
        Dim averageRate As Double = 0


        Using connection As New SqliteConnection(
            connectionString)

            connection.Open()


            Dim query As String =
                "SELECT " &
                "COALESCE(SUM(milk_quantity), 0), " &
                "COALESCE(SUM(total_amount), 0), " &
                "COUNT(*), " &
                "COUNT(DISTINCT farmer_name), " &
                "COALESCE(AVG(milk_rate), 0) " &
                "FROM milk_entries"


            Using command As New SqliteCommand(
                query,
                connection)

                Using reader As SqliteDataReader =
                    command.ExecuteReader()

                    If reader.Read() Then

                        totalMilk =
                            Convert.ToDouble(reader.GetValue(0))

                        totalAmount =
                            Convert.ToDouble(reader.GetValue(1))

                        totalEntries =
                            Convert.ToInt32(reader.GetValue(2))

                        totalFarmers =
                            Convert.ToInt32(reader.GetValue(3))

                        averageRate =
                            Convert.ToDouble(reader.GetValue(4))

                    End If

                End Using

            End Using

        End Using


        lblDashboardMilkValue.Text =
            totalMilk.ToString("0.00") &
            " Litres"


        lblDashboardAmountValue.Text =
            "₹" &
            totalAmount.ToString("0.00")


        lblDashboardEntriesValue.Text =
            totalEntries.ToString()


        lblDashboardFarmersValue.Text =
            totalFarmers.ToString()


        lblDashboardRateValue.Text =
            "₹" &
            averageRate.ToString("0.00") &
            " / Litre"

    End Sub

    Private Sub lblDashboardRateValue_Click(sender As Object, e As EventArgs) Handles lblDashboardRateValue.Click

    End Sub

    Private Sub lblTotalEntries_Click(sender As Object, e As EventArgs) Handles lblTotalEntries.Click

    End Sub

    Private Sub lblDashboardFarmersValue_Click(sender As Object, e As EventArgs) Handles lblDashboardFarmersValue.Click

    End Sub

    Private Sub dgvFarmerSummary_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFarmerSummary.CellContentClick

    End Sub
End Class