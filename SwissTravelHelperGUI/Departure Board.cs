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
    public partial class DepartureBoard : Form
    {
        StationBoardRoot StationBoardRoot_c= new StationBoardRoot();
        public DepartureBoard()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Setzt Departure Board anhand von der mitgegebenen Station aus der From_Combobox
        /// </summary>
        /// <param name="Station_p">StationName</param>
        /// <param name="Id_p">StationId</param>
        /// <param name="Transport_c">Transport Objekt</param>
        public void SetDepartureBoard(string Station_p, string Id_p,  Transport Transport_c)
         {
            this.Station_Label.Text = Station_p;
            StationBoardRoot_c = Transport_c.GetStationBoard(Station_p, Id_p);
            DepartureBoard_DataGridView.DataSource = StationBoardRoot_c.Entries;
            DepartureBoard_DataGridView.Columns["Name"].Visible = false;
            DepartureBoard_DataGridView.Columns["Operator"].Visible = false;
            DepartureBoard_DataGridView.Columns["Stop"].HeaderText = "Abfahrtszeit";
            DepartureBoard_DataGridView.Columns["Category"].HeaderText = "Typ";
            DepartureBoard_DataGridView.Columns["Category"].Width = 30;
            DepartureBoard_DataGridView.Columns["Number"].HeaderText = "Zug";
            DepartureBoard_DataGridView.Columns["To"].HeaderText = "Nach";
        }
        private void Stop_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
