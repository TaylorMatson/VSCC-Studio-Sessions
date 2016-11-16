<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VSCCSS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VSCCSS))
        Me.calendarDatePicker = New System.Windows.Forms.MonthCalendar()
        Me.listboxNames = New System.Windows.Forms.ListBox()
        Me.listboxStartTimes = New System.Windows.Forms.ListBox()
        Me.listboxEndTimes = New System.Windows.Forms.ListBox()
        Me.listboxLocation = New System.Windows.Forms.ListBox()
        Me.listboxPurpose = New System.Windows.Forms.ListBox()
        Me.groupAddASession = New System.Windows.Forms.GroupBox()
        Me.buttonAddSessionToSelectedDate = New System.Windows.Forms.Button()
        Me.labelAddPurpose = New System.Windows.Forms.Label()
        Me.textboxAddPurpose = New System.Windows.Forms.TextBox()
        Me.labelAddLocation = New System.Windows.Forms.Label()
        Me.comboboxAddLocation = New System.Windows.Forms.ComboBox()
        Me.timepickerAddEndTime = New System.Windows.Forms.DateTimePicker()
        Me.labelAddEndTime = New System.Windows.Forms.Label()
        Me.timepickerAddStartTime = New System.Windows.Forms.DateTimePicker()
        Me.labelAddStartTime = New System.Windows.Forms.Label()
        Me.labelAddName = New System.Windows.Forms.Label()
        Me.textboxName = New System.Windows.Forms.TextBox()
        Me.buttonDeleteSelectedSession = New System.Windows.Forms.Button()
        Me.groupActiveSessions = New System.Windows.Forms.GroupBox()
        Me.labelActivePurposes = New System.Windows.Forms.Label()
        Me.labelActiveLocations = New System.Windows.Forms.Label()
        Me.labelActiveEndTimes = New System.Windows.Forms.Label()
        Me.labelActiveStartTime = New System.Windows.Forms.Label()
        Me.labelActiveNames = New System.Windows.Forms.Label()
        Me.pictureboxVSCCLogo = New System.Windows.Forms.PictureBox()
        Me.menustripMain = New System.Windows.Forms.MenuStrip()
        Me.menuitemWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.groupAddASession.SuspendLayout()
        Me.groupActiveSessions.SuspendLayout()
        CType(Me.pictureboxVSCCLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menustripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'calendarDatePicker
        '
        Me.calendarDatePicker.CalendarDimensions = New System.Drawing.Size(1, 2)
        Me.calendarDatePicker.Location = New System.Drawing.Point(13, 37)
        Me.calendarDatePicker.Name = "calendarDatePicker"
        Me.calendarDatePicker.TabIndex = 0
        '
        'listboxNames
        '
        Me.listboxNames.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listboxNames.FormattingEnabled = True
        Me.listboxNames.ItemHeight = 16
        Me.listboxNames.Location = New System.Drawing.Point(6, 40)
        Me.listboxNames.Name = "listboxNames"
        Me.listboxNames.Size = New System.Drawing.Size(113, 116)
        Me.listboxNames.TabIndex = 3
        '
        'listboxStartTimes
        '
        Me.listboxStartTimes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listboxStartTimes.FormattingEnabled = True
        Me.listboxStartTimes.ItemHeight = 16
        Me.listboxStartTimes.Location = New System.Drawing.Point(125, 40)
        Me.listboxStartTimes.Name = "listboxStartTimes"
        Me.listboxStartTimes.Size = New System.Drawing.Size(93, 116)
        Me.listboxStartTimes.TabIndex = 4
        '
        'listboxEndTimes
        '
        Me.listboxEndTimes.FormattingEnabled = True
        Me.listboxEndTimes.ItemHeight = 16
        Me.listboxEndTimes.Location = New System.Drawing.Point(225, 40)
        Me.listboxEndTimes.Name = "listboxEndTimes"
        Me.listboxEndTimes.Size = New System.Drawing.Size(93, 116)
        Me.listboxEndTimes.TabIndex = 5
        '
        'listboxLocation
        '
        Me.listboxLocation.FormattingEnabled = True
        Me.listboxLocation.ItemHeight = 16
        Me.listboxLocation.Location = New System.Drawing.Point(324, 40)
        Me.listboxLocation.Name = "listboxLocation"
        Me.listboxLocation.Size = New System.Drawing.Size(124, 116)
        Me.listboxLocation.TabIndex = 6
        '
        'listboxPurpose
        '
        Me.listboxPurpose.FormattingEnabled = True
        Me.listboxPurpose.ItemHeight = 16
        Me.listboxPurpose.Location = New System.Drawing.Point(454, 40)
        Me.listboxPurpose.Name = "listboxPurpose"
        Me.listboxPurpose.Size = New System.Drawing.Size(115, 116)
        Me.listboxPurpose.TabIndex = 7
        '
        'groupAddASession
        '
        Me.groupAddASession.CausesValidation = False
        Me.groupAddASession.Controls.Add(Me.buttonAddSessionToSelectedDate)
        Me.groupAddASession.Controls.Add(Me.labelAddPurpose)
        Me.groupAddASession.Controls.Add(Me.textboxAddPurpose)
        Me.groupAddASession.Controls.Add(Me.labelAddLocation)
        Me.groupAddASession.Controls.Add(Me.comboboxAddLocation)
        Me.groupAddASession.Controls.Add(Me.timepickerAddEndTime)
        Me.groupAddASession.Controls.Add(Me.labelAddEndTime)
        Me.groupAddASession.Controls.Add(Me.timepickerAddStartTime)
        Me.groupAddASession.Controls.Add(Me.labelAddStartTime)
        Me.groupAddASession.Controls.Add(Me.labelAddName)
        Me.groupAddASession.Controls.Add(Me.textboxName)
        Me.groupAddASession.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupAddASession.ForeColor = System.Drawing.Color.White
        Me.groupAddASession.Location = New System.Drawing.Point(252, 243)
        Me.groupAddASession.Name = "groupAddASession"
        Me.groupAddASession.Size = New System.Drawing.Size(575, 105)
        Me.groupAddASession.TabIndex = 8
        Me.groupAddASession.TabStop = False
        Me.groupAddASession.Text = "Add A Session To The Selected Date"
        '
        'buttonAddSessionToSelectedDate
        '
        Me.buttonAddSessionToSelectedDate.ForeColor = System.Drawing.Color.Black
        Me.buttonAddSessionToSelectedDate.Location = New System.Drawing.Point(6, 73)
        Me.buttonAddSessionToSelectedDate.Name = "buttonAddSessionToSelectedDate"
        Me.buttonAddSessionToSelectedDate.Size = New System.Drawing.Size(563, 24)
        Me.buttonAddSessionToSelectedDate.TabIndex = 12
        Me.buttonAddSessionToSelectedDate.Text = "Add Session To Selected Date"
        Me.buttonAddSessionToSelectedDate.UseVisualStyleBackColor = True
        '
        'labelAddPurpose
        '
        Me.labelAddPurpose.AutoSize = True
        Me.labelAddPurpose.Location = New System.Drawing.Point(451, 27)
        Me.labelAddPurpose.Name = "labelAddPurpose"
        Me.labelAddPurpose.Size = New System.Drawing.Size(60, 16)
        Me.labelAddPurpose.TabIndex = 10
        Me.labelAddPurpose.Text = "Purpose"
        '
        'textboxAddPurpose
        '
        Me.textboxAddPurpose.Location = New System.Drawing.Point(454, 46)
        Me.textboxAddPurpose.Name = "textboxAddPurpose"
        Me.textboxAddPurpose.Size = New System.Drawing.Size(113, 22)
        Me.textboxAddPurpose.TabIndex = 9
        '
        'labelAddLocation
        '
        Me.labelAddLocation.AutoSize = True
        Me.labelAddLocation.Location = New System.Drawing.Point(321, 26)
        Me.labelAddLocation.Name = "labelAddLocation"
        Me.labelAddLocation.Size = New System.Drawing.Size(63, 16)
        Me.labelAddLocation.TabIndex = 8
        Me.labelAddLocation.Text = "Location"
        '
        'comboboxAddLocation
        '
        Me.comboboxAddLocation.FormattingEnabled = True
        Me.comboboxAddLocation.Items.AddRange(New Object() {"SRHB1", "SRHB2", "Ramer"})
        Me.comboboxAddLocation.Location = New System.Drawing.Point(324, 45)
        Me.comboboxAddLocation.Name = "comboboxAddLocation"
        Me.comboboxAddLocation.Size = New System.Drawing.Size(124, 24)
        Me.comboboxAddLocation.TabIndex = 7
        '
        'timepickerAddEndTime
        '
        Me.timepickerAddEndTime.CustomFormat = "hh:mm tt"
        Me.timepickerAddEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.timepickerAddEndTime.Location = New System.Drawing.Point(225, 46)
        Me.timepickerAddEndTime.Name = "timepickerAddEndTime"
        Me.timepickerAddEndTime.ShowUpDown = True
        Me.timepickerAddEndTime.Size = New System.Drawing.Size(93, 22)
        Me.timepickerAddEndTime.TabIndex = 6
        Me.timepickerAddEndTime.Value = New Date(2016, 11, 15, 9, 0, 0, 0)
        '
        'labelAddEndTime
        '
        Me.labelAddEndTime.AutoSize = True
        Me.labelAddEndTime.Location = New System.Drawing.Point(222, 26)
        Me.labelAddEndTime.Name = "labelAddEndTime"
        Me.labelAddEndTime.Size = New System.Drawing.Size(68, 16)
        Me.labelAddEndTime.TabIndex = 5
        Me.labelAddEndTime.Text = "End Time"
        '
        'timepickerAddStartTime
        '
        Me.timepickerAddStartTime.CustomFormat = "hh:mm tt"
        Me.timepickerAddStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.timepickerAddStartTime.Location = New System.Drawing.Point(125, 46)
        Me.timepickerAddStartTime.Name = "timepickerAddStartTime"
        Me.timepickerAddStartTime.ShowUpDown = True
        Me.timepickerAddStartTime.Size = New System.Drawing.Size(93, 22)
        Me.timepickerAddStartTime.TabIndex = 4
        Me.timepickerAddStartTime.Value = New Date(2016, 11, 15, 8, 0, 0, 0)
        '
        'labelAddStartTime
        '
        Me.labelAddStartTime.AutoSize = True
        Me.labelAddStartTime.Location = New System.Drawing.Point(122, 27)
        Me.labelAddStartTime.Name = "labelAddStartTime"
        Me.labelAddStartTime.Size = New System.Drawing.Size(74, 16)
        Me.labelAddStartTime.TabIndex = 3
        Me.labelAddStartTime.Text = "Start Time"
        '
        'labelAddName
        '
        Me.labelAddName.AutoSize = True
        Me.labelAddName.Location = New System.Drawing.Point(3, 26)
        Me.labelAddName.Name = "labelAddName"
        Me.labelAddName.Size = New System.Drawing.Size(45, 16)
        Me.labelAddName.TabIndex = 1
        Me.labelAddName.Text = "Name"
        '
        'textboxName
        '
        Me.textboxName.Location = New System.Drawing.Point(6, 45)
        Me.textboxName.Name = "textboxName"
        Me.textboxName.Size = New System.Drawing.Size(113, 22)
        Me.textboxName.TabIndex = 0
        '
        'buttonDeleteSelectedSession
        '
        Me.buttonDeleteSelectedSession.ForeColor = System.Drawing.Color.Black
        Me.buttonDeleteSelectedSession.Location = New System.Drawing.Point(6, 165)
        Me.buttonDeleteSelectedSession.Name = "buttonDeleteSelectedSession"
        Me.buttonDeleteSelectedSession.Size = New System.Drawing.Size(563, 24)
        Me.buttonDeleteSelectedSession.TabIndex = 9
        Me.buttonDeleteSelectedSession.Text = "Delete Selected Session"
        Me.buttonDeleteSelectedSession.UseVisualStyleBackColor = True
        '
        'groupActiveSessions
        '
        Me.groupActiveSessions.Controls.Add(Me.labelActivePurposes)
        Me.groupActiveSessions.Controls.Add(Me.labelActiveLocations)
        Me.groupActiveSessions.Controls.Add(Me.labelActiveEndTimes)
        Me.groupActiveSessions.Controls.Add(Me.labelActiveStartTime)
        Me.groupActiveSessions.Controls.Add(Me.labelActiveNames)
        Me.groupActiveSessions.Controls.Add(Me.listboxPurpose)
        Me.groupActiveSessions.Controls.Add(Me.listboxLocation)
        Me.groupActiveSessions.Controls.Add(Me.buttonDeleteSelectedSession)
        Me.groupActiveSessions.Controls.Add(Me.listboxStartTimes)
        Me.groupActiveSessions.Controls.Add(Me.listboxEndTimes)
        Me.groupActiveSessions.Controls.Add(Me.listboxNames)
        Me.groupActiveSessions.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupActiveSessions.ForeColor = System.Drawing.Color.White
        Me.groupActiveSessions.Location = New System.Drawing.Point(252, 37)
        Me.groupActiveSessions.Name = "groupActiveSessions"
        Me.groupActiveSessions.Size = New System.Drawing.Size(575, 200)
        Me.groupActiveSessions.TabIndex = 9
        Me.groupActiveSessions.TabStop = False
        Me.groupActiveSessions.Text = "Active Sessions"
        '
        'labelActivePurposes
        '
        Me.labelActivePurposes.AutoSize = True
        Me.labelActivePurposes.Location = New System.Drawing.Point(451, 18)
        Me.labelActivePurposes.Name = "labelActivePurposes"
        Me.labelActivePurposes.Size = New System.Drawing.Size(60, 16)
        Me.labelActivePurposes.TabIndex = 11
        Me.labelActivePurposes.Text = "Purpose"
        '
        'labelActiveLocations
        '
        Me.labelActiveLocations.AutoSize = True
        Me.labelActiveLocations.Location = New System.Drawing.Point(321, 18)
        Me.labelActiveLocations.Name = "labelActiveLocations"
        Me.labelActiveLocations.Size = New System.Drawing.Size(63, 16)
        Me.labelActiveLocations.TabIndex = 9
        Me.labelActiveLocations.Text = "Location"
        '
        'labelActiveEndTimes
        '
        Me.labelActiveEndTimes.AutoSize = True
        Me.labelActiveEndTimes.Location = New System.Drawing.Point(222, 18)
        Me.labelActiveEndTimes.Name = "labelActiveEndTimes"
        Me.labelActiveEndTimes.Size = New System.Drawing.Size(68, 16)
        Me.labelActiveEndTimes.TabIndex = 7
        Me.labelActiveEndTimes.Text = "End Time"
        '
        'labelActiveStartTime
        '
        Me.labelActiveStartTime.AutoSize = True
        Me.labelActiveStartTime.Location = New System.Drawing.Point(122, 18)
        Me.labelActiveStartTime.Name = "labelActiveStartTime"
        Me.labelActiveStartTime.Size = New System.Drawing.Size(74, 16)
        Me.labelActiveStartTime.TabIndex = 5
        Me.labelActiveStartTime.Text = "Start Time"
        '
        'labelActiveNames
        '
        Me.labelActiveNames.AutoSize = True
        Me.labelActiveNames.Location = New System.Drawing.Point(3, 18)
        Me.labelActiveNames.Name = "labelActiveNames"
        Me.labelActiveNames.Size = New System.Drawing.Size(45, 16)
        Me.labelActiveNames.TabIndex = 4
        Me.labelActiveNames.Text = "Name"
        '
        'pictureboxVSCCLogo
        '
        Me.pictureboxVSCCLogo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pictureboxVSCCLogo.Image = CType(resources.GetObject("pictureboxVSCCLogo.Image"), System.Drawing.Image)
        Me.pictureboxVSCCLogo.Location = New System.Drawing.Point(839, 43)
        Me.pictureboxVSCCLogo.Name = "pictureboxVSCCLogo"
        Me.pictureboxVSCCLogo.Size = New System.Drawing.Size(145, 305)
        Me.pictureboxVSCCLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureboxVSCCLogo.TabIndex = 10
        Me.pictureboxVSCCLogo.TabStop = False
        '
        'menustripMain
        '
        Me.menustripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemWindow})
        Me.menustripMain.Location = New System.Drawing.Point(0, 0)
        Me.menustripMain.Name = "menustripMain"
        Me.menustripMain.Size = New System.Drawing.Size(996, 24)
        Me.menustripMain.TabIndex = 11
        Me.menustripMain.Text = "MenuStrip1"
        '
        'menuitemWindow
        '
        Me.menuitemWindow.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreditsToolStripMenuItem})
        Me.menuitemWindow.Name = "menuitemWindow"
        Me.menuitemWindow.Size = New System.Drawing.Size(63, 20)
        Me.menuitemWindow.Text = "Window"
        '
        'CreditsToolStripMenuItem
        '
        Me.CreditsToolStripMenuItem.Name = "CreditsToolStripMenuItem"
        Me.CreditsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CreditsToolStripMenuItem.Text = "Credits"
        '
        'VSCCSS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(996, 363)
        Me.Controls.Add(Me.pictureboxVSCCLogo)
        Me.Controls.Add(Me.groupAddASession)
        Me.Controls.Add(Me.calendarDatePicker)
        Me.Controls.Add(Me.groupActiveSessions)
        Me.Controls.Add(Me.menustripMain)
        Me.MainMenuStrip = Me.menustripMain
        Me.Name = "VSCCSS"
        Me.Text = "VSCC Studio Sessions"
        Me.groupAddASession.ResumeLayout(False)
        Me.groupAddASession.PerformLayout()
        Me.groupActiveSessions.ResumeLayout(False)
        Me.groupActiveSessions.PerformLayout()
        CType(Me.pictureboxVSCCLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menustripMain.ResumeLayout(False)
        Me.menustripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calendarDatePicker As System.Windows.Forms.MonthCalendar
    Friend WithEvents listboxNames As System.Windows.Forms.ListBox
    Friend WithEvents listboxStartTimes As System.Windows.Forms.ListBox
    Friend WithEvents listboxEndTimes As System.Windows.Forms.ListBox
    Friend WithEvents listboxLocation As System.Windows.Forms.ListBox
    Friend WithEvents listboxPurpose As System.Windows.Forms.ListBox
    Friend WithEvents groupAddASession As System.Windows.Forms.GroupBox
    Friend WithEvents buttonDeleteSelectedSession As System.Windows.Forms.Button
    Friend WithEvents groupActiveSessions As System.Windows.Forms.GroupBox
    Friend WithEvents pictureboxVSCCLogo As System.Windows.Forms.PictureBox
    Friend WithEvents timepickerAddStartTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelAddStartTime As System.Windows.Forms.Label
    Friend WithEvents labelAddName As System.Windows.Forms.Label
    Friend WithEvents textboxName As System.Windows.Forms.TextBox
    Friend WithEvents labelActiveStartTime As System.Windows.Forms.Label
    Friend WithEvents labelActiveNames As System.Windows.Forms.Label
    Friend WithEvents timepickerAddEndTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelAddEndTime As System.Windows.Forms.Label
    Friend WithEvents labelActiveEndTimes As System.Windows.Forms.Label
    Friend WithEvents labelAddLocation As System.Windows.Forms.Label
    Friend WithEvents comboboxAddLocation As System.Windows.Forms.ComboBox
    Friend WithEvents labelActiveLocations As System.Windows.Forms.Label
    Friend WithEvents labelAddPurpose As System.Windows.Forms.Label
    Friend WithEvents textboxAddPurpose As System.Windows.Forms.TextBox
    Friend WithEvents labelActivePurposes As System.Windows.Forms.Label
    Friend WithEvents buttonAddSessionToSelectedDate As System.Windows.Forms.Button
    Friend WithEvents menustripMain As System.Windows.Forms.MenuStrip
    Friend WithEvents menuitemWindow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreditsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
