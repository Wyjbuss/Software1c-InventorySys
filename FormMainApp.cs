using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WyattBussellC968Software1C_
{
    public partial class mainApplicationWindow : Form
    {
        public Products selectedProduct = null;
        public Parts selectedPart = null;
        private BindingList<Parts> LookedUpPartsList = new BindingList<Parts>();
        private BindingList<Products> lookedUpProductsList = new BindingList<Products>();
        public mainApplicationWindow()
        {
            InitializeComponent();

            //sets that data source, the data auto displays in the DataGridView
            dataGridViewParts.DataSource = Inventory.AllParts;
            dataGridViewProducts.DataSource = Inventory.Product;

            //see a ful row selection
            dataGridViewParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //make the grid read only
            dataGridViewParts.ReadOnly = true;
            dataGridViewParts.MultiSelect = false;
            dataGridViewParts.AllowUserToAddRows = false;

            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.MultiSelect = false;
            dataGridViewProducts.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // this only occures once the balck text in the cells are clicked, this is not what we want
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
            //when this is clicked then check to see if selected part is not null
            if (selectedPart == null)
            {
                Console.WriteLine("There was no part selected to modify");
            }
            else
            {
                FormModifyParts frm = new FormModifyParts();
                
                
                //Inventory.updatePart(dataGridViewParts.CurrentRow.Index, selectedPart);
                Inventory.CurrentPartBindingList.Clear();
                Inventory.CurrentPartBindingList.Add(selectedPart);
                FormModifyParts.selectedPartindex = dataGridViewParts.CurrentRow.Index;
                Console.WriteLine("selectedPartIndex is: "+FormModifyParts.selectedPartindex+" from Main form app");

                frm.Show();
            }
            
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

        private void buttonExit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void dataGridViewParts_SelectionChanged(object sender, EventArgs e)
        {
            if (Inventory.CurrentPartBindingList.Count <= 0)
            {
                Inventory.CurrentPartBindingList.Clear();
                Inventory.CurrentPartBindingList.Add(selectedPart);
            }
            

        }

        private void buttonDeleteParts_MouseClick(object sender, MouseEventArgs e)
        {
            // this is incorrect because this isnt using the function from the inventory
            //but it works. 
            
            if (Inventory.AllParts.Count > 0)
            {
                //int currentIndex = dataGridViewParts.CurrentRow.Index;
                //Inventory.AllParts.RemoveAt(currentIndex);

                Inventory.deletePart(selectedPart); 
                //return selected part to null
                selectedPart = null;
                
            }else if (selectedPart == null) 
            { 
                Console.WriteLine("selected part is equil to null. Select a part to delete.");
                /*include a popup that tells the user to select an item*/ 
            }
            else { /* Error, cant remove item when there is no item */ }
            

        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDeleteParts_Click(object sender, EventArgs e)
        {
            
            
        }

        private void buttonModifyParts_Click(object sender, EventArgs e)
        {
            //dont use this
        }

        private void buttonSearchParts_MouseClick(object sender, MouseEventArgs e)
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

        private void dataGridViewProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewParts.ClearSelection();
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (Inventory.CurrentPartBindingList.Count <= 0)
            {
                Inventory.CurrentPartBindingList.Clear();
                Inventory.CurrentPartBindingList.Add(selectedPart);
            }
        }

        private void buttonSearchProducts_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearchProducts_MouseClick(object sender, MouseEventArgs e)
        {
            lookedUpProductsList.Clear();
            string searchedItem = textBoxSearchProducts.Text;
            if (searchedItem == "")
            {
                // bind dataGridView to data source
                dataGridViewParts.DataSource = Inventory.Product;

            }
            else
            {

                //loop through the items in the gridView
                for (int i = 0; i < Inventory.Product.Count; i++)
                {//this is basically a foreach loop
                    Products item = Inventory.Product[i];
                    //find items in the rows's cells that equate to the searched item
                    if (item.Name == searchedItem || item.ProductID.ToString() == searchedItem)
                    {
                        // serverything else will be a visable = false
                        // this wont work with a bound dataGridView
                        //dataGridViewParts.Rows[i].Visible = true;
                        lookedUpProductsList.Add(item);
                        dataGridViewProducts.DataSource = lookedUpProductsList;
                    }
                    else { /* do nothing if it dosent match anything*/ }


                }
            }
        }

        private void buttonDeleteProducts_MouseClick(object sender, MouseEventArgs e)
        {

            if (Inventory.Product.Count > 0)
            {
                //int currentIndex = dataGridViewParts.CurrentRow.Index;
                //Inventory.AllParts.RemoveAt(currentIndex);
                for(int i = 0;i < Inventory.Product.Count;i++)
                {
                    if (Inventory.Product[i] == selectedProduct)
                    {
                        Inventory.removeProduct(i);
                    }
                }
                
                //return selected part to null
                selectedPart = null;

            }
            else if (selectedPart == null)
            {
                Console.WriteLine("selected part is equil to null. Select a part to delete.");
                /*include a popup that tells the user to select an item*/
            }
            else { /* Error, cant remove item when there is no item */ }
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewProducts.SelectedRows.Count > 0)
                { // changes the current selected part every time this is triggered
                    int currentIndex = dataGridViewProducts.CurrentRow.Index;
                    Products currentProduct = Inventory.Product[currentIndex];
                    selectedProduct = currentProduct;
                }

                //Console.WriteLine(currentIndex);
            }
            catch (Exception)
            {

                Console.WriteLine("object not set to an instance of an object");
            }
        }
    }
}
