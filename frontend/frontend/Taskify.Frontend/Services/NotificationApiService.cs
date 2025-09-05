using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Taskify.Frontend.Services
{
    public class NotificationApiService
    {
        private readonly HttpClient _httpClient;
        public NotificationApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task SendNotificationAsync(string message)
        {
            await _httpClient.PostAsJsonAsync("api/notifications", message);
        }
    }
}
