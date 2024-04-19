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
        public static BindingList<Products> Product = new BindingList<Products>();
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
        public static void addProduct(Products thisProduct)
        {
            Product.Add(thisProduct);
        }
        public static bool removeProduct(int productToRemove)
        {
            if (Product.Count > 0 && productToRemove != -1) 
            {
                Product.RemoveAt(productToRemove);
                return true;
            }else
            {
                Console.WriteLine("Product Coundlt be removed");
                return false;
            }
            
        }

        public static Products lookupProduct(int productId){return Product[productId];}

        public static void updateProduct(int productId, Products product) 
        {
            try
            {
                // when save button is pressed do ACTION
                Products currentProduct = Product[productId];

                // send over modifyed product
                currentProduct.Name = product.Name;
                currentProduct.Price = product.Price;
                currentProduct.InStock = product.InStock;
                currentProduct.Min = product.Min;
                currentProduct.Max = product.Max;         
            }
            catch (Exception)
            {
                Console.WriteLine("Save modified product didn't occure");
            }
        }

        public static void addPart(Parts thisPart)
        {

            AllParts.Add(thisPart);
            //Console.WriteLine( thisPart);

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
            try
            {
                // when save button is pressed do ACTION
               Parts currentPart = AllParts[indexOfPartToUpdate];
                if (currentPart != null)
                {
                    
                    if (CurrentModifyedPart.GetType().Equals(typeof(Outsourced)))
                    {
                        Outsourced currentOutsourcedPart = new Outsourced();
                        currentOutsourcedPart.Name = CurrentModifyedPart.Name;
                        currentOutsourcedPart.PartID = CurrentModifyedPart.PartID;
                        currentOutsourcedPart.Price = CurrentModifyedPart.Price;
                        currentOutsourcedPart.InStock = CurrentModifyedPart.InStock;
                        currentOutsourcedPart.Min = CurrentModifyedPart.Min;
                        currentOutsourcedPart.Max = CurrentModifyedPart.Max;
                        Outsourced currentModifyedOutsourcedPart = CurrentModifyedPart as Outsourced;
                        currentOutsourcedPart.CompanyName = currentModifyedOutsourcedPart.CompanyName;
                        deletePart(currentPart);
                        addPart(currentOutsourcedPart);

                    }
                    else if (CurrentModifyedPart.GetType().Equals(typeof(Inhouse)))
                    {
                        Inhouse currentInhousePart = new Inhouse();
                        currentInhousePart.Name = CurrentModifyedPart.Name;
                        currentInhousePart.PartID = CurrentModifyedPart.PartID;
                        currentInhousePart.Price = CurrentModifyedPart.Price;
                        currentInhousePart.InStock = CurrentModifyedPart.InStock;
                        currentInhousePart.Min = CurrentModifyedPart.Min;
                        currentInhousePart.Max = CurrentModifyedPart.Max;
                        Inhouse currentModifyedInhousePart = CurrentModifyedPart as Inhouse;
                        currentInhousePart.MachineID = currentModifyedInhousePart.MachineID;
                        deletePart(currentPart);
                        addPart(currentInhousePart);
                    }

                } 
                else { Console.WriteLine("inventory scrip says part is null"); }
            }
            catch (Exception)
            {
                Console.WriteLine("Save modified product didn't occure");
            }

        }
    }
}
