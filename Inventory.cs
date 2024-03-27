using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WyattBussellC968Software1C_
{
    internal class Inventory
    {
        public static BindingList<Products> Products;
        public static BindingList<Parts> AllParts = new BindingList<Parts>();

        // this will only have one item in it at all times
        public static BindingList<Parts> CurrentPartBindingList = new BindingList<Parts>();
       
        static Inventory()
        {
            //AllParts.Add(new Parts { PartID = 1, Name = "Rapier", Price = 300.49M, InStock = 8, Min = 1, Max = 50 });
            //AllParts.Add(new Parts { PartID = 2, Name = "Broad", Price = 200.15M, InStock = 159, Min = 1, Max = 500 });
            //AllParts.Add(new Parts { PartID = 3, Name = "Dagger", Price = 90.70M, InStock = 13, Min = 1, Max = 50 });
            //AllParts.Add(new Parts { PartID = 4, Name = "Zwei-Hander", Price = 900.00M, InStock = 16, Min = 1, Max = 50 });
        }
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

        public static void addPart(Parts thisPart)
        {

            AllParts.Add(thisPart);

        }

        public static bool deletePart(Parts thisPart)
        {
            try
            {
                //removes part from list
                AllParts.Remove(thisPart);
                return true;
            }
            catch (Exception)
            {

                Console.WriteLine("error deleting item");
                return false;
            }
            
            
        }

        public static Parts lookupPart(int partId) {  return AllParts[partId]; }



        /// <summary>
        /// Replaces part values of given part with index specifyed with the part givin.
        /// </summary>
        /// <param name="indexOfPartToUpdate">specify part to modify, index in AllParts</param>
        /// <param name="CurrentModifyedPart">specify part whoes data you want to use to updates the parts[index] with</param>
        public static void updatePart(int indexOfPartToUpdate, Parts CurrentModifyedPart) 
        {
           // get current shown part
           Parts partToUpdate = AllParts[indexOfPartToUpdate];
          
           // chage part values
           partToUpdate.Name = CurrentModifyedPart.Name;
           partToUpdate.Price = CurrentModifyedPart.Price;
           partToUpdate.Min = CurrentModifyedPart.Min;
           partToUpdate.Max = CurrentModifyedPart.Max;
           partToUpdate.InStock = CurrentModifyedPart.InStock;
           
        }
    }
}
