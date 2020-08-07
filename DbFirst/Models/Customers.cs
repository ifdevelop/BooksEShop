using System;
using System.Collections.Generic;

namespace DbFirst.Domain
{
    public partial class Customers
    {
        public Customers()
        {
            Comments = new HashSet<Comments>();
            Orders = new HashSet<Orders>();
        }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string Phone { get; set; }
        public string Discount { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Card { get; set; }

        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
