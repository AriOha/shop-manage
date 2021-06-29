using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFinal
{
    class OrderProduct
    {
        private long id, custumerId, productId, total;

        public OrderProduct()
        {
            id = -1;
            custumerId = -1;
            productId = -1;
            total = 0;
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
        public long CustomerId
        {
            set
            {
                if (value > 0)
                    custumerId = value;
            }
            get { return custumerId; }
        }
        public long ProductId
        {
            set
            {
                if (value > 0)
                    productId = value;
            }
            get { return productId; }
        }
        public long Total
        {
            set
            {
                if (value > 0)
                    total = value;
            }
            get { return total; }
        }

    }
}