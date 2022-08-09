using Api.Infrastructure;
using Api.Models;
using Api.Repositories;

namespace Api.Services.Reminders
{
    public interface ICreateReminderHandler
    {
        public Task Handle(CreateReminderCommand command);
    }
}