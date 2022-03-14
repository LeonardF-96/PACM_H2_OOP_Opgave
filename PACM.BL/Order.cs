using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PACME.Common;

namespace PACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order(): this(0)
        {

        }
        public Order(int OrderID)
        {
            orderId = OrderID;
            OrderItems = new List<OrderItem>();
        }
        public int CustomerID { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int orderId { get; private set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressID { get; set; }

        public string Log() => $"{orderId}: Date: {this.OrderDate.Value.Date} Status: {this.EntityState.ToString()}";

        public override string ToString() => $"{OrderDate.Value.Date} ({orderId})";
        public override bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}
