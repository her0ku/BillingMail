using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BillingMail.Services
{
    internal class HttpService : IHttpService
    {

        public async Task<HttpResponseMessage> GetAsync(string url, string token)
        {
            using HttpClient client = new HttpClient();

            if (!string.IsNullOrEmpty(token))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            return await client.GetAsync(url);
        }

        public async Task<HttpResponseMessage> PostAsync(string url, string bodyJSON, string token)
        {
            using HttpClient client = new HttpClient();

            if (!string.IsNullOrEmpty(token))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            StringContent httpContent = new StringContent(bodyJSON, Encoding.UTF8, "application/json");

            return await client.PostAsync(url, httpContent);
        }
    }
}
