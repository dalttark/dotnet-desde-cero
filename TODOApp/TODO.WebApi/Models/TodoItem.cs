namespace TODO.WebApi.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public string IsCompleted { get; set; }
        public string UserId { get; set; }
        public string User { get; set; }

    }
}
