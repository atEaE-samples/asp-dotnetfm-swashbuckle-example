using System.Collections.Generic;

namespace WebAPIExample.Models
{
    /// <summary>
    /// UsersAPI response.
    /// </summary>
    public class UsersResponse
    {
        /// <summary>
        /// users.
        /// </summary>
        public List<User> Users { get; set; }
    }
}