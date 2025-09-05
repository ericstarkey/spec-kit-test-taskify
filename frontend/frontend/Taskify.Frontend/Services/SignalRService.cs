using Microsoft.AspNetCore.SignalR.Client;
using System.Threading.Tasks;

namespace Taskify.Frontend.Services
{
    public class SignalRService
    {
        private HubConnection? _connection;

        public async Task StartConnectionAsync(string hubUrl)
        {
            _connection = new HubConnectionBuilder()
                .WithUrl(hubUrl)
                .WithAutomaticReconnect()
                .Build();
            await _connection.StartAsync();
        }

        // Add methods to send/receive messages as needed
    }
}
