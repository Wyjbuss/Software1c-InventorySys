﻿using System;
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
        Parts selectedPart = null;
        public mainApplicationWindow()
        {
            InitializeComponent();

            //sets that data source, the data auto displays in the DataGridView
            dataGridViewParts.DataSource = Inventory.AllParts;
            dataGridViewProducts.DataSource = Inventory.Products;

            //see a ful row selection
            dataGridViewParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //make the grid read only
            dataGridViewParts.ReadOnly = true;
            dataGridViewParts.MultiSelect = false;
            dataGridViewParts.AllowUserToAddRows = false;
            
            
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
            // changes the current selected part every time this is triggered
            int currentIndex = dataGridViewParts.CurrentRow.Index;
            Parts currentPart = Inventory.AllParts[currentIndex];
            selectedPart = currentPart;
            //Console.WriteLine(currentIndex);
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

        private void buttonExit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void dataGridViewParts_SelectionChanged(object sender, EventArgs e)
        {
            
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
    }
}
