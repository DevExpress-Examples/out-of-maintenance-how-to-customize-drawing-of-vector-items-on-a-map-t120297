Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraMap

Namespace DrawMapItemExample

	Public Class MapItemFactory
		Inherits DefaultMapItemFactory

		Protected Overrides Sub InitializeItem(ByVal item As MapItem, ByVal obj As Object)
			MyBase.InitializeItem(item, obj)
			Dim rect As MapRectangle = TryCast(item, MapRectangle)
			If rect IsNot Nothing Then
				rect.Width = 1000
				rect.Height = 1000
			End If
		End Sub
	End Class
End Namespace
