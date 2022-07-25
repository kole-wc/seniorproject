using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pms
{
    class NewService
    {
        public int id;
        public int serviceid;
        public double fees;
        public int productid;
        public string name;
        public double price;
        public int qty;
        public string type;

        public NewService(int id, int serviceid, double fees, int productid, string name, double price, int qty, string type)
        {
            this.id = id;
            this.serviceid = serviceid;
            this.fees = fees;
            this.productid = productid;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.type = type;
        }

        public NewService()
        {
            
        }
    }//ec
}//en
