using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 1)
            {
                order.OrderDate = new DateTimeOffset(2014, 05, 12, 5, 44, 23, TimeSpan.FromHours(1));
            }
            return order;
        }

        public bool Save()
        {
            return true;
        }
    }
}
