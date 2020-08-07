using Microsoft.AspNetCore.Identity;

namespace BooksEShop.Domain
{
    /// <summary>
    /// The user data and profile
    /// </summary>
    public class User : IdentityUser
    {
        /// <summary>
        /// User first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// User last name
        /// </summary>
        public string LastName { get; set; }


        public Customer Customer { get; set; }
    }
}
