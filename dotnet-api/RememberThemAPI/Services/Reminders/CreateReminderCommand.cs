namespace Api.Services.Reminders
{
    public class CreateReminderCommand
    {
        public string Description { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
}