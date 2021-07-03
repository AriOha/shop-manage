using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFinal
{
    class Order
    {
        private int id, customerId;
        private string dateTime;

        public Order()
        {
            id = -1;
            customerId = -1;
            dateTime = "undefined";
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
        public int CustomerId
        {
            set
            {
                if (value > 0)
                    customerId = value;
            }
            get { return customerId; }
        }

        public string DateTime
        {
            set { dateTime = value; }
            get { return DateTime; }
        }
    }
}
