using System;
using System.Collections.Generic;

namespace DbFirst.Domain
{
    public partial class Orders
    {
        public Orders()
        {
            OrderItems = new HashSet<OrderItems>();
        }

        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string Price { get; set; }
        public int? IsPaid { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
