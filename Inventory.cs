using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WyattBussellC968Software1C_
{
    internal class Inventory
    {
        public BindingList<Products> products;
        public BindingList<Parts> AllParts;

        public void addProduct()
        {
            
        }
        public bool removeProduct(int removed)
        {
            return false;
        }

        public Products lookupProduct(int productId)
        {
            return null;
        }

        public void updateProduct(int productId, Products product) 
        { 

        }

        public void addPart(int partId)
        {

        }

        public bool deletePart(int partId)
        {
            return false;
        }

        public Parts lookupPart(int partId) {  return null; }

        public void updatePart(int partId, Parts part) 
        { 

        }
    }
}
