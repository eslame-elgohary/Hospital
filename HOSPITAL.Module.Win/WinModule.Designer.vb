﻿Imports Microsoft.VisualBasic
Imports System

Partial Public Class HOSPITALWindowsFormsModule
	''' <summary> 
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (Not components Is Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

#Region "Component Designer generated code"

	''' <summary> 
	''' Required method for Designer support - do not modify 
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		'
		'HOSPITALWindowsFormsModule
		'
		Me.RequiredModuleTypes.Add(GetType(HOSPITAL.Module.HOSPITALModule))
        Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule))
		Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.FileAttachments.Win.FileAttachmentsWindowsFormsModule))
		Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.ReportsV2.Win.ReportsWindowsFormsModuleV2))
		Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule))
	End Sub

#End Region
End Class