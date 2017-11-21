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
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using SwissTransport;

namespace SwissTravelHelperGUI
{
    public partial class Map : Form
    {
        GMapMarker GMapMarker_l;
        GMapOverlay GMapOverlay_l;

        public Map()
        {
            InitializeComponent();
        }

        private void Stop_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Zeigt die Station auf der Karte an.
        /// </summary>
        /// <param name="XCordination_p">X-Kordinate in dezimal</param>
        /// <param name="YCordination_p">y-Kordinate in dezimal</param>
        /// <param name="StationText_p">Stationen Name welche angezeigt werden soll.</param>
        public void SetLocation( double XCordination_p, double YCordination_p, string StationText_p)
        {
            GMap_GMapControl.DragButton = MouseButtons.Left;
            GMap_GMapControl.CanDragMap = true;
            GMap_GMapControl.MapProvider = GMapProviders.GoogleMap;
            GMap_GMapControl.Position = new PointLatLng(XCordination_p, YCordination_p);
            GMap_GMapControl.MinZoom = 0;
            GMap_GMapControl.MaxZoom = 24;
            GMap_GMapControl.Zoom = 18;
            GMap_GMapControl.AutoScroll = true;
            StationMap_Label.Text = StationText_p;
        }
        /// <summary>
        /// Setzt die Informationen für x-Y Kordinaten
        /// </summary>
        /// <param name="StationList_p">StationenListe welche erstellt wurde</param>
        /// <param name="StationName_p">Stationenname</param>
        public void GetCordination(List<Station> StationList_p,Transport Transport_p, string StationName_p)
        {
            StationList_p = Transport_p.GetStations(StationName_p).StationList;
            foreach (Station Station_l in StationList_p)
            {
                if (Station_l.Name == StationName_p)
                {
                    if ((Station_l.Coordinate.XCoordinate != 0.00) && (Station_l.Coordinate.YCoordinate != 0.00))
                    {
                        this.SetLocation(Station_l.Coordinate.XCoordinate, Station_l.Coordinate.YCoordinate, Station_l.Name.ToString());
                        this.Show();
                    }
                }
            }

        }
    }
}
