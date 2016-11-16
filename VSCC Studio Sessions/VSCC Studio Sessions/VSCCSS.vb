Imports System.Data.SQLite

Public Class VSCCSS

    Private Sub VSCCSS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _selectedDate = calendarDatePicker.TodayDate.ToString()
        AddDataToListBoxes()
    End Sub

    Private Sub calendarDatePicker_DateSelected(sender As Object, e As DateRangeEventArgs) Handles calendarDatePicker.DateSelected
        Try
            listboxNames.DataSource = Nothing
            listboxStartTimes.DataSource = Nothing
            listboxEndTimes.DataSource = Nothing
            listboxLocation.DataSource = Nothing
            listboxPurpose.DataSource = Nothing

            listboxNames.Items.Clear()
            listboxStartTimes.Items.Clear()
            listboxEndTimes.Items.Clear()
            listboxLocation.Items.Clear()
            listboxPurpose.Items.Clear()

            ShowSessionDataOnDate(calendarDatePicker.SelectionStart)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Dim _selectedDate As String = Nothing

    Private Sub ShowSessionDataOnDate(selectedDate As String)
        _selectedDate = selectedDate
        AddDataToListBoxes()
    End Sub

    Public Sub AddDataToListBoxes()
        Dim connectionString As String = "Data Source=VSCCStudioSessions.sqlite"
        Dim mSQL As String = "SELECT * FROM sessions WHERE date='" & _selectedDate & "'"
        Dim dt As DataTable = Nothing
        Dim ds As New DataSet

        Try
            Using con As New SQLiteConnection(connectionString)
                Using cmd As New SQLiteCommand(mSQL, con)
                    con.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        da.Fill(ds)
                        dt = ds.Tables(0)
                    End Using
                    con.Close()
                End Using
            End Using

            listboxNames.ValueMember = "start"
            listboxNames.DisplayMember = "name"
            listboxNames.DataSource = dt

            listboxStartTimes.ValueMember = "start"
            listboxStartTimes.DisplayMember = "start"
            listboxStartTimes.DataSource = dt

            listboxEndTimes.ValueMember = "end"
            listboxEndTimes.DisplayMember = "end"
            listboxEndTimes.DataSource = dt

            listboxLocation.ValueMember = "start"
            listboxLocation.DisplayMember = "location"
            listboxLocation.DataSource = dt

            listboxPurpose.DataSource = dt
            listboxPurpose.ValueMember = "start"
            listboxPurpose.DisplayMember = "purpose"
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub


    Public Function getValue(ByVal dbValue As Object) As Object
        If IsDBNull(dbValue) Then
            Return "No Data Available"
        Else
            Return dbValue
        End If
    End Function

    Dim _selectedStartTime As String = Nothing

    Private Sub listboxStartTimes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxStartTimes.SelectedIndexChanged
        ' MsgBox(listboxStartTimes.SelectedValue.ToString())
        Try
            _selectedStartTime = listboxStartTimes.SelectedValue
        Catch ex As Exception
            ' MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub buttonDeleteSelectedSession_Click(sender As Object, e As EventArgs) Handles buttonDeleteSelectedSession.Click
        Dim connectionString As String = "Data Source=VSCCStudioSessions.sqlite"
        Dim dSQL As String = "DELETE FROM sessions WHERE date='" & _selectedDate & "' AND " & "start='" & _selectedStartTime & "'"

        Dim dt As DataTable = Nothing
        Dim ds As New DataSet

        Try
            Using con As New SQLiteConnection(connectionString)
                Using cmd As New SQLiteCommand(dSQL, con)
                    con.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        da.Fill(ds)
                        dt = ds.Tables(0)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' MsgBox(ex.ToString())
        End Try

        AddDataToListBoxes()
    End Sub

    Private Sub buttonAddSessionToSelectedDate_Click(sender As Object, e As EventArgs) Handles buttonAddSessionToSelectedDate.Click
        ' MsgBox(Strings.Right(timepickerAddStartTime.Value, 11)) ' Interesting function, not useful here

        ' MsgBox(calendarDatePicker.SelectionStart & " | " & textboxName.Text & " | " & timepickerAddStartTime.Text & " | " & timepickerAddEndTime.Text & " | " & comboboxAddLocation.Text & " | " & textboxAddPurpose.Text)
        Dim connectionString As String = "Data Source=VSCCStudioSessions.sqlite"
        Dim aSQL As String = "INSERT INTO sessions (date, name, start, end, location, purpose) VALUES ('" & calendarDatePicker.SelectionStart & "', '" & textboxName.Text & "', '" _
                              & timepickerAddStartTime.Text & "', '" & timepickerAddEndTime.Text & "', '" & comboboxAddLocation.Text & "', '" & textboxAddPurpose.Text & "')"

        Dim dt As DataTable = Nothing
        Dim ds As New DataSet

        Try
            Using con As New SQLiteConnection(connectionString)
                Using cmd As New SQLiteCommand(aSQL, con)
                    con.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' MsgBox(ex.ToString())
        End Try
        AddDataToListBoxes()
    End Sub

    Private Sub CreditsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem.Click
        MsgBox("Programmed By Taylor Matson, License: Public Domain")
    End Sub
End Class
