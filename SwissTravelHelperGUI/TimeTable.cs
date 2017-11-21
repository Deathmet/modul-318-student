using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SwissTravelHelperGUI
{
    public partial class TimeTable : Form
    {
        string RefFromstation_l = null;
        string RefToStation_l = null;
        string RefDate_l = null;
        string RefTime_l = null;
        string RefIsArrivalTime_l = null;
        Transport RefTransport_l = null;
        List<Station> RefStationList_l = null;
        int ArrowIndicator = 0;
        DateTime DateTime_l;
        public TimeTable()
        {
            InitializeComponent();

        }

        public void SetTimeTable(string FromStation_p, string ToStation_p, Transport Transport_c, List<Station> StationList_p, String Date_p, string Time_p, string IsArrivalTime_p)
        {
            RefFromstation_l = FromStation_p;
            RefToStation_l = ToStation_p;
            RefDate_l = Date_p;
            RefTime_l = Time_p;
            RefIsArrivalTime_l = IsArrivalTime_p;
            RefTransport_l = Transport_c;
            RefStationList_l = StationList_p;

            List<Connection> ConnectionsList_c = Transport_c.GetConnections(FromStation_p, ToStation_p, Date_p, Time_p, IsArrivalTime_p).ConnectionList;
            BindingList<TimeTabelValues> TimeTableValueList_c = new BindingList<TimeTabelValues>();

            foreach (Connection Connection_l in ConnectionsList_c)
            {
                TimeTabelValues TimeTableValue_c = new TimeTabelValues();
                TimeTableValue_c.FromStation_g = Connection_l.From.Station.Name.ToString();
                TimeTableValue_c.ToStation_g = Connection_l.To.Station.Name.ToString();
                TimeTableValue_c.DepartureTime_g = Convert.ToDateTime(Connection_l.From.Departure).ToString("HH:mm");
                TimeTableValue_c.ArrivalTime_g = Convert.ToDateTime(Connection_l.To.Arrival).ToString("HH:mm");
                if (Connection_l.From.Platform != null)
                    TimeTableValue_c.Line_g = Connection_l.From.Platform.ToString();
                TimeTableValue_c.Durration_g = Convert.ToDateTime(Connection_l.Duration.Split('d')[1]).ToString("HH:mm");
                TimeTableValueList_c.Add(TimeTableValue_c);
            }

            TimeTable_DataGridView.DataSource = TimeTableValueList_c;
            TimeTable_DataGridView.Columns["FromStation_g"].HeaderText = "Abfahrtsstation";
            TimeTable_DataGridView.Columns["DepartureTime_g"].HeaderText = "Abfahrtszeit";
            TimeTable_DataGridView.Columns["ToStation_g"].HeaderText = "Ankunftsstation";
            TimeTable_DataGridView.Columns["ArrivalTime_g"].HeaderText = "Ankunftszeit";
            TimeTable_DataGridView.Columns["Durration_g"].HeaderText = "Fahrtdauer";
            TimeTable_DataGridView.Columns["Line_g"].HeaderText = "Perron";
        }

        private void Previous_Button_Click(object sender, EventArgs e)
        {
            DateTime_l = GetDateTime(RefDate_l, RefTime_l);
            DateTime_l = DateTime_l.AddHours(-1);
            SetTimeTable(RefFromstation_l, RefToStation_l, RefTransport_l, RefStationList_l, GetDate(DateTime_l), GetTime(DateTime_l), RefIsArrivalTime_l);
        }

        private void LaterOn_Button_Click(object sender, EventArgs e)
        {
            DateTime_l = GetDateTime(RefDate_l, RefTime_l);
            DateTime_l = DateTime_l.AddHours(+1);
            SetTimeTable(RefFromstation_l, RefToStation_l, RefTransport_l, RefStationList_l, GetDate(DateTime_l), GetTime(DateTime_l), RefIsArrivalTime_l);
        }

        private void Directions_Button_Click(object sender, EventArgs e)
        {
            if (ArrowIndicator == 0)
            {
                Directions_Button.Image = System.Drawing.Image.FromFile(@"C:\Modul318\Icons\Arrow-OutLeft-icon.png");
                ArrowIndicator = 1;
            }
            else
            {
                Directions_Button.Image = System.Drawing.Image.FromFile(@"C:\Modul318\Icons\Arrow-OutRight-icon.png");
                ArrowIndicator = 0;
            }
            DateTime_l = GetDateTime(RefDate_l, RefTime_l);
            SetTimeTable(RefToStation_l, RefFromstation_l, RefTransport_l, RefStationList_l, GetDate(DateTime_l), GetTime(DateTime_l), RefIsArrivalTime_l);
        }
        private DateTime GetDateTime(string Date_p, string Time_p)
        {
            DateTime LocalDateTime_l;
            LocalDateTime_l = Convert.ToDateTime(Date_p + " " + Time_p);
            return LocalDateTime_l;
        }
        /// <summary>
        /// Ermittelt Datum anhand einer DatetimeVariable
        /// </summary>
        /// <param name="DateTime_p">Datum dasumgewandelt werden soll</param>
        /// <returns>yyy-MM-dd gibt Datum zurück</returns>
        public string GetDate(DateTime DateTime_p)
        {
            string Date_l;
            Date_l = Convert.ToDateTime(DateTime_p).ToString("yyyy-MM-dd");
            return Date_l;
        }
        /// <summary>
        /// Ermittelt Zeit anhand einer DatetimeVariable
        /// </summary>
        /// <param name="DateTime_p">Datum dasumgewandelt werden soll</param>
        /// <returns>HH:mm gibt Zeit zurück</returns>
        public string GetTime(DateTime DateTime_p)
        {
            string Date_l;
            Date_l = Convert.ToDateTime(DateTime_p).ToString("HH:mm");
            return Date_l;
        }

        private void FromMap_Button_Click(object sender, EventArgs e)
        {
            Map Map_c = new Map();
            Map_c.GetCordination(RefStationList_l, RefTransport_l, RefFromstation_l);
        }

        private void ToMap_Button_Click(object sender, EventArgs e)
        {
            Map Map_c = new Map();
            Map_c.GetCordination(RefStationList_l, RefTransport_l, RefToStation_l);
        }
    }
}
