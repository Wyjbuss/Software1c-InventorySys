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
        // Find a way to put the index here
        public static int selectedPartindex { get; set; }

        public event EventHandler OnFormExit;
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
            if (textBoxMax.Text.Length > 0 && textBoxMax.Text.All(char.IsNumber))
            {
                textBoxMax.BackColor = Color.White;
            }
            else { textBoxMax.BackColor = Color.LightCoral; };

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
            }
            else { buttonSave.Enabled = false; }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (selectedPartindex == -1 || !allTextBoxesAreCleared())
                {
                    return;
                }
                else if (allTextBoxesAreCleared() && selectedPartindex != -1)
                {
                    //create new part
                    if (radioButtonInHouse.Checked) 
                    {
                        Inhouse newInHouse = new Inhouse();
                        newInHouse.Name = textBoxName.Text;
                        newInHouse.Price = decimal.Parse(textBoxPriceCost.Text);
                        newInHouse.InStock = int.Parse(textBoxInventory.Text);
                        newInHouse.Min = int.Parse(textBoxMin.Text);
                        newInHouse.Max = int.Parse(textBoxMax.Text);
                        newInHouse.MachineID = int.Parse(textBoxLocation.Text);
                        
                        Inventory.updatePart(selectedPartindex, (Inhouse)newInHouse);
                        this.Close();

                    }
                    else if (radioButtonOutsourced.Checked)
                    {
                        Outsourced newOutsourced = new Outsourced();
                        newOutsourced.Name = textBoxName.Text;
                        newOutsourced.Price = decimal.Parse(textBoxPriceCost.Text);
                        newOutsourced.InStock = int.Parse(textBoxInventory.Text);
                        newOutsourced.Min = int.Parse(textBoxMin.Text);
                        newOutsourced.Max = int.Parse(textBoxMax.Text);
                        newOutsourced.CompanyName = textBoxLocation.Text;

                        Inventory.updatePart(selectedPartindex, (Outsourced)newOutsourced);
                        this.Close();

                    }

                    //find the index of the part
                    //Inventory.updatePart(selectedPartindex, Inventory.CurrentPartBindingList[0]);
                    Console.WriteLine("selectedPartIndex is: " + selectedPartindex);
                    if (Inventory.CurrentPartBindingList.Count < 0)
                    {
                        Console.WriteLine(Inventory.CurrentPartBindingList[0].Name);
                    }

                    //this.Close();
                }
                else if (selectedPartindex == -1) { Console.WriteLine("selected part index is -1: " + selectedPartindex); }
                else { Console.WriteLine("Failed to save, from FormModifyParts, selectedPartIndex is: " + selectedPartindex); }
                
                // Parts updatePart = new Parts();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void FormModifyParts_Load(object sender, EventArgs e)
        {

            //load in the values of the part
            //LoadValuesOfCurrentPart(Inventory.CurrentPartBindingList[0]);

        }

        public void LoadValuesOfCurrentPartInhouse(Inhouse inHousePart, int index)
        {
            // this can go in the main app once the app is created new
            if (inHousePart != null)
            {
                textBoxName.Text = inHousePart.Name;
                textBoxPriceCost.Text = inHousePart.Price.ToString();
                textBoxMin.Text = inHousePart.Min.ToString();
                textBoxMax.Text = inHousePart.Max.ToString();
                textBoxInventory.Text = inHousePart.InStock.ToString();
                textBoxID.Text = inHousePart.PartID.ToString();
                textBoxLocation.Text = inHousePart.MachineID.ToString();
                radioButtonInHouse.Checked = true;
                Console.WriteLine("in House name is: " + inHousePart.MachineID);

            }
            else { Console.WriteLine(inHousePart + ": part is null"); }

        }
        public void LoadValuesOfCurrentPartOutsourced(Outsourced outsourcedPart, int index)
        {
            // this can go in the main app once the app is created new
            if (outsourcedPart != null)
            {
                textBoxName.Text = outsourcedPart.Name;
                textBoxPriceCost.Text = outsourcedPart.Price.ToString();
                textBoxMin.Text = outsourcedPart.Min.ToString();
                textBoxMax.Text = outsourcedPart.Max.ToString();
                textBoxInventory.Text = outsourcedPart.InStock.ToString();
                textBoxID.Text = outsourcedPart.PartID.ToString();
                textBoxLocation.Text = outsourcedPart.CompanyName;
                radioButtonOutsourced.Checked = true;
                Console.WriteLine("Company name is: "+outsourcedPart.CompanyName);

            }
            else { Console.WriteLine(outsourcedPart + ": part is null"); }

        }



        private bool allTextBoxesAreCleared()
        {
            if (textBoxInventory.BackColor == Color.White && textBoxMin.BackColor == Color.White && textBoxMax.BackColor == Color.White && textBoxName.BackColor == Color.White && textBoxPriceCost.BackColor == Color.White && textBoxLocation.BackColor == Color.White && (radioButtonInHouse.Checked || radioButtonOutsourced.Checked))
            {
                return true;
            }
            else { return false; }
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        public void LoadValuesOfCurrentPart(Parts part, int index)
        {
            // this can go in the main app once the app is created new
            if (part != null)
            {
                textBoxName.Text = part.Name.ToString();
                textBoxPriceCost.Text = part.Price.ToString();
                textBoxMin.Text = part.Min.ToString();
                textBoxMax.Text = part.Max.ToString();
                textBoxInventory.Text = part.InStock.ToString();
                textBoxID.Text = part.PartID.ToString();

                if (part.GetType().Equals(typeof(Outsourced)))
                {
                    Console.WriteLine("this is type of outsourced");
                    radioButtonInHouse.Checked = false;
                    radioButtonOutsourced.Checked = true;
                    //string companyName = (Outsourced)part.;
                    //textBoxLocation.Text = part.
                }
                if (part.GetType().Equals(typeof(Inhouse)))
                {
                    Console.WriteLine("this is type of outsourced");
                    radioButtonInHouse.Checked = true;
                    radioButtonOutsourced.Checked = false;
                    //textBoxLocation.Text = part.
                }
                //radioButtonInHouse.Checked = true;


            }
            else { Console.WriteLine(part + ": part is null"); }
        }

        private void FormModifyParts_FormClosing(object sender, FormClosingEventArgs e)
        {
            // when the form exits it will trigger this
            //then this will call a refresh of the dataGridViewPArts on the main app
            OnFormExit.Invoke(this, e);
        }
    }
}
