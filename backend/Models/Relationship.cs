namespace backend.Models
{
    public class Relationship : BaseEntity
    {
        public int SenderId { get; set; }
        public User Sender { get; set; }

        public int ReceiverId { get; set; }
        public User Receiver { get; set; }

        public RelationshipType Status { get; set; }
    }
}
