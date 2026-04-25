namespace backend.Models
{
    public class Role : BaseEntity
    {
        public string Name;
        public List<Permissions> Actions { get; set; }
        public Server server { get; set; }
    }
}
