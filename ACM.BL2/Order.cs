using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL {
    public class Order : EntityBase, ILoggable {
        public Order() {

        }

        public Order(int orderId) {
            this.Orderid = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int Orderid { get; private set; }

        public string Log() {
            var logString = this.Orderid + ": " +
                "Date: " + this.OrderDate.Value.Date + " " +
                "Status: " + this.EntityState.ToString();
            return logString;
        }

        public override bool Validate() {
            var isValid = true;
            if (OrderDate == null) isValid = false;

            return isValid;
        }


    }
}
