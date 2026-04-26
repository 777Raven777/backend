using Microsoft.VisualBasic;

namespace backend.Models
{
    public class PrivateMessage : BaseMessage
    {
        public int ConversationId { get; set; }
        public Conversation Conversation { get; set; }
    }
}
