using Xunit;
using Taskify.Backend.Models;
using Taskify.Backend.Services;

namespace Taskify.Backend.Tests.Unit
{
    public class ModelsAndServicesTests
    {
        [Fact]
        public void User_Model_CanBeCreated()
        {
            var user = new User { Name = "Test", Email = "test@example.com" };
            Assert.Equal("Test", user.Name);
        }

        [Fact]
        public void ProjectService_CanCreateProject()
        {
            var service = new ProjectService();
            var project = new Project { Name = "Test Project" };
            var result = service.CreateProject(project);
            Assert.Equal("Test Project", result.Name);
        }
    }
}
