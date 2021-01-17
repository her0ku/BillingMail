using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BillingMail.Models
{
    public class ChatModel
    {
        [Required]
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<ApplicationUserModel> Members { get; set; }
        public ICollection<MessageModel> Messages { get; set; }
    }
}
