using Microsoft.Extensions.Logging;

namespace Taskify.Backend
{
    public static class LoggingConfig
    {
        public static void ConfigureLogging(ILoggingBuilder logging)
        {
            logging.ClearProviders();
            logging.AddConsole();
            logging.AddDebug();
            // Add more structured logging providers as needed
        }
    }
}
