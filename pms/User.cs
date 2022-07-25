using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pms
{
    public class User
    {
        public int id;
        public string firstName;
        public string lastName;
        public string username;
        public string role;

        public User(int id, string firstName, string lastName, string username, string role)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.role = role;
        }//ef

        public User()
        {
            //empty
        }//ef
    }//ec
}
