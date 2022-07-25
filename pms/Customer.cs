using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pms
{
    public class Customer
    {
        public int id;
        public string firstName;
        public string lastName;
        public string company;
        public string address;
        public string tel;
        public string phone;
        public string email;
        public string type;
        public string fullName;

        public Customer(int id, string firstName, string lastName, string company, string address, string tel, string phone, string email, string type, string fullName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.company = company;
            this.address = address;
            this.tel = tel;
            this.phone = phone;
            this.email = email;
            this.type = type;
            this.fullName = fullName;
        }//ef

        public Customer()
        {
            //empty
        }//ef
    }//ec
}//en
