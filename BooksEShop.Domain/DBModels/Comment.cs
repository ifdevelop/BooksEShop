using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksEShop.Domain
{
    public class Comment
    {
        /// <summary>
        /// Comment id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Book id to bind comment with the book
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// Book to comment
        /// </summary>
        public Book Book { get; set; }

        /// <summary>
        /// Id of customer who leave the comment
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Customer data
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Book comment
        /// </summary>
        public string BookComment { get; set; }

        /// <summary>
        /// Rating of the book
        /// </summary>
        public Rating Rating { get; set; }


    }
}
