using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {
                
        }

        public Order(int orderId)
        {
            this.Orderid = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int Orderid { get; private set; }

        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;

            return isValid;
        }

    }
}
