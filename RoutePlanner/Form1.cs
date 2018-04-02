using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace RoutePlanner
{
    public partial class MainForm : Form
    {
        public static List<GMapMarker> listMarkers = new List<GMapMarker>();
        public static GMapMarker startMarker = new GMarkerGoogle(new PointLatLng(0, 0), GMarkerGoogleType.red_dot);
        public static GMapMarker stopMarker = new GMarkerGoogle(new PointLatLng(0, 0), GMarkerGoogleType.red_dot);
        public static GMapOverlay markersOverlay = new GMapOverlay("MarkersOverlay");
        public List<Landmarks> listLandmarks = new List<Landmarks>();
        public string MarkerMode = "Add";
        
  
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gmap.SetPositionByKeywords("Bandung, Indonesia");
            gmap.ShowCenter = false;
            gmap.MouseClick += new MouseEventHandler(Map_MouseClick);
            AddMarkersRadio.Checked = true;
            LandmarksComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FillLandmarks();
            AddLandmarksComboBox();
        }

        private void FillLandmarks()
        {
            listLandmarks.Add(new Landmarks("ITB", -6.8909100679646, 107.6103807680887));
            listLandmarks.Add(new Landmarks("Alun-Alun Bandung", -6.921803261958416, 107.60705882369496));
            listLandmarks.Add(new Landmarks("Trans Studio Bandung", -6.926140039022282, 107.63656367594649));
        }

        private void AddLandmarksComboBox()
        {
            foreach(Landmarks mark in listLandmarks)
            {
                LandmarksComboBox.Items.Add(mark.name);
            }
        }

        private void LandmarksComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string entry = LandmarksComboBox.Text;
            Landmarks move = new Landmarks("None", 0, 0);
            foreach(Landmarks mark in listLandmarks)
            {
                if(mark.name == entry)
                {
                    move = mark;
                    break;
                }
            }

            if(move.name != "None")
            {
                gmap.Position = new GMap.NET.PointLatLng(move.lat, move.lng);
            }
        }

        private void AddMarkersRadio_CheckedChanged(object sender, EventArgs e)
        {
            MarkerMode = "Add";
        }

        private void RemoveMarkersRadio_CheckedChanged(object sender, EventArgs e)
        {
            MarkerMode = "Remove";
        }

        private void ConfigMarkersRadio_CheckedChanged(object sender, EventArgs e)
        {
            MarkerMode = "Config";
        }

        private void StartMarkerLatTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void StartMarkerLngTextBox_TextChanged(object sender, EventArgs e)
        {
            var str = startMarker.Position.Lng;
            StartMarkerLngTextBox.Text = str.ToString();
        }

        private void StopLabelLatTextBox_TextChanged(object sender, EventArgs e)
        {
            var str = startMarker.Position.Lat;
            StopLabelLatTextBox.Text = str.ToString();
        }

        private void StopLabelLngTextBox_TextChanged(object sender, EventArgs e)
        {
            var str = startMarker.Position.Lng;
            StopLabelLngTextBox.Text = str.ToString();
        }

        private void Map_MouseClick(object sender, MouseEventArgs e)
        { 
            if(e.Button == MouseButtons.Left && MarkerMode == "Add")
            {
                double lat = gmap.FromLocalToLatLng(e.X, e.Y).Lat;
                double lng = gmap.FromLocalToLatLng(e.X, e.Y).Lng;

                GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.red_dot);

                gmap.Overlays.Add(markersOverlay);
                markersOverlay.Markers.Add(marker);
                listMarkers.Add(marker);
            }
        }

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if(MarkerMode == "Remove")
            {
                listMarkers.Remove(item);
                markersOverlay.Markers.Remove(item);
            }

            if(MarkerMode == "Config")
            {
                Form2 subForm = new Form2();
                var result = subForm.ShowDialog();
                if(result == DialogResult.OK)
                {
                    string val = subForm.returnvalue;
                    if(val == "Start")
                    {
                        startMarker = item;
                        var str = startMarker.Position.Lat; StartMarkerLatTextBox.Text = str.ToString();
                        str = startMarker.Position.Lng; StartMarkerLngTextBox.Text = str.ToString();
                    }
                    else
                    {
                        stopMarker = item;
                        var str = stopMarker.Position.Lat; StopLabelLatTextBox.Text = str.ToString();
                        str = stopMarker.Position.Lng; StopLabelLngTextBox.Text = str.ToString();
                    }
                }
                MarkerMode = "Add";
                AddMarkersRadio.Checked = true;
            }
        }

        private void CreateRouteButton_Click(object sender, EventArgs e)
        {
            //SearchRoute();
        }
    }

    public class Landmarks
    {
        public string name;
        public double lat, lng;

        public Landmarks(string na, double la, double ln)
        {
            name = na;
            lat = la;
            lng = ln;
        }
    }

    public class RouteSearcher
    {
        public double[,] AdjMatrix;

        public void FillMatrix()
        {
            MainForm.listMarkers.Remove(MainForm.startMarker);
            MainForm.listMarkers.Insert(0, MainForm.startMarker);
            AdjMatrix = new double[MainForm.listMarkers.Count, MainForm.listMarkers.Count];

            GMapMarker marker = new GMapMarker();
            
        }
    }

}
