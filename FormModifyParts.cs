using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WyattBussellC968Software1C_
{
    public partial class FormModifyParts : Form
    {
        public FormModifyParts()
        {
            InitializeComponent();
        }

        private void buttonCancel_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void radioButtonOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonOutsourced.Checked) { this.labelLocationName.Text = "Company Name".ToString(); };
            if (!this.radioButtonOutsourced.Checked) { this.labelLocationName.Text = "MachineID".ToString(); };
        }
    }
}
