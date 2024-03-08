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
            dataGridViewParts.DataSource = Parts.part;

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

        private void buttonAddParts_MouseClick(object sender, MouseEventArgs e)
        {
            FormAddParts frm = new FormAddParts();
            frm.Show();
        }

        private void buttonModifyParts_MouseClick(object sender, MouseEventArgs e)
        {
            FormModifyParts frm = new FormModifyParts();
            frm.Show();
        }

        private void buttonAddProducts_MouseClick(object sender, MouseEventArgs e)
        {
            FormAddProducts frm = new FormAddProducts();
            frm.Show();
        }

        private void buttonModifyProducts_MouseClick(object sender, MouseEventArgs e)
        {
            FormModifyProducts frm = new FormModifyProducts();
            frm.Show();
        }
    }
}
