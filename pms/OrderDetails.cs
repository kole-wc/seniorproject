using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pms
{
    class OrderDetails
    {
        public int id;
        public int salesid;
        public int productid;
        public string name;
        public double price;
        public int qty;
        public string type;

        public OrderDetails(int id, int salesid, int productid, string name, double price, int qty, string type)
        {
            this.id = id;
            this.salesid = salesid;
            this.productid = productid;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.type = type;
        }

        public OrderDetails()
        {

        }
    }//ec
}//en
