Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.IO

Public Class Form2

    Private dbconnections As New DatabaseConnections()
    Private connectionstr As String = dbconnections.GetConnectionString("stringconect_main")
    Private MyImage As Bitmap
    Private Imageorg As Bitmap

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif|All Files (*.*)|*.*"
        If OFD.ShowDialog = DialogResult.OK Then
            ShowMyImage(OFD.FileName, 0, 0)
        End If
    End Sub

    Private Sub ShowMyImage(fileToDisplay As String, X As Integer, Y As Integer)

        If PictureBox1.Image IsNot Nothing Then
            PictureBox1.Image.Dispose()
            PictureBox1.Image = Nothing
        End If

        If MyImage IsNot Nothing Then
            MyImage.Dispose()
            MyImage = Nothing
        End If

        GC.Collect()
        GC.WaitForPendingFinalizers()
        Dim origin As New Bitmap(fileToDisplay)
        MyImage = New Bitmap(800, 450)

        Using g As Graphics = Graphics.FromImage(MyImage)
            g.DrawImage(origin, 0, 0, 800, 450)
        End Using

        copyimage(MyImage)

        origin.Dispose()

        PictureBox1.Image = MyImage
        PictureBox1.Location = New Point(X, Y)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Width = 800
        PictureBox1.Height = 450


    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        ' Получить объект Graphics из события PaintEventArgs
        If CheckBox1.Checked = True Then
            Dim g As Graphics = e.Graphics

            ' Получить координаты курсора мыши относительно PictureBox
            Dim mousePos As Point = PictureBox1.PointToClient(MousePosition)

            ' Нарисовать направляющие по оси X и Y
            g.DrawLine(Pens.Red, mousePos.X, 0, mousePos.X, PictureBox1.Height)
            g.DrawLine(Pens.Red, 0, mousePos.Y, PictureBox1.Width, mousePos.Y)
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        GroupBox2.Enabled = True

        DrawLinesAndEllipse(TextBox5.Text, TextBox4.Text, TextBox1.Text, TextBox3.Text)

    End Sub
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        ' Перерисовать PictureBox, вызывая его метод Invalidate
        PictureBox1.Invalidate()
    End Sub

    Private Sub DrawLinesAndEllipse(Xparam As Integer, Yparam As Integer, Wt As Integer, ind As Integer)
        If MyImage Is Nothing Then Exit Sub

        Try

            Using g As Graphics = Graphics.FromImage(MyImage)
                Dim y As Integer
                Dim x As Integer
                Dim Weight As Integer
                Dim Index As Integer

                If Integer.TryParse(Yparam, y) AndAlso Integer.TryParse(Xparam, x) Then
                    g.DrawLine(Pens.Blue, 0, y, PictureBox1.Width, y)
                    g.DrawLine(Pens.Blue, x, 0, x, PictureBox1.Height)

                    Dim ellipseRect As New Rectangle(x - 5, y - 5, 10, 10)
                    g.DrawEllipse(Pens.Green, ellipseRect)

                End If

                If Integer.TryParse(Wt, Weight) AndAlso Integer.TryParse(ind, Index) Then
                    g.DrawString($"({Weight},{Index})", New Font("Arial", 12), Brushes.Black, x + 4, y - 4)
                End If

            End Using

            PictureBox1.Refresh()
        Catch ex As Exception
            MsgBox("Ошибка вывода изображения " & ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MyImage IsNot Nothing Then
            MyImage.Dispose()
            PictureBox1.Image = Nothing
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox4.Text = "0"
        TextBox5.Text = "0"
        TextBox3.Text = "0"
        TextBox1.Text = "0"
        GroupBox2.Enabled = False
        RestoreOriginalImage()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox2.Enabled = False

    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        If GroupBox2.Enabled = False Then
            TextBox4.Text = e.Y.ToString
            TextBox5.Text = e.X.ToString
        ElseIf GroupBox2.Enabled = True Then
            TextBox6.Text = e.X.ToString
            TextBox2.Text = e.Y.ToString
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        DrawLinesAndEllipse(TextBox6.Text, TextBox2.Text, TextBox8.Text, TextBox7.Text)
    End Sub

    Private Sub copyimage(srcimage As Bitmap)
        If Imageorg IsNot Nothing Then
            Imageorg.Dispose()
        End If

        Imageorg = New Bitmap(srcimage.Width, srcimage.Height)
        Using g As Graphics = Graphics.FromImage(Imageorg)
            g.DrawImage(srcimage, 0, 0)
        End Using

    End Sub

    Private Sub RestoreOriginalImage()
        If Imageorg Is Nothing Then Exit Sub

        If PictureBox1.Image IsNot Nothing Then
            PictureBox1.Image.Dispose()
        End If

        MyImage = New Bitmap(Imageorg.Width, Imageorg.Height)
        Using g As Graphics = Graphics.FromImage(MyImage)
            g.DrawImage(Imageorg, 0, 0)
        End Using

        PictureBox1.Image = MyImage
        PictureBox1.Refresh()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox8.Text = "0"
        TextBox7.Text = "0"
        TextBox6.Text = "0"
        TextBox2.Text = "0"
        RestoreOriginalImage()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim query As String = ""
        Select Case ComboBox1.SelectedIndex
            Case 0
                query = "INSERT INTO [Test].[dbo].[C_G] ([AircraftType], [flight_bort], [config_id], [mtowcorrect], [mtowcorrectindex], [mzfwcorrect], [mzfwcorrectindex], [mtowcorrectpixelsX], [mtowcorrectpixelsY], [mzfwcorrectpixelsX], [mzfwcorrectpixelsY], [pictures]) VALUES (@AircraftType, @flight_bort, @config_id, @mtowcorrect, @mtowcorrectindex, @mzfwcorrect, @mzfwcorrectindex, @mtowcorrectpixelsX, @mtowcorrectpixelsY, @mzfwcorrectpixelsX, @mzfwcorrectpixelsY, @pictures)"
            Case 1
                query = "INSERT INTO [Test].[dbo].[C_G] ([AircraftType], [mtowcorrect], [mtowcorrectindex], [mzfwcorrect], [mzfwcorrectindex], [mtowcorrectpixelsX], [mtowcorrectpixelsY], [mzfwcorrectpixelsX], [mzfwcorrectpixelsY], [pictures]) VALUES (@AircraftType,  @mtowcorrect, @mtowcorrectindex, @mzfwcorrect, @mzfwcorrectindex, @mtowcorrectpixelsX, @mtowcorrectpixelsY, @mzfwcorrectpixelsX, @mzfwcorrectpixelsY, @pictures)"
            Case 2
                query = "INSERT INTO [Test].[dbo].[C_G] ([AircraftType], [flight_bort], [config_id], [mtowcorrect], [mtowcorrectindex], [mzfwcorrect], [mzfwcorrectindex], [mtowcorrectpixelsX], [mtowcorrectpixelsY], [mzfwcorrectpixelsX], [mzfwcorrectpixelsY], [pictures]) VALUES (@AircraftType, @flight_bort, @config_id, @mtowcorrect, @mtowcorrectindex, @mzfwcorrect, @mzfwcorrectindex, @mtowcorrectpixelsX, @mtowcorrectpixelsY, @mzfwcorrectpixelsX, @mzfwcorrectpixelsY, @pictures)"
        End Select
        Try
            RestoreOriginalImage()
            Dim imageBytes As Byte() = ConvertImageToByteArray(MyImage)
            Using connection As New SqlConnection(connectionstr)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@AircraftType", Label1.Text)

                    If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 2 Then
                        command.Parameters.AddWithValue("@flight_bort", Label2.Text)
                        command.Parameters.AddWithValue("@config_id", Label3.Text)
                    End If

                    command.Parameters.AddWithValue("@mtowcorrect", Convert.ToInt32(TextBox1.Text))
                    command.Parameters.AddWithValue("@mtowcorrectindex", Convert.ToDecimal(TextBox3.Text))
                    command.Parameters.AddWithValue("@mzfwcorrect", Convert.ToInt32(TextBox8.Text))
                    command.Parameters.AddWithValue("@mzfwcorrectindex", Convert.ToDecimal(TextBox7.Text))
                    command.Parameters.AddWithValue("@mtowcorrectpixelsX", Convert.ToInt32(TextBox5.Text))
                    command.Parameters.AddWithValue("@mtowcorrectpixelsY", Convert.ToInt32(TextBox4.Text))
                    command.Parameters.AddWithValue("@mzfwcorrectpixelsX", Convert.ToInt32(TextBox6.Text))
                    command.Parameters.AddWithValue("@mzfwcorrectpixelsY", Convert.ToInt32(TextBox2.Text))
                    command.Parameters.AddWithValue("@pictures", imageBytes)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Запись в Базу Данных")
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString())
        End Try
    End Sub

    Private Function ConvertImageToByteArray(image As Bitmap) As Byte()
        Using ms As New MemoryStream()
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function
End Class