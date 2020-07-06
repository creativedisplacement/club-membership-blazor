using System.ComponentModel.DataAnnotations;

namespace ClubMembership.Shared.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your age")]
        [Range( 18, 120, ErrorMessage = "Unfortunately you are too young to join ")]
        public int Age { get; set; }
    }
}