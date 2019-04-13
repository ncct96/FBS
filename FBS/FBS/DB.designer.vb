﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="FBS")>  _
Partial Public Class DBDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertVenue(instance As Venue)
    End Sub
  Partial Private Sub UpdateVenue(instance As Venue)
    End Sub
  Partial Private Sub DeleteVenue(instance As Venue)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.FBS.My.MySettings.Default.FBSConnectionString2, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Venues() As System.Data.Linq.Table(Of Venue)
		Get
			Return Me.GetTable(Of Venue)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Venue")>  _
Partial Public Class Venue
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _VenueID As Integer
	
	Private _VenueType As String
	
	Private _VenueName As String
	
	Private _VenuePicture As System.Data.Linq.Binary
	
	Private _VenueMaxCapacity As System.Nullable(Of Integer)
	
	Private _VenueRecommendations As String
	
	Private _VenueRate As System.Nullable(Of Decimal)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnVenueIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnVenueIDChanged()
    End Sub
    Partial Private Sub OnVenueTypeChanging(value As String)
    End Sub
    Partial Private Sub OnVenueTypeChanged()
    End Sub
    Partial Private Sub OnVenueNameChanging(value As String)
    End Sub
    Partial Private Sub OnVenueNameChanged()
    End Sub
    Partial Private Sub OnVenuePictureChanging(value As System.Data.Linq.Binary)
    End Sub
    Partial Private Sub OnVenuePictureChanged()
    End Sub
    Partial Private Sub OnVenueMaxCapacityChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnVenueMaxCapacityChanged()
    End Sub
    Partial Private Sub OnVenueRecommendationsChanging(value As String)
    End Sub
    Partial Private Sub OnVenueRecommendationsChanged()
    End Sub
    Partial Private Sub OnVenueRateChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnVenueRateChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_VenueID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property VenueID() As Integer
		Get
			Return Me._VenueID
		End Get
		Set
			If ((Me._VenueID = value)  _
						= false) Then
				Me.OnVenueIDChanging(value)
				Me.SendPropertyChanging
				Me._VenueID = value
				Me.SendPropertyChanged("VenueID")
				Me.OnVenueIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_VenueType", DbType:="NVarChar(50)")>  _
	Public Property VenueType() As String
		Get
			Return Me._VenueType
		End Get
		Set
			If (String.Equals(Me._VenueType, value) = false) Then
				Me.OnVenueTypeChanging(value)
				Me.SendPropertyChanging
				Me._VenueType = value
				Me.SendPropertyChanged("VenueType")
				Me.OnVenueTypeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_VenueName", DbType:="NVarChar(30) NOT NULL", CanBeNull:=false)>  _
	Public Property VenueName() As String
		Get
			Return Me._VenueName
		End Get
		Set
			If (String.Equals(Me._VenueName, value) = false) Then
				Me.OnVenueNameChanging(value)
				Me.SendPropertyChanging
				Me._VenueName = value
				Me.SendPropertyChanged("VenueName")
				Me.OnVenueNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_VenuePicture", DbType:="Image", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property VenuePicture() As System.Data.Linq.Binary
		Get
			Return Me._VenuePicture
		End Get
		Set
			If (Object.Equals(Me._VenuePicture, value) = false) Then
				Me.OnVenuePictureChanging(value)
				Me.SendPropertyChanging
				Me._VenuePicture = value
				Me.SendPropertyChanged("VenuePicture")
				Me.OnVenuePictureChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_VenueMaxCapacity", DbType:="Int")>  _
	Public Property VenueMaxCapacity() As System.Nullable(Of Integer)
		Get
			Return Me._VenueMaxCapacity
		End Get
		Set
			If (Me._VenueMaxCapacity.Equals(value) = false) Then
				Me.OnVenueMaxCapacityChanging(value)
				Me.SendPropertyChanging
				Me._VenueMaxCapacity = value
				Me.SendPropertyChanged("VenueMaxCapacity")
				Me.OnVenueMaxCapacityChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_VenueRecommendations", DbType:="NVarChar(30)")>  _
	Public Property VenueRecommendations() As String
		Get
			Return Me._VenueRecommendations
		End Get
		Set
			If (String.Equals(Me._VenueRecommendations, value) = false) Then
				Me.OnVenueRecommendationsChanging(value)
				Me.SendPropertyChanging
				Me._VenueRecommendations = value
				Me.SendPropertyChanged("VenueRecommendations")
				Me.OnVenueRecommendationsChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_VenueRate", DbType:="Money")>  _
	Public Property VenueRate() As System.Nullable(Of Decimal)
		Get
			Return Me._VenueRate
		End Get
		Set
			If (Me._VenueRate.Equals(value) = false) Then
				Me.OnVenueRateChanging(value)
				Me.SendPropertyChanging
				Me._VenueRate = value
				Me.SendPropertyChanged("VenueRate")
				Me.OnVenueRateChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class