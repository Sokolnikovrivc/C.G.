<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        SkControl1 = New SkiaSharp.Views.Desktop.SKControl()
        SuspendLayout()
        ' 
        ' SkControl1
        ' 
        SkControl1.Location = New Point(1, 1)
        SkControl1.Name = "SkControl1"
        SkControl1.Size = New Size(1182, 760)
        SkControl1.TabIndex = 0
        SkControl1.Text = "SkControl1"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1184, 761)
        Controls.Add(SkControl1)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
    End Sub

    Friend WithEvents SkControl1 As SkiaSharp.Views.Desktop.SKControl
End Class
