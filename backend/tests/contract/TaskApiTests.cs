using Xunit;

namespace Taskify.Backend.Tests.Contract
{
    public class TaskApiTests
    {
        [Fact]
        public void PostTask_ShouldFail_BeforeImplementation()
        {
            Assert.False(true, "Contract test for POST /api/tasks must fail before implementation.");
        }
    }
}
