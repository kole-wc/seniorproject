using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pms
{
    public class Sales
    {
        public int id;
        public string customer;
        public string status;
        public double amount;
        public string order_date;

        public Sales(int id, string customer, string status, double amount, string order_date)
        {
            this.id = id;
            this.customer = customer;
            this.status = status;
            this.amount = amount;
            this.order_date = order_date;
        }//ef

        public Sales()
        {
            //empty
        }//ef
    }//ec
}//en
