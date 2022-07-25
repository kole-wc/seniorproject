using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pms
{
    class CustomerRetention
    {
        public int id;
        public string firstName;
        public string lastName;
        public string company;
        public int servcomp;
        public int ordercomp;
        public double weighted;
        public string date;

        public CustomerRetention(int id, string firstName, string lastName, string company, int servcomp, int ordercomp, double weighted, string date)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.company = company;
            this.servcomp = servcomp;
            this.ordercomp = ordercomp;
            this.weighted = weighted;
            this.date = date;
        }//ef

        public CustomerRetention()
        {
            //empty
        }//ef
    }//ec
}//en
