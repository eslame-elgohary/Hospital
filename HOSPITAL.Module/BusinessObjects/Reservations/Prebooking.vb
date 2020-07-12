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


<DefaultClassOptions(), DefaultProperty("Hajz")>
<RuleCombinationOfPropertiesIsUnique("Doctors,Tkhasos,DateReservation,Pationt", MessageTemplateCombinationOfPropertiesMustBeUnique:=" يوجد حجز أخر لهذا المريض")>
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
    <ImmediatePostData, XafDisplayName("الحجوزات")>
    ReadOnly Property Hajz As String
        Get
            Dim s As String = ""
            s = String.Format("حجز رقم {0} بتاريخ {1}", Me.Code, String.Format(Me.DateReservation.Date, "d").ToString)
            Return s
        End Get
    End Property
    Private _acte As Tarifa
    Private _price As Double
    Private _pationt As Pationt
    <ImmediatePostData, RuleRequiredField>
    Property Pationt As Pationt
        Get
            Return _pationt
        End Get
        Set(ByVal Value As Pationt)
            SetPropertyValue(NameOf(Pationt), _pationt, Value)
        End Set
    End Property

    Private _dateReservation As Date

    <ImmediatePostData, RuleRequiredField, Indexed>
    <ModelDefault("DisplayFormat", "{0:d}")>
    Property DateReservation As Date
        Get
            Return _dateReservation
        End Get
        Set(ByVal Value As Date)
            If SetPropertyValue(NameOf(DateReservation), _dateReservation, Value) And IsLoading = False And IsSaving = False Then
                If Session.IsNewObject(Me) Then
                    Me.Code = Me.NewNumber()
                End If
            End If
        End Set
    End Property
    Private _Tkhasos As Tkhasos
    <ImmediatePostData, RuleRequiredField, Indexed>
    Property Tkhasos As Tkhasos
        Get
            Return _Tkhasos
        End Get
        Set(ByVal Value As Tkhasos)
            If SetPropertyValue(NameOf(Tkhasos), _Tkhasos, Value) And IsLoading = False And IsSaving = False Then
                If Session.IsNewObject(Me) Then
                    Me.Code = Me.NewNumber()
                End If
                If Value Is Nothing Then
                    Me.Doctors = Nothing
                Else
                    If Me.Doctors IsNot Nothing AndAlso Value.Doctors.Contains(Me.Doctors) = False Then
                        Me.Doctors = Nothing

                    End If
                End If
            End If
        End Set
    End Property

    Private _Doctors As Doctors
    <ImmediatePostData, RuleRequiredField>
    <DataSourceProperty("Tkhasos.Doctors"), Indexed>
    <ConditionalAppearance.Appearance("doc", "ViewItem", Enabled:=False, Criteria:="IsNull(Tkhasos)")>
    Property Doctors As Doctors
        Get
            Return _Doctors
        End Get
        Set(ByVal Value As Doctors)
            If SetPropertyValue(NameOf(Doctors), _Doctors, Value) And IsSaving = False And IsLoading = False Then
                If Session.IsNewObject(Me) Then
                    Me.Code = Me.NewNumber()
                End If
            End If
        End Set
    End Property

    Public Function NewNumber() As Integer
        Try
            Dim gc As New GroupOperator
            gc.OperatorType = GroupOperatorType.And
            With gc.Operands
                .Add(New BinaryOperator("Doctors", Me.Doctors))
                .Add(New BinaryOperator("Tkhasos", Me.Tkhasos))
                .Add(New BinaryOperator("DateReservation", Me.DateReservation))
            End With
            Dim n As Integer = (From lst As PreBooking In Session.GetObjects(Session.GetClassInfo(Of PreBooking), gc, New SortingCollection(New SortProperty("Code", DB.SortingDirection.Descending)), 0, False, True)).Max(Function(a) a.Code)
            Return n + 1
        Catch ex As Exception
            Return 1
        End Try
    End Function
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
    <ImmediatePostData, DataSourceProperty("Tkhasos.CodeMony")>
    <ModelDefault("LookupProperty", "Name")>
    Property Acte As Tarifa
        Get
            Return _acte
        End Get
        Set(ByVal Value As Tarifa)
            SetPropertyValue(NameOf(Acte), _acte, Value)
        End Set
    End Property
    
    <ImmediatePostData>
    ReadOnly Property Price As Double
        Get
            Try
                Return Me.Doctors.GetPrices(Me.Tkhasos, Me.Acte)
            Catch ex As Exception

            End Try

        End Get
    End Property
    
End Class
