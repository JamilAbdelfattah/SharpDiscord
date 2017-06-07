using System.Net;
using SharpDiscord.Clients.Common;
using static SharpDiscord.Configuration.DiscordURLs;

namespace SharpDiscord.Clients.HTTP
{
    class HTTPClient : IClient
    {
        string Token;

        public HTTPClient(string authentication)
        {
            Token = authentication;
        }

        WebClient CreateDiscordHTTPClient()
        {
            WebClient discordHTTPClient = new WebClient();
            discordHTTPClient.Headers["Authorization"] = Token;
            return discordHTTPClient;
        }

        public string GetString(string endPoint)
        {
            using (WebClient discordHTTPClient = CreateDiscordHTTPClient())
            {
                return discordHTTPClient.DownloadString(DISCORD_BASE_HTTPS_URL + endPoint);
            }
        }
    }
}
