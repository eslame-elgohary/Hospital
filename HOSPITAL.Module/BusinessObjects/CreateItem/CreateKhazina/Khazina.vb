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
<DefaultClassOptions(), RuleCombinationOfPropertiesIsUnique("Code")>
Public Class Khazina
    Inherits privatebaseobject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()

    End Sub

    Private _rasedKhazina As Double
    Private _dateToDay As Date

    Property DateToDay As Date
        Get
            Return _dateToDay
        End Get
        Set(ByVal Value As Date)
            SetPropertyValue(NameOf(DateToDay), _dateToDay, Value)
        End Set
    End Property

    <ModelDefault("DisplayFormat", "{0:c2}"), ModelDefault("EditMask", "c2")>
    <RuleValueComparison(ValueComparisonType.GreaterThanOrEqual, 0)>
    Property RasedKhazina As Double
        Get
            Return _rasedKhazina
        End Get
        Set(ByVal Value As Double)
            SetPropertyValue(Nameof(RasedKhazina), _rasedKhazina, Value)
        End Set
    End Property
    
End Class
