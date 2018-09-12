using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acme.Common;

namespace ACM.BL {
    public class Customer : EntityBase, ILoggable {
        public Customer() : this(0) {

        }

        public Customer(int customerid) {
            this.CustomerId = customerid;
            AddressList = new List<Address>();
        }

        public int CustomerType { get; set; }
        public List<Address> AddressList { get; set; }

        public static int InstanceCount { get; set; }

        private string _lastName;

        public string LastName {
            get {
                // any code
                return _lastName;
            }
            set {
                // any code here
                _lastName = value;
            }
        }

        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }

        public string FullName {
            get {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName)) {
                    if (!string.IsNullOrWhiteSpace(fullName)) {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        /// <param name="customerid"></param>
        /// <returns></returns>

        public override bool Validate() {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public string Log() {
            return "5";
        }
    }
}
