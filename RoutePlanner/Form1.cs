using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace RoutePlanner
{
    public partial class MainForm : Form
    {
        public static List<GMapMarker> listMarkers = new List<GMapMarker>(); // contains add markers
        public static List<Edge> listEdges = new List<Edge>(); // contains added edges
        public static GMapMarker startMarker = new GMarkerGoogle(new PointLatLng(0, 0), GMarkerGoogleType.red_dot); // contains start markers
        public static GMapMarker stopMarker = new GMarkerGoogle(new PointLatLng(0, 0), GMarkerGoogleType.red_dot); // contains stop markers
        public static GMapOverlay markersOverlay = new GMapOverlay("MarkersOverlay"); // overlay that contains markers
        public static GMapOverlay routesOverlay = new GMapOverlay("RoutesOverlay"); // overlay that contains routes/edges
        public List<Landmarks> listLandmarks = new List<Landmarks>(); //list of landmarks
        public int MarkerNumbers = 1; // for markers' tooltip
        public string RemoveMode = "Markers";
        public static double[,] AdjMatrix;
        public static List<double> Heuristic = new List<double>();
        public const double INF = 2e20;

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
            LandmarksComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StartMarkerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StopMarkerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StartMarkerLatTextBox.ReadOnly = true;
            StartMarkerLngTextBox.ReadOnly = true;
            StopLabelLatTextBox.ReadOnly = true;
            StopLabelLngTextBox.ReadOnly = true;

            FillLandmarks();
            AddLandmarksComboBox();
        }

        // fill list of landmarks
        private void FillLandmarks()
        {
            listLandmarks.Add(new Landmarks("ITB", -6.8909100679646, 107.6103807680887));
            listLandmarks.Add(new Landmarks("Alun-Alun Bandung", -6.921803261958416, 107.60705882369496));
            listLandmarks.Add(new Landmarks("Trans Studio Bandung", -6.926140039022282, 107.63656367594649));
        }

        // populate landmarks' combobox 
        private void AddLandmarksComboBox()
        {
            foreach(Landmarks mark in listLandmarks)
            {
                LandmarksComboBox.Items.Add(mark.name);
            }
        }

        // landmarks' combobox handler
        private void LandmarksComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string entry = LandmarksComboBox.Text; //selected landmark
            Landmarks move = new Landmarks("None", 0, 0); //dummy landmarks

            // search selected landmark in the list
            foreach(Landmarks mark in listLandmarks)
            {
                if(mark.name == entry)
                {
                    move = mark;
                    break;
                }
            }

            // Move map to landmark position
            gmap.Position = new PointLatLng(move.lat, move.lng);
        }


        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if(RemoveMode == "Markers")
            {
                markersOverlay.Clear();
                routesOverlay.Clear();
                listMarkers.Clear();
                listEdges.Clear();
                MarkerNumbers = 1;
                AddRemoveStartStopMarkerComboBox();
                StartMarkerLatTextBox.Text = "";
                StartMarkerLngTextBox.Text = "";
                StopLabelLatTextBox.Text = "";
                StopLabelLngTextBox.Text = "";

            }
            else if(RemoveMode == "Edges")
            {
                routesOverlay.Clear();
                listEdges.Clear();
            }
        }

        // event for adding edge/line between two markers
        private void addEdgeButton_Click(object sender, EventArgs e)
        {
            if(startEdgeTextBox.Text != "" && EndEdgeTextBox.Text != "" && startEdgeTextBox.Text != EndEdgeTextBox.Text)
            {
                List<PointLatLng> points = new List<PointLatLng>();
                foreach(GMapMarker marker in listMarkers)
                {
                    if(marker.ToolTipText == startEdgeTextBox.Text || marker.ToolTipText == EndEdgeTextBox.Text)
                    {
                        points.Add(new PointLatLng(marker.Position.Lat, marker.Position.Lng));
                    }
                }
                GMapRoute route = new GMapRoute(points, "route");
                route.Stroke = new Pen(Color.Red, 3);
                gmap.Overlays.Add(routesOverlay);
                routesOverlay.Routes.Add(route);
                
                listEdges.Add(new Edge(startEdgeTextBox.Text, EndEdgeTextBox.Text));
            }
        }

        /* START MARKER HANDLER */
        private void AddRemoveStartStopMarkerComboBox()
        {
            StartMarkerComboBox.Items.Clear();
            StopMarkerComboBox.Items.Clear();

            foreach(GMapMarker marker in listMarkers)
            {
                StartMarkerComboBox.Items.Add(marker.ToolTipText);
                StopMarkerComboBox.Items.Add(marker.ToolTipText);
            }
        }

        private void StartMarkerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string entry = StartMarkerComboBox.Text;
            GMapMarker dummy = new GMarkerGoogle(new PointLatLng(0, 0), GMarkerGoogleType.red_dot);

            foreach(GMapMarker marker in listMarkers)
            {
                if(marker.ToolTipText == entry)
                {
                    dummy = marker;
                }
            }

            RefreshStartMarker(dummy);
        }

        private void RefreshStartMarker(GMapMarker entry)
        {
            startMarker = entry;
            StartMarkerLatTextBox.Text = startMarker.Position.Lat.ToString();
            StartMarkerLngTextBox.Text = startMarker.Position.Lng.ToString();
        }

        private void StartMarkerLatTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void StartMarkerLngTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        /* STOP MARKER HANDLER */
        private void StopMarkerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string entry = StopMarkerComboBox.Text;
            GMapMarker dummy = new GMarkerGoogle(new PointLatLng(0, 0), GMarkerGoogleType.red_dot);

            foreach (GMapMarker marker in listMarkers)
            {
                if (marker.ToolTipText == entry)
                {
                    dummy = marker;
                }
            }

            RefreshStopMarker(dummy);
        }

        private void StopLabelLatTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void StopLabelLngTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RefreshStopMarker(GMapMarker entry)
        {
            stopMarker = entry;
            
            StopLabelLatTextBox.Text = stopMarker.Position.Lat.ToString();
            StopLabelLngTextBox.Text = stopMarker.Position.Lng.ToString();
        }

        private void Map_MouseClick(object sender, MouseEventArgs e)
        { 
            // Check if the clicked button is left
            if(e.Button == MouseButtons.Left)
            {
                // retrieve position
                double lat = gmap.FromLocalToLatLng(e.X, e.Y).Lat;
                double lng = gmap.FromLocalToLatLng(e.X, e.Y).Lng;

                // make marker from position
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.red_dot);
                marker.ToolTipText = MarkerNumbers.ToString();
                marker.ToolTip.Fill = Brushes.Black;
                marker.ToolTip.Foreground = Brushes.White;
                marker.ToolTip.Stroke = Pens.Black;
                marker.ToolTip.TextPadding = new Size(20, 20);

                // add marker to overlays and list
                gmap.Overlays.Add(markersOverlay);
                markersOverlay.Markers.Add(marker);
                listMarkers.Add(marker);
                MarkerNumbers += 1;
                AddRemoveStartStopMarkerComboBox();
            }
        }

        // Fill Matrix with distance of two markers
        public void FillMatrix()
        {
            // initialize matrix
            AdjMatrix = new double[listMarkers.Count + 1, listMarkers.Count + 1];
            for (int row = 0; row <= listMarkers.Count; ++row)
            {
                for (int col = 0; col <= listMarkers.Count; ++col)
                {
                    AdjMatrix[row, col] = INF;
                }
            }

            // FILL ADJMATRIX
            foreach (Edge line in listEdges)
            {
                // get tooltip as identifier for the vertices
                string startTooltip = line.startMarkerLabel;
                string endTooltip = line.endMarkerLabel;

                // dummy markers
                GMapMarker a = new GMarkerGoogle(new PointLatLng(0, 0), GMarkerGoogleType.red_dot);
                GMapMarker b = new GMarkerGoogle(new PointLatLng(0, 0), GMarkerGoogleType.red_dot);

                // replace dummy markers with the vertices
                foreach (GMapMarker marker in listMarkers)
                {
                    if (marker.ToolTipText == startTooltip)
                    {
                        a = marker;
                    }
                    else if (marker.ToolTipText == endTooltip)
                    {
                        b = marker;
                    }
                }

                // get distance
                double distance = getDistance(a, b);

                // convert tooltip to array index
                int i = Int32.Parse(startTooltip);
                int j = Int32.Parse(endTooltip);

                // add distance into matrix
                AdjMatrix[i, j] = distance;
                AdjMatrix[j, i] = distance;
            }

            GMapMarker end = new GMarkerGoogle(new PointLatLng(0, 0), GMarkerGoogleType.red_dot);
            // search end mark
            foreach (GMapMarker marker in listMarkers)
            {
                if(marker.ToolTipText == stopMarker.ToolTipText)
                {
                    end = marker;
                    break;
                }
            }

            foreach(GMapMarker marker in listMarkers)
            {
                Heuristic.Add(getDistance(marker, end));
            }
        }

        // Get distance between two markers in meter
        public double getDistance(GMapMarker a, GMapMarker b)
        {
            if (a.Equals(b))
            {
                return 0;
            }

            var Coord1 = new GeoCoordinate(a.Position.Lat, a.Position.Lng);
            var Coord2 = new GeoCoordinate(b.Position.Lat, b.Position.Lng);

            return Coord1.GetDistanceTo(Coord2);
        }

        // Search for shortest route
        private void CreateRouteButton_Click(object sender, EventArgs e)
        {
            // Fill matrix with distance and heuristics
            FillMatrix();

            // Search the shortest routes
            AStar shortestRoute = new AStar(AdjMatrix, Heuristic, Int32.Parse(startMarker.ToolTipText.ToString()), Int32.Parse(stopMarker.ToolTipText.ToString()));
            
            // clear routes from map
            routesOverlay.Clear();

            // Print the shortest route to map
            List<PointLatLng> points = new List<PointLatLng>();
            for (int i = 0; i < shortestRoute.FinalPath.Item3.Count; ++i)
            {
                foreach (GMapMarker marker in listMarkers)
                {
                    if (marker.ToolTipText == shortestRoute.FinalPath.Item3[i].ToString())
                    {
                        points.Add(new PointLatLng(marker.Position.Lat, marker.Position.Lng));
                    }
                }
                GMapRoute route = new GMapRoute(points, "route");
                route.Stroke = new Pen(Color.Red, 3);
                gmap.Overlays.Add(routesOverlay);
                routesOverlay.Routes.Add(route);

                listEdges.Add(new Edge(startEdgeTextBox.Text, EndEdgeTextBox.Text));
            }

            // Print the distance of the shortest routes
            ShortestRouteDistTextBox.Text = Math.Round(shortestRoute.FinalPath.Item1, 3).ToString();
        }

        private void RemoveMarkersRadio_CheckedChanged(object sender, EventArgs e)
        {
            RemoveMode = "Markers";
        }

        private void RemoveEdgesRadio_CheckedChanged(object sender, EventArgs e)
        {
            RemoveMode = "Edges";
        }

        private void ShortestRouteDistTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }

    // class for edge that connects two markers
    public class Edge
    {
        public string startMarkerLabel;
        public string endMarkerLabel;

        public Edge(string start, string end)
        {
            startMarkerLabel = start;
            endMarkerLabel = end;
        }
    }

    // class for landmarks
    public class Landmarks
    {
        public string name; // name for combobox
        public double lat, lng; //position for landmarks

        // constructor
        public Landmarks(string na, double la, double ln)
        {
            name = na;
            lat = la;
            lng = ln;
        }
    }
}
