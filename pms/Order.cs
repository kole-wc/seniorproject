using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pms
{
    class Order
    {
        public int id;
        public int sales_id;
        public int product_id;
        public string name;
        public double price;
        public int qty;
        public string type;

        public Order(int id, int sales_id, int product_id, string name, double price, int qty, string type)
        {
            this.id = id;
            this.sales_id = sales_id;
            this.product_id = product_id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.type = type;
        }//ef

        public Order()
        {
            //empty
        }//ef
    }//ec
}//ef
