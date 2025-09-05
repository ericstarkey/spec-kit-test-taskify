using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Taskify.Frontend.Services
{
    public class TaskApiService
    {
        private readonly HttpClient _httpClient;
        public TaskApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<TaskDto?> CreateTaskAsync(TaskDto task)
        {
            var response = await _httpClient.PostAsJsonAsync("api/tasks", task);
            return await response.Content.ReadFromJsonAsync<TaskDto>();
        }
        // Add more methods as needed
    }

    public class TaskDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ProjectId { get; set; }
    }
}
