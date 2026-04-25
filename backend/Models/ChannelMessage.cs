namespace backend.Models
{
    public class ChannelMessage : BaseEntity
    {
        public int ServerChannelId { get; set; }
        public ServerChannel ServerChannel { get; set; }
    }
}
