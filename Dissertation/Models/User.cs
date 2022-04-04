using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Dissertation.Models
{
    public class User:IdentityUser
    {
        public int UserId { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        [Display(Name = "Image")]
        public string image { get; set; }
        public int? ApprovalStatus { get; set; }    

    }
}