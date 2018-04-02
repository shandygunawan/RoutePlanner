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
    public partial class Form2 : Form
    {
        public string returnvalue;

        public Form2()
        {
            InitializeComponent();
            StartMarkerRadio.Checked = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void StartMarkerRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StopMarkerRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if(StartMarkerRadio.Checked == true)
            {
                returnvalue = "Start";
            }
            else
            {
                returnvalue = "Stop";
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
