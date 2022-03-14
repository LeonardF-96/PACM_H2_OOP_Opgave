using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int OrderItemID)
        {
            orderItemId = OrderItemID;
        }
        public int orderItemId { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }
        public OrderItem Retrieve(int OrderItemID)
        {
            return new OrderItem();
        }
        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isValid = true;
            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;
            return isValid;
        }
    }
}
