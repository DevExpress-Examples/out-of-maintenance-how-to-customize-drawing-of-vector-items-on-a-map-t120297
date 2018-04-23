Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace DrawMapItemExample

	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()

			mapControl1.SetMapItemFactory(New MapItemFactory())
			Dim adapter As ListSourceDataAdapter = CType(Layer.Data, ListSourceDataAdapter)
			adapter.DataSource = TestData.Instance
		End Sub

		Public ReadOnly Property Layer() As VectorItemsLayer
			Get
				Return CType(mapControl1.Layers(0), VectorItemsLayer)
			End Get
		End Property

		Private Sub mapControl1_DrawMapItem(ByVal sender As Object, ByVal e As DrawMapItemEventArgs) Handles mapControl1.DrawMapItem
			Dim color1 As Color = CType(e.Item.Attributes("ColorProp").Value, Color)
			Dim color2 As Color = Color.FromArgb(255 - color1.R, 255 - color1.G, 255 - color1.B)
			e.Fill = If(e.IsHighlighted, color2, color1)
			e.Stroke = If(e.IsHighlighted, color1, color2)
			e.StrokeWidth = If(e.IsHighlighted, 5, 2)
		End Sub
	End Class

End Namespace
