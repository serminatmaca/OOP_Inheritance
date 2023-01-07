using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.HOME.INHERİTANCE
{
    internal class HomeInformation : Host
    {
        public string district { get; set; }
        public int SquareMeters { get; set; }
        public int  NumberOfRooms { get; set; }
        public int NumberOfBathrooms { get; set; }
        public int AgeOfTheHouse { get; set; }
        public int SalePrice { get; set; }

    }
}
