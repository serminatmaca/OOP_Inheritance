using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class Personnel : Human // Human sınıfından kalıtıyorum ( inheritance)
    {
        public string Salary { get; set; }
        public string Title { get; set; }
        public string WorkingTime { get; set; }

    }
}
