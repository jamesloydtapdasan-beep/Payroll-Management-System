Imports AForge.Controls
Imports AForge.Video
Imports AForge.Video.DirectShow


Public Class frmCameraSelfie
    Private callingForm As FormFullDetailed

    Public Sub New(caller As FormFullDetailed)
        ' This call is required by the designer.
        InitializeComponent()

        ' Save reference to caller
        callingForm = caller
    End Sub
    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        If picPreview.Image IsNot Nothing Then
            Dim snapshot As Bitmap = New Bitmap(picPreview.Image)

            Dim folderPath As String = "C:\Temp"
            Dim filePath As String = System.IO.Path.Combine(folderPath, "Selfie.jpg")

            ' Check if directory exists, create if missing
            If Not System.IO.Directory.Exists(folderPath) Then
                System.IO.Directory.CreateDirectory(folderPath)
            End If

            ' Save the snapshot safely
            snapshot.Save(filePath, Imaging.ImageFormat.Jpeg)

            MessageBox.Show("Snapshot saved at " & filePath)
        Else
            MessageBox.Show("No image to capture.")
        End If
    End Sub



    Private videoDevices As FilterInfoCollection
    Private videoSource As VideoCaptureDevice

    Private Sub frmCameraSelfie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If videoDevices.Count > 0 Then
            ' Find front camera by name if available, else default to 0
            Dim frontCamIndex As Integer = -1
            For i As Integer = 0 To videoDevices.Count - 1
                Dim devName As String = videoDevices(i).Name.ToLower()
                If devName.Contains("front") OrElse devName.Contains("integrated") Then
                    frontCamIndex = i
                    Exit For
                End If
            Next

            Dim camToUseIndex As Integer = If(frontCamIndex >= 0, frontCamIndex, 0)

            videoSource = New VideoCaptureDevice(videoDevices(camToUseIndex).MonikerString)
            AddHandler videoSource.NewFrame, AddressOf videoSource_NewFrame
            videoSource.Start()
        Else
            MessageBox.Show("No camera found!")
        End If
    End Sub

    Private Sub videoSource_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        ' This runs on a separate thread! Use Invoke if updating UI.
        Dim bitmap As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)

        ' Update your PictureBox safely on the UI thread:
        If picPreview.InvokeRequired Then
            picPreview.Invoke(Sub() picPreview.Image = bitmap)
        Else
            picPreview.Image = bitmap
        End If
    End Sub



    Private Sub video_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        Dim frame As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)

        ' Update PictureBox on UI thread safely
        picPreview.Invoke(Sub() picPreview.Image = frame)
    End Sub

    Private Sub frmCameraSelfie_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            videoSource.SignalToStop()
            videoSource.WaitForStop()
        End If
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' First, stop the webcam safely
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            videoSource.SignalToStop()
            videoSource.WaitForStop()
        End If

        ' Grab the current frame from PictureBox
        If picPreview.Image IsNot Nothing Then
            Dim capturedImage As Bitmap = New Bitmap(picPreview.Image)

            ' Send image to FormFullDetailed
            ' Assuming FormFullDetailed is open and has a method/property for this
            Dim fullForm As FormFullDetailed = CType(Application.OpenForms("FormFullDetailed"), FormFullDetailed)
            If fullForm IsNot Nothing Then
                fullForm.ReceiveCapturedImage(capturedImage)
            Else
                MessageBox.Show("FormFullDetailed is not open!")
            End If
        Else
            MessageBox.Show("No image captured!")
        End If

        ' Close this form
        Me.Close()
    End Sub


End Class