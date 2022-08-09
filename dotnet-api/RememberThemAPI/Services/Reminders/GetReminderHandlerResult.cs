namespace Api.Services.Reminders
{
    public class GetReminderHandlerResult
    {
        public string Description { get; set; }
        public DateTime ExpiresAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}