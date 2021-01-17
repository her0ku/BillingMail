using BillingMail.Models;
using System.Threading.Tasks;

namespace BillingMail.Services
{
    public interface IMessageService
    {
        Task<MessageModel> SendMessageAsync(ApplicationUserModel userFrom, ChatModel chat, string text);
    }
}
