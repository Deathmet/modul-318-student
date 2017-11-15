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
    public partial class DepartureBoard : Form
    {
        public DepartureBoard()
        {
            InitializeComponent();
        }

        private void Stop_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
