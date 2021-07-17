using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFinal
{
    public class OrderProduct
    {
        private int id, supplierId;
        private string name;
        public OrderProduct()
        {
            id = -1;
            supplierId = -1;
            name = "";
        }

        public int Id
        {
            set
            {
                if (value > 0)
                    id = value;
            }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public int SupplierId { get => supplierId; set => supplierId = value; }
    }
}