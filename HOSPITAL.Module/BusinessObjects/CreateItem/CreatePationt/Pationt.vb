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
Public Class Pationt
    Inherits privatebaseobject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()

    End Sub


    Private _types As String
    Private _childerin As String
    Private _opertion As String
    Private _phon2 As String
    Private _name2 As String
    Private _phon As String


    <Size(SizeAttribute.DefaultStringMappingFieldSize)>
    Property Types As String
        Get
            Return _types
        End Get
        Set(ByVal Value As String)
            SetPropertyValue(NameOf(Types), _types, Value)
        End Set
    End Property
    Property BirthDay As Date

    <Size(SizeAttribute.DefaultStringMappingFieldSize)>
    Property Phon As String
        Get
            Return _phon
        End Get
        Set(ByVal Value As String)
            SetPropertyValue(NameOf(Phon), _phon, Value)
        End Set
    End Property

    <Size(SizeAttribute.DefaultStringMappingFieldSize)>
    Property Name2 As String
        Get
            Return _name2
        End Get
        Set(ByVal Value As String)
            SetPropertyValue(NameOf(Name2), _name2, Value)
        End Set
    End Property

    <Size(SizeAttribute.DefaultStringMappingFieldSize)>
    Property Phon2 As String
        Get
            Return _phon2
        End Get
        Set(ByVal Value As String)
            SetPropertyValue(NameOf(Phon2), _phon2, Value)
        End Set
    End Property

    <Size(SizeAttribute.DefaultStringMappingFieldSize)>
    Property Opertion As String
        Get
            Return _opertion
        End Get
        Set(ByVal Value As String)
            SetPropertyValue(NameOf(Opertion), _opertion, Value)
        End Set
    End Property

    <Size(SizeAttribute.DefaultStringMappingFieldSize)>
    Property Childerin As String
        Get
            Return _childerin
        End Get
        Set(ByVal Value As String)
            SetPropertyValue(NameOf(Childerin), _childerin, Value)
        End Set
    End Property

End Class
