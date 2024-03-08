using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WyattBussellC968Software1C_
{
    internal class Products
    {
        public BindingList<Parts> AssociatedParts;
        public int ProductID;
        public string Name;
        public decimal Price;
        public int InStock;
        public int Max;
        public int Min;
        public void addAssociatedPart(Parts part)
        {

        }

        public bool removeAssociatedPart(int part)
        {
            return false;
        }

        public Parts lookupAssociatedPart(int part)
        {
            return null;
        }
    }
}
