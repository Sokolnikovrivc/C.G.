<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        CheckBox1 = New CheckBox()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        GroupBox1 = New GroupBox()
        Button5 = New Button()
        Button4 = New Button()
        Label8 = New Label()
        Label7 = New Label()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label6 = New Label()
        TextBox3 = New TextBox()
        GroupBox2 = New GroupBox()
        Button6 = New Button()
        Button7 = New Button()
        Label5 = New Label()
        Label9 = New Label()
        TextBox2 = New TextBox()
        TextBox6 = New TextBox()
        Label10 = New Label()
        TextBox7 = New TextBox()
        Label11 = New Label()
        TextBox8 = New TextBox()
        Button3 = New Button()
        ComboBox1 = New ComboBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(1, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 450)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.System
        Button1.Location = New Point(32, 478)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 1
        Button1.Text = "Обзор"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(138, 478)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 2
        Button2.Text = "Отчистить"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(275, 481)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(170, 19)
        CheckBox1.TabIndex = 3
        CheckBox1.Text = "Включить направляющие"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(89, 34)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 4
        TextBox1.Text = "0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(491, 482)
        Label1.Name = "Label1"
        Label1.Size = New Size(33, 15)
        Label1.TabIndex = 6
        Label1.Text = "A320"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(569, 482)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 15)
        Label2.TabIndex = 7
        Label2.Text = "VP-BMT"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(646, 482)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 15)
        Label3.TabIndex = 8
        Label3.Text = "C12Y144"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(18, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 15)
        Label4.TabIndex = 9
        Label4.Text = "MTOW"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Location = New Point(807, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(220, 214)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "Корректирующие значения"
        ' 
        ' Button5
        ' 
        Button5.FlatStyle = FlatStyle.System
        Button5.Location = New Point(120, 185)
        Button5.Name = "Button5"
        Button5.Size = New Size(74, 23)
        Button5.TabIndex = 17
        Button5.Text = "Сбросить"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.FlatStyle = FlatStyle.System
        Button4.Location = New Point(18, 185)
        Button4.Name = "Button4"
        Button4.Size = New Size(74, 23)
        Button4.TabIndex = 16
        Button4.Text = "Установить"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(69, 145)
        Label8.Name = "Label8"
        Label8.Size = New Size(14, 15)
        Label8.TabIndex = 15
        Label8.Text = "Y"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(69, 107)
        Label7.Name = "Label7"
        Label7.Size = New Size(14, 15)
        Label7.TabIndex = 14
        Label7.Text = "X"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(89, 142)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 13
        TextBox4.Text = "0"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(89, 104)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 12
        TextBox5.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(8, 75)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 15)
        Label6.TabIndex = 11
        Label6.Text = "MTOW Index"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(89, 72)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 10
        TextBox3.Text = "0"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button6)
        GroupBox2.Controls.Add(Button7)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(TextBox6)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(TextBox7)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(TextBox8)
        GroupBox2.Location = New Point(807, 236)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(220, 214)
        GroupBox2.TabIndex = 12
        GroupBox2.TabStop = False
        GroupBox2.Text = "Корректирующие значения"
        ' 
        ' Button6
        ' 
        Button6.FlatStyle = FlatStyle.System
        Button6.Location = New Point(120, 185)
        Button6.Name = "Button6"
        Button6.Size = New Size(74, 23)
        Button6.TabIndex = 19
        Button6.Text = "Сбросить"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.FlatStyle = FlatStyle.System
        Button7.Location = New Point(18, 185)
        Button7.Name = "Button7"
        Button7.Size = New Size(74, 23)
        Button7.TabIndex = 18
        Button7.Text = "Установить"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(69, 147)
        Label5.Name = "Label5"
        Label5.Size = New Size(14, 15)
        Label5.TabIndex = 15
        Label5.Text = "Y"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(69, 109)
        Label9.Name = "Label9"
        Label9.Size = New Size(14, 15)
        Label9.TabIndex = 14
        Label9.Text = "X"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(89, 144)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 13
        TextBox2.Text = "0"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(89, 106)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 12
        TextBox6.Text = "0"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(8, 75)
        Label10.Name = "Label10"
        Label10.Size = New Size(74, 15)
        Label10.TabIndex = 11
        Label10.Text = "MZFW Index"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(89, 72)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(100, 23)
        TextBox7.TabIndex = 10
        TextBox7.Text = "0"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(18, 37)
        Label11.Name = "Label11"
        Label11.Size = New Size(42, 15)
        Label11.TabIndex = 9
        Label11.Text = "MZFW"
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(89, 34)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(100, 23)
        TextBox8.TabIndex = 4
        TextBox8.Text = "0"
        ' 
        ' Button3
        ' 
        Button3.FlatStyle = FlatStyle.System
        Button3.Location = New Point(870, 478)
        Button3.Name = "Button3"
        Button3.Size = New Size(131, 23)
        Button3.TabIndex = 13
        Button3.Text = "Сохранить"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Для конкретного ВС", "Для типа ВС"})
        ComboBox1.Location = New Point(734, 479)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 14
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1039, 510)
        Controls.Add(ComboBox1)
        Controls.Add(Button3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CheckBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
