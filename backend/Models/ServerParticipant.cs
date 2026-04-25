using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace backend.Models
{
    public class ServerParticipant : BaseEntity
    {
        public int ServerId  { get; set; }
        public Server Server { get; set; }
        public User Participant { get; set; }
        public User Role { get; set; }
        public string CustomName { get; set; }
    }
}
