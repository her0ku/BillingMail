using BillingMail.Models;
using System;
using System.Threading.Tasks;

namespace BillingMail.Services
{
    public class MessageService : IMessageService
    {
        public MessageService()
        {
            httpService = new HttpService();
            jSONService = new JSONService();
        }

        private readonly IHttpService httpService;
        private readonly IJSONService jSONService;

        private enum API
        {
            GET,
            POST,
            DELETE,
            UPDATE
        };

        public Task<MessageModel> SendMessageAsync(ApplicationUserModel userFrom, ChatModel chat, string text)
        {
            MessageModel message = new MessageModel
            {
                Text = text,
                Chat = chat,
                UserFrom = userFrom,
                ReceivedTime = DateTime.Now
            };

            string json = jSONService.Serialize(message);
            string url = GetUrl(API.POST);

            httpService.PostAsync(url, json);
        }

        private string GetUrl(API api)
        {
            return api switch
            {
                API.GET => "/api/message/details",
                API.POST => "/api/message/send",
                API.DELETE => "/api/message/delete",
                API.UPDATE => "/api/message/edit",
                _ => throw new NotImplementedException(),
            };
        }
    }
}
