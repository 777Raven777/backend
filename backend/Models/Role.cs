namespace backend.Models
{
    public class Role
    {
        public string Name;
        public List<Action> Actions { get; set; }
        public Server server { get; set; }
    }
}
