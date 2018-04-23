using DevExpress.XtraMap;

namespace DrawMapItemExample {

    public class MapItemFactory : DefaultMapItemFactory {

        protected override void InitializeItem(MapItem item, object obj) {
            base.InitializeItem(item, obj);
            MapRectangle rect = item as MapRectangle;
            if(rect != null) {
                rect.Width = 1000;
                rect.Height = 1000;
            }
        }
    }
}
