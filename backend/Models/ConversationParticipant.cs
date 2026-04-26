namespace backend.Models
{
    public class ConversationParticipant : BaseEntity
    {
        public int ConversationId { get; set; }
        public Conversation Conversation { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
