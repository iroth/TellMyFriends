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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SelectFileButton = New System.Windows.Forms.Button()
        Me.folderPathLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numMessagesLabel = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DefaultBrowserCombo = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GetURLFront = New System.Windows.Forms.Button()
        Me.FrontTabURL = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tell My Friends On WhatsApp"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select Data File:"
        '
        'StartButton
        '
        Me.StartButton.Enabled = False
        Me.StartButton.Location = New System.Drawing.Point(1133, 259)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(202, 23)
        Me.StartButton.TabIndex = 2
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 3
        '
        'SelectFileButton
        '
        Me.SelectFileButton.Location = New System.Drawing.Point(175, 60)
        Me.SelectFileButton.Name = "SelectFileButton"
        Me.SelectFileButton.Size = New System.Drawing.Size(106, 23)
        Me.SelectFileButton.TabIndex = 4
        Me.SelectFileButton.Text = "Select Data File"
        Me.SelectFileButton.UseVisualStyleBackColor = True
        '
        'folderPathLabel
        '
        Me.folderPathLabel.AutoSize = True
        Me.folderPathLabel.Location = New System.Drawing.Point(304, 65)
        Me.folderPathLabel.Name = "folderPathLabel"
        Me.folderPathLabel.Size = New System.Drawing.Size(61, 13)
        Me.folderPathLabel.TabIndex = 5
        Me.folderPathLabel.Text = "Folder Path"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Messages Sent:"
        '
        'numMessagesLabel
        '
        Me.numMessagesLabel.AutoSize = True
        Me.numMessagesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numMessagesLabel.Location = New System.Drawing.Point(151, 268)
        Me.numMessagesLabel.Name = "numMessagesLabel"
        Me.numMessagesLabel.Size = New System.Drawing.Size(16, 17)
        Me.numMessagesLabel.TabIndex = 7
        Me.numMessagesLabel.Text = "0"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.Location = New System.Drawing.Point(24, 297)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.Size = New System.Drawing.Size(1311, 535)
        Me.DataGridView1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "How to Use:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(126, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(480, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Create a CSV file with a header row, and the fields: name, phone, template."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(126, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(890, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "The CSV file should be stored in a folder alongside the text template files. Temp" &
    "late files are referenced from the csv file as ""template-file.txt"""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(126, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(290, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Example Files are shown in the blog articles: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label9.Location = New System.Drawing.Point(422, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(619, 17)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "https://www.srooltheknife.com/2024/02/automating-whatsapp-part-2-on-windows.html"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(126, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1055, 17)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "In the TellMyFriends app, click ""select data file"" and point to the CSV file. Onc" &
    "e you do, a preview of the records will be shown. Click on Start to start sendin" &
    "g messages"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(126, 201)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1026, 17)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Before you start, make sure Microsoft Edge is the default browser and that you ar" &
    "e connected to WhatsApp web in the browser session. Close any whatsapp tabs."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(947, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 17)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Default Browser:"
        Me.Label12.Visible = False
        '
        'DefaultBrowserCombo
        '
        Me.DefaultBrowserCombo.FormattingEnabled = True
        Me.DefaultBrowserCombo.Items.AddRange(New Object() {"Microsoft Edge", "Google Chrome"})
        Me.DefaultBrowserCombo.Location = New System.Drawing.Point(1098, 84)
        Me.DefaultBrowserCombo.Name = "DefaultBrowserCombo"
        Me.DefaultBrowserCombo.Size = New System.Drawing.Size(121, 21)
        Me.DefaultBrowserCombo.TabIndex = 17
        Me.DefaultBrowserCombo.Text = "Microsoft Edge"
        Me.DefaultBrowserCombo.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(950, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Open Browser"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'GetURLFront
        '
        Me.GetURLFront.Location = New System.Drawing.Point(950, 44)
        Me.GetURLFront.Name = "GetURLFront"
        Me.GetURLFront.Size = New System.Drawing.Size(118, 23)
        Me.GetURLFront.TabIndex = 19
        Me.GetURLFront.Text = "Get Front Tab URL"
        Me.GetURLFront.UseVisualStyleBackColor = True
        Me.GetURLFront.Visible = False
        '
        'FrontTabURL
        '
        Me.FrontTabURL.AutoSize = True
        Me.FrontTabURL.Location = New System.Drawing.Point(1075, 53)
        Me.FrontTabURL.Name = "FrontTabURL"
        Me.FrontTabURL.Size = New System.Drawing.Size(10, 13)
        Me.FrontTabURL.TabIndex = 20
        Me.FrontTabURL.Text = "-"
        Me.FrontTabURL.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1347, 844)
        Me.Controls.Add(Me.FrontTabURL)
        Me.Controls.Add(Me.GetURLFront)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DefaultBrowserCombo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.numMessagesLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.folderPathLabel)
        Me.Controls.Add(Me.SelectFileButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents StartButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents SelectFileButton As Button
    Friend WithEvents folderPathLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents numMessagesLabel As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DefaultBrowserCombo As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GetURLFront As Button
    Friend WithEvents FrontTabURL As Label
End Class
