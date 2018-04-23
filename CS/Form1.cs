using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace DrawMapItemExample {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();

            mapControl1.SetMapItemFactory(new MapItemFactory());
            ListSourceDataAdapter adapter = (ListSourceDataAdapter)Layer.Data;
            adapter.DataSource = TestData.Instance;
        }

        public VectorItemsLayer Layer { get { return (VectorItemsLayer)mapControl1.Layers[0]; } }

        private void mapControl1_DrawMapItem(object sender, DrawMapItemEventArgs e) {
            Color color1 = (Color)e.Item.Attributes["ColorProp"].Value;
            Color color2 = Color.FromArgb(255 - color1.R, 255 - color1.G, 255 - color1.B);
            e.Fill = e.IsHighlighted ? color2 : color1;
            e.Stroke = e.IsHighlighted ? color1 :  color2;
            e.StrokeWidth = e.IsHighlighted ? 5 : 2;
        }
    }

}
