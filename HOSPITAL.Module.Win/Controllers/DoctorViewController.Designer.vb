﻿Partial Class DoctorViewController

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New(ByVal Container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        Container.Add(Me)

    End Sub

    'Component overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TestAction = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
        '
        'TestAction
        '
        Me.TestAction.Caption = "العربي السوداني"
        Me.TestAction.Category = "Save"
        Me.TestAction.Id = "TestAction"
        Me.TestAction.PaintStyle = DevExpress.ExpressApp.Templates.ActionItemPaintStyle.CaptionAndImage
        Me.TestAction.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject
        Me.TestAction.Shortcut = "F7"
        '
        'DoctorViewController
        '
        Me.Actions.Add(Me.TestAction)

    End Sub

    Friend WithEvents TestAction As DevExpress.ExpressApp.Actions.SimpleAction
End Class
