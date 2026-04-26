namespace backend.Models
{
    public class ChannelMessage : BaseMessage
    {
        public int ServerChannelId { get; set; }
        public ServerChannel ServerChannel { get; set; }
    }
}
