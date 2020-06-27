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
Public Class Doctors
    Inherits privatebaseobject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
    End Sub

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
    <Association>
    Public ReadOnly Property takhassousat() As XPCollection(Of Tkhasos)
        Get
            Return GetCollection(Of Tkhasos)(NameOf(takhassousat))
        End Get
    End Property

    <Association>
    Public ReadOnly Property CodeMony() As XPCollection(Of Tarifa)
        Get
            Return GetCollection(Of Tarifa)(NameOf(CodeMony))
        End Get
    End Property

End Class
