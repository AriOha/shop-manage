using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFinal
{
    class Customer
    {
        private long id;
        private string firstName, lastName;

        public Customer()
        {
            id = -1;
            firstName = "undefined";
            lastName = "undefined";
        }

        public long Id
        {
            set
            {
                if (value > 0)
                    id = value;
            }
            get { return id; }
        }
        public string FirstName
        {
            set { firstName = value; }
            get { return firstName; }
        }

        public string LastName
        {
            set { lastName = value; }
            get { return lastName; }
        }
    }
}

