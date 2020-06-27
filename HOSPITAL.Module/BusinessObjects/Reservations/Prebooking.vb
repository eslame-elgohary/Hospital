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


<DefaultClassOptions()>
Public Class PreBooking
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
    Private _pationt As Pationt
    Property Pationt As Pationt
        Get
            Return _pationt
        End Get
        Set(ByVal Value As Pationt)
            SetPropertyValue(NameOf(Pationt), _pationt, Value)
        End Set
    End Property

    Private _dateReservation As Date

    <Size(SizeAttribute.DefaultStringMappingFieldSize)>
    Property DateReservation As Date
        Get
            Return _dateReservation
        End Get
        Set(ByVal Value As Date)
            SetPropertyValue(NameOf(DateReservation), _dateReservation, Value)
        End Set
    End Property
    Private _Tkhasos As Tkhasos
    Property Tkhasos As Tkhasos
        Get
            Return _Tkhasos
        End Get
        Set(ByVal Value As Tkhasos)
            SetPropertyValue(NameOf(Tkhasos), _Tkhasos, Value)
        End Set
    End Property

    Private _Doctors As Doctors
    Property Doctors As Doctors
        Get
            Return _Doctors
        End Get
        Set(ByVal Value As Doctors)
            SetPropertyValue(NameOf(Doctors), _Doctors, Value)
        End Set
    End Property

    Public Function NewNumber() As Integer
        Try
            Dim n As Integer = (From lst As PreBooking In Session.GetObjects(Session.GetClassInfo(Of PreBooking), Nothing, New SortingCollection(New SortProperty("Code", DB.SortingDirection.Descending)), 0, False, True)).Max(Function(a) a.Code)
            Return n + 1
        Catch ex As Exception
            Return 1
        End Try
    End Function
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

End Class
