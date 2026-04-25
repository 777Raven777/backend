namespace backend.Models
{
    public class Conversation : BaseEntity
    {
        public List<User> Participants { get; set; }
    }
}
