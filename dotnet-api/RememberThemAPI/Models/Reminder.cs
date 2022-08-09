namespace Api.Models
{
    public class Reminder : IEntity
    {
        public Guid Id { get; private set; }
        public string Description { get; private set; }
        public DateTime ExpiresAt { get; private set; }
        public DateTime CreatedAt { get; private set; }

        protected Reminder()
        {
        }

        public Reminder(string description, DateTime expiresAt)
        {
            Id = Guid.NewGuid();
            Description = description;
            ExpiresAt = expiresAt;
            CreatedAt = DateTime.UtcNow;
        }
    }
}