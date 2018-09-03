using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL {
    public class AddressRepository {
        private AddressRepository addressRepository { get; set; }
        public Address Retrieve(int addressId) {
            Address address = new Address(addressId);

            //Code that retrieves the defined addresses
            // for the customer.

            // Temporary hard coded values to return
            // a set of addresses for customer.
            if (addressId == 1) {
                address.StreetLine1 = "Bad End";
                address.StreetLine2 = "Bagshot Row";
                address.City = "Nobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId) {
            //Code that retrieves the defined addresses
            // for the customer.

            // Temporary hard coded values to return
            // a set of addresses for customer.
            var addressList = new List<Address>();
            Address address1 = new Address(1) {
                AddressType = 1,
                StreetLine1 = "Bad End",
                StreetLine2 = "Bagshot Row",
                City = "Nobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };

            Address address2 = new Address(2) {
                AddressType = 2,
                StreetLine1 = "green Dragon",
                City = "Nywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "146"
            };

            addressList.Add(address1);
            addressList.Add(address2);
            return addressList;
        }




        /// <summary>
        /// Save the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save() {
            return true;
        }

    }
}


