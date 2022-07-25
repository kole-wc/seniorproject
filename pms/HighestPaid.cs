using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pms
{
    class HighestPaid
    {
        public int id;
        public string customer;
        public string type;
        public double amount;
        public string date;

        public HighestPaid(int id, string customer, string type, double amount, string date)
        {
            this.id = id;
            this.customer = customer;
            this.type = type;
            this.amount = amount;
            this.date = date;
        }//ef

        public HighestPaid()
        {
            //empty
        }//ef
    }//ec
}//ef
