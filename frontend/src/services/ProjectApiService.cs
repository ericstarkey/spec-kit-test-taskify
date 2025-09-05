using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Taskify.Frontend.Services
{
    public class ProjectApiService
    {
        private readonly HttpClient _httpClient;
        public ProjectApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ProjectDto?> CreateProjectAsync(ProjectDto project)
        {
            var response = await _httpClient.PostAsJsonAsync("api/projects", project);
            return await response.Content.ReadFromJsonAsync<ProjectDto>();
        }
        // Add more methods as needed
    }

    public class ProjectDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
