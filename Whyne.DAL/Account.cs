using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Whyne.DAL
{
    public class Account
    {
        public int AccountId { get; set; }

        [MaxLength(150)] public string? Title { get; set; }

        [MaxLength(150)] [Required] public string FirstName { get; set; }

        [MaxLength(150)] [Required] public string LastName { get; set; }

        [MaxLength(150)]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [MaxLength(150)]
        [Required]
        [DefaultValue("VISITOR")]
        public string Role { get; set; } = "VISITOR";

        [Required] public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        [Required] [DefaultValue(false)] public bool IsVerified { get; set; } = false;
    }
}