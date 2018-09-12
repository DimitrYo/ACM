using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest {

    [TestClass]
    public class OrderRepositoryTest {

        [TestMethod]
        public void RetrieveOrderDisplayTest() {
            //-- Arrange
            var orderRepositoy = new OrderRepository();
            var expected = new OrderDisplay() {
                FirstName = "Bilbo",
                LastName = "Baggins",
                OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, TimeSpan.FromHours(1)),
                ShippingAddress = new Address() {

                    AddressType = 1,
                    StreetLine1 = "Bad End",
                    StreetLine2 = "Bagshot Row",
                    City = "Nobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                },
                orderDisplayItemList = new List<OrderDisplayItem>() {
                    new OrderDisplayItem() {
                    ProductName = "Sunfliwers",
                    PurchasePrice = 15.96M,
                    OrderQuantity = 2
                    },


                    new OrderDisplayItem() {
                    ProductName = "Rake",
                    PurchasePrice = 6M,
                    OrderQuantity = 1
                    }
                }
            };

            //-- Act

            var actual = orderRepositoy.RetrieveOrderDisplay(10);

            //-- Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);

            Assert.AreEqual(expected.ShippingAddress.AddressType, actual.ShippingAddress.AddressType);
            Assert.AreEqual(expected.ShippingAddress.StreetLine1, actual.ShippingAddress.StreetLine1);
            Assert.AreEqual(expected.ShippingAddress.StreetLine2, actual.ShippingAddress.StreetLine2);
            Assert.AreEqual(expected.ShippingAddress.City, actual.ShippingAddress.City);
            Assert.AreEqual(expected.ShippingAddress.State, actual.ShippingAddress.State);
            Assert.AreEqual(expected.ShippingAddress.Country, actual.ShippingAddress.Country);
            Assert.AreEqual(expected.ShippingAddress.PostalCode, actual.ShippingAddress.PostalCode);

            for (int i = 0; i < 1; i++) {
                Assert.AreEqual(expected.orderDisplayItemList[i].OrderQuantity, actual.orderDisplayItemList[i].OrderQuantity);
                Assert.AreEqual(expected.orderDisplayItemList[i].ProductName, actual.orderDisplayItemList[i].ProductName);
                Assert.AreEqual(expected.orderDisplayItemList[i].PurchasePrice, actual.orderDisplayItemList[i].PurchasePrice);
            }


        }

    };
}

