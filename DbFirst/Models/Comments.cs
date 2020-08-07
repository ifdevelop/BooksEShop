using System;
using System.Collections.Generic;

namespace DbFirst.Domain
{
    public partial class Comments
    {
        public string Id { get; set; }
        public string BookId { get; set; }
        public string CustomerId { get; set; }
        public string Rating { get; set; }
        public string Comment { get; set; }

        public virtual Books Book { get; set; }
        public virtual Customers Customer { get; set; }
    }
}
