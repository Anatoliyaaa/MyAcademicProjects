using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraMap;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Map;

namespace Приложение_V_0._1
{
    public partial class FMap : Form
    {
        List<MyPoint> _DP = new List<MyPoint>();
        //const string imageFilePath = @"../../logo.png";
        //VectorItemsLayer VectorLayer { get { return (VectorItemsLayer)mapControl1.Layers["VectorLayer"]; } }
        //MapItemStorage ItemStorage { get { return (MapItemStorage)VectorLayer.Data; } }
        public FMap(List<MyPoint> demopoint)
        {
            InitializeComponent();
            _DP = demopoint;
        }

        private void FMap_Load(object sender, EventArgs e)
        {
            lNrc.Text = "Размещено РЦ: "+ Convert.ToString(_DP.Count);

            VectorItemsLayer itemsLayer = new VectorItemsLayer();
            mapControl1.Layers.Add(itemsLayer);
            MapItemStorage storage = new MapItemStorage();
            for (int i = 0; i < _DP.Count; i++)
            {
                string s = "";
                if (_DP[i]._p)
                    s = " ( построено )";
                else
                    s = " ( не построено )";

                storage.Items.Add(new MapCallout() { Location = new GeoPoint(_DP[i]._x, _DP[i]._y), Text = "РЦ №" + (i + 1)+s, TextColor = Color.FromArgb(212, 62, 63) });
                //storage.Items.Add(new MapRectangle() { Location = new GeoPoint(_DP[i]._x, _DP[i]._y), Width = MyPoint.R(_DP[i]._x, _DP[i]._x + SectorCounting.nx, _DP[i]._y, _DP[i]._y + SectorCounting.ny), Height = 200 });// MyPoint.R(_DP[i]._x, _DP[i]._x + SectorCounting.nx, _DP[i]._y, _DP[i]._y + SectorCounting.ny)
            }
                
            itemsLayer.Data = storage;
            this.Controls.Add(mapControl1);
            // Create a map control.
            //MapControl mapConrol1 = new MapControl();//

            // Specify the map position on the form.           
            //map.Dock = DockStyle.Fill;

            // Create a layer.
            ImageLayer layer = new ImageLayer();
            mapControl1.Layers.Add(layer);

            // Create a data provider.
            BingMapDataProvider provider = new BingMapDataProvider();
            provider.BingKey = "AnpNIUucHglIOvIdAuYxRp-d07RDd0vqZjZD4R845bm_7OXi9drHFZoRKARMQhxj";
            layer.DataProvider = provider;

            // Specify the map zoom level and center point. 
            mapControl1.ZoomLevel = 10;
            mapControl1.CenterPoint = new GeoPoint(45, 38.98);

            // Add the map control to the window.
            this.Controls.Add(mapControl1);
        }

        private void mapControl1_Click(object sender, EventArgs e)
        {

        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lNrc_Click(object sender, EventArgs e)
        {

        }
    }
}
