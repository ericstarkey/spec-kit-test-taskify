using Xunit;

namespace Taskify.Backend.Tests.Contract
{
    public class ProjectApiTests
    {
        [Fact]
        public void PostProject_ShouldFail_BeforeImplementation()
        {
            Assert.False(true, "Contract test for POST /api/projects must fail before implementation.");
        }
    }
}
