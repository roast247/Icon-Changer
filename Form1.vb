Public Class Form1
    Private draggable As Boolean
    Private mouseY As Integer
    Private mouseX As Integer
    Dim ico As New OpenFileDialog
    Dim exe As New OpenFileDialog
    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles Closebtn.Click
        Close()
    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        draggable = False
    End Sub
    Private Sub RoastingLabel_MouseDown(sender As Object, e As MouseEventArgs) Handles RoastingLabel.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub RoastingLabel_MouseMove(sender As Object, e As MouseEventArgs) Handles RoastingLabel.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub RoastingLabel_MouseUp(sender As Object, e As MouseEventArgs) Handles RoastingLabel.MouseUp
        draggable = False
    End Sub
    Private Sub RoastingPic_MouseDown(sender As Object, e As MouseEventArgs) Handles RoastingPic.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub RoastingPic_MouseMove(sender As Object, e As MouseEventArgs) Handles RoastingPic.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub RoastingPic_MouseUp(sender As Object, e As MouseEventArgs) Handles RoastingPic.MouseUp
        draggable = False
    End Sub

    Private Sub addico_Click(sender As Object, e As EventArgs) Handles addico.Click
        OpenFileDialog1.DefaultExt = "ico"
        OpenFileDialog1.Filter = "Icon(*.ico)|*.ico"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            TextBox1.Text = String.Empty
            TextBox1.Text = OpenFileDialog1.FileName
        End If
        Dim icon As Icon = Icon.ExtractAssociatedIcon(OpenFileDialog1.FileName)
            pictureBox1.BackgroundImage = icon.ToBitmap
        pictureBox1.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub addexe_Click(sender As Object, e As EventArgs) Handles addexe.Click
        OpenFileDialog1.DefaultExt = "exe"
        OpenFileDialog1.Filter = "Application(*.exe)|*.exe"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            TextBox2.Text = String.Empty
            TextBox2.Text = OpenFileDialog1.FileName
        End If
    End Sub
    Private Function LoadIconFromFile(ByVal fileName As String) As Icon
        Return New Icon(fileName) ' New Size(48, 48))
    End Function
    Private Sub changeico_Click(sender As Object, e As EventArgs) Handles changeico.Click
        If TextBox2.Text = "" Then
            MsgBox("You must pick an EXE File")
        End If
        If TextBox2.Text = "" Then Exit Sub

        If TextBox1.Text = "" Then Exit Sub

        IconInjector.InjectIcon(TextBox2.Text, TextBox1.Text)
        Dim pros As Process()
        pros = Process.GetProcesses()
        For Each pro As Process In pros
            If pro.ProcessName.ToLower().IndexOf("explore") > -1 Then
                pro.Kill()
                Exit For
            End If
        Next
        MsgBox("Icon Changed Successfully")
    End Sub
End Class