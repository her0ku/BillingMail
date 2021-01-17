using System.Net.Http;
using System.Threading.Tasks;

namespace BillingMail.Services
{
    public interface IHttpService
    {
        Task<HttpResponseMessage> PostAsync(string url, string bodyJSON, string token);
        Task<HttpResponseMessage> GetAsync(string url, string token);
    }
}
