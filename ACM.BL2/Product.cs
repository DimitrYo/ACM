using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL {
    public class Product : EntityBase {
        public Product() {

        }

        public Product(int productId) {
            this.Productid = productId;
        }

        public Decimal? CurrentPrice { get; set; }

        public int Productid { get; private set; }
        public string ProductDescription { get; set; }
        private string _Productname;

        public string ProductName {
            get {
                return _Productname.InsertSpaces();
            }
            set { _Productname = value; }
        }


        public override bool Validate() {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
        public override string ToString() {
            return ProductName;
        }

    }
}
