
using System.Collections.Generic;
using System.Drawing;

namespace DrawMapItemExample {

    public class TestDataItem {
        public string Label { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public Color Tag { get; set; }
    }

    public class TestData : List<TestDataItem> {
        static readonly TestData instance;

        static TestData() {
            instance = new TestData();
            instance.Add(new TestDataItem() { Lat = 14, Lon = 8, Label = "A", Tag = Color.Yellow });
            instance.Add(new TestDataItem() { Lat = 4, Lon = -2, Label = "B", Tag = Color.Purple });
            instance.Add(new TestDataItem() { Lat = -6, Lon = -12, Label = "C", Tag = Color.Red });
        }

        public static TestData Instance { get { return instance; } }
    }

}
