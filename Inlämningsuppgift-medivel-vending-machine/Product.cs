using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inlämningsuppgift_medivel_vending_machine
{
    abstract internal class Product
    {

        public string name;
        public int price;
        public string description;


        public Product(string name, int price, string description)
        {
            
            this.name = name;
            this.price = price;
            this.description = description;

        
        }

       
    }
}
