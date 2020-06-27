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
Public Class Drugs
    Inherits privatebaseobject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
    End Sub

    Private _drugsType As String

    <Size(20), RuleRequiredField, Indexed>
    Property DrugsType As String
        Get
            Return _drugsType
        End Get
        Set(ByVal Value As String)
            SetPropertyValue(NameOf(DrugsType), _drugsType, Value)
        End Set
    End Property
    

End Class
