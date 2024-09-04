Public Class Form1

    ' Определяем координаты контрольных точек и их значения веса и индекса
    Private mtow As New PointF(453, 55)
    'Private mlw As New PointF(248, 169)
    Private mzfw As New PointF(289, 206)

    ' Соответствующие веса и индексы
    Private mtowWeight As Integer = 77000
    'Private mlwWeight As Integer = 64500
    Private mzfwWeight As Integer = 60500

    Private mtowIndex As Integer = 69
    'Private mlwIndex As Integer = 45
    Private mzfwIndex As Integer = 50

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Относительный путь к изображению
            Dim imagePath As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "C.G. - A320.png")

            ' Загрузка изображения в PictureBox
            PictureBox1.Image = Image.FromFile(imagePath)
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage

        Catch ex As Exception
            ' Показ сообщения об ошибке
            MsgBox("Ошибка загрузки изображения: " & ex.Message)
        End Try
    End Sub

    ' Метод для линейной интерполяции
    Private Function Interpolate(value As Single, fromMin As Single, fromMax As Single, toMin As Single, toMax As Single) As Single
        Return (value - fromMin) * (toMax - toMin) / (fromMax - fromMin) + toMin
        '(x-x1)/(x2-x1)=(y-y1)/(y2-y1)
    End Function

    ' Метод для преобразования значений веса и индекса в координаты пикселей
    Private Function MapToPixelCoordinates(weight As Integer, index As Integer) As PointF

        ' Преобразование веса в координату X

        Dim x As Single = Interpolate(index, mzfwIndex, mtowIndex, mzfw.X, mtow.X)

        ' Преобразование веса в координату Y
        Dim y As Single = Interpolate(weight, mzfwWeight, mtowWeight, mzfw.Y, mtow.Y)

        Return New PointF(x, y)
    End Function

    ' Метод для рисования точки на графике
    Private Sub PlotPoint(g As Graphics, weight As Integer, index As Integer, CAX As Decimal)
        Dim point As PointF = MapToPixelCoordinates(weight, index)
        ' Рисование точки на PictureBox
        g.FillEllipse(Brushes.Red, point.X - 4, point.Y - 4, 8, 8)
        ' Вывод значений координат
        g.DrawString($"({CAX}%)", New Font("Arial", 8), Brushes.Black, point.X + 4, point.Y - 4)
    End Sub

    ' Обработчик события для кнопки
    Private Sub Exempl(sender As Object, e As EventArgs) Handles Button1.Click
        ' Пример добавления точек на график с различными значениями веса и индекса
        Using g As Graphics = PictureBox1.CreateGraphics()
            'PlotPoint(g, 40000, 60) ' Примbер веса 55000 и индекс 60
            PlotPoint(g, 40000, 60, 33) ' Пример веса 60500 и индекс 50
            PlotPoint(g, 64500, 45, 44) ' Пример веса 64500 и индекс 45
            PlotPoint(g, 77000, 70, 56) ' Пример веса 77000 и индекс 70
        End Using
    End Sub

    ' Обработчик события MouseMove для PictureBox
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        ' Отображение координат курсора в Label
        Label1.Text = $"X: {e.X}, Y: {e.Y}"
    End Sub

End Class