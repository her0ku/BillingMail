using System;

namespace BillingMail.Models
{
    public class MessageModel
    {
        public string Text { get; set; }
        public ChatModel Chat { get; set; }
        public ApplicationUserModel UserFrom { get; set; }
        public DateTime ReceivedTime { get; set; }
    }
}
