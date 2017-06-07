using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDiscord.Models.User;
using SharpDiscord.Models.Guild;
using SharpDiscord.Models.Channel.Embed;

namespace SharpDiscord.Models.Channel
{
    class MessageModel
    {
        public string id {get; set;}
        public string channel_id {get; set;}
        public UserModel author {get; set;}
        public string content {get; set;}
        public string timestamp {get; set;}
        public string edited_timestamp {get; set;}
        public bool tts {get; set;}
        public bool mention_everyone {get; set;}
        public UserModel[] mentions {get; set;}
        public RoleModel[] mention_roles {get; set;}
        public AttachmentModel[] attachments {get; set;}
        public EmbedModel[] embeds {get; set;}
        public ReactionModel[] reactions {get; set;}
        public string nonce {get; set;}
        public bool pinned {get; set;}
        public string webhook_id {get; set;}
    }
}
