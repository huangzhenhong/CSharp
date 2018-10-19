using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order: EntityBase
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        // Keep timezone information
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderItem> orderItems { get; set; }

        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }

        public override bool Validate() {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }

        public override string ToString()
        {
            return OrderDate.Value.Date + " (" + OrderId + ")";
        }
    }
}
