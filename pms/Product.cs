using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pms
{
    class Product
    {
        public int id;
        public string name;
        public double price;
        public string type;

        public Product(int id, string name, double price, string type)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.type = type;
        }//ef

        public Product()
        {
            //empty
        }//ef
    }//ec
}//en
