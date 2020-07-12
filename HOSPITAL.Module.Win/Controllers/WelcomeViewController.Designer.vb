Partial Class WelcomeViewController

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
        Me.AddPatientAction = New DevExpress.ExpressApp.Actions.SimpleAction()
        '
        'AddPatientAction
        '
        Me.AddPatientAction.Caption = "أضافة مريض"
        Me.AddPatientAction.Category = "Tools"
        Me.AddPatientAction.ConfirmationMessage = Nothing
        Me.AddPatientAction.Id = "AddPatientAction"
        Me.AddPatientAction.ToolTip = Nothing
        '
        'WelcomeViewController
        '
        Me.Actions.Add(Me.AddPatientAction)
        Me.TargetViewId = "Welcome"
        Me.TargetViewType = DevExpress.ExpressApp.ViewType.DashboardView
        Me.TypeOfView = GetType(DevExpress.ExpressApp.DashboardView)

    End Sub

    Friend WithEvents AddPatientAction As DevExpress.ExpressApp.Actions.SimpleAction
End Class
