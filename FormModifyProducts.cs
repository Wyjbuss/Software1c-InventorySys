﻿using System;
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
    public partial class FormModifyProducts : Form
    {
        public FormModifyProducts()
        {
            InitializeComponent();

            dataGridViewParts.DataSource = Inventory.AllParts;

            //see a ful row selection
            dataGridViewParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //make the grid read only
            dataGridViewParts.ReadOnly = true;
            dataGridViewParts.MultiSelect = false;
            dataGridViewParts.AllowUserToAddRows = false;
        }

        private void buttonCancel_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();   
        }

        private void dataGridViewParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
