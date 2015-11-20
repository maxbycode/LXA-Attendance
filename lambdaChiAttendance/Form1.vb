'This program is designed to keep attendance for the Lambda Chi Alpha fraternity
'It is currently an alpha and a lot of work needs to be done such as optimization and adding features
'This program contains materials from chapters 1-5 and chapter 9 of "Starting out with Visual Basic 2012, Sixth edition"
'This program is licensed to Alexander Hamilton under CreativeCommons Attribution-Noncommercial - https://creativecommons.org/licenses/by-nc/4.0/
Imports System.IO 'Imports the StreamWriter object
Public Class attendanceForm
    Dim noCheck As Boolean = True 'Variable to check to see if a meeting type is checked
    Dim addName As String 'Varible for a new member's name
    Dim addNumber As String 'Varible for new member's number
    Dim attendance As StreamWriter 'Varible for the writing to a file (New name in next version)
    Dim member As String 'Varible for member name
    Dim attendanceDetail As String 'Varible for present, excused, unexcused absence
    Dim reason As String 'Varible for the InputBox's output
    Dim loops As Integer 'Amount of times various loops complete a loop
    Private Sub btnAddMember_Click(sender As Object, e As EventArgs) Handles btnAddMember.Click 'Button to add a new member
        If txtNewName.Text <> "" Then 'Checks to see if name text box is blank
            If txtNewNumber.Text <> "" Then 'Checks to see if number text box is blank
                Try 'Attempts to write the name and number to the memberList.txt file and then add it to the combobox
                    addName = txtNewName.Text
                    addNumber = txtNewNumber.Text
                    attendance = File.AppendText("memberList.txt")
                    attendance.WriteLine(addName + " - " + addNumber)
                    attendance.Close()
                    cmbMembers.Items.Clear()
                    cmbMembers.Items.AddRange(File.ReadAllLines("memberList.txt"))
                Catch 'Catches the failed name addition
                    MessageBox.Show("Something went wrong. Please try again", "Error")
                End Try
            End If
            If txtNewNumber.Text = "" Then 'Displays if no number is input in new member number text box is empty
                MessageBox.Show("Please enter a member number", "Error")
            End If
        Else 'Displays if no number is input in new member name text box is empty
            MessageBox.Show("Please enter a name", "Error")
        End If
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click 'Confirms attendance name and detail
        attendance = File.AppendText("attendanceLog.txt") 'Opens file
        attendance.Write(cmbMembers.Text) 'Writes selected name to attendanceLog.Txt
        If radPresent.Checked = True Then 'Checks the specified detail, writes it then closes the file
            attendance.Write(": Present")
            attendance.WriteLine()
            attendance.Close()
        End If
        If radExcused.Checked = True Then 'Checks the specified detail, writes it then closes the file
            reason = InputBox("Reason for absence", "Excused Absence", "Undisclosed")
            attendance.Write(": Excused absence because " + reason)
            attendance.WriteLine()
            attendance.Close()
        End If
        If radUnexcused.Checked = True Then 'Checks the specified detail, writes it then closes the file
            attendance.Write(": Unexcused absence")
            attendance.WriteLine()
            attendance.Close()
        End If
    End Sub
    Private Sub attendanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try 'Tries to write the date to attendanceLog.txt
            attendance = File.AppendText("attendanceLog.txt")
            attendance.Write(Date.Today.ToString("dd/MM/yyyy"))
            attendance.Flush()
        Catch 'If file is unable to open, this message appears (common error in testing, seems to have been fixed)
            MessageBox.Show("File access denied", "Error")
        End Try
        cmbMembers.Items.AddRange(File.ReadAllLines("memberList.txt")) 'Writes members list to combobox
    End Sub

    Private Sub btnType_Click(sender As Object, e As EventArgs) Handles btnType.Click 'Picks the meeting type and then allows access to other groupboxes
        If chkBusiness.Checked = True Then
            attendance.Write(" with Business Meeting")
            noCheck = False
        End If
        If chkKappa.Checked = True Then
            attendance.Write(" with Kappa Session")
            noCheck = False
        End If
        If chkElection.Checked = True Then
            attendance.Write(" with Election")
            noCheck = False
        End If
        If noCheck = True Then
            MessageBox.Show("Please select a meeting type", "Error")
        Else
            grpMember.Visible = True
            grpDetails.Visible = True
            grpType.Enabled = False
            grpGuest.Visible = True
            grpList.Visible = True
            grpNew.Visible = True
            attendance.WriteLine()
            attendance.Close()
        End If
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click 'Puts the name in the text box into the guest list
        lstGuest.Items.Add(txtGuest.Text)
        txtGuest.Text = ""
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click 'Exports the guest list to the attendanceLog.txt file
        attendance = File.AppendText("attendanceLog.txt")
        attendance.WriteLine("Guests:")
        loops = 0
        While loops < lstGuest.Items.Count
            attendance.WriteLine(lstGuest.Items.Item(loops))
            loops = loops + 1
        End While
        attendance.Close()
    End Sub
End Class
