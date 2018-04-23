namespace DrawMapItemExample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            DevExpress.XtraMap.ListSourceDataAdapter listSourceDataAdapter1 = new DevExpress.XtraMap.ListSourceDataAdapter();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping1 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping2 = new DevExpress.XtraMap.MapItemAttributeMapping();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            mapItemAttributeMapping1.Member = "Tag";
            mapItemAttributeMapping1.Name = "ColorProp";
            mapItemAttributeMapping2.Member = "Label";
            mapItemAttributeMapping2.Name = "Label";
            mapItemAttributeMapping2.ValueType = DevExpress.XtraMap.FieldValueType.String;
            listSourceDataAdapter1.AttributeMappings.Add(mapItemAttributeMapping1);
            listSourceDataAdapter1.AttributeMappings.Add(mapItemAttributeMapping2);
            listSourceDataAdapter1.DefaultMapItemType = DevExpress.XtraMap.MapItemType.Rectangle;
            listSourceDataAdapter1.Mappings.Latitude = "Lat";
            listSourceDataAdapter1.Mappings.Longitude = "Lon";
            listSourceDataAdapter1.Mappings.Text = "Text";
            vectorItemsLayer1.Data = listSourceDataAdapter1;
            vectorItemsLayer1.ShapeTitlesPattern = "{Label}";
            this.mapControl1.Layers.Add(vectorItemsLayer1);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.LookAndFeel.SkinName = "VS2010";
            this.mapControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(825, 546);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 4D;
            this.mapControl1.DrawMapItem += new DevExpress.XtraMap.DrawMapItemEventHandler(this.mapControl1_DrawMapItem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 546);
            this.Controls.Add(this.mapControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;




    }
}

