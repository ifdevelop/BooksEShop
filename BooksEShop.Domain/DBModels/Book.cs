using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksEShop.Domain
{
    public class Book
    {
        /// <summary>
        /// Book id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Book author
        /// </summary>
        public int Author { get; set; }

        /// <summary>
        /// Book title
        /// </summary>
        public int Title { get; set; }

        /// <summary>
        /// Book description
        /// </summary>
        public int Description { get; set; }

        /// <summary>
        /// Book genre
        /// </summary>
        public int Genre { get; set; }

        /// <summary>
        /// Number of pages in the book
        /// </summary>
        public int Pages { get; set; }

        /// <summary>
        /// Count of books available in stock
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// Book price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Book image
        /// </summary>
        public byte[] Image { get; set; }

        /// <summary>
        /// Book comments
        /// </summary>
        public List<Comment> Comments { get; set; }

    }
}
