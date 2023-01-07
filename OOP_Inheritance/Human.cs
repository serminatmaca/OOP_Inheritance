using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class Human
    { //class ımın özelliklerini ( properties) tanımlıyorum. dışardan erişilebilmesi için de public access modifier
      //  kullanılıyor.
        public string Name { get; set; }
        public string SurName { get; set; }
        public string TCIDNo { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public string Adress { get; set; }



    }
}
