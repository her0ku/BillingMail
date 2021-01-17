using System.ComponentModel.DataAnnotations;

namespace BillingMail.Models
{
    public class UserRoleModel
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
