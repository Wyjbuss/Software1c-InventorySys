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
    public partial class FormAddParts : Form
    {
        public FormAddParts()
        {
            InitializeComponent();
        }

        private void buttonCancel_MouseClick(object sender, MouseEventArgs e)
        {
            FormAddParts frm = new FormAddParts();
            frm.Close();
        }
    }
}
