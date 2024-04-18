﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WyattBussellC968Software1C_
{
    public abstract class Parts
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Parts()
        {
            PartID = Inventory.AllParts.Count + 1;
            Name = "newPart" + Inventory.AllParts.Count;
            Price = 0;
            InStock = 0;
            Min = 0;
            Max = 0;
        }
       

        

      
    }
}
