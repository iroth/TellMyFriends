Imports System.Runtime.InteropServices
Imports System.Windows.Automation
Imports System.Globalization
Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports System.Text
Imports System.Diagnostics.Eventing.Reader
Imports System.Net.Mime.MediaTypeNames
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Text.RegularExpressions
Imports Microsoft.Win32

Public Class Form1

    Public Class MessageEntry

        Public Sub New(ByVal name As String, ByVal phone As String, ByVal template As String)
            _name = name
            _phone = phone
            _template = template
        End Sub

        Private _name As String
        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property

        Private _phone As String
        Public Property Phone() As String
            Get
                Return _phone
            End Get
            Set(ByVal value As String)
                _phone = value
            End Set
        End Property

        Private _template As String
        Public Property Template() As String
            Get
                Return _template
            End Get
            Set(ByVal value As String)
                _template = value
            End Set
        End Property

    End Class

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function SetForegroundWindow(ByVal point As IntPtr) As Integer
    End Function

    <DllImport("User32", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function ShowWindow(ByVal hWnd As Integer, ByVal nCmdShow As Integer) As Integer
    End Function


    Private defaultBrowserProcessName = "msedge"

    Private Function getDefaultBrowser() As String
        Dim browser As String = String.Empty
        Dim key As RegistryKey = Nothing
        Try
            key = Registry.ClassesRoot.OpenSubKey("HTTP\shell\open\command", False)

            'trim off quotes
            browser = key.GetValue(Nothing).ToString().ToLower().Replace("""", "")
            If Not browser.EndsWith("exe") Then
                'get rid of everything after the ".exe"
                browser = browser.Substring(0, browser.LastIndexOf(".exe") + 4)
            End If
        Finally
            If key IsNot Nothing Then
                key.Close()
            End If
        End Try
        Return browser
    End Function

    Private Function ReadTemplateFile(templateFilePath) As String
        Dim fileBytes As Byte()
        ' Read the file containing UTF-8 encoded text
        fileBytes = System.IO.File.ReadAllBytes(templateFilePath)
        Dim s As String = System.Text.Encoding.UTF8.GetString(fileBytes)
        Return s
    End Function

    Private Function GetFrontTabURL() As String
        Dim procsEdge() As Process = System.Diagnostics.Process.GetProcessesByName(defaultBrowserProcessName)
        For Each proc As Process In procsEdge
            If proc.MainWindowHandle = IntPtr.Zero Then
                Continue For
            End If
            Dim TabUrl As String = String.Empty
            Dim root As AutomationElement = AutomationElement.FromHandle(proc.MainWindowHandle)
            Dim condTabItem As Condition = New PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.TabItem)
            For Each tabitem As AutomationElement In root.FindAll(TreeScope.Subtree, condTabItem)
                Dim searchBar = root.FindFirst(TreeScope.Descendants, New PropertyCondition(AutomationElement.NameProperty, "Address and search bar"))
                TabUrl = searchBar.GetCurrentPropertyValue(ValuePatternIdentifiers.ValueProperty)
                Return TabUrl
            Next
        Next
        Return "-"
    End Function
    Private Function WhatsAppTabStillOpen() As Boolean
        Dim procsEdge() As Process = System.Diagnostics.Process.GetProcessesByName(defaultBrowserProcessName)
        For Each proc As Process In procsEdge
            If proc.MainWindowHandle = IntPtr.Zero Then
                Continue For
            End If
            Dim TabUrl As String = String.Empty
            Dim root As AutomationElement = AutomationElement.FromHandle(proc.MainWindowHandle)
            Try
                Dim condTabItem As Condition = New PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.TabItem)
                For Each tabitem As AutomationElement In root.FindAll(TreeScope.Subtree, condTabItem)
                    Dim searchBar = root.FindFirst(TreeScope.Descendants, New PropertyCondition(AutomationElement.NameProperty, "Address and search bar"))
                    TabUrl = searchBar.GetCurrentPropertyValue(ValuePatternIdentifiers.ValueProperty)
                    Dim ci As CultureInfo = New CultureInfo("en-US")
                    Dim webWhatsApp As String = "https://web.whatsapp.com"
                    If TabUrl.StartsWith(webWhatsApp, False, ci) Then
                        Return True
                    End If
                    Exit For ' check only first tab item
                Next
            Catch ex As Exception
                Return False
            End Try
        Next
        Return False
    End Function

    Private Sub SendToWhatsApp(name As String, phone As String, text As String)
        Dim findString As String = "FNAME"
        Dim templatePopulatedContent As String = text.Replace(findString, name)
        Dim templateContentEncoded = System.Uri.EscapeDataString(templatePopulatedContent)
        Console.WriteLine(String.Format("{0} - {1} - {2}", name, phone, "-"))
        Dim psi As ProcessStartInfo = New ProcessStartInfo
        psi.FileName = "https://web.whatsapp.com/send/?phone=" + phone + "&text=" + templateContentEncoded + "&type=phone_number"
        psi.UseShellExecute = True
        Process.Start(psi)
        While WhatsAppTabStillOpen()
            Threading.Thread.Sleep(1000)
        End While
    End Sub
    Private Sub LoadDataAndRun(filePath As String)
        Dim dirPath As String = Path.GetDirectoryName(filePath)
        Dim tfp As TextFieldParser = New TextFieldParser(filePath, Encoding.UTF8)
        tfp.Delimiters = New String() {","}
        tfp.TextFieldType = FieldType.Delimited
        Dim name As String
        Dim phone As String
        Dim template As String
        Dim templateDict As Dictionary(Of String, String) = New Dictionary(Of String, String)
        tfp.ReadLine() ' skip header
        Dim numSent As Integer = 0
        While tfp.EndOfData = False
            Dim fields = tfp.ReadFields()
            name = fields(0)
            phone = fields(1)
            template = fields(2)
            If Not templateDict.ContainsKey(template) Then
                Dim templateFilePath As String = Path.Combine(dirPath, template)
                Dim templateContent As String = ReadTemplateFile(templateFilePath)
                templateDict.Add(template, templateContent)
            End If
            SendToWhatsApp(name, phone, templateDict(template))
            numSent = numSent + 1
            numMessagesLabel.Text = numSent
        End While
    End Sub
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        LoadDataAndRun(folderPathLabel.Text)
    End Sub

    Private Sub LoadDataToTable(filePath As String)
        Dim list = New List(Of MessageEntry)
        Dim tfp As TextFieldParser = New TextFieldParser(filePath, Encoding.UTF8)
        tfp.Delimiters = New String() {","}
        tfp.TextFieldType = FieldType.Delimited
        Dim name As String
        Dim phone As String
        Dim template As String
        tfp.ReadLine() ' skip header
        While tfp.EndOfData = False
            Dim fields = tfp.ReadFields()
            name = fields(0)
            phone = fields(1)
            template = fields(2)
            list.Add(New MessageEntry(name, phone, template))
        End While
        DataGridView1.DataSource = list
    End Sub
    Private Sub SelectFileButton_Click(sender As Object, e As EventArgs) Handles SelectFileButton.Click
        ' Call ShowDialog.
        Dim OpenFileDialog1 As OpenFileDialog = New OpenFileDialog
        OpenFileDialog1.Filter = "CSV files (*.csv)|*.csv"
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        ' Test result.
        If result = Windows.Forms.DialogResult.OK Then
            ' Get the file name.
            folderPathLabel.Text = OpenFileDialog1.FileName
            LoadDataToTable(OpenFileDialog1.FileName)
            StartButton.Enabled = True
        End If

    End Sub

    Private Sub DefaultBrowserCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DefaultBrowserCombo.SelectedIndexChanged
        If DefaultBrowserCombo.SelectedItem.ToString.StartsWith("M") Then
            defaultBrowserProcessName = "msedge"
        Else
            defaultBrowserProcessName = "chrome"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim psi As ProcessStartInfo = New ProcessStartInfo
        psi.FileName = "https://www.apple.com"
        psi.UseShellExecute = True
        Process.Start(psi)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles GetURLFront.Click
        Dim url As String = GetFrontTabURL()
        FrontTabURL.Text = url
    End Sub
End Class
