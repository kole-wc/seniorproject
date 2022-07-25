using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pms
{
    class Maintenance
    {
        public int id;
        public string service;
        public string problem;
        public string status;
        public string request_date;

        public Maintenance(int id, string service, string problem, string status, string request_date)
        {
            this.id = id;
            this.service = service;
            this.problem = problem;
            this.status = status;
            this.request_date = request_date;
        }//ef

        public Maintenance()
        {
            //empty
        }//ef
    }//ec
}//en
