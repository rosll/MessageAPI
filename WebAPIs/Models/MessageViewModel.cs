namespace WebAPIs.Models
{
    public class MessageViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public bool Active { get; set; }

        public string UserId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
