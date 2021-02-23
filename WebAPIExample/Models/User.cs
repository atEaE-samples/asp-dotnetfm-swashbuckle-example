using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace WebAPIExample.Models
{
    /// <summary>
    /// User models.
    /// </summary>
    [DataContract]
    public class User
    {
        /// <summary>
        /// family name
        /// </summary>
        [DataMember(Name = "familyName")]
        public string FamilyName { get; set; }

        /// <summary>
        /// first name.
        /// </summary>
        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// userName.
        /// </summary>
        [DataMember(Name = "userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [DataMember(Name = "email")]
        public string Email { get; set; }

        /// <summary>
        /// gender
        /// </summary>
        [DataMember(Name = "gender")]
        public string Gender { get; set; }

        /// <summary>
        /// age
        /// </summary>
        [DataMember(Name = "age")]
        public uint Age { get; set; }

        /// <summary>
        /// self introduction.
        /// </summary>
        [DataMember(Name = "bio")]
        public string Bio { get; set; }
    }
}