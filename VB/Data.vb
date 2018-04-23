Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Drawing

Namespace DrawMapItemExample

	Public Class TestDataItem
		Private privateLabel As String
		Public Property Label() As String
			Get
				Return privateLabel
			End Get
			Set(ByVal value As String)
				privateLabel = value
			End Set
		End Property
		Private privateLat As Double
		Public Property Lat() As Double
			Get
				Return privateLat
			End Get
			Set(ByVal value As Double)
				privateLat = value
			End Set
		End Property
		Private privateLon As Double
		Public Property Lon() As Double
			Get
				Return privateLon
			End Get
			Set(ByVal value As Double)
				privateLon = value
			End Set
		End Property
		Private privateTag As Color
		Public Property Tag() As Color
			Get
				Return privateTag
			End Get
			Set(ByVal value As Color)
				privateTag = value
			End Set
		End Property
	End Class

	Public Class TestData
		Inherits List(Of TestDataItem)
		Private Shared ReadOnly instance_Renamed As TestData

		Shared Sub New()
			instance_Renamed = New TestData()
			instance_Renamed.Add(New TestDataItem() With {.Lat = 14, .Lon = 8, .Label = "A", .Tag = Color.Yellow})
			instance_Renamed.Add(New TestDataItem() With {.Lat = 4, .Lon = -2, .Label = "B", .Tag = Color.Purple})
			instance_Renamed.Add(New TestDataItem() With {.Lat = -6, .Lon = -12, .Label = "C", .Tag = Color.Red})
		End Sub

		Public Shared ReadOnly Property Instance() As TestData
			Get
				Return instance_Renamed
			End Get
		End Property
	End Class

End Namespace
