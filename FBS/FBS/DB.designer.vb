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
  Partial Private Sub InsertBooking(instance As Booking)
    End Sub
  Partial Private Sub UpdateBooking(instance As Booking)
    End Sub
  Partial Private Sub DeleteBooking(instance As Booking)
    End Sub
  Partial Private Sub InsertTimeslot(instance As Timeslot)
    End Sub
  Partial Private Sub UpdateTimeslot(instance As Timeslot)
    End Sub
  Partial Private Sub DeleteTimeslot(instance As Timeslot)
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
	
	Public ReadOnly Property Bookings() As System.Data.Linq.Table(Of Booking)
		Get
			Return Me.GetTable(Of Booking)
		End Get
	End Property
	
	Public ReadOnly Property Timeslots() As System.Data.Linq.Table(Of Timeslot)
		Get
			Return Me.GetTable(Of Timeslot)
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
	
	Private _Timeslots As EntitySet(Of Timeslot)
	
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
		Me._Timeslots = New EntitySet(Of Timeslot)(AddressOf Me.attach_Timeslots, AddressOf Me.detach_Timeslots)
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
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Venue_Timeslot", Storage:="_Timeslots", ThisKey:="VenueID", OtherKey:="VenueID")>  _
	Public Property Timeslots() As EntitySet(Of Timeslot)
		Get
			Return Me._Timeslots
		End Get
		Set
			Me._Timeslots.Assign(value)
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
	
	Private Sub attach_Timeslots(ByVal entity As Timeslot)
		Me.SendPropertyChanging
		entity.Venue = Me
	End Sub
	
	Private Sub detach_Timeslots(ByVal entity As Timeslot)
		Me.SendPropertyChanging
		entity.Venue = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Booking")>  _
Partial Public Class Booking
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _BookingID As String
	
	Private _BookingDate As System.Nullable(Of Date)
	
	Private _BookingTime As System.Nullable(Of System.TimeSpan)
	
	Private _VisitDate As System.Nullable(Of Date)
	
	Private _BookingCharges As System.Nullable(Of Decimal)
	
	Private _StartTime As System.Nullable(Of System.TimeSpan)
	
	Private _EndTime As System.Nullable(Of System.TimeSpan)
	
	Private _Duration As System.Nullable(Of Integer)
	
	Private _CustID As String
	
	Private _SlotID As String
	
	Private _Timeslot As EntityRef(Of Timeslot)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnBookingIDChanging(value As String)
    End Sub
    Partial Private Sub OnBookingIDChanged()
    End Sub
    Partial Private Sub OnBookingDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnBookingDateChanged()
    End Sub
    Partial Private Sub OnBookingTimeChanging(value As System.Nullable(Of System.TimeSpan))
    End Sub
    Partial Private Sub OnBookingTimeChanged()
    End Sub
    Partial Private Sub OnVisitDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnVisitDateChanged()
    End Sub
    Partial Private Sub OnBookingChargesChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnBookingChargesChanged()
    End Sub
    Partial Private Sub OnStartTimeChanging(value As System.Nullable(Of System.TimeSpan))
    End Sub
    Partial Private Sub OnStartTimeChanged()
    End Sub
    Partial Private Sub OnEndTimeChanging(value As System.Nullable(Of System.TimeSpan))
    End Sub
    Partial Private Sub OnEndTimeChanged()
    End Sub
    Partial Private Sub OnDurationChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnDurationChanged()
    End Sub
    Partial Private Sub OnCustIDChanging(value As String)
    End Sub
    Partial Private Sub OnCustIDChanged()
    End Sub
    Partial Private Sub OnSlotIDChanging(value As String)
    End Sub
    Partial Private Sub OnSlotIDChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Timeslot = CType(Nothing, EntityRef(Of Timeslot))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_BookingID", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property BookingID() As String
		Get
			Return Me._BookingID
		End Get
		Set
			If (String.Equals(Me._BookingID, value) = false) Then
				Me.OnBookingIDChanging(value)
				Me.SendPropertyChanging
				Me._BookingID = value
				Me.SendPropertyChanged("BookingID")
				Me.OnBookingIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_BookingDate", DbType:="Date")>  _
	Public Property BookingDate() As System.Nullable(Of Date)
		Get
			Return Me._BookingDate
		End Get
		Set
			If (Me._BookingDate.Equals(value) = false) Then
				Me.OnBookingDateChanging(value)
				Me.SendPropertyChanging
				Me._BookingDate = value
				Me.SendPropertyChanged("BookingDate")
				Me.OnBookingDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_BookingTime", DbType:="Time")>  _
	Public Property BookingTime() As System.Nullable(Of System.TimeSpan)
		Get
			Return Me._BookingTime
		End Get
		Set
			If (Me._BookingTime.Equals(value) = false) Then
				Me.OnBookingTimeChanging(value)
				Me.SendPropertyChanging
				Me._BookingTime = value
				Me.SendPropertyChanged("BookingTime")
				Me.OnBookingTimeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_VisitDate", DbType:="Date")>  _
	Public Property VisitDate() As System.Nullable(Of Date)
		Get
			Return Me._VisitDate
		End Get
		Set
			If (Me._VisitDate.Equals(value) = false) Then
				Me.OnVisitDateChanging(value)
				Me.SendPropertyChanging
				Me._VisitDate = value
				Me.SendPropertyChanged("VisitDate")
				Me.OnVisitDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_BookingCharges", DbType:="Money")>  _
	Public Property BookingCharges() As System.Nullable(Of Decimal)
		Get
			Return Me._BookingCharges
		End Get
		Set
			If (Me._BookingCharges.Equals(value) = false) Then
				Me.OnBookingChargesChanging(value)
				Me.SendPropertyChanging
				Me._BookingCharges = value
				Me.SendPropertyChanged("BookingCharges")
				Me.OnBookingChargesChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_StartTime", DbType:="Time")>  _
	Public Property StartTime() As System.Nullable(Of System.TimeSpan)
		Get
			Return Me._StartTime
		End Get
		Set
			If (Me._StartTime.Equals(value) = false) Then
				Me.OnStartTimeChanging(value)
				Me.SendPropertyChanging
				Me._StartTime = value
				Me.SendPropertyChanged("StartTime")
				Me.OnStartTimeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EndTime", DbType:="Time")>  _
	Public Property EndTime() As System.Nullable(Of System.TimeSpan)
		Get
			Return Me._EndTime
		End Get
		Set
			If (Me._EndTime.Equals(value) = false) Then
				Me.OnEndTimeChanging(value)
				Me.SendPropertyChanging
				Me._EndTime = value
				Me.SendPropertyChanged("EndTime")
				Me.OnEndTimeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Duration", DbType:="Int")>  _
	Public Property Duration() As System.Nullable(Of Integer)
		Get
			Return Me._Duration
		End Get
		Set
			If (Me._Duration.Equals(value) = false) Then
				Me.OnDurationChanging(value)
				Me.SendPropertyChanging
				Me._Duration = value
				Me.SendPropertyChanged("Duration")
				Me.OnDurationChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CustID", DbType:="NVarChar(50)")>  _
	Public Property CustID() As String
		Get
			Return Me._CustID
		End Get
		Set
			If (String.Equals(Me._CustID, value) = false) Then
				Me.OnCustIDChanging(value)
				Me.SendPropertyChanging
				Me._CustID = value
				Me.SendPropertyChanged("CustID")
				Me.OnCustIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SlotID", DbType:="NVarChar(50)")>  _
	Public Property SlotID() As String
		Get
			Return Me._SlotID
		End Get
		Set
			If (String.Equals(Me._SlotID, value) = false) Then
				If Me._Timeslot.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnSlotIDChanging(value)
				Me.SendPropertyChanging
				Me._SlotID = value
				Me.SendPropertyChanged("SlotID")
				Me.OnSlotIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Timeslot_Booking", Storage:="_Timeslot", ThisKey:="SlotID", OtherKey:="SlotID", IsForeignKey:=true)>  _
	Public Property Timeslot() As Timeslot
		Get
			Return Me._Timeslot.Entity
		End Get
		Set
			Dim previousValue As Timeslot = Me._Timeslot.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Timeslot.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Timeslot.Entity = Nothing
					previousValue.Bookings.Remove(Me)
				End If
				Me._Timeslot.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Bookings.Add(Me)
					Me._SlotID = value.SlotID
				Else
					Me._SlotID = CType(Nothing, String)
				End If
				Me.SendPropertyChanged("Timeslot")
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

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Timeslot")>  _
Partial Public Class Timeslot
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _SlotID As String
	
	Private _StartTime As System.Nullable(Of System.TimeSpan)
	
	Private _EndTime As System.Nullable(Of System.TimeSpan)
	
	Private _Date As System.Nullable(Of Date)
	
	Private _BookingID As String
	
	Private _VenueID As System.Nullable(Of Integer)
	
	Private _Status As System.Nullable(Of Boolean)
	
	Private _Bookings As EntitySet(Of Booking)
	
	Private _Venue As EntityRef(Of Venue)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnSlotIDChanging(value As String)
    End Sub
    Partial Private Sub OnSlotIDChanged()
    End Sub
    Partial Private Sub OnStartTimeChanging(value As System.Nullable(Of System.TimeSpan))
    End Sub
    Partial Private Sub OnStartTimeChanged()
    End Sub
    Partial Private Sub OnEndTimeChanging(value As System.Nullable(Of System.TimeSpan))
    End Sub
    Partial Private Sub OnEndTimeChanged()
    End Sub
    Partial Private Sub OnDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnDateChanged()
    End Sub
    Partial Private Sub OnBookingIDChanging(value As String)
    End Sub
    Partial Private Sub OnBookingIDChanged()
    End Sub
    Partial Private Sub OnVenueIDChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnVenueIDChanged()
    End Sub
    Partial Private Sub OnStatusChanging(value As System.Nullable(Of Boolean))
    End Sub
    Partial Private Sub OnStatusChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Bookings = New EntitySet(Of Booking)(AddressOf Me.attach_Bookings, AddressOf Me.detach_Bookings)
		Me._Venue = CType(Nothing, EntityRef(Of Venue))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SlotID", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property SlotID() As String
		Get
			Return Me._SlotID
		End Get
		Set
			If (String.Equals(Me._SlotID, value) = false) Then
				Me.OnSlotIDChanging(value)
				Me.SendPropertyChanging
				Me._SlotID = value
				Me.SendPropertyChanged("SlotID")
				Me.OnSlotIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_StartTime", DbType:="Time")>  _
	Public Property StartTime() As System.Nullable(Of System.TimeSpan)
		Get
			Return Me._StartTime
		End Get
		Set
			If (Me._StartTime.Equals(value) = false) Then
				Me.OnStartTimeChanging(value)
				Me.SendPropertyChanging
				Me._StartTime = value
				Me.SendPropertyChanged("StartTime")
				Me.OnStartTimeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EndTime", DbType:="Time")>  _
	Public Property EndTime() As System.Nullable(Of System.TimeSpan)
		Get
			Return Me._EndTime
		End Get
		Set
			If (Me._EndTime.Equals(value) = false) Then
				Me.OnEndTimeChanging(value)
				Me.SendPropertyChanging
				Me._EndTime = value
				Me.SendPropertyChanged("EndTime")
				Me.OnEndTimeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="Date", Storage:="_Date", DbType:="Date")>  _
	Public Property [Date]() As System.Nullable(Of Date)
		Get
			Return Me._Date
		End Get
		Set
			If (Me._Date.Equals(value) = false) Then
				Me.OnDateChanging(value)
				Me.SendPropertyChanging
				Me._Date = value
				Me.SendPropertyChanged("[Date]")
				Me.OnDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_BookingID", DbType:="NVarChar(50)")>  _
	Public Property BookingID() As String
		Get
			Return Me._BookingID
		End Get
		Set
			If (String.Equals(Me._BookingID, value) = false) Then
				Me.OnBookingIDChanging(value)
				Me.SendPropertyChanging
				Me._BookingID = value
				Me.SendPropertyChanged("BookingID")
				Me.OnBookingIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_VenueID", DbType:="Int")>  _
	Public Property VenueID() As System.Nullable(Of Integer)
		Get
			Return Me._VenueID
		End Get
		Set
			If (Me._VenueID.Equals(value) = false) Then
				If Me._Venue.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnVenueIDChanging(value)
				Me.SendPropertyChanging
				Me._VenueID = value
				Me.SendPropertyChanged("VenueID")
				Me.OnVenueIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Status", DbType:="Bit")>  _
	Public Property Status() As System.Nullable(Of Boolean)
		Get
			Return Me._Status
		End Get
		Set
			If (Me._Status.Equals(value) = false) Then
				Me.OnStatusChanging(value)
				Me.SendPropertyChanging
				Me._Status = value
				Me.SendPropertyChanged("Status")
				Me.OnStatusChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Timeslot_Booking", Storage:="_Bookings", ThisKey:="SlotID", OtherKey:="SlotID")>  _
	Public Property Bookings() As EntitySet(Of Booking)
		Get
			Return Me._Bookings
		End Get
		Set
			Me._Bookings.Assign(value)
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Venue_Timeslot", Storage:="_Venue", ThisKey:="VenueID", OtherKey:="VenueID", IsForeignKey:=true)>  _
	Public Property Venue() As Venue
		Get
			Return Me._Venue.Entity
		End Get
		Set
			Dim previousValue As Venue = Me._Venue.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Venue.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Venue.Entity = Nothing
					previousValue.Timeslots.Remove(Me)
				End If
				Me._Venue.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Timeslots.Add(Me)
					Me._VenueID = value.VenueID
				Else
					Me._VenueID = CType(Nothing, Nullable(Of Integer))
				End If
				Me.SendPropertyChanged("Venue")
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
	
	Private Sub attach_Bookings(ByVal entity As Booking)
		Me.SendPropertyChanging
		entity.Timeslot = Me
	End Sub
	
	Private Sub detach_Bookings(ByVal entity As Booking)
		Me.SendPropertyChanging
		entity.Timeslot = Nothing
	End Sub
End Class
