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
Public Class PriceTester
    Inherits BaseObject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
        Me.Code = NewNumber()
    End Sub
    Protected Overrides Sub OnSaving()
        MyBase.OnSaving()
        If Session.IsNewObject(Me) And Session.IsObjectToDelete(Me) = False Then
            Me.Code = NewNumber()
        End If
    End Sub
    Public Function NewNumber() As Integer
        Try
            Dim n As Integer = (From lst As PriceTester In Session.GetObjects(Session.GetClassInfo(Of PriceTester), Nothing, New SortingCollection(New SortProperty("Code", DB.SortingDirection.Descending)), 0, False, True)).Max(Function(a) a.Code)
            Return n + 1
        Catch ex As Exception
            Return 1
        End Try
    End Function
    Private _testerName As Tester
    Private _labsName As Labs
    Private _priceEgyption As Double
    Private _priceLab As Double
    Private _code As String
    <Size(20), RuleRequiredField, Indexed, ModelDefault("AllowEdit", "False")>
    Property Code As String
        Get
            Return _code
        End Get
        Set(ByVal Value As String)
            SetPropertyValue(NameOf(Code), _code, Value)
        End Set
    End Property

    <ModelDefault("DisplayFormat", "{0:c2}"), ModelDefault("EditMask", "c2")>
    <RuleValueComparison(ValueComparisonType.GreaterThanOrEqual, 0)>
    Property PriceLab As Double
        Get
            Return _priceLab
        End Get
        Set(ByVal Value As Double)
            SetPropertyValue(NameOf(PriceLab), _priceLab, Value)
        End Set
    End Property
    <ModelDefault("DisplayFormat", "{0:c2}"), ModelDefault("EditMask", "c2")>
    <RuleValueComparison(ValueComparisonType.GreaterThanOrEqual, 0)>
    Property PriceEgyption As Double
        Get
            Return _priceEgyption
        End Get
        Set(ByVal Value As Double)
            SetPropertyValue(NameOf(PriceEgyption), _priceEgyption, Value)
        End Set
    End Property

    <Association>
    Property LabsName As Labs
        Get
            Return _labsName
        End Get
        Set(ByVal Value As Labs)
            SetPropertyValue(NameOf(LabsName), _labsName, Value)
        End Set
    End Property

    <Association>
    Property TesterName As Tester
        Get
            Return _testerName
        End Get
        Set(ByVal Value As Tester)
            SetPropertyValue(NameOf(TesterName), _testerName, Value)
        End Set
    End Property
    

End Class
