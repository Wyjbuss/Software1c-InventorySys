using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WyattBussellC968Software1C_
{
    public class Outsourced : Parts
    {

        public string CompanyName { get; set; }

        public Outsourced()
        {
            CompanyName = string.Empty;
        }

        public string GetCompanyName()
        {
            return CompanyName;
        }
    }
}
