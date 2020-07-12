Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Text
Imports DevExpress.ExpressApp
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Utils
Imports DevExpress.ExpressApp.Layout
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.Templates
Imports DevExpress.Persistent.Validation
Imports DevExpress.ExpressApp.SystemModule
Imports DevExpress.ExpressApp.Model.NodeGenerators
Imports System.ComponentModel

' For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
Partial Public Class WelcomeViewController
    Inherits ViewController
    Public Sub New()
        InitializeComponent()
        ' Target required Views (via the TargetXXX properties) and create their Actions.
    End Sub
    Protected Overrides Sub OnActivated()
        MyBase.OnActivated()
        Dim cl As DevExpress.ExpressApp.Win.SystemModule.CloseWindowController = Frame.GetController(Of DevExpress.ExpressApp.Win.SystemModule.CloseWindowController)
        If cl IsNot Nothing Then
            cl.CloseAction.Active.SetItemValue("NotClose", False)
        End If
        'If View IsNot Nothing Then
        '    AddHandler View.QueryCanClose, AddressOf QueryCanClose
        '    Dim ex As DevExpress.ExpressApp.Win.SystemModule.ExitController = Frame.GetController(Of DevExpress.ExpressApp.Win.SystemModule.ExitController)
        '    If ex IsNot Nothing Then
        '        AddHandler ex.ExitAction.Executing, AddressOf CloseApp
        '    End If
        '    AddHandler Application.LoggingOff, AddressOf LogOff
        'End If
        ' Perform various tasks depending on the target View.
    End Sub

    'Private Sub CloseApp(sender As Object, e As CancelEventArgs)
    '    exitapp = True
    'End Sub

    'Private Sub LogOff(sender As Object, e As LoggingOffEventArgs)
    '    exitapp = True
    'End Sub

    'Private exitapp As Boolean = False
    'Private Sub QueryCanClose(sender As Object, e As CancelEventArgs)
    '    e.Cancel = Not exitapp
    'End Sub

    Protected Overrides Sub OnViewControlsCreated()
        MyBase.OnViewControlsCreated()
        ' Access and customize the target View control.
    End Sub
    Protected Overrides Sub OnDeactivated()
        ' Unsubscribe from previously subscribed events and release other references and resources.
        MyBase.OnDeactivated()
    End Sub

    Private Sub AddPatientAction_Execute(sender As Object, e As SimpleActionExecuteEventArgs) Handles AddPatientAction.Execute
        Dim ob As IObjectSpace = Application.CreateObjectSpace
        Dim svp As New ShowViewParameters
        'If SecuritySystem.IsGranted(New DevExpress.ExpressApp.Security.PermissionRequest(ob, GetType(Pationt), Security.SecurityOperations.Read)) = True Then
        '    With svp
        '        .Context = TemplateContext.View
        '        .CreatedView = Application.CreateListView(GetType(Pationt), True)
        '        .TargetWindow = TargetWindow.Default
        '        .CreateAllControllers = True
        '    End With
        '    Application.ShowViewStrategy.ShowView(svp, New ShowViewSource(Nothing, Nothing))
        'Else
        '    MsgBox("ليس لديك حق الدخول")
        'End If


        If SecuritySystem.IsGranted(New DevExpress.ExpressApp.Security.PermissionRequest(ob, GetType(Pationt), Security.SecurityOperations.Create)) = True Then
            Dim p As Pationt
            p = ob.CreateObject(Of Pationt)
            With svp
                .Context = TemplateContext.View
                .CreatedView = Application.CreateDetailView(ob, p, True)
                .TargetWindow = TargetWindow.Default
                .CreateAllControllers = True
            End With
            Application.ShowViewStrategy.ShowView(svp, New ShowViewSource(Nothing, Nothing))
        Else
            MsgBox("ليس لديك حق الاضافة")
        End If
    End Sub
End Class
