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

<DefaultClassOptions()> _
Public Class InfoHospital ' Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    Inherits BaseObject ' Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
        ' Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
    End Sub


    Private _phonNumber2 As String
    Private _phonNumber As String
    Private _adress As String
    Private _nameHospital As String

    <Size(SizeAttribute.DefaultStringMappingFieldSize)>
    Property NameHospital As String
        Get
            Return _nameHospital
        End Get
        Set(ByVal Value As String)
            SetPropertyValue(NameOf(NameHospital), _nameHospital, Value)
        End Set
    End Property

    <Size(SizeAttribute.DefaultStringMappingFieldSize)>
    Property Adress As String
        Get
            Return _adress
        End Get
        Set(ByVal Value As String)
            SetPropertyValue(NameOf(Adress), _adress, Value)
        End Set
    End Property

    <Size(SizeAttribute.DefaultStringMappingFieldSize)>
    Property PhonNumber As String
        Get
            Return _phonNumber
        End Get
        Set(ByVal Value As String)
            SetPropertyValue(NameOf(PhonNumber), _phonNumber, Value)
        End Set
    End Property

    <Size(SizeAttribute.DefaultStringMappingFieldSize)>
    Property PhonNumber2 As String
        Get
            Return _phonNumber2
        End Get
        Set(ByVal Value As String)
            SetPropertyValue(NameOf(PhonNumber2), _phonNumber2, Value)
        End Set
    End Property

End Class
