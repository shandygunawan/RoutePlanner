namespace RoutePlanner
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.LandmarksLabel = new System.Windows.Forms.Label();
            this.LandmarksComboBox = new System.Windows.Forms.ComboBox();
            this.AddRemoveMarkersLabel = new System.Windows.Forms.Label();
            this.AddMarkersRadio = new System.Windows.Forms.RadioButton();
            this.RemoveMarkersRadio = new System.Windows.Forms.RadioButton();
            this.StartMarkerLabel = new System.Windows.Forms.Label();
            this.StartMarkerLatLabel = new System.Windows.Forms.Label();
            this.StartMarkerLngLabel = new System.Windows.Forms.Label();
            this.StartMarkerLatTextBox = new System.Windows.Forms.TextBox();
            this.StartMarkerLngTextBox = new System.Windows.Forms.TextBox();
            this.StopLabelLngTextBox = new System.Windows.Forms.TextBox();
            this.StopLabelLatTextBox = new System.Windows.Forms.TextBox();
            this.StopMarkerLngLabel = new System.Windows.Forms.Label();
            this.StopMarkerLatLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateRouteButton = new System.Windows.Forms.Button();
            this.ConfigMarkersRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(453, 12);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 1;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(739, 565);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 15D;
            this.gmap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gmap_OnMarkerClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the\r\nPersonal Route Planner!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LandmarksLabel
            // 
            this.LandmarksLabel.AutoSize = true;
            this.LandmarksLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LandmarksLabel.Location = new System.Drawing.Point(12, 140);
            this.LandmarksLabel.Name = "LandmarksLabel";
            this.LandmarksLabel.Size = new System.Drawing.Size(122, 28);
            this.LandmarksLabel.TabIndex = 2;
            this.LandmarksLabel.Text = "Landmarks :";
            // 
            // LandmarksComboBox
            // 
            this.LandmarksComboBox.FormattingEnabled = true;
            this.LandmarksComboBox.Location = new System.Drawing.Point(140, 140);
            this.LandmarksComboBox.Name = "LandmarksComboBox";
            this.LandmarksComboBox.Size = new System.Drawing.Size(251, 28);
            this.LandmarksComboBox.TabIndex = 3;
            this.LandmarksComboBox.SelectedIndexChanged += new System.EventHandler(this.LandmarksComboBox_SelectedIndexChanged);
            // 
            // AddRemoveMarkersLabel
            // 
            this.AddRemoveMarkersLabel.AutoSize = true;
            this.AddRemoveMarkersLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRemoveMarkersLabel.Location = new System.Drawing.Point(12, 192);
            this.AddRemoveMarkersLabel.Name = "AddRemoveMarkersLabel";
            this.AddRemoveMarkersLabel.Size = new System.Drawing.Size(220, 28);
            this.AddRemoveMarkersLabel.TabIndex = 4;
            this.AddRemoveMarkersLabel.Text = "Add/Remove Markers :";
            // 
            // AddMarkersRadio
            // 
            this.AddMarkersRadio.AutoSize = true;
            this.AddMarkersRadio.Location = new System.Drawing.Point(17, 224);
            this.AddMarkersRadio.Name = "AddMarkersRadio";
            this.AddMarkersRadio.Size = new System.Drawing.Size(124, 24);
            this.AddMarkersRadio.TabIndex = 5;
            this.AddMarkersRadio.TabStop = true;
            this.AddMarkersRadio.Text = "Add Markers";
            this.AddMarkersRadio.UseVisualStyleBackColor = true;
            this.AddMarkersRadio.CheckedChanged += new System.EventHandler(this.AddMarkersRadio_CheckedChanged);
            // 
            // RemoveMarkersRadio
            // 
            this.RemoveMarkersRadio.AutoSize = true;
            this.RemoveMarkersRadio.Location = new System.Drawing.Point(157, 224);
            this.RemoveMarkersRadio.Name = "RemoveMarkersRadio";
            this.RemoveMarkersRadio.Size = new System.Drawing.Size(154, 24);
            this.RemoveMarkersRadio.TabIndex = 6;
            this.RemoveMarkersRadio.TabStop = true;
            this.RemoveMarkersRadio.Text = "Remove Markers";
            this.RemoveMarkersRadio.UseVisualStyleBackColor = true;
            this.RemoveMarkersRadio.CheckedChanged += new System.EventHandler(this.RemoveMarkersRadio_CheckedChanged);
            // 
            // StartMarkerLabel
            // 
            this.StartMarkerLabel.AutoSize = true;
            this.StartMarkerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartMarkerLabel.Location = new System.Drawing.Point(12, 299);
            this.StartMarkerLabel.Name = "StartMarkerLabel";
            this.StartMarkerLabel.Size = new System.Drawing.Size(135, 28);
            this.StartMarkerLabel.TabIndex = 7;
            this.StartMarkerLabel.Text = "Start Marker :";
            // 
            // StartMarkerLatLabel
            // 
            this.StartMarkerLatLabel.AutoSize = true;
            this.StartMarkerLatLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartMarkerLatLabel.Location = new System.Drawing.Point(12, 335);
            this.StartMarkerLatLabel.Name = "StartMarkerLatLabel";
            this.StartMarkerLatLabel.Size = new System.Drawing.Size(34, 28);
            this.StartMarkerLatLabel.TabIndex = 8;
            this.StartMarkerLatLabel.Text = "lat";
            // 
            // StartMarkerLngLabel
            // 
            this.StartMarkerLngLabel.AutoSize = true;
            this.StartMarkerLngLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartMarkerLngLabel.Location = new System.Drawing.Point(12, 367);
            this.StartMarkerLngLabel.Name = "StartMarkerLngLabel";
            this.StartMarkerLngLabel.Size = new System.Drawing.Size(41, 28);
            this.StartMarkerLngLabel.TabIndex = 9;
            this.StartMarkerLngLabel.Text = "lng";
            // 
            // StartMarkerLatTextBox
            // 
            this.StartMarkerLatTextBox.Location = new System.Drawing.Point(52, 334);
            this.StartMarkerLatTextBox.Name = "StartMarkerLatTextBox";
            this.StartMarkerLatTextBox.Size = new System.Drawing.Size(339, 26);
            this.StartMarkerLatTextBox.TabIndex = 10;
            this.StartMarkerLatTextBox.TextChanged += new System.EventHandler(this.StartMarkerLatTextBox_TextChanged);
            // 
            // StartMarkerLngTextBox
            // 
            this.StartMarkerLngTextBox.Location = new System.Drawing.Point(52, 367);
            this.StartMarkerLngTextBox.Name = "StartMarkerLngTextBox";
            this.StartMarkerLngTextBox.Size = new System.Drawing.Size(339, 26);
            this.StartMarkerLngTextBox.TabIndex = 11;
            this.StartMarkerLngTextBox.TextChanged += new System.EventHandler(this.StartMarkerLngTextBox_TextChanged);
            // 
            // StopLabelLngTextBox
            // 
            this.StopLabelLngTextBox.Location = new System.Drawing.Point(53, 480);
            this.StopLabelLngTextBox.Name = "StopLabelLngTextBox";
            this.StopLabelLngTextBox.Size = new System.Drawing.Size(339, 26);
            this.StopLabelLngTextBox.TabIndex = 16;
            this.StopLabelLngTextBox.TextChanged += new System.EventHandler(this.StopLabelLngTextBox_TextChanged);
            // 
            // StopLabelLatTextBox
            // 
            this.StopLabelLatTextBox.Location = new System.Drawing.Point(53, 447);
            this.StopLabelLatTextBox.Name = "StopLabelLatTextBox";
            this.StopLabelLatTextBox.Size = new System.Drawing.Size(339, 26);
            this.StopLabelLatTextBox.TabIndex = 15;
            this.StopLabelLatTextBox.TextChanged += new System.EventHandler(this.StopLabelLatTextBox_TextChanged);
            // 
            // StopMarkerLngLabel
            // 
            this.StopMarkerLngLabel.AutoSize = true;
            this.StopMarkerLngLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopMarkerLngLabel.Location = new System.Drawing.Point(13, 480);
            this.StopMarkerLngLabel.Name = "StopMarkerLngLabel";
            this.StopMarkerLngLabel.Size = new System.Drawing.Size(41, 28);
            this.StopMarkerLngLabel.TabIndex = 14;
            this.StopMarkerLngLabel.Text = "lng";
            // 
            // StopMarkerLatLabel
            // 
            this.StopMarkerLatLabel.AutoSize = true;
            this.StopMarkerLatLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopMarkerLatLabel.Location = new System.Drawing.Point(13, 448);
            this.StopMarkerLatLabel.Name = "StopMarkerLatLabel";
            this.StopMarkerLatLabel.Size = new System.Drawing.Size(34, 28);
            this.StopMarkerLatLabel.TabIndex = 13;
            this.StopMarkerLatLabel.Text = "lat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stop Marker :";
            // 
            // CreateRouteButton
            // 
            this.CreateRouteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateRouteButton.Location = new System.Drawing.Point(17, 537);
            this.CreateRouteButton.Name = "CreateRouteButton";
            this.CreateRouteButton.Size = new System.Drawing.Size(180, 60);
            this.CreateRouteButton.TabIndex = 17;
            this.CreateRouteButton.Text = "Create Route!";
            this.CreateRouteButton.UseVisualStyleBackColor = true;
            this.CreateRouteButton.Click += new System.EventHandler(this.CreateRouteButton_Click);
            // 
            // ConfigMarkersRadio
            // 
            this.ConfigMarkersRadio.AutoSize = true;
            this.ConfigMarkersRadio.Location = new System.Drawing.Point(17, 254);
            this.ConfigMarkersRadio.Name = "ConfigMarkersRadio";
            this.ConfigMarkersRadio.Size = new System.Drawing.Size(164, 24);
            this.ConfigMarkersRadio.TabIndex = 18;
            this.ConfigMarkersRadio.TabStop = true;
            this.ConfigMarkersRadio.Text = "Configure Markers";
            this.ConfigMarkersRadio.UseVisualStyleBackColor = true;
            this.ConfigMarkersRadio.CheckedChanged += new System.EventHandler(this.ConfigMarkersRadio_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 609);
            this.Controls.Add(this.ConfigMarkersRadio);
            this.Controls.Add(this.CreateRouteButton);
            this.Controls.Add(this.StopLabelLngTextBox);
            this.Controls.Add(this.StopLabelLatTextBox);
            this.Controls.Add(this.StopMarkerLngLabel);
            this.Controls.Add(this.StopMarkerLatLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StartMarkerLngTextBox);
            this.Controls.Add(this.StartMarkerLatTextBox);
            this.Controls.Add(this.StartMarkerLngLabel);
            this.Controls.Add(this.StartMarkerLatLabel);
            this.Controls.Add(this.StartMarkerLabel);
            this.Controls.Add(this.RemoveMarkersRadio);
            this.Controls.Add(this.AddMarkersRadio);
            this.Controls.Add(this.AddRemoveMarkersLabel);
            this.Controls.Add(this.LandmarksComboBox);
            this.Controls.Add(this.LandmarksLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gmap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Route Planner";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LandmarksLabel;
        private System.Windows.Forms.ComboBox LandmarksComboBox;
        private System.Windows.Forms.Label AddRemoveMarkersLabel;
        private System.Windows.Forms.RadioButton AddMarkersRadio;
        private System.Windows.Forms.RadioButton RemoveMarkersRadio;
        private System.Windows.Forms.Label StartMarkerLabel;
        private System.Windows.Forms.Label StartMarkerLatLabel;
        private System.Windows.Forms.Label StartMarkerLngLabel;
        private System.Windows.Forms.TextBox StartMarkerLatTextBox;
        private System.Windows.Forms.TextBox StartMarkerLngTextBox;
        private System.Windows.Forms.TextBox StopLabelLngTextBox;
        private System.Windows.Forms.TextBox StopLabelLatTextBox;
        private System.Windows.Forms.Label StopMarkerLngLabel;
        private System.Windows.Forms.Label StopMarkerLatLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateRouteButton;
        private System.Windows.Forms.RadioButton ConfigMarkersRadio;
    }
}

