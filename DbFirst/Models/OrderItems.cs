using System;
using System.Collections.Generic;

namespace DbFirst.Domain
{
    public partial class OrderItems
    {
        public string Id { get; set; }
        public string BookId { get; set; }
        public string OrderId { get; set; }
        public string BooksCount { get; set; }

        public virtual Books Book { get; set; }
        public virtual Orders Order { get; set; }
    }
}
