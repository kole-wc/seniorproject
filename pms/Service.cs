using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pms
{
    class Service
    {
        public int id;
        public string description;
        public string status;
        public string type;
        public string customer;
        public double amount;
        public string startdate;

        public Service(int id, string description, string status, string type, string customer, double amount, string startdate)
        {
            this.id = id;
            this.description = description;
            this.status = status;
            this.type = type;
            this.customer = customer;
            this.amount = amount;
            this.startdate = startdate;
        }//ef

        public Service()
        {

        }//ef
    }//ef
}//ef
