namespace backend.Models
{
    public class Conversation : BaseEntity
    {
        public List<ConversationParticipant> Participants { get; set; }
    }
}
