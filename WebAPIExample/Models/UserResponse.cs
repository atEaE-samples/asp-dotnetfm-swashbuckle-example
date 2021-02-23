using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WebAPIExample.Models
{
    /// <summary>
    /// UsersAPI response.
    /// </summary>
    [DataContract]
    public class UserResponse
    {
        /// <summary>
        /// users.
        /// </summary>
        [DataMember(Name = "users")]
        public List<User> Users { get; set; }
    }
}