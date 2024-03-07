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
    public partial class mainApplicationWindow : Form
    {
        public mainApplicationWindow()
        {
            InitializeComponent();

            //sets that data source, the data auto displays in the DataGridView
            dataGridViewParts.DataSource = parts.part;

            //see a ful row selection
            dataGridViewParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //make the grid read only
            dataGridViewParts.ReadOnly = true;
            dataGridViewParts.MultiSelect = false;
            dataGridViewParts.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       private void button1_Click(object sender, EventArgs e)
        {

        }

        private void labelParts_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewParts.ClearSelection();
        }

        private void dataGridViewParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAddParts_Click(object sender, EventArgs e)
        {

        }
    }
}
