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
    public partial class FormAddProducts : Form
    {

        public FormAddProducts()
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

        private void dataGridViewParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewParts.ClearSelection();
        }

        private void buttonSave_MouseClick(object sender, MouseEventArgs e)
        {
            // gives the texboxes a name/verable
            string currentName = textBoxName.Text;
            decimal currentPrice = decimal.Parse(textBoxPriceCost.Text);
            int currentInSock = int.Parse(textBoxInventory.Text);
            int currentMax = int.Parse(textBoxMax.Text);
            int currentMin = int.Parse(textBoxMin.Text);
           

            // if this is clicked then create the new product
            Products currentProduct  = new Products();
            currentProduct.Name = currentName;
            currentProduct.Price = currentPrice;
            currentProduct.InStock = currentInSock;
            currentProduct.Max = currentMax;
            currentProduct.Min = currentMin;

            try
            {
                // then add the product to the list in inventory
                Inventory.addProduct(currentProduct);
                this.Close();
            }
            catch (Exception)
            {

                Console.WriteLine("Product Couldn't be added, From add product script");
            }
            

        }
        private bool allTextBoxesAreCleared()
        {
            if (textBoxInventory.BackColor == Color.White && textBoxMin.BackColor == Color.White && textBoxMax.BackColor == Color.White && textBoxName.BackColor == Color.White && textBoxPriceCost.BackColor == Color.White )
            {
                return true;
            }
            else { return false; }
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

        private void textBoxMax_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMax.Text.Length <= 0)
            {
                textBoxMax.BackColor = Color.LightCoral;
            }
            else if (!textBoxMax.Text.Any(char.IsNumber))
            {
                textBoxMax.BackColor = Color.LightCoral;
            }
            else if (textBoxMax.Text.Length > 0) { textBoxMax.BackColor = Color.White; };

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
    }
}
