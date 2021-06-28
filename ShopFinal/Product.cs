using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFinal
{
    public class Product
    {
        private long id, supplierId;
        private string name;

        public Product()
        {
            id = -1;
            supplierId = -1;
            name = "undefined";
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
        public long SupplierId
        {
            set
            {
                if (value > 0)
                    supplierId = value;
            }
            get { return supplierId; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
    }
}
