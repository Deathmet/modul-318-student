using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTravelHelperGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
    }
}
