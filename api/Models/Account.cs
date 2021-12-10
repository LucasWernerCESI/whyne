using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Api.Models
{
    public class Account
    {
        [JsonProperty("AccountId")] public int AccountId { get; set; }

        [JsonProperty("Title")] [MaxLength(150)] public string? Title { get; set; }

        [JsonProperty("FirstName")] [MaxLength(150)] [Required] public string FirstName { get; set; }

        [JsonProperty("LastName")] [MaxLength(150)] [Required] public string LastName { get; set; }

        [MaxLength(150)]
        [EmailAddress]
        [Required]
        [JsonProperty("Email")] public string Email { get; set; }

        [MaxLength(150)]
        [Required]
        [DefaultValue("VISITOR")]
        [JsonProperty("Role")] public string Role { get; set; } = "VISITOR";

        [JsonProperty("CreatedAt")] [Required] public DateTime CreatedAt { get; set; }

        [JsonProperty("UpdatedAt")] public DateTime? UpdatedAt { get; set; }

        [JsonProperty("IsVerified")] [Required] [DefaultValue(false)] public bool IsVerified { get; set; } = false;
    }

    public class AccountDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}