namespace Api.Extensions
{
    public static class ModuleServiceCollectionExtensions
    {
        public static IServiceCollection AddModule(this IServiceCollection services, IModule module)
        {
            module.ConfigureServices(services);
            return services;
        }
    }
}