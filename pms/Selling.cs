using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pms
{
    class Selling
    {
        public int id;
        public string name;
        public string type;
        public int qty;
        public double total;
        public string date;

        public Selling(int id, string name, string type, int qty, double total, string date)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.qty = qty;
            this.total = total;
            this.date = date;
        }//ef

        public Selling()
        {
            //empty
        }//ef
    }//ec
}//en
