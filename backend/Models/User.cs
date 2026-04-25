using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class User : BaseEntity
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public bool OnlyFriendsMessages { get; set; } = false;
        
        public bool AcceptInvites { get; set; } = true;

        public string? ProfilePictureUrl { get; set; } // this string storage the path to the profile picture
    }
}
