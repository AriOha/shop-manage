using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFinal
{
    public class Customer
    {
        private int id;
        private string firstName, lastName;

        public Customer()
        {
            id = -1;
            firstName = "";
            lastName = "";
        }

        public int Id
        {
            set
            {
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
        public void Clear()
        {
            Id = -1;
            FirstName = LastName = "";
        }
    }
}

