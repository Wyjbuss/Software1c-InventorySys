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
            this.Close();
        }

        private void radioButtonOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonOutsourced.Checked) 
            { 
                this.labelLocationName.Text = "Company Name".ToString();
                if (!textBoxLocation.Text.Any(char.IsLetter))
                { 
                    textBoxLocation.BackColor = Color.LightCoral; 
                }
                else if (textBoxLocation.Text.Length <= 0) { textBoxLocation.BackColor = Color.LightCoral; }
                else { textBoxLocation.BackColor = Color.White; }
            }
            else if (!this.radioButtonOutsourced.Checked) 
            { 
                this.labelLocationName.Text = "MachineID".ToString(); 
                if (!textBoxLocation.Text.All(char.IsNumber)) 
                {
                    textBoxLocation.BackColor = Color.LightCoral; 
                }
                else if (textBoxLocation.Text.Length <= 0) { textBoxLocation.BackColor = Color.LightCoral; }
                else { textBoxLocation.BackColor = Color.White; }
            };
        }


        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length <= 0) { textBoxName.BackColor = Color.LightCoral; 
            }else if (textBoxName.Text.Length > 0) { textBoxName.BackColor = Color.White; };

            //if all of the text feilds are white then save button is active
            if (textBoxName.BackColor == Color.White && textBoxInventory.BackColor == Color.White && textBoxPriceCost.BackColor == Color.White && textBoxMax.BackColor == Color.White && textBoxMin.BackColor == Color.White && textBoxLocation.BackColor == Color.White)
            {
                buttonSave.Enabled = true;
            }
            else buttonSave.Enabled = false;
        }

        private void textBoxInventory_TextChanged(object sender, EventArgs e)
        {

            //if all of the text feilds are white then save button is active
            if (textBoxName.BackColor == Color.White && textBoxInventory.BackColor == Color.White && textBoxPriceCost.BackColor == Color.White && textBoxMax.BackColor == Color.White && textBoxMin.BackColor == Color.White && textBoxLocation.BackColor == Color.White)
            {
                buttonSave.Enabled = true;
            }
            else buttonSave.Enabled = false;

            if (textBoxMax.Text.Length <= 0)
            {
                textBoxInventory.BackColor = Color.LightCoral;
            }
            else if (textBoxInventory.Text.Length > 0 && textBoxInventory.Text.All(char.IsNumber) && int.Parse(textBoxInventory.Text) >= int.Parse(textBoxMax.Text))
            {
                textBoxInventory.BackColor = Color.White;
            }
            else { textBoxInventory.BackColor = Color.LightCoral; };
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
            else if (textBoxPriceCost.Text.Length > 0 && (textBoxPriceCost.Text.Any(char.IsDigit) || textBoxPriceCost.Text.Any(char.IsPunctuation)) )
            { 
                textBoxPriceCost.BackColor = Color.White; 
            };

            //if all of the text feilds are white then save button is active
            if (textBoxName.BackColor == Color.White && textBoxInventory.BackColor == Color.White && textBoxPriceCost.BackColor == Color.White && textBoxMax.BackColor == Color.White && textBoxMin.BackColor == Color.White && textBoxLocation.BackColor == Color.White)
            {
                buttonSave.Enabled = true;
            }
            else buttonSave.Enabled = false;
        }

        private void textBoxMax_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMax.Text.Length <= 0 || textBoxMin.Text.Length <= 0 || int.Parse(textBoxMax.Text) > int.Parse(textBoxInventory.Text) ) 
            { 
                textBoxMax.BackColor = Color.LightCoral; 
            }
            else if (!textBoxMax.Text.Any(char.IsNumber))
            {
                textBoxMax.BackColor = Color.LightCoral;
            }
            else if (int.Parse(textBoxMax.Text) < int.Parse(textBoxMin.Text) && textBoxMax.Text.Length > 0 && textBoxMin.Text.Length > 0 )
            {
                textBoxMax.BackColor = Color.LightCoral;
            }
            else if (int.Parse(textBoxMax.Text) == -1 || int.Parse(textBoxMin.Text) == -1)
            {
                textBoxMax.BackColor = Color.LightCoral;
            }
            else if (textBoxMax.Text.Length > 0) { textBoxMax.BackColor = Color.White; };

            //if all of the text feilds are white then save button is active
            if (textBoxName.BackColor == Color.White && textBoxInventory.BackColor == Color.White && textBoxPriceCost.BackColor == Color.White && textBoxMax.BackColor == Color.White && textBoxMin.BackColor == Color.White && textBoxLocation.BackColor == Color.White)
            {
                buttonSave.Enabled = true;
            }
            else buttonSave.Enabled = false;
        }

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMin.Text.Length > 0 && textBoxMax.Text.Length > 0 && textBoxMin.Text.All(char.IsNumber) && int.Parse(textBoxMin.Text) <= int.Parse(textBoxMax.Text))
            {
                textBoxMin.BackColor = Color.White;
            }
            else { textBoxMin.BackColor = Color.LightCoral; };

            //if all of the text feilds are white then save button is active
            if (textBoxName.BackColor == Color.White && textBoxInventory.BackColor == Color.White && textBoxPriceCost.BackColor == Color.White && textBoxMax.BackColor == Color.White && textBoxMin.BackColor == Color.White && textBoxLocation.BackColor == Color.White)
            {
                buttonSave.Enabled = true;
            }
            else buttonSave.Enabled = false;
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

            //if all of the text feilds are white then save button is active
            if (textBoxName.BackColor == Color.White && textBoxInventory.BackColor == Color.White && textBoxPriceCost.BackColor == Color.White && textBoxMax.BackColor == Color.White && textBoxMin.BackColor == Color.White && textBoxLocation.BackColor == Color.White)
            {
                buttonSave.Enabled = true;
            }
            else buttonSave.Enabled = false;

        }

        private void buttonSave_MouseClick(object sender, MouseEventArgs e)
        {

            //sets the textbox feilds as verables
            string currentName = textBoxName.Text;
            decimal currentPrice = decimal.Parse(textBoxPriceCost.Text);
            int currentInSock = int.Parse(textBoxInventory.Text);
            int currentMax = int.Parse(textBoxMax.Text);
            int currentMin = int.Parse(textBoxMin.Text);
            bool outsourced = radioButtonOutsourced.Checked;
            bool inHouse = radioButtonInHouse.Checked;
            string local = textBoxLocation.Text;

            if (outsourced)
            {
                Outsourced outsourcedPart = new Outsourced();
                outsourcedPart.PartID = Inventory.AllParts.Count +1;
                outsourcedPart.Name = currentName;
                outsourcedPart.Price = currentPrice;
                outsourcedPart.InStock = currentInSock;
                outsourcedPart.Max = currentMax;
                outsourcedPart.Min = currentMin;
                outsourcedPart.CompanyName = local;

                try
                {
                    Console.WriteLine(  outsourcedPart);
                    // add the part
                    Inventory.addPart(outsourcedPart);
                    this.Close();
                }
                catch (Exception)
                {

                    Console.WriteLine("Error with adding inhouse part");
                }


            }
            else if (inHouse)
            {
                Inhouse inhousePart = new Inhouse();
                inhousePart.PartID = Inventory.AllParts.Count + 1;
                inhousePart.Name = currentName;
                inhousePart.Price = currentPrice;
                inhousePart.InStock = currentInSock;
                inhousePart.Max = currentMax;
                inhousePart.Min = currentMin;
                inhousePart.MachineID = int.Parse(local);

                try
                {
                    Console.WriteLine(inhousePart);
                    // add the part
                    Inventory.addPart(inhousePart);
                    this.Close();
                }
                catch (Exception)
                {

                    Console.WriteLine("Error with adding inhouse part");
                }



            } else { Console.WriteLine("error, no locaton selected (radio button)"); }
            

            
            
            

        }

        private void FormAddParts_Load(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
