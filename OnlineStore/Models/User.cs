namespace OnlineStore.Models
{
    public abstract class User
    {
        public string Name { get; set; }
        public bool IsBlocked { get; set; }
    }
}
