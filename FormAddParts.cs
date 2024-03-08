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
    public partial class FormAddParts : Form
    {
        public FormAddParts()
        {
            InitializeComponent();
        }

        private void buttonCancel_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void radioButtonOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonOutsourced.Checked) 
            { 
                this.labelLocationName.Text = "Company Name".ToString();
                if (textBoxLocation.Text.Any(char.IsDigit)){ textBoxLocation.BackColor = Color.LightCoral; } else { textBoxLocation.BackColor = Color.White; }
            }
            else if (!this.radioButtonOutsourced.Checked) 
            { 
                this.labelLocationName.Text = "MachineID".ToString(); 
                if (!textBoxLocation.Text.All(char.IsDigit)) { textBoxLocation.BackColor = Color.LightCoral; } else { textBoxLocation.BackColor = Color.White; }
            };
        }


        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length <= 0) { textBoxName.BackColor = Color.LightCoral; };
            if (textBoxName.Text.Length > 0) { textBoxName.BackColor = Color.White; };
        }

        private void textBoxInventory_TextChanged(object sender, EventArgs e)
        {
            if (textBoxInventory.Text.Length <= 0) { textBoxInventory.BackColor = Color.LightCoral; };
            if (textBoxInventory.Text.Length > 0) { textBoxInventory.BackColor = Color.White; };
        }

        private void textBoxPriceCost_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPriceCost.Text.Length <= 0) { textBoxPriceCost.BackColor = Color.LightCoral; };
            if (textBoxPriceCost.Text.Length > 0) { textBoxPriceCost.BackColor = Color.White; };
        }

        private void textBoxMax_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMax.Text.Length <= 0) { textBoxMax.BackColor = Color.LightCoral; };
            if (textBoxMax.Text.Length > 0) { textBoxMax.BackColor = Color.White; };
        }

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMin.Text.Length <= 0) { textBoxMin.BackColor = Color.LightCoral; };
            if (textBoxMin.Text.Length > 0) { textBoxMin.BackColor = Color.White; };
        }

        private void textBoxLocation_TextChanged(object sender, EventArgs e)
        {
            
            if (textBoxLocation.Text.Any(char.IsDigit) && radioButtonOutsourced.Checked)
            {
                textBoxLocation.BackColor = Color.LightCoral;
            }
            else if(!textBoxLocation.Text.All(char.IsDigit) && radioButtonInHouse.Checked)
            {
                textBoxLocation.BackColor = Color.LightCoral;
            }
            else if (textBoxLocation.Text.Length <= 0)
            { 
                textBoxLocation.BackColor = Color.LightCoral;
            }
            else { textBoxLocation.BackColor = Color.White; }
        }
    }
}
