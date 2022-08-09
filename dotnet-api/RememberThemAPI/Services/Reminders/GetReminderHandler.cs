using Api.Infrastructure;
using Api.Models;

namespace Api.Services.Reminders
{
    public class GetReminderHandler : IGetReminderHandler
    {
        private readonly IRepository<Reminder> _repository;

        public GetReminderHandler(IRepository<Reminder> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<GetReminderHandlerResult>> QueryHandle()
        {
            var result = await _repository.GetAsync();

            return result.Select(r => new GetReminderHandlerResult
            {
                Description = r.Description,
                CreatedAt = r.CreatedAt,
                ExpiresAt = r.ExpiresAt
            });
        }
    }
}