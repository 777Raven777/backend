using Microsoft.VisualBasic;

namespace backend.Models
{
    public class PrivateMessage : BaseEntity
    {
        public int ConversationId { get; set; }
        public Conversation Conversation { get; set; }
    }
}
