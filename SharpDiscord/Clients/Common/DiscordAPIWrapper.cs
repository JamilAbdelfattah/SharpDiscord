
using Newtonsoft.Json;
using static SharpDiscord.Configuration.DiscordURLs;
using SharpDiscord.Models.Channel;
using SharpDiscord.Models.User;

namespace SharpDiscord.Clients.Common
{
    class DiscordAPIWrapper 
    {
        IClient Client;

        public DiscordAPIWrapper(Configuration.Configuration config)
        {
            if(config.getProtocol() == Configuration.Configuration.ProtocolType.HTTP)
            {
                Client = new HTTP.HTTPClient(config.getToken());
            }

            else if(config.getProtocol() == Configuration.Configuration.ProtocolType.WSS)
            {
                Client = null; // new WSS.DiscordWSSClient(null);
            }
        }

        public UserModel GetCurrentUser()
        {
            return JsonConvert.DeserializeObject<UserModel>(Client.GetString(GET_CURRENT_USER_URL));
        }

        public UserModel GetUser(int userID)
        {
            return JsonConvert.DeserializeObject<UserModel>(Client.GetString(string.Format(GET_USER_URL, userID)));
        }

        public MessageModel[] GET_MESSAGES(int channelID, int lastMessage, int limit)
        {
            return JsonConvert.DeserializeObject<MessageModel[]>(Client.GetString(string.Format(GET_MESSAGES_URL, channelID, lastMessage, limit)));
        }

        public GuildChannelModel[] GetDirectMessageChannels()
        {
            return JsonConvert.DeserializeObject<GuildChannelModel[]>(Client.GetString(GET_DM_CHANNEL_URL));
        }

        public GuildChannelModel[] GetChannel(int channelID)
        {
            return JsonConvert.DeserializeObject<GuildChannelModel[]>(Client.GetString(string.Format(GET_CHANNEL_URL, channelID)));
        }

        
    }
}
