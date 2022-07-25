using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pms
{
    class Supplier
    {
        public int id;
        public string name;
        public string address;
        public string tel;
        public string email;
        public string type;

        public Supplier(int id, string name, string address, string tel, string email, string type)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.tel = tel;
            this.email = email;
            this.type = type;
        }//ef

        public Supplier()
        {

        }//ef
    }//ef
}//ef
