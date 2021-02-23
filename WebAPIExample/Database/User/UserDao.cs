using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPIExample.Database.User
{
    /// <summary>
    /// Data access object of user(example)
    /// </summary>
    public class UserDao
    {
        /// <summary>
        /// identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// family name
        /// </summary>
        [Required]
        public string FamilyName { get; set; }

        /// <summary>
        /// first name.
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// userName.
        /// </summary>
        [Required]
        public string UserName { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// gender
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// age
        /// </summary>
        public uint? Age { get; set; }

        /// <summary>
        /// self introduction.
        /// </summary>
        public string Bio { get; set; }

        /// <summary>
        /// creation time.
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// update time.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }
    }
}