using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksEShop.Domain
{
    public class Order
    {
        /// <summary>
        /// Order Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Id of a customer who leave the comment
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Customer data
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Total price of order
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Is this order paid?
        /// </summary>
        public bool IsPaid { get; set; }

        /// <summary>
        /// Is this order received?
        /// </summary>
        public bool IsReceived { get; set; }

        /// <summary>
        /// Items in this order
        /// </summary>
        public List<OrderItem> OrderItems { get; set; }

    }
}
