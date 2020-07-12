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
Public Class Doctors
    Inherits privatebaseobject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()

    End Sub
    'Public Enum tt
    '    <XafDisplayName("نقدي")>
    '    Doctor
    '    Infermier
    'End Enum
    'Property typedoc As tt
    Private _phon2 As String
    Private _phon As String


    <Size(11)>
    Property Phon As String
        Get
            Return _phon
        End Get
        Set(ByVal Value As String)
            SetPropertyValue(NameOf(Phon), _phon, Value)
        End Set
    End Property

    <Size(11)>
    Property Phon2 As String
        Get
            Return _phon2
        End Get
        Set(ByVal Value As String)
            SetPropertyValue(NameOf(Phon2), _phon2, Value)
        End Set
    End Property

    'Public Function NewNumber() As Integer
    '    Try
    '        Dim n As Integer = (From lst As Doctors In Session.GetObjects(Session.GetClassInfo(Of Doctors), Nothing, New SortingCollection(New SortProperty("Code", DB.SortingDirection.Descending)), 0, False, True)).Max(Function(a) a.Code)
    '        Return n + 1
    '    Catch ex As Exception
    '        Return 1
    '    End Try
    'End Function

    'Private _speciality As Tkhasos

    '<Association>
    'Property Speciality As Tkhasos
    '    Get
    '        Return _speciality
    '    End Get
    '    Set(ByVal Value As Tkhasos)
    '        SetPropertyValue(NameOf(Tkhasos), _speciality, Value)
    '    End Set
    'End Property
    Public Function GetPrices(_tkhasos As Tkhasos, _tarifa As Tarifa) As Double
        Dim p As Double = 0
        Try
            p = (From lst As DoctorsPrice In Me.Prices Where lst.Tkhasos Is _tkhasos And lst.Tarifa Is _tarifa).FirstOrDefault.Money
        Catch ex As Exception
            Try
                Dim t As Tkhasos = (From lst As Tkhasos In Me.takhassousat Where lst Is _tkhasos).FirstOrDefault
                If t IsNot Nothing Then
                    p = (From lst As Tarifa In t.CodeMony Where lst Is _tarifa).FirstOrDefault.Money
                End If
            Catch ex1 As Exception

            End Try

        End Try
        Return p
    End Function
    <Association>
    Public ReadOnly Property takhassousat() As XPCollection(Of Tkhasos)
        Get
            Return GetCollection(Of Tkhasos)(NameOf(takhassousat))
        End Get
    End Property

    '<Association>
    'Public ReadOnly Property CodeMony() As XPCollection(Of Tarifa)
    '    Get
    '        Return GetCollection(Of Tarifa)(NameOf(CodeMony))
    '    End Get
    'End Property
    <Association, DevExpress.Xpo.Aggregated>
    Public ReadOnly Property Prices() As XPCollection(Of DoctorsPrice)
        Get
            Return GetCollection(Of DoctorsPrice)(NameOf(Prices))
        End Get
    End Property
End Class
<DefaultListViewOptions(True, NewItemRowPosition.Bottom)>
Public Class DoctorsPrice
    Inherits BaseObject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
    End Sub

    Private _tarifa As Tarifa
    Private _tkhasos As Tkhasos
    Private _doctor As Doctors
    Private _money As Double

    <Association, Indexed, RuleRequiredField, ImmediatePostData>
    Property Doctor As Doctors
        Get
            Return _doctor
        End Get
        Set(ByVal Value As Doctors)
            SetPropertyValue(NameOf(Doctor), _doctor, Value)
        End Set
    End Property
    <RuleRequiredField, ImmediatePostData, Indexed>
    <DataSourceProperty("Doctor.takhassousat")>
    Property Tkhasos As Tkhasos
        Get
            Return _tkhasos
        End Get
        Set(ByVal Value As Tkhasos)
            If SetPropertyValue(NameOf(Tkhasos), _tkhasos, Value) And IsLoading = False And IsSaving = False Then
                If Value Is Nothing Then
                    Me.Tarifa = Nothing
                Else
                    If Me.Tarifa IsNot Nothing AndAlso Me.Tarifa.tkhasos IsNot Value Then
                        Me.Tarifa = Nothing
                    End If
                End If
            End If
        End Set
    End Property
    <ImmediatePostData, RuleRequiredField, Indexed>
    <DataSourceProperty("Tkhasos.CodeMony")>
    Property Tarifa As Tarifa
        Get
            Return _tarifa
        End Get
        Set(ByVal Value As Tarifa)
            If SetPropertyValue(NameOf(Tarifa), _tarifa, Value) And IsLoading = False And IsSaving = False Then
                If Value Is Nothing Then
                    Me.Money = 0
                Else
                    If Session.IsNewObject(Me) Then
                        Me.Money = Value.Money
                    End If
                End If
            End If
        End Set
    End Property
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
End Class
