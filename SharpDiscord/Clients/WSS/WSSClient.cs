using System;
using System.Net.WebSockets;
using System.Threading;
using static SharpDiscord.Configuration.DiscordURLs;

namespace SharpDiscord.Clients.WSS
{
    class WSSClient
    {
        string Token;

        public WSSClient(string authentication)
        {
            Token = authentication;
        }

        ClientWebSocket CreateDiscordWebSocket()
        {
            ClientWebSocket discordWebSocket = new ClientWebSocket();
            discordWebSocket.ConnectAsync(getURI(DISCORD_BASE_WSS_URI), CancellationToken.None);
            return discordWebSocket;
        }

        private Uri getURI(string toConvert)
        {
            return new Uri(toConvert);
        }



    }
}
