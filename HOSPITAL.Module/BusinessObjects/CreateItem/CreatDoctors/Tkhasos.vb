Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports System.ComponentModel
Imports DevExpress.ExpressApp.DC
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.Base
Imports System.Collections.Generic
Imports DevExpress.ExpressApp.Model
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation
<DefaultClassOptions(), RuleCombinationOfPropertiesIsUnique("Code"), DefaultProperty("Name")>
<ConditionalAppearance.Appearance("a1", "ViewItem", FontColor:="Red", Criteria:="CodeMoney.Money<=23", TargetItems:="CodeMoney")>
Public Class Tkhasos
    Inherits privatebaseobject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()

    End Sub

    Private _codeMony As Tarifa
    '<ImmediatePostData>
    'Property CodeMony As Tarifa
    '    Get
    '        Return _codeMony
    '    End Get
    '    Set(ByVal Value As Tarifa)
    '        SetPropertyValue(NameOf(CodeMony), _codeMony, Value)
    '    End Set
    'End Property

    <Association, DevExpress.Xpo.Aggregated, RuleRequiredField>
    Public ReadOnly Property CodeMony() As XPCollection(Of Tarifa)
        Get
            Return GetCollection(Of Tarifa)(NameOf(CodeMony))
        End Get
    End Property

    <Association>
    Public ReadOnly Property Doctors() As XPCollection(Of Doctors)
        Get
            Return GetCollection(Of Doctors)(NameOf(Doctors))
        End Get
    End Property



End Class
