using System.ComponentModel.DataAnnotations;

namespace WebAPIExample.Models
{
    /// <summary>
    /// User models.
    /// </summary>
    public class User
    {
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
        /// gender
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// age
        /// </summary>
        public uint Age { get; set; }
    }
}