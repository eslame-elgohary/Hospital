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

<NonPersistent>
Public Class privatebaseobject ' Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    Inherits BaseObject ' Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
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
    Public Overridable Function NewNumber() As Integer
        Try
            Dim n As Integer = (From lst As privatebaseobject In Session.GetObjects(Session.GetClassInfo(Me.GetType), Nothing, New SortingCollection(New SortProperty("Code", DB.SortingDirection.Descending)), 0, False, True)).Max(Function(a) a.Code)
            Return n + 1
        Catch ex As Exception
            Return 1
        End Try
    End Function
    Private _observation As String
    Private _name As String
    Private _code As String

    <Size(20), RuleRequiredField, Indexed, ModelDefault("AllowEdit", "False"), ImmediatePostData>
    Property Code As String
        Get
            Return _code
        End Get
        Set(ByVal Value As String)
            SetPropertyValue(NameOf(Code), _code, Value)
        End Set
    End Property

    <Size(200), RuleRequiredField, Indexed>
    Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            SetPropertyValue(NameOf(Name), _name, Value)
        End Set
    End Property

    <Size(SizeAttribute.Unlimited)>
    Property Observation As String
        Get
            Return _observation
        End Get
        Set(ByVal Value As String)
            SetPropertyValue(NameOf(Observation), _observation, Value)
        End Set
    End Property
    
End Class
