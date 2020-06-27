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
<DefaultClassOptions(), DefaultProperty("Tarifa"), ImageName("Business_Dollar"), XafDisplayName("الأسعار")>
<ConditionalAppearance.Appearance("a1", "ViewItem", FontColor:="Red", Criteria:="Money<=23", TargetItems:="*")>
Public Class Tarifa
    Inherits privatebaseobject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()

    End Sub


    <PersistentAlias("Name + ' بمبلغ ' + Money +' جنية '"), ImmediatePostData, XafDisplayName("السعر")>
    ReadOnly Property Tarifa As String
        Get
            Return EvaluateAlias(NameOf(Tarifa))
        End Get
    End Property

    Private _money As Double
    <ModelDefault("DisplayFormat", "{0:c2}"), ModelDefault("EditMask", "c2")>
    <RuleValueComparison(ValueComparisonType.GreaterThanOrEqual, 0)>
    Property Money As Double
        Get
            Return _money
        End Get
        Set(ByVal Value As Double)
            SetPropertyValue(NameOf(Money), _money, Value)
        End Set
    End Property
    <Association>
    Public ReadOnly Property takhassousat() As XPCollection(Of Tkhasos)
        Get
            Return GetCollection(Of Tkhasos)(NameOf(takhassousat))
        End Get
    End Property

    <Association>
    Public ReadOnly Property Doctors() As XPCollection(Of Doctors)
        Get
            Return GetCollection(Of Doctors)(NameOf(Doctors))
        End Get
    End Property
End Class
