Imports Microsoft.VisualBasic
Imports System
Namespace DrawMapItemExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim vectorItemsLayer1 As New DevExpress.XtraMap.VectorItemsLayer()
			Dim listSourceDataAdapter1 As New DevExpress.XtraMap.ListSourceDataAdapter()
			Dim mapItemAttributeMapping1 As New DevExpress.XtraMap.MapItemAttributeMapping()
			Dim mapItemAttributeMapping2 As New DevExpress.XtraMap.MapItemAttributeMapping()
			Me.mapControl1 = New DevExpress.XtraMap.MapControl()
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' mapControl1
			' 
			Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
			mapItemAttributeMapping1.Member = "Tag"
			mapItemAttributeMapping1.Name = "ColorProp"
			mapItemAttributeMapping2.Member = "Label"
			mapItemAttributeMapping2.Name = "Label"
			mapItemAttributeMapping2.ValueType = DevExpress.XtraMap.FieldValueType.String
			listSourceDataAdapter1.AttributeMappings.Add(mapItemAttributeMapping1)
			listSourceDataAdapter1.AttributeMappings.Add(mapItemAttributeMapping2)
			listSourceDataAdapter1.DefaultMapItemType = DevExpress.XtraMap.MapItemType.Rectangle
			listSourceDataAdapter1.Mappings.Latitude = "Lat"
			listSourceDataAdapter1.Mappings.Longitude = "Lon"
			listSourceDataAdapter1.Mappings.Text = "Text"
			vectorItemsLayer1.Data = listSourceDataAdapter1
			vectorItemsLayer1.ShapeTitlesPattern = "{Label}"
			Me.mapControl1.Layers.Add(vectorItemsLayer1)
			Me.mapControl1.Location = New System.Drawing.Point(0, 0)
			Me.mapControl1.LookAndFeel.SkinName = "VS2010"
			Me.mapControl1.LookAndFeel.UseDefaultLookAndFeel = False
			Me.mapControl1.Name = "mapControl1"
			Me.mapControl1.Size = New System.Drawing.Size(825, 546)
			Me.mapControl1.TabIndex = 0
			Me.mapControl1.ZoomLevel = 4R
'			Me.mapControl1.DrawMapItem += New DevExpress.XtraMap.DrawMapItemEventHandler(Me.mapControl1_DrawMapItem);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(825, 546)
			Me.Controls.Add(Me.mapControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents mapControl1 As DevExpress.XtraMap.MapControl




	End Class
End Namespace

