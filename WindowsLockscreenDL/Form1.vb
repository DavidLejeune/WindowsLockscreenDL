Imports System
Imports System.IO
Imports System.Collections.Generic


Public Class Form1

    Dim iTick As Integer = 66
    Dim sUser As String = Environment.UserName
    Dim sOrigin As String = "C:\Users\" & sUser & "\AppData\Local\Packages\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets\"
    Dim sTarget As String = "C:\Users\" & sUser & "\Pictures\Windows Lockscreens\"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.downloads_9
        HideStuff()
        txtIntro.ReadOnly = True

    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        ShowIntro()
        'start main method
        ImportThePictures()


    End Sub
    Sub ImportThePictures()
        txtCmd.Show()
        txtCmd.ForeColor = Color.Blue

        'counters
        Dim iCount As Integer = 0
        Dim iNew As Integer = 0
        Dim iDiscarded As Integer = 0
        Dim iFound As Integer = 0

        'check username
        txtCmd.AppendText("Username : " & Environment.UserName & vbCrLf)
        Threading.Thread.Sleep(iTick)

        'check if origin folder and targetfolder exist
        If My.Computer.FileSystem.DirectoryExists(sOrigin) Then
            Threading.Thread.Sleep(iTick)
            txtCmd.AppendText("Origin folder found." & vbCrLf)
            If My.Computer.FileSystem.DirectoryExists(sTarget) Then
                txtCmd.AppendText("Target folder found." & vbCrLf)
            Else
                Directory.CreateDirectory(sTarget)
                txtCmd.AppendText("Target folder created." & vbCrLf)
            End If
            Threading.Thread.Sleep(iTick * 4)


            Dim sFile As String = ""
            Dim sLastFile As String = ""
            Dim di As New DirectoryInfo(sOrigin)
            ' Get a reference to each file in that directory.
            Dim fiArr As FileInfo() = di.GetFiles()
            ' Display the names of the files.
            Dim fri As FileInfo


            'remove the unwanted lines to give the illusion of coolness
            Dim newList As List(Of String) = txtCmd.Lines.ToList
            newList.RemoveAt(0)
            txtCmd.Lines = newList.ToArray

            For Each fri In fiArr
                iCount += 1
                sFile = fri.Name
                sFile = sFile.Substring(0, 10)
                Dim sText As String = ""

                'check if correct dimension 1920*1080
                Dim bmp As New Bitmap(fri.FullName)
                Dim bDimOK As Boolean = False
                If bmp.Width.ToString = "1920" And bmp.Height.ToString = "1080" Then
                    bDimOK = True
                Else
                    iDiscarded += 1
                    sText = "Discarded"
                End If

                'check if the file exists
                Dim sTargetFile As String = sTarget & sFile & ".jpg"
                Dim sOriginFile As String = sOrigin & fri.Name
                If My.Computer.FileSystem.FileExists(sTargetFile) Then
                    iFound += 1
                    sText = "Exist"
                Else
                    If bDimOK = True Then
                        sText = "*New"
                        iNew += 1
                        'copy the file
                        If System.IO.File.Exists(sOriginFile) = True Then

                            System.IO.File.Copy(sOriginFile, sTargetFile)

                        End If
                    End If
                End If

                txtCmd.Text = ""
                txtCmd.AppendText("File " & sFile.Substring(0, 10) & "   " & sText & vbCrLf)
                txtCmd.AppendText(vbTab & "Total file(s) : " & iCount & vbCrLf)
                txtCmd.AppendText(vbTab & "New file(s) : " & iNew & vbCrLf)
                txtCmd.AppendText(vbTab & "Discarded file(s) : " & iDiscarded & vbCrLf)
                txtCmd.AppendText(vbTab & "Existing file(s) : " & iFound & vbCrLf)
                txtCmd.ReadOnly = True
                Threading.Thread.Sleep(iTick)
                Me.Refresh()



            Next fri

            txtCmd.ForeColor = Color.Yellow
            txtCmd.Text = "FINAL RESULT : " & vbCrLf
            txtCmd.AppendText(vbTab & "Total file(s) : " & iCount & vbCrLf)
            txtCmd.AppendText(vbTab & "New file(s) : " & iNew & vbCrLf)
            txtCmd.AppendText(vbTab & "Discarded file(s) : " & iDiscarded & vbCrLf)
            txtCmd.AppendText(vbTab & "Existing file(s) : " & iFound & vbCrLf)
            PictureBoxFolder.Image = My.Resources.Places_folder_windows_icon
            Me.Refresh()
            Timer1.Start()



        Else
            'exit if no origin folder exist
            txtCmd.AppendText("Aborting , origin folder " & sOrigin & " Not found." & vbCrLf)
            Threading.Thread.Sleep(10500)
            Me.Close()
        End If



    End Sub





    Sub HideStuff()
        txtCmd.Hide()
    End Sub
    Sub ShowIntro()
        ' A little bit of narcissism / brand imaging
        PictureBoxLogo.Show()
        PictureBoxLogo.Select()
        txtIntro.Text = "Windows Lockscreen Downloader"
        txtIntro.Show()
        Me.Refresh()
        Threading.Thread.Sleep(3500)
        PictureBoxLogo.Hide()
        txtIntro.Hide()
        Me.Refresh()

    End Sub

    Private Sub PictureBoxFolder_Click(sender As Object, e As EventArgs) Handles PictureBoxFolder.Click
        Process.Start(sTarget)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()

    End Sub
End Class
