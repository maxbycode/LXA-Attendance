<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class attendanceForm
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
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.radUnexcused = New System.Windows.Forms.RadioButton()
        Me.radExcused = New System.Windows.Forms.RadioButton()
        Me.radPresent = New System.Windows.Forms.RadioButton()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.cmbMembers = New System.Windows.Forms.ComboBox()
        Me.txtNewNumber = New System.Windows.Forms.TextBox()
        Me.txtNewName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpNew = New System.Windows.Forms.GroupBox()
        Me.btnAddMember = New System.Windows.Forms.Button()
        Me.grpGuest = New System.Windows.Forms.GroupBox()
        Me.btnGuest = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGuest = New System.Windows.Forms.TextBox()
        Me.lstGuest = New System.Windows.Forms.ListBox()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.chkKappa = New System.Windows.Forms.CheckBox()
        Me.chkElection = New System.Windows.Forms.CheckBox()
        Me.chkBusiness = New System.Windows.Forms.CheckBox()
        Me.btnType = New System.Windows.Forms.Button()
        Me.grpList = New System.Windows.Forms.GroupBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpMember = New System.Windows.Forms.GroupBox()
        Me.grpDetails.SuspendLayout()
        Me.grpNew.SuspendLayout()
        Me.grpGuest.SuspendLayout()
        Me.grpType.SuspendLayout()
        Me.grpList.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMember.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDetails
        '
        Me.grpDetails.Controls.Add(Me.radUnexcused)
        Me.grpDetails.Controls.Add(Me.radExcused)
        Me.grpDetails.Controls.Add(Me.radPresent)
        Me.grpDetails.Controls.Add(Me.btnConfirm)
        Me.grpDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpDetails.Location = New System.Drawing.Point(273, 12)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(112, 127)
        Me.grpDetails.TabIndex = 0
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Attendance Details"
        Me.grpDetails.Visible = False
        '
        'radUnexcused
        '
        Me.radUnexcused.AutoSize = True
        Me.radUnexcused.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radUnexcused.Location = New System.Drawing.Point(11, 62)
        Me.radUnexcused.Name = "radUnexcused"
        Me.radUnexcused.Size = New System.Drawing.Size(78, 17)
        Me.radUnexcused.TabIndex = 2
        Me.radUnexcused.TabStop = True
        Me.radUnexcused.Text = "Unexcused"
        Me.radUnexcused.UseVisualStyleBackColor = True
        '
        'radExcused
        '
        Me.radExcused.AutoSize = True
        Me.radExcused.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radExcused.Location = New System.Drawing.Point(11, 41)
        Me.radExcused.Name = "radExcused"
        Me.radExcused.Size = New System.Drawing.Size(65, 17)
        Me.radExcused.TabIndex = 1
        Me.radExcused.TabStop = True
        Me.radExcused.Text = "Excused"
        Me.radExcused.UseVisualStyleBackColor = True
        '
        'radPresent
        '
        Me.radPresent.AutoSize = True
        Me.radPresent.Checked = True
        Me.radPresent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radPresent.Location = New System.Drawing.Point(11, 20)
        Me.radPresent.Name = "radPresent"
        Me.radPresent.Size = New System.Drawing.Size(60, 17)
        Me.radPresent.TabIndex = 0
        Me.radPresent.TabStop = True
        Me.radPresent.Text = "Present"
        Me.radPresent.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Location = New System.Drawing.Point(11, 92)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(77, 23)
        Me.btnConfirm.TabIndex = 12
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'cmbMembers
        '
        Me.cmbMembers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMembers.FormattingEnabled = True
        Me.cmbMembers.Location = New System.Drawing.Point(10, 17)
        Me.cmbMembers.Name = "cmbMembers"
        Me.cmbMembers.Size = New System.Drawing.Size(244, 150)
        Me.cmbMembers.TabIndex = 3
        '
        'txtNewNumber
        '
        Me.txtNewNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewNumber.Location = New System.Drawing.Point(6, 74)
        Me.txtNewNumber.Name = "txtNewNumber"
        Me.txtNewNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtNewNumber.TabIndex = 5
        '
        'txtNewName
        '
        Me.txtNewName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewName.Location = New System.Drawing.Point(6, 35)
        Me.txtNewName.Name = "txtNewName"
        Me.txtNewName.Size = New System.Drawing.Size(100, 20)
        Me.txtNewName.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Member Number"
        '
        'grpNew
        '
        Me.grpNew.Controls.Add(Me.btnAddMember)
        Me.grpNew.Controls.Add(Me.txtNewNumber)
        Me.grpNew.Controls.Add(Me.Label2)
        Me.grpNew.Controls.Add(Me.Label3)
        Me.grpNew.Controls.Add(Me.txtNewName)
        Me.grpNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpNew.Location = New System.Drawing.Point(17, 192)
        Me.grpNew.Name = "grpNew"
        Me.grpNew.Size = New System.Drawing.Size(200, 100)
        Me.grpNew.TabIndex = 9
        Me.grpNew.TabStop = False
        Me.grpNew.Text = "Add New Member"
        Me.grpNew.Visible = False
        '
        'btnAddMember
        '
        Me.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddMember.Location = New System.Drawing.Point(115, 40)
        Me.btnAddMember.Name = "btnAddMember"
        Me.btnAddMember.Size = New System.Drawing.Size(75, 48)
        Me.btnAddMember.TabIndex = 10
        Me.btnAddMember.Text = "Add Member"
        Me.btnAddMember.UseVisualStyleBackColor = True
        '
        'grpGuest
        '
        Me.grpGuest.Controls.Add(Me.btnGuest)
        Me.grpGuest.Controls.Add(Me.Label4)
        Me.grpGuest.Controls.Add(Me.txtGuest)
        Me.grpGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpGuest.Location = New System.Drawing.Point(517, 12)
        Me.grpGuest.Name = "grpGuest"
        Me.grpGuest.Size = New System.Drawing.Size(122, 100)
        Me.grpGuest.TabIndex = 9
        Me.grpGuest.TabStop = False
        Me.grpGuest.Text = "Add guest"
        Me.grpGuest.Visible = False
        '
        'btnGuest
        '
        Me.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuest.Location = New System.Drawing.Point(25, 66)
        Me.btnGuest.Name = "btnGuest"
        Me.btnGuest.Size = New System.Drawing.Size(75, 23)
        Me.btnGuest.TabIndex = 11
        Me.btnGuest.Text = "Add Guest"
        Me.btnGuest.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Guest Name"
        '
        'txtGuest
        '
        Me.txtGuest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGuest.Location = New System.Drawing.Point(12, 40)
        Me.txtGuest.Name = "txtGuest"
        Me.txtGuest.Size = New System.Drawing.Size(100, 20)
        Me.txtGuest.TabIndex = 0
        '
        'lstGuest
        '
        Me.lstGuest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstGuest.FormattingEnabled = True
        Me.lstGuest.Location = New System.Drawing.Point(6, 20)
        Me.lstGuest.Name = "lstGuest"
        Me.lstGuest.Size = New System.Drawing.Size(110, 119)
        Me.lstGuest.TabIndex = 10
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.chkKappa)
        Me.grpType.Controls.Add(Me.chkElection)
        Me.grpType.Controls.Add(Me.chkBusiness)
        Me.grpType.Controls.Add(Me.btnType)
        Me.grpType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpType.Location = New System.Drawing.Point(390, 12)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(122, 127)
        Me.grpType.TabIndex = 13
        Me.grpType.TabStop = False
        Me.grpType.Text = "Type of meeting"
        '
        'chkKappa
        '
        Me.chkKappa.AutoSize = True
        Me.chkKappa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkKappa.Location = New System.Drawing.Point(12, 42)
        Me.chkKappa.Name = "chkKappa"
        Me.chkKappa.Size = New System.Drawing.Size(92, 17)
        Me.chkKappa.TabIndex = 15
        Me.chkKappa.Text = "Kappa session"
        Me.chkKappa.UseVisualStyleBackColor = True
        '
        'chkElection
        '
        Me.chkElection.AutoSize = True
        Me.chkElection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkElection.Location = New System.Drawing.Point(12, 66)
        Me.chkElection.Name = "chkElection"
        Me.chkElection.Size = New System.Drawing.Size(106, 17)
        Me.chkElection.TabIndex = 16
        Me.chkElection.Text = "Election was held"
        Me.chkElection.UseVisualStyleBackColor = True
        '
        'chkBusiness
        '
        Me.chkBusiness.AutoSize = True
        Me.chkBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBusiness.Location = New System.Drawing.Point(12, 19)
        Me.chkBusiness.Name = "chkBusiness"
        Me.chkBusiness.Size = New System.Drawing.Size(105, 17)
        Me.chkBusiness.TabIndex = 14
        Me.chkBusiness.Text = "Business meeting"
        Me.chkBusiness.UseVisualStyleBackColor = True
        '
        'btnType
        '
        Me.btnType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnType.Location = New System.Drawing.Point(18, 85)
        Me.btnType.Name = "btnType"
        Me.btnType.Size = New System.Drawing.Size(84, 36)
        Me.btnType.TabIndex = 14
        Me.btnType.Text = "Select meeting type"
        Me.btnType.UseVisualStyleBackColor = True
        '
        'grpList
        '
        Me.grpList.Controls.Add(Me.btnExport)
        Me.grpList.Controls.Add(Me.lstGuest)
        Me.grpList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpList.Location = New System.Drawing.Point(518, 118)
        Me.grpList.Name = "grpList"
        Me.grpList.Size = New System.Drawing.Size(122, 174)
        Me.grpList.TabIndex = 15
        Me.grpList.TabStop = False
        Me.grpList.Text = "Guest List"
        Me.grpList.Visible = False
        '
        'btnExport
        '
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Location = New System.Drawing.Point(6, 145)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(110, 23)
        Me.btnExport.TabIndex = 11
        Me.btnExport.Text = "Export Guests"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.lambdaChiAttendance.My.Resources.Resources.flag
        Me.PictureBox1.Location = New System.Drawing.Point(273, 145)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(239, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!)
        Me.Label5.Location = New System.Drawing.Point(433, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 7)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Alpha Build, Creative Commons BY-NC Alexander Hamilton 2014"
        '
        'grpMember
        '
        Me.grpMember.Controls.Add(Me.cmbMembers)
        Me.grpMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpMember.Location = New System.Drawing.Point(7, 12)
        Me.grpMember.Name = "grpMember"
        Me.grpMember.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpMember.Size = New System.Drawing.Size(260, 168)
        Me.grpMember.TabIndex = 18
        Me.grpMember.TabStop = False
        Me.grpMember.Text = "Select Member and Number"
        Me.grpMember.Visible = False
        '
        'attendanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 308)
        Me.Controls.Add(Me.grpMember)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpList)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.grpGuest)
        Me.Controls.Add(Me.grpNew)
        Me.Controls.Add(Me.grpDetails)
        Me.Name = "attendanceForm"
        Me.Text = "Lambda Chi Attendance - Version 0.0.2"
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.grpNew.ResumeLayout(False)
        Me.grpNew.PerformLayout()
        Me.grpGuest.ResumeLayout(False)
        Me.grpGuest.PerformLayout()
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.grpList.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMember.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents radUnexcused As System.Windows.Forms.RadioButton
    Friend WithEvents radExcused As System.Windows.Forms.RadioButton
    Friend WithEvents radPresent As System.Windows.Forms.RadioButton
    Friend WithEvents cmbMembers As System.Windows.Forms.ComboBox
    Friend WithEvents txtNewNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtNewName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grpNew As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddMember As System.Windows.Forms.Button
    Friend WithEvents grpGuest As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuest As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGuest As System.Windows.Forms.TextBox
    Friend WithEvents lstGuest As System.Windows.Forms.ListBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents grpType As System.Windows.Forms.GroupBox
    Friend WithEvents chkKappa As System.Windows.Forms.CheckBox
    Friend WithEvents chkElection As System.Windows.Forms.CheckBox
    Friend WithEvents chkBusiness As System.Windows.Forms.CheckBox
    Friend WithEvents btnType As System.Windows.Forms.Button
    Friend WithEvents grpList As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grpMember As System.Windows.Forms.GroupBox
    Friend WithEvents btnExport As System.Windows.Forms.Button

End Class
