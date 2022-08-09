using Api.Infrastructure;
using Api.Models;
using Api.Repositories;
using Api.Services;
using Api.Services.Reminders;
using Microsoft.EntityFrameworkCore;

namespace Api
{
    public class ApiModule : IModule
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DatabaseContext>(opt =>
            {
                opt.UseNpgsql("Host=localhost;Port=5432;Database=rememberThem;User ID=postgres;Password=postgres;");
            });

            services.AddTransient<IRepository<Reminder>, EfRepository<Reminder>>();
            services.AddTransient<ICreateReminderHandler, CreateReminderHandler>();
            services.AddTransient<IGetReminderHandler, GetReminderHandler>();
        }
    }
}