Imports System.Net.NetworkInformation
Imports AForge.Video.DirectShow

Public Class Selfie
    Public CapturedImage As Image = Nothing

    ' Your camera/video setup here
    Private videoSource As VideoCaptureDevice

    Private Sub SelfieForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim videoDevices As New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If videoDevices.Count = 0 Then
            MsgBox("No camera found!")
            Return
        End If
        videoSource = New VideoCaptureDevice(videoDevices(0).MonikerString)
        AddHandler videoSource.NewFrame, AddressOf Video_NewFrame
        videoSource.Start()
    End Sub

    Private Sub Video_NewFrame(sender As Object, e As AForge.Video.NewFrameEventArgs)
        PicBox.Image = CType(e.Frame.Clone(), Bitmap)
    End Sub

    ' Capture button
    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        If PicBox.Image IsNot Nothing Then
            ' Make a deep copy of the current frame
            CapturedImage = New Bitmap(PicBox.Image)
            MsgBox("Photo captured!")
        End If
    End Sub


    ' BACK button
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Stop camera properly
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            videoSource.SignalToStop()
            videoSource.WaitForStop()
        End If

        Me.Close()
    End Sub

End Class
