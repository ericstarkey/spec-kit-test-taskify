using Xunit;

namespace Taskify.Backend.Tests.Contract
{
    public class NotificationApiTests
    {
        [Fact]
        public void PostNotification_ShouldFail_BeforeImplementation()
        {
            Assert.False(true, "Contract test for POST /api/notifications must fail before implementation.");
        }
    }
}
