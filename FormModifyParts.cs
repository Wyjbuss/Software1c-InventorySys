using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WyattBussellC968Software1C_
{
    public partial class FormModifyParts : Form
    {
        int selectedPartIndex { get; set; }
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
            if (this.radioButtonOutsourced.Checked)
            {
                this.labelLocationName.Text = "Company Name".ToString();
                if (textBoxLocation.Text.Any(char.IsDigit)) { textBoxLocation.BackColor = Color.LightCoral; } else { textBoxLocation.BackColor = Color.White; }
            }
            else if (!this.radioButtonOutsourced.Checked)
            {
                this.labelLocationName.Text = "MachineID".ToString();
                if (!textBoxLocation.Text.All(char.IsDigit)) { textBoxLocation.BackColor = Color.LightCoral; } else { textBoxLocation.BackColor = Color.White; }
            };

            if (allTextBoxesAreCleared())
            {
                buttonSave.Enabled = true;
            }
            else { buttonSave.Enabled = false; }
        }

        private void textBoxLocation_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLocation.Text.Any(char.IsDigit) && radioButtonOutsourced.Checked)
            {
                textBoxLocation.BackColor = Color.LightCoral;
            }
            else if (!textBoxLocation.Text.All(char.IsDigit) && radioButtonInHouse.Checked)
            {
                textBoxLocation.BackColor = Color.LightCoral;
            }
            else if (textBoxLocation.Text.Length <= 0)
            {
                textBoxLocation.BackColor = Color.LightCoral;
            }
            else { textBoxLocation.BackColor = Color.White; }

            if (allTextBoxesAreCleared())
            {
                buttonSave.Enabled = true;
            }
            else { buttonSave.Enabled = false; }
        }

        private void textBoxPriceCost_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPriceCost.Text.Length <= 0)
            {
                textBoxPriceCost.BackColor = Color.LightCoral;
            }
            else if (!textBoxPriceCost.Text.Any(char.IsDigit) || !textBoxPriceCost.Text.Any(char.IsPunctuation) || textBoxPriceCost.Text.Any(char.IsLetter))
            {
                textBoxPriceCost.BackColor = Color.LightCoral;
            }
            else if (textBoxPriceCost.Text.Length > 0 && (textBoxPriceCost.Text.Any(char.IsDigit) || textBoxPriceCost.Text.Any(char.IsPunctuation)))
            {
                textBoxPriceCost.BackColor = Color.White;
            };

            if (allTextBoxesAreCleared())
            {
                buttonSave.Enabled = true;
            }
            else { buttonSave.Enabled = false; }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length <= 0)
            {
                textBoxName.BackColor = Color.LightCoral;
            }
            else if (textBoxName.Text.Length > 0) { textBoxName.BackColor = Color.White; };

            if (allTextBoxesAreCleared())
            {
                buttonSave.Enabled = true;
            }
            else { buttonSave.Enabled = false; }
        }

        private void textBoxMax_TextChanged(object sender, EventArgs e)
        {
            if(textBoxMax.Text.Length > 0 && textBoxMax.Text.All(char.IsNumber))
            {
                textBoxMax.BackColor = Color.White;
            }else { textBoxMax.BackColor = Color.LightCoral; };

            if (allTextBoxesAreCleared())
            {
                buttonSave.Enabled = true;
            }
            else { buttonSave.Enabled = false; }
        }

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMin.Text.Length > 0 && textBoxMin.Text.All(char.IsNumber))
            {
                textBoxMin.BackColor = Color.White;
            }
            else { textBoxMin.BackColor = Color.LightCoral; };

            if (allTextBoxesAreCleared())
            {
                buttonSave.Enabled = true;
            }
            else { buttonSave.Enabled = false; }
        }

        private void textBoxInventory_TextChanged(object sender, EventArgs e)
        {
            if (textBoxInventory.Text.Length > 0 && textBoxInventory.Text.All(char.IsNumber))
            {
                textBoxInventory.BackColor = Color.White;
            }
            else { textBoxInventory.BackColor = Color.LightCoral; };

            if (allTextBoxesAreCleared())
            {
                buttonSave.Enabled = true;
            }else { buttonSave.Enabled = false; }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Inventory.updatePart(Inventory.AllParts[selectedPartIndex]);
        }

        private void FormModifyParts_Load(object sender, EventArgs e)
        {

            //load in the values of the part
            LoadValuesOfCurrentPart(Inventory.AllParts[0]);
            
        }

        private void LoadValuesOfCurrentPart(Parts part)
        {
            if (part != null)
            {
                textBoxName.Text = part.Name.ToString();
                textBoxPriceCost.Text = part.Price.ToString();
                textBoxMin.Text = part.Min.ToString();
                textBoxMax.Text = part.Max.ToString();
                textBoxInventory.Text = part.InStock.ToString();
                textBoxID.Text = part.PartID.ToString();
                //textBoxLocation.Text = part.;


            }else { Console.WriteLine(part +": part is null");}
            
        }

        public static void SetcurrentPart(Parts partIndex)
        { 
            
        
        }

        private bool allTextBoxesAreCleared()
        {
            if (textBoxInventory.BackColor == Color.White && textBoxMin.BackColor == Color.White && textBoxMax.BackColor == Color.White && textBoxName.BackColor == Color.White && textBoxPriceCost.BackColor == Color.White && textBoxLocation.BackColor == Color.White && (radioButtonInHouse.Checked || radioButtonOutsourced.Checked))
            {
                return true;
            }else { return false; }
        }
    }
}
