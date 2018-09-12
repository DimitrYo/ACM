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

        public  OrderDisplay RetrieveOrderDisplay(int orderId) {
            OrderDisplay orderDisplay = new OrderDisplay();
            // Code that retrieves the defined fields

            // Temporary Hard-coded data
            if (orderId == 10) {
                orderDisplay.FirstName = "Bilbo";
                orderDisplay.LastName = "Baggins";
                orderDisplay.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, TimeSpan.FromHours(1));
                orderDisplay.ShippingAddress = new Address() {
                    AddressType = 1,
                    StreetLine1 = "Bad End",
                    StreetLine2 = "Bagshot Row",
                    City = "Nobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                };

            }

            orderDisplay.orderDisplayItemList = new List<OrderDisplayItem>();

            if (orderId == 10) {
                var orderDisplayItem = new OrderDisplayItem() {
                    ProductName = "Sunfliwers",
                    PurchasePrice = 15.96M,
                    OrderQuantity = 2
                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);

                orderDisplayItem = new OrderDisplayItem() {
                    ProductName = "Rake",
                    PurchasePrice = 6M,
                    OrderQuantity = 1
                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);

            }
            return orderDisplay;
        }

        public bool Save()
        {
            return true;
        }
    }
}
