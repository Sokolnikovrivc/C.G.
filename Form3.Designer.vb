<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        SkControl1 = New SkiaSharp.Views.Desktop.SKControl()
        GroupBox1 = New GroupBox()
        Button2 = New Button()
        Label4 = New Label()
        Label5 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        GroupBox2 = New GroupBox()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        TextBox12 = New TextBox()
        TextBox11 = New TextBox()
        TextBox10 = New TextBox()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        TextBox9 = New TextBox()
        Button3 = New Button()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        ColorDialog1 = New ColorDialog()
        GroupBox3 = New GroupBox()
        GroupBox5 = New GroupBox()
        Label22 = New Label()
        Label23 = New Label()
        TextBox21 = New TextBox()
        TextBox22 = New TextBox()
        Label20 = New Label()
        Label21 = New Label()
        TextBox19 = New TextBox()
        TextBox20 = New TextBox()
        Label18 = New Label()
        Label19 = New Label()
        TextBox17 = New TextBox()
        TextBox18 = New TextBox()
        Button10 = New Button()
        Button11 = New Button()
        GroupBox4 = New GroupBox()
        Button9 = New Button()
        Button8 = New Button()
        Label16 = New Label()
        Label17 = New Label()
        TextBox15 = New TextBox()
        TextBox16 = New TextBox()
        Label15 = New Label()
        Label14 = New Label()
        TextBox14 = New TextBox()
        TextBox13 = New TextBox()
        ComboBox1 = New ComboBox()
        Button7 = New Button()
        Button1 = New Button()
        Button12 = New Button()
        GroupBox6 = New GroupBox()
        Label26 = New Label()
        Label25 = New Label()
        Label24 = New Label()
        TextBox25 = New TextBox()
        TextBox24 = New TextBox()
        TextBox23 = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(1203, 751)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 21)
        Label1.TabIndex = 1
        ' 
        ' SkControl1
        ' 
        SkControl1.BackColor = SystemColors.Control
        SkControl1.Location = New Point(0, 0)
        SkControl1.Name = "SkControl1"
        SkControl1.Size = New Size(1200, 775)
        SkControl1.TabIndex = 3
        SkControl1.Text = "SkControl1"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Location = New Point(1218, 21)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(288, 160)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(110, 136)
        Button2.Name = "Button2"
        Button2.Size = New Size(88, 22)
        Button2.TabIndex = 5
        Button2.Text = "Установить"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 111)
        Label4.Name = "Label4"
        Label4.Size = New Size(192, 15)
        Label4.TabIndex = 7
        Label4.Text = "Максимальное значение индекса"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 82)
        Label5.Name = "Label5"
        Label5.Size = New Size(188, 15)
        Label5.TabIndex = 6
        Label5.Text = "Минимальное значение индекса"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(200, 108)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(82, 23)
        TextBox3.TabIndex = 5
        TextBox3.Text = "108"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(200, 79)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(82, 23)
        TextBox4.TabIndex = 4
        TextBox4.Text = "21"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 54)
        Label3.Name = "Label3"
        Label3.Size = New Size(172, 15)
        Label3.TabIndex = 3
        Label3.Text = "Максимальное значение веса"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(168, 15)
        Label2.TabIndex = 2
        Label2.Text = "Минимальное значение веса"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(200, 51)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(82, 23)
        TextBox2.TabIndex = 1
        TextBox2.Text = "80"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(200, 22)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(82, 23)
        TextBox1.TabIndex = 0
        TextBox1.Text = "37"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button6)
        GroupBox2.Controls.Add(Button5)
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Controls.Add(TextBox12)
        GroupBox2.Controls.Add(TextBox11)
        GroupBox2.Controls.Add(TextBox10)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(TextBox9)
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(TextBox5)
        GroupBox2.Controls.Add(TextBox6)
        GroupBox2.Controls.Add(TextBox7)
        GroupBox2.Controls.Add(TextBox8)
        GroupBox2.Location = New Point(1218, 199)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(288, 202)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(6, 145)
        Button6.Name = "Button6"
        Button6.Size = New Size(37, 23)
        Button6.TabIndex = 20
        Button6.Text = "=>"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(6, 88)
        Button5.Name = "Button5"
        Button5.Size = New Size(37, 23)
        Button5.TabIndex = 19
        Button5.Text = "=>"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(6, 27)
        Button4.Name = "Button4"
        Button4.Size = New Size(37, 23)
        Button4.TabIndex = 18
        Button4.Text = "=>"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(98, 146)
        TextBox12.Name = "TextBox12"
        TextBox12.ReadOnly = True
        TextBox12.Size = New Size(40, 23)
        TextBox12.TabIndex = 17
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(98, 88)
        TextBox11.Name = "TextBox11"
        TextBox11.ReadOnly = True
        TextBox11.Size = New Size(40, 23)
        TextBox11.TabIndex = 16
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(98, 28)
        TextBox10.Name = "TextBox10"
        TextBox10.ReadOnly = True
        TextBox10.Size = New Size(40, 23)
        TextBox10.TabIndex = 15
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(49, 149)
        Label13.Name = "Label13"
        Label13.Size = New Size(42, 15)
        Label13.TabIndex = 14
        Label13.Text = "MZFW"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(49, 91)
        Label12.Name = "Label12"
        Label12.Size = New Size(34, 15)
        Label12.TabIndex = 13
        Label12.Text = "MLW"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(49, 31)
        Label11.Name = "Label11"
        Label11.Size = New Size(43, 15)
        Label11.TabIndex = 12
        Label11.Text = "MTOW"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(148, 144)
        Label10.Name = "Label10"
        Label10.Size = New Size(14, 15)
        Label10.TabIndex = 11
        Label10.Text = "K"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(148, 115)
        Label9.Name = "Label9"
        Label9.Size = New Size(43, 15)
        Label9.TabIndex = 10
        Label9.Text = "RefSTA"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(148, 60)
        Label8.Name = "Label8"
        Label8.Size = New Size(30, 15)
        Label8.TabIndex = 9
        Label8.Text = "CAX"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(148, 86)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 15)
        Label7.TabIndex = 8
        Label7.Text = "LEMAC"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(148, 31)
        Label6.Name = "Label6"
        Label6.Size = New Size(15, 15)
        Label6.TabIndex = 7
        Label6.Text = "C"
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(200, 141)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(82, 23)
        TextBox9.TabIndex = 6
        TextBox9.Text = "50"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(116, 174)
        Button3.Name = "Button3"
        Button3.Size = New Size(88, 22)
        Button3.TabIndex = 5
        Button3.Text = "Установить"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(200, 112)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(82, 23)
        TextBox5.TabIndex = 5
        TextBox5.Text = "1885"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(200, 83)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(82, 23)
        TextBox6.TabIndex = 4
        TextBox6.Text = "1780,15"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(200, 57)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(82, 23)
        TextBox7.TabIndex = 1
        TextBox7.Text = "419,35"
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(200, 28)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(82, 23)
        TextBox8.TabIndex = 0
        TextBox8.Text = "100000"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(GroupBox5)
        GroupBox3.Controls.Add(GroupBox4)
        GroupBox3.Controls.Add(ComboBox1)
        GroupBox3.Controls.Add(Button7)
        GroupBox3.Controls.Add(Button1)
        GroupBox3.Location = New Point(1218, 418)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(288, 257)
        GroupBox3.TabIndex = 6
        GroupBox3.TabStop = False
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(Label22)
        GroupBox5.Controls.Add(Label23)
        GroupBox5.Controls.Add(TextBox21)
        GroupBox5.Controls.Add(TextBox22)
        GroupBox5.Controls.Add(Label20)
        GroupBox5.Controls.Add(Label21)
        GroupBox5.Controls.Add(TextBox19)
        GroupBox5.Controls.Add(TextBox20)
        GroupBox5.Controls.Add(Label18)
        GroupBox5.Controls.Add(Label19)
        GroupBox5.Controls.Add(TextBox17)
        GroupBox5.Controls.Add(TextBox18)
        GroupBox5.Controls.Add(Button10)
        GroupBox5.Controls.Add(Button11)
        GroupBox5.Enabled = False
        GroupBox5.Location = New Point(10, 151)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(272, 98)
        GroupBox5.TabIndex = 10
        GroupBox5.TabStop = False
        GroupBox5.Text = "Кривые"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(67, 72)
        Label22.Name = "Label22"
        Label22.Size = New Size(20, 15)
        Label22.TabIndex = 44
        Label22.Text = "Y1"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(5, 72)
        Label23.Name = "Label23"
        Label23.Size = New Size(20, 15)
        Label23.TabIndex = 43
        Label23.Text = "X1"
        ' 
        ' TextBox21
        ' 
        TextBox21.Location = New Point(93, 69)
        TextBox21.Name = "TextBox21"
        TextBox21.Size = New Size(37, 23)
        TextBox21.TabIndex = 42
        TextBox21.Text = "0"
        ' 
        ' TextBox22
        ' 
        TextBox22.Location = New Point(31, 69)
        TextBox22.Name = "TextBox22"
        TextBox22.Size = New Size(37, 23)
        TextBox22.TabIndex = 41
        TextBox22.Text = "0"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(202, 25)
        Label20.Name = "Label20"
        Label20.Size = New Size(20, 15)
        Label20.TabIndex = 40
        Label20.Text = "Y2"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(140, 25)
        Label21.Name = "Label21"
        Label21.Size = New Size(20, 15)
        Label21.TabIndex = 39
        Label21.Text = "X2"
        ' 
        ' TextBox19
        ' 
        TextBox19.Location = New Point(228, 22)
        TextBox19.Name = "TextBox19"
        TextBox19.Size = New Size(37, 23)
        TextBox19.TabIndex = 38
        TextBox19.Text = "0"
        ' 
        ' TextBox20
        ' 
        TextBox20.Location = New Point(166, 22)
        TextBox20.Name = "TextBox20"
        TextBox20.Size = New Size(37, 23)
        TextBox20.TabIndex = 37
        TextBox20.Text = "0"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(74, 25)
        Label18.Name = "Label18"
        Label18.Size = New Size(20, 15)
        Label18.TabIndex = 36
        Label18.Text = "Y0"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(5, 25)
        Label19.Name = "Label19"
        Label19.Size = New Size(20, 15)
        Label19.TabIndex = 35
        Label19.Text = "X0"
        ' 
        ' TextBox17
        ' 
        TextBox17.Location = New Point(100, 22)
        TextBox17.Name = "TextBox17"
        TextBox17.Size = New Size(37, 23)
        TextBox17.TabIndex = 34
        TextBox17.Text = "0"
        ' 
        ' TextBox18
        ' 
        TextBox18.Location = New Point(31, 22)
        TextBox18.Name = "TextBox18"
        TextBox18.Size = New Size(37, 23)
        TextBox18.TabIndex = 33
        TextBox18.Text = "0"
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(206, 70)
        Button10.Name = "Button10"
        Button10.Size = New Size(58, 22)
        Button10.TabIndex = 32
        Button10.Text = "Отмена"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.Location = New Point(142, 70)
        Button11.Name = "Button11"
        Button11.Size = New Size(58, 22)
        Button11.TabIndex = 31
        Button11.Text = "Создать"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Button9)
        GroupBox4.Controls.Add(Button8)
        GroupBox4.Controls.Add(Label16)
        GroupBox4.Controls.Add(Label17)
        GroupBox4.Controls.Add(TextBox15)
        GroupBox4.Controls.Add(TextBox16)
        GroupBox4.Controls.Add(Label15)
        GroupBox4.Controls.Add(Label14)
        GroupBox4.Controls.Add(TextBox14)
        GroupBox4.Controls.Add(TextBox13)
        GroupBox4.Enabled = False
        GroupBox4.Location = New Point(9, 22)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(154, 121)
        GroupBox4.TabIndex = 9
        GroupBox4.TabStop = False
        GroupBox4.Text = "Линии"
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(89, 93)
        Button9.Name = "Button9"
        Button9.Size = New Size(58, 22)
        Button9.TabIndex = 30
        Button9.Text = "Отмена"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(6, 93)
        Button8.Name = "Button8"
        Button8.Size = New Size(58, 22)
        Button8.TabIndex = 29
        Button8.Text = "Создать"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(85, 54)
        Label16.Name = "Label16"
        Label16.Size = New Size(20, 15)
        Label16.TabIndex = 28
        Label16.Text = "Y1"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(85, 25)
        Label17.Name = "Label17"
        Label17.Size = New Size(20, 15)
        Label17.TabIndex = 27
        Label17.Text = "X1"
        ' 
        ' TextBox15
        ' 
        TextBox15.Location = New Point(111, 51)
        TextBox15.Name = "TextBox15"
        TextBox15.Size = New Size(37, 23)
        TextBox15.TabIndex = 26
        TextBox15.Text = "0"
        ' 
        ' TextBox16
        ' 
        TextBox16.Location = New Point(111, 22)
        TextBox16.Name = "TextBox16"
        TextBox16.Size = New Size(37, 23)
        TextBox16.TabIndex = 25
        TextBox16.Text = "0"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(1, 54)
        Label15.Name = "Label15"
        Label15.Size = New Size(20, 15)
        Label15.TabIndex = 24
        Label15.Text = "Y0"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(1, 25)
        Label14.Name = "Label14"
        Label14.Size = New Size(20, 15)
        Label14.TabIndex = 23
        Label14.Text = "X0"
        ' 
        ' TextBox14
        ' 
        TextBox14.Location = New Point(27, 51)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(37, 23)
        TextBox14.TabIndex = 22
        TextBox14.Text = "0"
        ' 
        ' TextBox13
        ' 
        TextBox13.Location = New Point(27, 22)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(37, 23)
        TextBox13.TabIndex = 21
        TextBox13.Text = "0"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"MTOW", "MLW", "MZFW"})
        ComboBox1.Location = New Point(179, 32)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(101, 23)
        ComboBox1.TabIndex = 8
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(179, 115)
        Button7.Name = "Button7"
        Button7.Size = New Size(103, 22)
        Button7.TabIndex = 7
        Button7.Text = "Кривые"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(179, 72)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 22)
        Button1.TabIndex = 6
        Button1.Text = "Линии"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button12
        ' 
        Button12.Location = New Point(227, 32)
        Button12.Name = "Button12"
        Button12.Size = New Size(55, 23)
        Button12.TabIndex = 7
        Button12.Text = "Запись"
        Button12.UseVisualStyleBackColor = True
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(Label26)
        GroupBox6.Controls.Add(Label25)
        GroupBox6.Controls.Add(Label24)
        GroupBox6.Controls.Add(TextBox25)
        GroupBox6.Controls.Add(TextBox24)
        GroupBox6.Controls.Add(TextBox23)
        GroupBox6.Controls.Add(Button12)
        GroupBox6.Location = New Point(1218, 684)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(288, 66)
        GroupBox6.TabIndex = 8
        GroupBox6.TabStop = False
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Location = New Point(176, 13)
        Label26.Name = "Label26"
        Label26.Size = New Size(28, 15)
        Label26.TabIndex = 33
        Label26.Text = "Рег."
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(81, 13)
        Label25.Name = "Label25"
        Label25.Size = New Size(75, 15)
        Label25.TabIndex = 32
        Label25.Text = "Компановка"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(15, 13)
        Label24.Name = "Label24"
        Label24.Size = New Size(45, 15)
        Label24.TabIndex = 31
        Label24.Text = "Тип ВС"
        ' 
        ' TextBox25
        ' 
        TextBox25.Location = New Point(158, 32)
        TextBox25.Name = "TextBox25"
        TextBox25.Size = New Size(63, 23)
        TextBox25.TabIndex = 10
        ' 
        ' TextBox24
        ' 
        TextBox24.Location = New Point(84, 32)
        TextBox24.Name = "TextBox24"
        TextBox24.Size = New Size(63, 23)
        TextBox24.TabIndex = 9
        ' 
        ' TextBox23
        ' 
        TextBox23.Location = New Point(6, 32)
        TextBox23.Name = "TextBox23"
        TextBox23.Size = New Size(63, 23)
        TextBox23.TabIndex = 8
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(1518, 776)
        Controls.Add(GroupBox6)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(SkControl1)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents SkControl1 As SkiaSharp.Views.Desktop.SKControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents Button12 As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TextBox23 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents TextBox25 As TextBox
    Friend WithEvents TextBox24 As TextBox
End Class
