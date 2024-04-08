using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WyattBussellC968Software1C_
{
    public class Products
    {
        public BindingList<Parts> AssociatedParts;
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price {  get; set; }
        public int InStock {  get; set; }
        public int Max {  get; set; }
        public int Min {  get; set; }

        public Products()
        {
            AssociatedParts = new BindingList<Parts>();
            ProductID = Inventory.Product.Count+1;
            Name = "newProduct" + Inventory.Product.Count;
            Price = 0;
            InStock = 0;
            Max = 0;
            Min = 0;

        }
        public void addAssociatedPart(Parts part)
        {
            if (part != null)
            {
                AssociatedParts.Add(part);
            }
            else { Console.WriteLine("error adding part to associated parts bindingList"); }
            
        }

        public bool removeAssociatedPart(int partIndex)
        {
            if(partIndex != -1)
            {
                Console.WriteLine("part index in products script {0}", partIndex);
                AssociatedParts.Remove(AssociatedParts[partIndex]);
                //AssociatedParts[partIndex];
                return true;
            }
            return false;
        }

        public Parts lookupAssociatedPart(int partIndex)
        {
            if (partIndex != -1)
            {
                return AssociatedParts[partIndex];
            }
            else
            {
                Console.WriteLine("not part association exists in the search");
                return null;
            }
            

        }
    }
}
