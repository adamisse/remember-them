using Api.Infrastructure;
using Api.Models;
using Api.Repositories;

namespace Api.Services.Reminders
{
    public class CreateReminderHandler : ICreateReminderHandler
    {
        private readonly IRepository<Reminder> _repository;

        public CreateReminderHandler(IRepository<Reminder> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateReminderCommand command)
        {
            var reminder = new Reminder(command.Description, command.ExpiresAt);

            await _repository.CreateAsync(reminder);
        }
    }
}