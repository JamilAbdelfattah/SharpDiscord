
namespace SharpDiscord.Configuration
{
    public class Configuration 
    {
        public enum ProtocolType { WSS, HTTP }

        ProtocolType Protocol;
        string AuthenticaitonToken;

        public string getToken()
        {
            return AuthenticaitonToken;
        }

        public void setToken(string Token)
        {
            AuthenticaitonToken = Token;
        }

        public ProtocolType getProtocol()
        {
            return Protocol;
        }

        public void setProtocol(ProtocolType protocol)
        {
            Protocol = protocol;
        }

    }
}
