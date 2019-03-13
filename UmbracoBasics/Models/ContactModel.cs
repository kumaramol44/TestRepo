using System.ComponentModel.DataAnnotations;

namespace UmbracoBasics.Models
{
    public class ContactModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}