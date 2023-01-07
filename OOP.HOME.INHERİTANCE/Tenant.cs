using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.HOME.INHERİTANCE
{
    internal class Tenant : HomeInformation
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string CityOfResidance { get; set; }

        public int Bitch { get; set; }  
    }
}
