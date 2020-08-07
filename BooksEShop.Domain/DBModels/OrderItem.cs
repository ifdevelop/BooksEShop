using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksEShop.Domain
{
    public class OrderItem
    {
        /// <summary>
        /// Item Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Number of books
        /// </summary>
        public int BooksCount { get; set; }

        /// <summary>
        /// Id of the order that has this item
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Order data
        /// </summary>
        public Order Order { get; set; }

        /// <summary>
        /// Id of the book in this order item
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// Book data
        /// </summary>
        public Book Book { get; set; }

    }
}
