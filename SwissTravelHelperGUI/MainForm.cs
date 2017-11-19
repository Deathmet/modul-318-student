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
    public partial class MainForm : Form
    {
        Transport Transport_c = new Transport();
        List<Station> StationList_c = new List<Station>();
        public MainForm()
        {
            InitializeComponent();
        }
        private void GetStationsList_l(string InputValue_l)
        {
            StationList_c = Transport_c.GetStations(InputValue_l).StationList;
        }
        private void GetStationNameAndDisplay(object ToFillComboBox_l)
        {
            if (ToFillComboBox_l is ComboBox)
            {
                foreach (Station Station_l in StationList_c)
                {
                    (ToFillComboBox_l as ComboBox).Items.Add(Station_l.Name);
                }
                (ToFillComboBox_l as ComboBox).DroppedDown = true;
            }
        }
        /// <summary>
        /// Löscht die mitgegebene Combobox
        /// </summary>
        /// <param name="ToDeleteBox_l">Objekt welches gelöscht werden soll.</param>
        private void ClearTextBox_m(object ToDeleteBox_l)
        {
            if (ToDeleteBox_l is ComboBox)
            {
                (ToDeleteBox_l as ComboBox).Items.Clear();
                (ToDeleteBox_l as ComboBox).ResetText();
            }
        }

        private void FromDelete_Button_Click(object sender, EventArgs e)
        {
            ClearTextBox_m(From_ComboBox);
        }

        private void ToDelete_Button_Click(object sender, EventArgs e)
        {
            ClearTextBox_m(To_ComboBox);
        }

        private void From_ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char)Keys.Enter == e.KeyChar)
            {
                GetStationsList_l(From_ComboBox.Text);
                GetStationNameAndDisplay(From_ComboBox);
            } 
        }

        private void To_ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char)Keys.Enter == e.KeyChar)
            {
                GetStationsList_l(To_ComboBox.Text);
                GetStationNameAndDisplay(To_ComboBox);
            }
        }
    }
}
