
namespace SharpDiscord.Configuration
{
    internal static class DiscordURLs
    {
        public const string DISCORD_BASE_HTTPS_URL = "https://discordapp.com/api/v6";
        public const string DISCORD_BASE_WSS_URI = "wss://gateway.discord.gg";
        public const string GET_CURRENT_USER_URL = "/users/@me";
        public const string GET_USER_URL = "/users/{0}";
        public const string GET_DM_CHANNEL_URL = "/users/@me/channels";
        public const string GET_MESSAGES_URL = "/channels/{0}/messages?before={1}&limit={2}";
        public const string GET_CHANNEL_URL = "/channels/{0}";
        
    }
}
