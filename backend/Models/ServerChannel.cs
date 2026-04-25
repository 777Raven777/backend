namespace backend.Models
{
    public class ServerChannel
    {
        public int ServerId { get; set; }
        public string Name { get; set; }
        public Server Server { get; set; }
    }
}
