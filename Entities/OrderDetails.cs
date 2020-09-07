using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class OrderDetails
    {
        private decimal totalPrice;

        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        public decimal TotalPrice
        {
            get { return totalPrice; }
            set
            {
                decimal.TryParse(Discount.ToString(), out decimal discount);
                totalPrice = UnitPrice * Quantity * discount;
            }
        }

        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
        
    }
}
