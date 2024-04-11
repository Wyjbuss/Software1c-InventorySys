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
    public partial class FormModifyProducts : Form
    {
        public int selectedProductIndex;
        public Products newProduct = new Products();
        public Parts selectedPart;
        private BindingList<Parts> LookedUpPartsList = new BindingList<Parts>();

        public int selectedAssioatedPartIndex;
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

            dataGridViewAssociatedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAssociatedParts.ReadOnly = true;
            dataGridViewAssociatedParts.MultiSelect = false;
            dataGridViewAssociatedParts.AllowUserToAddRows = false;
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

        public void loadModifyProductData(Products productToModify, int index)
        {
            
            textBoxName.Text = productToModify.Name;
            textBoxInventory.Text = productToModify.InStock.ToString();
            textBoxPriceCost.Text = productToModify.Price.ToString();
            textBoxMax.Text = productToModify.Max.ToString();
            textBoxMin.Text = productToModify.Min.ToString();

            dataGridViewAssociatedParts.DataSource = productToModify.AssociatedParts;
            dataGridViewAssociatedParts.Refresh();
            newProduct = productToModify;
            selectedProductIndex = index;
        }

        private void buttonSave_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                // when save button is pressed do ACTION
                //Products currentProduct = Inventory.Product[selectedProductIndex];
                //Products updatedProduct = new Products();

                newProduct.Name = textBoxName.Text;
                newProduct.Price = decimal.Parse(textBoxPriceCost.Text);
                newProduct.InStock = int.Parse(textBoxInventory.Text);
                newProduct.Min = int.Parse(textBoxMin.Text);
                newProduct.Max = int.Parse(textBoxMax.Text);

                Inventory.updateProduct(selectedProductIndex, newProduct);
                this.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Save modified product didn't occure");
            }
            
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

        private bool allTextBoxesAreCleared()
        {
            if (textBoxInventory.BackColor == Color.White && textBoxMin.BackColor == Color.White && textBoxMax.BackColor == Color.White && textBoxName.BackColor == Color.White && textBoxPriceCost.BackColor == Color.White)
            {
                return true;
            }
            else { return false; }
        }

        private void buttonAdd_MouseClick(object sender, MouseEventArgs e)
        {
            if (!buttonAdd.Enabled) { return; }
            else 
            {
                newProduct.addAssociatedPart(selectedPart);

                dataGridViewAssociatedParts.DataSource = newProduct.AssociatedParts;

                dataGridViewParts.ClearSelection();
                dataGridViewAssociatedParts.ClearSelection();
            }
            // when add is press add the part to the associated parts list of the product
        }

        private void dataGridViewParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewParts.SelectedRows.Count > 0)
                { // changes the current selected part every time this is triggered
                    int currentIndex = dataGridViewParts.CurrentRow.Index;
                    Parts currentPart = Inventory.AllParts[currentIndex];
                    selectedPart = currentPart;
                }

                //Console.WriteLine(currentIndex);
            }
            catch (Exception)
            {

                Console.WriteLine("object not set to an instance of an object");
            }
        }

        private void FormModifyProducts_Load(object sender, EventArgs e)
        {
            //newProduct.Name = textBoxName.Text;
            //newProduct.Price = decimal.Parse(textBoxPriceCost.Text);
            //newProduct.InStock = int.Parse(textBoxInventory.Text);
            //newProduct.Min = int.Parse(textBoxMin.Text);
            //newProduct.Max = int.Parse(textBoxMax.Text);

        }

        private void buttonDelete_MouseClick(object sender, MouseEventArgs e)
        {
            int currentIndex = dataGridViewParts.CurrentRow.Index;
            if (currentIndex == -1)
            {
                return;
            }
            else
            {
                newProduct.removeAssociatedPart(currentIndex);
                dataGridViewAssociatedParts.Refresh();
            }
        }

        private void dataGridViewAssociatedParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewParts.SelectedRows.Count > 0)
                { // changes the current selected part every time this is triggered
                    selectedAssioatedPartIndex = dataGridViewParts.CurrentRow.Index;
                    //Parts currentPart = Inventory.AllParts[currentIndex];
                    //selectedAssioatedPartIndex = currentPart;
                }

                //Console.WriteLine(currentIndex);
            }
            catch (Exception)
            {

                Console.WriteLine("object not set to an instance of an object");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LookedUpPartsList.Clear();
            string searchedItem = textBoxSearchParts.Text;
            if (searchedItem == "")
            {
                // bind dataGridView to data source
                dataGridViewParts.DataSource = Inventory.AllParts;

            }
            else
            {

                //loop through the items in the gridView
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {//this is basically a foreach loop
                    Parts item = Inventory.AllParts[i];
                    //find items in the rows's cells that equate to the searched item
                    if (item.Name == searchedItem || item.PartID.ToString() == searchedItem)
                    {
                        // serverything else will be a visable = false
                        // this wont work with a bound dataGridView
                        //dataGridViewParts.Rows[i].Visible = true;
                        LookedUpPartsList.Add(item);
                        dataGridViewParts.DataSource = LookedUpPartsList;
                    }
                    else { /* do nothing if it dosent match anything*/ }


                }
            }

        }
    }
}
