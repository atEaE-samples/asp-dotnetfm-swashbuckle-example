using System.Runtime.Serialization;

namespace WebAPIExample.Models
{
    /// <summary>
    /// userApi create request.
    /// </summary>
    [DataContract]
    public class UserRequest
    {
        /// <summary>
        /// update user.
        /// </summary>
        public User user;
    }
}