using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFinal
{
    public class Supplier
    {
        private int id;
        private string name, address, phone, email;


        public Supplier() : this("", "", "", "")
        { }

        public Supplier(string name, string address, string phone, string email) : this(-1, name, address, phone, email)
        { }

        public Supplier(int id, string name, string address, string phone, string email)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
        }

        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Address
        {
            set { address = value; }
            get { return address; }
        }
        public string Phone
        {
            set { phone = value; }
            get { return phone; }
        }
        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        public void Clear()
        {
            Id = -1;
            Name = Address = Phone = Email = "";
        }



    }
}
