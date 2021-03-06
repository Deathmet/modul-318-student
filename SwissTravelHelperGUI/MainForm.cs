﻿using System;
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
        int FromToIndicator_l = 0;
        int FirstTimeIndicator_l = 0;
        public MainForm()
        {
            InitializeComponent();

        }

        public DepartureBoard DepartureBoard
        {
            get => default(DepartureBoard);
            set
            {
            }
        }

        public Map Map
        {
            get => default(Map);
            set
            {
            }
        }

        public TimeTable TimeTable
        {
            get => default(TimeTable);
            set
            {
            }
        }

        private bool CheckToFillCombobox(ComboBox ToCheckCombobox, string FillText_l)
        {
            if (ToCheckCombobox.SelectedItem == null)
            {
                MessageBox.Show("Geben Sie eine Station im Feld " + FillText_l + " an.");
                return false;
            }
            else
            {
                return true;
            }
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
                if ((FirstTimeIndicator_l == 0) && (StationList_c != null))
                {
                    //Verursacht Flackern
                    //(ToFillComboBox_l as ComboBox).DroppedDown = true;
                    (ToFillComboBox_l as ComboBox).SelectedIndex = 0;
                    FirstTimeIndicator_l = 1;
                }
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
            FirstTimeIndicator_l = 0;
        }

        private void ToDelete_Button_Click(object sender, EventArgs e)
        {
            ClearTextBox_m(To_ComboBox);
            To_ComboBox_Leave(null,null);
            FirstTimeIndicator_l = 0;
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

        private void DepartureBoard_Button_Click(object sender, EventArgs e)
        {
            FirstTimeIndicator_l = 1;
            From_ComboBox_KeyPress(null, new KeyPressEventArgs((Char)Keys.Enter));
            if (CheckToFillCombobox(From_ComboBox, "Von"))
            {
                DepartureBoard departureBoard_c = new DepartureBoard();
                foreach (Station Station_l in StationList_c)
                {
                    if (Station_l.Name == (string)From_ComboBox.SelectedItem)
                    {
                        departureBoard_c.SetDepartureBoard(Station_l.Name, Station_l.Id, Transport_c);
                        departureBoard_c.Show();
                    }
                }
            }
        }

        private void Connection_Button_Click(object sender, EventArgs e)
        {
            if (CheckToFillCombobox(From_ComboBox, "Von") &&
                    CheckToFillCombobox(To_ComboBox, "Nach"))
            {
                TimeTable TimeTable_c = new TimeTable();
                if (FromToIndicator_l == 0)
                {
                    TimeTable_c.SetTimeTable((string)From_ComboBox.SelectedItem, (string)To_ComboBox.SelectedItem, Transport_c, StationList_c,
                        TimeTable_c.GetDate(Convert.ToDateTime(FromTime_DateTimePicker.Text)), TimeTable_c.GetTime(Convert.ToDateTime(FromTime_DateTimePicker.Text)), FromToIndicator_l.ToString());
                }
                else
                {
                    TimeTable_c.SetTimeTable((string)From_ComboBox.SelectedItem, (string)To_ComboBox.SelectedItem, Transport_c, StationList_c,
                        TimeTable_c.GetDate(Convert.ToDateTime(ToTime_DateTimePicker.Text)), TimeTable_c.GetTime(Convert.ToDateTime(ToTime_DateTimePicker.Text)), FromToIndicator_l.ToString());
                }
                TimeTable_c.Show();
            }
        }

        private void FromTo_Button_Click(object sender, EventArgs e)
        {
            if (FromTo_Label.Text == "Abfahrtszeit")
            {
                FromTo_Label.Text = "Ankunftszeit";
                FromToIndicator_l = 1;
                FromTime_DateTimePicker.Enabled = false;
                ToTime_DateTimePicker.Enabled = true;
            }
            else
            {
                FromTo_Label.Text = "Abfahrtszeit";
                FromToIndicator_l = 0;
                FromTime_DateTimePicker.Enabled = true;
                ToTime_DateTimePicker.Enabled = false;
            }
        }

        private void To_ComboBox_Enter(object sender, EventArgs e)
        {
            FirstTimeIndicator_l = 0;
            DepartureBoard_Button.Enabled = false;
            Connection_Button.Enabled = true;
        }

        private void To_ComboBox_Leave(object sender, EventArgs e)
        {
            if (To_ComboBox.Items.Count == 0)
            {
                DepartureBoard_Button.Enabled = true;
                Connection_Button.Enabled = false;
            }
        }

        private void Map_Button_Click(object sender, EventArgs e)
        {
            if (CheckToFillCombobox(From_ComboBox, "Von"))
            {
                Map Map_c = new Map();
                Map_c.GetCordination(StationList_c,Transport_c, From_ComboBox.SelectedItem.ToString());
            }
        }
 
    }
}
