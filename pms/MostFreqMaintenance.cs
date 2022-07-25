using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pms
{
    class MostFreqMaintenance
    {
        public int id;
        public string customer;
        public int freq;
        public string date;

        public MostFreqMaintenance(int id, string customer, int freq, string date)
        {
            this.id = id;
            this.customer = customer;
            this.freq = freq;
            this.date = date;
        }//ef

        public MostFreqMaintenance()
        {
            //empty
        }//ef
    }//ec
}//en
