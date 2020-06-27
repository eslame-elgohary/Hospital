Imports System.IO
Imports System.Reflection
Imports DevExpress.ExpressApp.Win.Utils
Imports DevExpress.Skins
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraSplashScreen

Public Partial Class XafSplashScreen
    Inherits SplashScreen
    
	Protected Overrides Sub DrawContent(graphicsCache As GraphicsCache, skin As Skin)
        Dim bounds As Rectangle = ClientRectangle
        bounds.Width = (bounds.Width - 1)
        bounds.Height = (bounds.Height - 1)
        graphicsCache.Graphics.DrawRectangle(graphicsCache.GetPen(Color.FromArgb(255, 87, 87, 87), 1), bounds)
    End Sub

    Protected Sub UpdateLabelsPosition()
        applicationNameLabel.CalcBestSize()
        Dim newLeft As Integer = CType((Width - applicationNameLabel.Width) / 2, Integer)
        applicationNameLabel.Location = New Point(newLeft, applicationNameLabel.Top)
        subtitleLabel.CalcBestSize()
        newLeft = CType((Width - subtitleLabel.Width) / 2, Integer)
        subtitleLabel.Location = New Point(newLeft, subtitleLabel.Top)
    End Sub

    Sub New()
        InitializeComponent()
        Me.labelControl1.Text = "حقوق النشر © " & DateTime.Now.Year.ToString() & " ." _
            & System.Environment.NewLine & "جميع الحقوق محفوظة لشركة الكارما سوفت ."
        Dim executingAssembly As Assembly = Assembly.GetExecutingAssembly
        Me.pictureEdit1.SvgImage = SvgImage.FromResources(executingAssembly.GetName().Name & ".Logotype.svg", executingAssembly)
        UpdateLabelsPosition()
    End Sub
    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
        If (CType(cmd, UpdateSplashCommand) = UpdateSplashCommand.Description) Then
            labelControl2.Text = CType(arg, String)
        End If

    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum
End Class
