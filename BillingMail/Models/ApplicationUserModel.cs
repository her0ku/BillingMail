using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BillingMail.Models
{
    public class ApplicationUserModel : IdentityUser
    {

        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        public ICollection<ChatModel> Chats { get; set; }
        public ICollection<ApplicationUserModel> Contacts { get; set; }
    }
}
