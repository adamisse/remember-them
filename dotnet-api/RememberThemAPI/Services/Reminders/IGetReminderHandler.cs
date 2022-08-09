using Api.Infrastructure;
using Api.Models;

namespace Api.Services.Reminders
{
    public interface IGetReminderHandler
    {
        public Task<IEnumerable<GetReminderHandlerResult>> QueryHandle();
    }
}