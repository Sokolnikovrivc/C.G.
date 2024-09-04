Imports System.Diagnostics.Eventing.Reader
Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.AxHost
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports Microsoft.VisualBasic.Logging
Imports SkiaSharp
Imports SkiaSharp.Views.Desktop


Public Class Form3

    Private dbconnections As New DatabaseConnections()
    Private connectionstr As String = dbconnections.GetConnectionString("stringconect_main")
    Private WithEvents SkControl As SKControl
    Private chartDrawer As DrawLine
    Private mtow As MTOW
    Private mlw As MLW
    Private mzfw As MZFW
    Private minX As Single
    Private maxX As Single
    Private minY As Single
    Private maxY As Single
    Private c As Integer
    Private _cax As Single
    Private lemac As Single
    Private refsta As Single
    Private k As Integer
    Private colormtow As SKColor
    Private colormlw As SKColor
    Private colorzfw As SKColor
    Private chekmtow As Boolean = False
    Private chekmlw As Boolean = False
    Private chekzfw As Boolean = False
    Private chekline As Boolean = False
    Private checkcurv As Boolean = False
    Private chekdiff As Boolean = False

    Public Sub New()
        ' Инициализируем компонент формы
        InitializeComponent()

        ' Создаем и добавляем SKControl на форму
        SkControl = New SKControl() With {
            .Dock = DockStyle.Fill
        }
        Controls.Add(SkControl)
        AddHandler SkControl1.PaintSurface, AddressOf OnPaintSurface
        Me.minX = 21
        Me.maxX = 108
        Me.minY = 37
        Me.maxY = 80
        Me.c = 100000
        Me._cax = 419.35
        Me.lemac = 1780.15
        Me.refsta = 1885
        Me.k = 50
        ColorDialog1.FullOpen = True
        Me.colormtow = SKColors.Blue
        Me.colormlw = SKColors.Red
        Me.colorzfw = SKColors.Green
        mtow = New MTOW(Nothing, SkControl1.Width, SkControl1.Height, minX, maxX, minY, maxY, colormtow)
        mlw = New MLW(Nothing, SkControl1.Width, SkControl1.Height, minX, maxX, minY, maxY, colormlw)
        mzfw = New MZFW(Nothing, SkControl1.Width, SkControl1.Height, minX, maxX, minY, maxY, colorzfw)
    End Sub

    ' Обработчик события PaintSurface
    Private Sub OnPaintSurface(sender As Object, e As SKPaintSurfaceEventArgs)
        Dim canvas = e.Surface.Canvas
        Dim width = e.Info.Width
        Dim height = e.Info.Height

        ' Очищаем канву белым цветом
        canvas.Clear(SKColors.White)


        chartDrawer = New DrawLine(canvas, width, height, minX, maxX, minY, maxY)

        Dim pointcolor As New SKPaint With {
            .Color = colormtow,
            .IsAntialias = True,
           .Style = SKPaintStyle.Stroke,
           .StrokeWidth = 3
        }


        'canvas.DrawPoint(chartDrawer.Xval(100), chartDrawer.Yval(70), pointcolor)
        'canvas.DrawCircle(chartDrawer.Xval(100), chartDrawer.Yval(70), 2, pointcolor)

        chartDrawer.DrawDataLineXY()
        chartDrawer.DrawLineXY()
        chartDrawer.DrawGrid()

        mtow.UpdateCanvas(canvas)
        mtow.UpdateSize(width, height)
        mlw.UpdateCanvas(canvas)
        mlw.UpdateSize(width, height)
        mzfw.UpdateCanvas(canvas)
        mzfw.UpdateSize(width, height)

        'mtow = New MTOW(canvas, width, height, minX, maxX, minY, maxY, colormtow)
        If chekmtow = True AndAlso chekdiff = True Then

            If pointsX0MTOW.Count > 0 Then
                For i = 0 To pointsX0MTOW.Count - 1

                    mtow.AddLine(pointsX0MTOW(i), pointsY0MTOW(i), pointsX1MTOW(i), pointsY1MTOW(i))
                Next
            End If
            If pointscurvX0.Count > 0 Then
                For i = 0 To pointscurvX0.Count - 1
                    mtow.AddCurve(pointscurvX0(i), pointscurvY0(i), pointscurvX1(i), pointscurvY1(i), pointscurvX2(i), pointscurvY2(i))
                Next

            End If
            chekdiff = False
        End If

        mtow.DrawAllCurves()
        mtow.DrawAllLines()

        If chekmlw = True AndAlso chekdiff = True Then

            If pointsX0MTOW.Count > 0 Then
                For i = 0 To pointsX0MTOW.Count - 1

                    mlw.AddLine(pointsX0MTOW(i), pointsY0MTOW(i), pointsX1MTOW(i), pointsY1MTOW(i))
                Next
            End If
            If pointscurvX0.Count > 0 Then
                For i = 0 To pointscurvX0.Count - 1
                    mlw.AddCurve(pointscurvX0(i), pointscurvY0(i), pointscurvX1(i), pointscurvY1(i), pointscurvX2(i), pointscurvY2(i))
                Next
            End If
            chekdiff = False
        End If

        mlw.DrawAllCurves()
        mlw.DrawAllLines()

        If chekzfw = True AndAlso chekdiff = True Then

            If pointsX0MTOW.Count > 0 Then
                For i = 0 To pointsX0MTOW.Count - 1

                    mzfw.AddLine(pointsX0MTOW(i), pointsY0MTOW(i), pointsX1MTOW(i), pointsY1MTOW(i))
                Next
            End If
            If pointscurvX0.Count > 0 Then
                For i = 0 To pointscurvX0.Count - 1
                    mzfw.AddCurve(pointscurvX0(i), pointscurvY0(i), pointscurvX1(i), pointscurvY1(i), pointscurvX2(i), pointscurvY2(i))
                Next
            End If
            chekdiff = False
        End If

        mzfw.DrawAllCurves()
        mzfw.DrawAllLines()

        Dim CAX As New CAX(canvas, width, height, minX, maxX, minY, maxY)
        CAX.DrawLineCAX(c, _cax, lemac, refsta, k)

        chartDrawer.Upcast = New DrawText(canvas, width, height, minX, maxX, minY, maxY)
        chartDrawer.Upcast.DrawVerticalText()



    End Sub



    Private Sub SkControl1_MouseMove1(sender As Object, e As MouseEventArgs) Handles SkControl1.MouseMove

        If chartDrawer IsNot Nothing Then
            Dim screenX As Single = e.X
            Dim screenY As Single = e.Y

            ' Преобразуем экранные координаты в значения на графике

            Dim graphX As Single = (screenX - chartDrawer.StartX) / chartDrawer.ScaleX + chartDrawer.MinX
            Dim graphY As Single = chartDrawer.MinY - (screenY - chartDrawer.StartY) / chartDrawer.ScaleY

            ' Проверяем, находятся ли координаты в пределах допустимого диапазона
            If graphX >= chartDrawer.MinX AndAlso graphX <= chartDrawer.MaxX AndAlso
       graphY >= chartDrawer.MinY AndAlso graphY <= chartDrawer.MaxY Then
                Label1.Text = $"Index: {graphX:F2}; Weight: {graphY:F2}"
            Else
                Label1.Text = "Out of bounds"
            End If

        Else
            Return
        End If

    End Sub

    'Private Sub SkControl1_MouseDown(sender As Object, e As MouseEventArgs) Handles SkControl1.MouseDown
    '    ' Начало рисования
    '    startx = e.X
    '    starty = e.Y
    '    isDrawing = True
    'End Sub

    'Private Sub SkControl1_MouseMove2(sender As Object, e As MouseEventArgs) Handles SkControl1.MouseMove
    '    If isDrawing Then
    '        ' Обновляем конечную точку и перерисовываем
    '        endX = e.X
    '        endY = e.Y
    '        SkControl1.Invalidate() ' Перерисовываем SKControl
    '    End If
    'End Sub

    'Private Sub SkControl1_MouseUp(sender As Object, e As MouseEventArgs) Handles SkControl1.MouseUp

    '    If isDrawing Then
    '        ' Завершаем рисование и добавляем линию в список
    '        endX = e.X
    '        endY = e.Y
    '        drawnLines.Add(Tuple.Create(startx, starty, endX, endY))

    '        isDrawing = False
    '        SkControl1.Invalidate() ' Перерисовываем SKControl

    '    End If
    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    If drawnLines.Count > 0 Then
    '        drawnLines.RemoveAt(drawnLines.Count - 1)
    '        SkControl1.Invalidate()
    '    End If
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not String.IsNullOrEmpty(TextBox1.Text) AndAlso
       Not String.IsNullOrEmpty(TextBox2.Text) AndAlso
       Not String.IsNullOrEmpty(TextBox3.Text) AndAlso
       Not String.IsNullOrEmpty(TextBox4.Text) Then

            minX = TextBox4.Text
            maxX = TextBox3.Text
            minY = TextBox1.Text
            maxY = TextBox2.Text
            SkControl1.Invalidate()
        Else
            MsgBox("Поля не должны быть пустыми!")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not String.IsNullOrEmpty(TextBox5.Text) AndAlso
       Not String.IsNullOrEmpty(TextBox6.Text) AndAlso
       Not String.IsNullOrEmpty(TextBox7.Text) AndAlso
       Not String.IsNullOrEmpty(TextBox8.Text) AndAlso Not String.IsNullOrEmpty(TextBox9.Text) Then
            'Single.TryParse(TextBox7.Text, _cax)
            c = TextBox8.Text
            _cax = TextBox7.Text
            lemac = TextBox6.Text
            refsta = TextBox5.Text
            k = TextBox9.Text
            SkControl1.Invalidate()
        Else
            MsgBox("Поля не должны быть пустыми!")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If ColorDialog1.ShowDialog() = DialogResult.Cancel Then
            Return
        End If
        TextBox10.BackColor = ColorDialog1.Color
        Dim selectedColor As System.Drawing.Color = ColorDialog1.Color
        colormtow = New SKColor(selectedColor.R, selectedColor.G, selectedColor.B, selectedColor.A)
        If mtow IsNot Nothing Then
            mtow.UpdateColor(colormtow)
        End If
        SkControl1.Invalidate()
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TextBox10.BackColor.Equals(SystemColors.Control) Then
            ' Преобразуем SKColor в System.Drawing.Color
            Dim drawingColor As System.Drawing.Color = System.Drawing.Color.FromArgb(colormtow.Alpha, colormtow.Red, colormtow.Green, colormtow.Blue)
            ' Устанавливаем цвет фона TextBox10
            TextBox10.BackColor = drawingColor

        End If
        If TextBox11.BackColor.Equals(SystemColors.Control) Then
            ' Преобразуем SKColor в System.Drawing.Color
            Dim drawingColor As System.Drawing.Color = System.Drawing.Color.FromArgb(colormlw.Alpha, colormlw.Red, colormlw.Green, colormlw.Blue)
            ' Устанавливаем цвет фона TextBox10
            TextBox11.BackColor = drawingColor

        End If
        If TextBox12.BackColor.Equals(SystemColors.Control) Then
            ' Преобразуем SKColor в System.Drawing.Color
            Dim drawingColor As System.Drawing.Color = System.Drawing.Color.FromArgb(colorzfw.Alpha, colorzfw.Red, colorzfw.Green, colorzfw.Blue)
            ' Устанавливаем цвет фона TextBox10
            TextBox12.BackColor = drawingColor

        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ColorDialog1.ShowDialog() = DialogResult.Cancel Then
            Return
        End If
        TextBox11.BackColor = ColorDialog1.Color
        Dim selectedColor As System.Drawing.Color = ColorDialog1.Color
        colormlw = New SKColor(selectedColor.R, selectedColor.G, selectedColor.B, selectedColor.A)
        If mlw IsNot Nothing Then
            mlw.UpdateColor(colormlw)
        End If
        SkControl1.Invalidate()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ColorDialog1.ShowDialog() = DialogResult.Cancel Then
            Return
        End If
        TextBox12.BackColor = ColorDialog1.Color
        Dim selectedColor As System.Drawing.Color = ColorDialog1.Color
        colorzfw = New SKColor(selectedColor.R, selectedColor.G, selectedColor.B, selectedColor.A)
        If mzfw IsNot Nothing Then
            mzfw.UpdateColor(colorzfw)
        End If
        SkControl1.Invalidate()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                SetFlags(True, False, False)
                ClearPointsIfNotEmpty()
                chekline = False
                checkcurv = False
            Case 1
                SetFlags(False, True, False)
                ClearPointsIfNotEmpty()
                chekline = False
                checkcurv = False

            Case 2
                SetFlags(False, False, True)
                ClearPointsIfNotEmpty()
                chekline = False
                checkcurv = False
        End Select
    End Sub

    Private Sub SetFlags(mtow As Boolean, mlw As Boolean, xfw As Boolean)
        chekmtow = mtow
        chekmlw = mlw
        chekzfw = xfw
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.SelectedItem Is Nothing Then
            MsgBox("Выберите значения для типа линии!")
            Return
        End If
        GroupBox4.Enabled = True
        GroupBox5.Enabled = False

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If ComboBox1.SelectedItem Is Nothing Then
            MsgBox("Выберите значения для типа линии!")
            Return
        End If
        GroupBox4.Enabled = False
        GroupBox5.Enabled = True
    End Sub

    Private pointsX0MTOW As New List(Of Single)()
    Private pointsY0MTOW As New List(Of Single)()
    Private pointsX1MTOW As New List(Of Single)()
    Private pointsY1MTOW As New List(Of Single)()

    Public Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Try
            If Not String.IsNullOrEmpty(TextBox13.Text) AndAlso Not String.IsNullOrEmpty(TextBox14.Text) AndAlso Not String.IsNullOrEmpty(TextBox15.Text) AndAlso Not String.IsNullOrEmpty(TextBox16.Text) Then
                Dim x0 As Single
                Dim y0 As Single
                Dim x1 As Single
                Dim y1 As Single

                x0 = Convert.ToSingle(TextBox13.Text)
                y0 = Convert.ToSingle(TextBox14.Text)
                x1 = Convert.ToSingle(TextBox16.Text)
                y1 = Convert.ToSingle(TextBox15.Text)
                pointsX0MTOW.Add(x0)
                pointsY0MTOW.Add(y0)
                pointsX1MTOW.Add(x1)
                pointsY1MTOW.Add(y1)

                SkControl1.Invalidate()

                TextBox13.Text = Convert.ToString(pointsX1MTOW.Last)
                TextBox14.Text = Convert.ToString(pointsY1MTOW.Last)
                TextBox16.Text = Nothing
                TextBox15.Text = Nothing
                chekline = True
                chekdiff = True
                ' MsgBox($"{mtow.AllPoints.Count}")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'Нужно переработать
        If chekmtow = True AndAlso pointsX0MTOW.Count > 0 AndAlso
            pointsY0MTOW.Count > 0 AndAlso
            pointsX1MTOW.Count > 0 AndAlso
            pointsY1MTOW.Count > 0 AndAlso
            mtow.AllPoints.Count > 1 Then


            pointsX0MTOW.RemoveAt(pointsX0MTOW.Count - 1)
            pointsY0MTOW.RemoveAt(pointsY0MTOW.Count - 1)
            pointsX1MTOW.RemoveAt(pointsX1MTOW.Count - 1)
            pointsY1MTOW.RemoveAt(pointsY1MTOW.Count - 1)

            mtow.AllPoints.RemoveRange(mtow.AllPoints.Count - 2, 2)

            'mtow.PointsX0.RemoveAt(mtow.PointsX0.Count - 1)
            'mtow.PointsY0.RemoveAt(mtow.PointsY0.Count - 1)
            'mtow.PointsX1.RemoveAt(mtow.PointsX1.Count - 1)
            'mtow.PointsY1.RemoveAt(mtow.PointsY1.Count - 1)
            mtow.ClearList()
            SkControl1.Invalidate()
            chekdiff = True
        ElseIf chekmlw = True AndAlso pointsX0MTOW.Count > 0 AndAlso
            pointsY0MTOW.Count > 0 AndAlso
            pointsX1MTOW.Count > 0 AndAlso
            pointsY1MTOW.Count > 0 AndAlso
            mlw.AllPoints.Count > 1 Then

            pointsX0MTOW.RemoveAt(pointsX0MTOW.Count - 1)
            pointsY0MTOW.RemoveAt(pointsY0MTOW.Count - 1)
            pointsX1MTOW.RemoveAt(pointsX1MTOW.Count - 1)
            pointsY1MTOW.RemoveAt(pointsY1MTOW.Count - 1)

            mlw.AllPoints.RemoveRange(mlw.AllPoints.Count - 2, 2)
            mlw.ClearList()
            SkControl1.Invalidate()
            chekdiff = True
        ElseIf chekzfw = True AndAlso pointsX0MTOW.Count > 0 AndAlso
            pointsY0MTOW.Count > 0 AndAlso
            pointsX1MTOW.Count > 0 AndAlso
            pointsY1MTOW.Count > 0 AndAlso
            mzfw.AllPoints.Count > 1 Then

            pointsX0MTOW.RemoveAt(pointsX0MTOW.Count - 1)
            pointsY0MTOW.RemoveAt(pointsY0MTOW.Count - 1)
            pointsX1MTOW.RemoveAt(pointsX1MTOW.Count - 1)
            pointsY1MTOW.RemoveAt(pointsY1MTOW.Count - 1)

            mzfw.AllPoints.RemoveRange(mzfw.AllPoints.Count - 2, 2)
            mzfw.ClearList()
            SkControl1.Invalidate()
            chekdiff = True
        End If

        'MsgBox($"{mtow.AllPoints.Count}")
    End Sub

    Private pointscurvX0 As New List(Of Single)()
    Private pointscurvY0 As New List(Of Single)()
    Private pointscurvX1 As New List(Of Single)()
    Private pointscurvY1 As New List(Of Single)()
    Private pointscurvX2 As New List(Of Single)()
    Private pointscurvY2 As New List(Of Single)()

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            If Not String.IsNullOrEmpty(TextBox17.Text) AndAlso
               Not String.IsNullOrEmpty(TextBox18.Text) AndAlso
               Not String.IsNullOrEmpty(TextBox19.Text) AndAlso
               Not String.IsNullOrEmpty(TextBox20.Text) AndAlso
               Not String.IsNullOrEmpty(TextBox21.Text) AndAlso
               Not String.IsNullOrEmpty(TextBox22.Text) Then

                Dim x0 As Single
                Dim y0 As Single
                Dim x1 As Single
                Dim y1 As Single
                Dim x2 As Single
                Dim y2 As Single

                x0 = Convert.ToSingle(TextBox18.Text)
                y0 = Convert.ToSingle(TextBox17.Text)
                x1 = Convert.ToSingle(TextBox22.Text)
                y1 = Convert.ToSingle(TextBox21.Text)
                x2 = Convert.ToSingle(TextBox20.Text)
                y2 = Convert.ToSingle(TextBox19.Text)

                pointscurvX0.Add(x0)
                pointscurvY0.Add(y0)
                pointscurvX1.Add(x1)
                pointscurvY1.Add(y1)
                pointscurvX2.Add(x2)
                pointscurvY2.Add(y2)

                SkControl1.Invalidate()
                TextBox18.Text = Convert.ToString(pointscurvX2.Last)
                TextBox17.Text = Convert.ToString(pointscurvY2.Last)
                TextBox19.Text = Nothing
                TextBox20.Text = Nothing
                TextBox21.Text = Nothing
                TextBox22.Text = Nothing
                checkcurv = True
                chekdiff = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearPointsIfNotEmpty()
        If chekline = True AndAlso checkcurv = True AndAlso pointsX0MTOW.Count > 0 AndAlso pointsY0MTOW.Count > 0 AndAlso pointsY1MTOW.Count > 0 AndAlso
           pointsX1MTOW.Count > 0 AndAlso pointscurvX0.Count > 0 AndAlso pointscurvX1.Count > 0 AndAlso
           pointscurvX2.Count > 0 AndAlso pointscurvY0.Count > 0 AndAlso pointscurvY1.Count > 0 AndAlso
           pointscurvY2.Count > 0 Then

            pointsX0MTOW.Clear()
            pointsY0MTOW.Clear()
            pointsY1MTOW.Clear()
            pointsX1MTOW.Clear()
            pointscurvX0.Clear()
            pointscurvX1.Clear()
            pointscurvX2.Clear()
            pointscurvY0.Clear()
            pointscurvY1.Clear()
            pointscurvY2.Clear()

        ElseIf chekline = True AndAlso pointsX0MTOW.Count > 0 AndAlso pointsY0MTOW.Count > 0 AndAlso pointsY1MTOW.Count > 0 AndAlso
           pointsX1MTOW.Count > 0 Then
            pointsX0MTOW.Clear()
            pointsY0MTOW.Clear()
            pointsY1MTOW.Clear()
            pointsX1MTOW.Clear()

        ElseIf checkcurv = True AndAlso pointscurvX0.Count > 0 AndAlso pointscurvX1.Count > 0 AndAlso
           pointscurvX2.Count > 0 AndAlso pointscurvY0.Count > 0 AndAlso pointscurvY1.Count > 0 AndAlso
           pointscurvY2.Count > 0 Then
            pointscurvX1.Clear()
            pointscurvX2.Clear()
            pointscurvY0.Clear()
            pointscurvY1.Clear()
            pointscurvY2.Clear()
        End If

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If chekmtow = True AndAlso pointscurvX0.Count > 0 AndAlso
           pointscurvY0.Count > 0 AndAlso
           pointscurvX1.Count > 0 AndAlso
           pointscurvY1.Count > 0 AndAlso
           pointscurvX2.Count > 0 AndAlso
           pointscurvY2.Count > 0 AndAlso
           mtow.AllPoints.Count > 1 Then

            pointscurvX0.RemoveAt(pointscurvX0.Count - 1)
            pointscurvY0.RemoveAt(pointscurvY0.Count - 1)
            pointscurvX1.RemoveAt(pointscurvX1.Count - 1)
            pointscurvY1.RemoveAt(pointscurvY1.Count - 1)
            pointscurvX2.RemoveAt(pointscurvX2.Count - 1)
            pointscurvY2.RemoveAt(pointscurvY2.Count - 1)

            mtow.AllPoints.RemoveRange(mtow.AllPoints.Count - 3, 3)
            mtow.ClearList()
            SkControl1.Invalidate()
            chekdiff = True
        ElseIf chekmlw = True AndAlso pointscurvX0.Count > 0 AndAlso
           pointscurvY0.Count > 0 AndAlso
           pointscurvX1.Count > 0 AndAlso
           pointscurvY1.Count > 0 AndAlso
           pointscurvX2.Count > 0 AndAlso
           pointscurvY2.Count > 0 AndAlso
           mlw.AllPoints.Count > 1 Then

            pointscurvX0.RemoveAt(pointscurvX0.Count - 1)
            pointscurvY0.RemoveAt(pointscurvY0.Count - 1)
            pointscurvX1.RemoveAt(pointscurvX1.Count - 1)
            pointscurvY1.RemoveAt(pointscurvY1.Count - 1)
            pointscurvX2.RemoveAt(pointscurvX2.Count - 1)
            pointscurvY2.RemoveAt(pointscurvY2.Count - 1)

            mlw.AllPoints.RemoveRange(mlw.AllPoints.Count - 3, 3)
            mlw.ClearList()
            SkControl1.Invalidate()
            chekdiff = True
        ElseIf chekzfw = True AndAlso pointscurvX0.Count > 0 AndAlso
           pointscurvY0.Count > 0 AndAlso
           pointscurvX1.Count > 0 AndAlso
           pointscurvY1.Count > 0 AndAlso
           pointscurvX2.Count > 0 AndAlso
           pointscurvY2.Count > 0 AndAlso
           mzfw.AllPoints.Count > 1 Then

            pointscurvX0.RemoveAt(pointscurvX0.Count - 1)
            pointscurvY0.RemoveAt(pointscurvY0.Count - 1)
            pointscurvX1.RemoveAt(pointscurvX1.Count - 1)
            pointscurvY1.RemoveAt(pointscurvY1.Count - 1)
            pointscurvX2.RemoveAt(pointscurvX2.Count - 1)
            pointscurvY2.RemoveAt(pointscurvY2.Count - 1)

            mzfw.AllPoints.RemoveRange(mzfw.AllPoints.Count - 3, 3)
            mzfw.ClearList()
            SkControl1.Invalidate()
            chekdiff = True
        End If

    End Sub

#If DEBUG Then
    Private Sub Exit_Form(sender As Object, e As EventArgs) Handles MyBase.Closed

    End Sub
#End If

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        Try
            If mtow IsNot Nothing Then
                Using connection As New SqlConnection(connectionstr)
                    connection.Open()
                    Dim command As New SqlCommand("INSERT INTO DataLine (NameLine, PointsX0, PointsY0, PointsX1, PointsY1, Movex0, Movey0, Movex1, Movey1, Movex2, Movey2, PaintColor,AircraftType, flight_bort,config_id) 
                            VALUES (@NameLine,@PointsX0, @PointsY0, @PointsX1, @PointsY1, @Movex0, @Movey0, @Movex1, @Movey1, @Movex2, @Movey2, @PaintColor, @AircraftType, @flight_bort,@config_id)", connection)

                    command.Parameters.AddWithValue("@NameLine", "MTOW")
                    command.Parameters.AddWithValue("@PointsX0", String.Join(";", mtow.PointsX0.Select(Function(x) x.ToString().Replace(",", "."))))
                    command.Parameters.AddWithValue("@PointsY0", String.Join(";", mtow.PointsY0.Select(Function(x) x.ToString().Replace(",", "."))))
                    command.Parameters.AddWithValue("@PointsX1", String.Join(";", mtow.PointsX1.Select(Function(x) x.ToString().Replace(",", "."))))
                    command.Parameters.AddWithValue("@PointsY1", String.Join(";", mtow.PointsY1.Select(Function(x) x.ToString().Replace(",", "."))))
                    command.Parameters.AddWithValue("@Movex0", String.Join(";", mtow.Movex0.Select(Function(x) x.ToString().Replace(",", "."))))
                    command.Parameters.AddWithValue("@Movey0", String.Join(";", mtow.Movey0.Select(Function(x) x.ToString().Replace(",", "."))))
                    command.Parameters.AddWithValue("@Movex1", String.Join(";", mtow.Movex1.Select(Function(x) x.ToString().Replace(",", "."))))
                    command.Parameters.AddWithValue("@Movey1", String.Join(";", mtow.Movey1.Select(Function(x) x.ToString().Replace(",", "."))))
                    command.Parameters.AddWithValue("@Movex2", String.Join(";", mtow.Movex2.Select(Function(x) x.ToString().Replace(",", "."))))
                    command.Parameters.AddWithValue("@Movey2", String.Join(";", mtow.Movey2.Select(Function(x) x.ToString().Replace(",", "."))))
                    command.Parameters.AddWithValue("@PaintColor", mtow.Paint.Color.ToString())
                    command.Parameters.AddWithValue("@AircraftType", TextBox23.Text)
                    command.Parameters.AddWithValue("@flight_bort", TextBox25.Text)
                    command.Parameters.AddWithValue("@config_id", TextBox24.Text)
                    command.ExecuteNonQuery()

                End Using
            End If
            If mlw IsNot Nothing Then
                Using connection As New SqlConnection(connectionstr)
                    connection.Open()
                    Dim command As New SqlCommand("INSERT INTO DataLine (NameLine, PointsX0, PointsY0, PointsX1, PointsY1, Movex0, Movey0, Movex1, Movey1, Movex2, Movey2, PaintColor,AircraftType, flight_bort,config_id) 
                            VALUES (@NameLine,@PointsX0, @PointsY0, @PointsX1, @PointsY1, @Movex0, @Movey0, @Movex1, @Movey1, @Movex2, @Movey2, @PaintColor, @AircraftType, @flight_bort,@config_id)", connection)

                    command.Parameters.AddWithValue("@NameLine", "MLW")
                    command.Parameters.AddWithValue("@PointsX0", String.Join(";", mlw.PointsX0.Select(Function(x) x.ToString())))
                    command.Parameters.AddWithValue("@PointsY0", String.Join(";", mlw.PointsY0.Select(Function(x) x.ToString())))
                    command.Parameters.AddWithValue("@PointsX1", String.Join(";", mlw.PointsX1.Select(Function(x) x.ToString())))
                    command.Parameters.AddWithValue("@PointsY1", String.Join(";", mlw.PointsY1.Select(Function(x) x.ToString())))
                    command.Parameters.AddWithValue("@Movex0", String.Join(";", mlw.Movex0.Select(Function(x) x.ToString())))
                    command.Parameters.AddWithValue("@Movey0", String.Join(";", mlw.Movey0.Select(Function(x) x.ToString())))
                    command.Parameters.AddWithValue("@Movex1", String.Join(";", mlw.Movex1.Select(Function(x) x.ToString())))
                    command.Parameters.AddWithValue("@Movey1", String.Join(";", mlw.Movey1.Select(Function(x) x.ToString())))
                    command.Parameters.AddWithValue("@Movex2", String.Join(";", mlw.Movex2.Select(Function(x) x.ToString())))
                    command.Parameters.AddWithValue("@Movey2", String.Join(";", mlw.Movey2.Select(Function(x) x.ToString())))
                    command.Parameters.AddWithValue("@PaintColor", mlw.Paint.Color.ToString())
                    command.Parameters.AddWithValue("@AircraftType", TextBox23.Text)
                    command.Parameters.AddWithValue("@flight_bort", TextBox25.Text)
                    command.Parameters.AddWithValue("@config_id", TextBox24.Text)
                    command.ExecuteNonQuery()
                End Using
            End If
            If mzfw IsNot Nothing Then
                Using connection As New SqlConnection(connectionstr)
                    connection.Open()
                    Dim command As New SqlCommand("INSERT INTO DataLine (NameLine, PointsX0, PointsY0, PointsX1, PointsY1, Movex0, Movey0, Movex1, Movey1, Movex2, Movey2, PaintColor,AircraftType, flight_bort,config_id) 
                            VALUES (@NameLine,@PointsX0, @PointsY0, @PointsX1, @PointsY1, @Movex0, @Movey0, @Movex1, @Movey1, @Movex2, @Movey2, @PaintColor, @AircraftType, @flight_bort,@config_id)", connection)

                    command.Parameters.AddWithValue("@NameLine", "MZFW")
                    command.Parameters.AddWithValue("@PointsX0", String.Join(";", mzfw.PointsX0.Select(Function(x) x.ToString())))
                    command.Parameters.AddWithValue("@PointsY0", String.Join(";", mzfw.PointsY0.Select(Function(x) x.ToString())))
                    command.Parameters.AddWithValue("@PointsX1", String.Join(";", mzfw.PointsX1.Select(Function(x) x.ToString())))
                    command.Parameters.AddWithValue("@PointsY1", String.Join(";", mzfw.PointsY1.Select(Function(x) x.ToString())))
                    command.Parameters.AddWithValue("@Movex0", String.Join(";", mzfw.Movex0.Select(Function(x) x.ToString())))
                    command.Parameters.AddWithValue("@Movey0", String.Join(";", mzfw.Movey0.Select(Function(x) x.ToString())))
                    command.Parameters.AddWithValue("@Movex1", String.Join(";", mzfw.Movex1.Select(Function(x) x.ToString())))
                    command.Parameters.AddWithValue("@Movey1", String.Join(";", mzfw.Movey1.Select(Function(x) x.ToString())))
                    command.Parameters.AddWithValue("@Movex2", String.Join(";", mzfw.Movex2.Select(Function(x) x.ToString())))
                    command.Parameters.AddWithValue("@Movey2", String.Join(";", mzfw.Movey2.Select(Function(x) x.ToString())))
                    command.Parameters.AddWithValue("@PaintColor", mzfw.Paint.Color.ToString())
                    command.Parameters.AddWithValue("@AircraftType", TextBox23.Text)
                    command.Parameters.AddWithValue("@flight_bort", TextBox25.Text)
                    command.Parameters.AddWithValue("@config_id", TextBox24.Text)
                    command.ExecuteNonQuery()
                End Using
            End If

            Using connection As New SqlConnection(connectionstr)
                connection.Open()
                Dim command As New SqlCommand("INSERT INTO Graphics_item (minX,maxX,minY,maxY,c,_cax,lemac,refsta,k,AircraftType,flight_bort,config_id)
                      VALUES (@minX, @maxX, @minY, @maxY,@c,@_cax,@lemac,@refsta, @k,@AircraftType, @flight_bort, @config_id)", connection)
                command.Parameters.AddWithValue("@minX", minX * 1000)
                command.Parameters.AddWithValue("@maxX", maxX * 1000)
                command.Parameters.AddWithValue("@minY", minY * 1000)
                command.Parameters.AddWithValue("@maxY", maxY * 1000)
                command.Parameters.AddWithValue("c", c)
                command.Parameters.AddWithValue("@_cax", _cax)
                command.Parameters.AddWithValue("@lemac", lemac)
                command.Parameters.AddWithValue("@refsta", refsta)
                command.Parameters.AddWithValue("@k", k)
                command.Parameters.AddWithValue("@AircraftType", TextBox23.Text)
                command.Parameters.AddWithValue("@flight_bort", TextBox25.Text)
                command.Parameters.AddWithValue("@config_id", TextBox24.Text)
                command.ExecuteNonQuery()

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
End Class