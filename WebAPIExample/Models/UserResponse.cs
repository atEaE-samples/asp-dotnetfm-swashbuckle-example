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

        /// <summary>
        ///  Create new UserResponse.
        /// </summary>
        /// <returns>response</returns>
        public static UserResponse Create()
        {
            return new UserResponse();
        }

        /// <summary>
        /// Create new UserResponse.
        /// </summary>
        /// <param name="users">users</param>
        /// <returns>response</returns>
        public static UserResponse Create(IList<User> users)
        {
            return new UserResponse()
            {
                Users = new List<User>(users)
            };
        }

        /// <summary>
        /// Create new UserResponse.
        /// </summary>
        /// <param name="user">user</param>
        /// <returns>response</returns>
        public static UserResponse Create(User user)
        {
            return new UserResponse()
            {
                Users = new List<User>() { user }
            };
        }
    }
}