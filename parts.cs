using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WyattBussellC968Software1C_
{
    public class Parts
    {

        public int PartID;
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock {  get; set; }
        public int Min {  get; set; }
        public int Max {  get; set; }


        public static BindingList<Parts> part = new BindingList<Parts>();


        static Parts()
        {
            part.Add(new Parts{ PartID = 1, Name = "Rapier", Price = 300.49M, InStock = 15, Min = 1, Max = 5 });
            part.Add(new Parts { PartID = 1, Name = "Broad", Price = 200.15M, InStock = 15, Min = 1, Max = 5 });
            part.Add(new Parts { PartID = 1, Name = "Dagger", Price = 90.70M, InStock = 15, Min = 1, Max = 5 });
            part.Add(new Parts { PartID = 1, Name = "Zwei-Hander", Price = 900.00M, InStock = 15, Min = 1, Max = 5 });
        }
    }
}
