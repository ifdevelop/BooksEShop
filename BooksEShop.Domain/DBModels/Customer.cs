using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksEShop.Domain
{
    public class Customer
    {
        /// <summary>
        /// Customer Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Customer first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Customer last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Customer patronymic
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Customer birth day
        /// </summary>
        public DateTime BirthDay { get; set; }

        /// <summary>
        /// Customer registration date
        /// </summary>
        public DateTime RegistrationDate { get; set; }

        /// <summary>
        /// Customer phone
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Customer personal discount
        /// </summary>
        public int Discount { get; set; }

        /// <summary>
        /// Customer email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Customer address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Customer card
        /// </summary>
        public string Card { get; set; }

        /// <summary>
        /// Customer orders
        /// </summary>
        public List<Order> Orders { get; set; }

        /// <summary>
        /// Customer comments
        /// </summary>
        public List<Comment> Comments { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
