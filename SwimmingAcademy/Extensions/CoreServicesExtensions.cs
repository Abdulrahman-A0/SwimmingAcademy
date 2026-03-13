
using Service;
using Service.Implementations;
using ServiceAbstraction.Contracts;

namespace SwimmingAcademy.Extensions
{
    public static class CoreServicesExtensions
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddAutoMapper(cfg => { }, typeof(AssemblyReference).Assembly);


            services.AddScoped<IServiceManager, ServiceManager>();


            services.AddScoped<ILocationService, LocationService>();

            services.AddScoped<Func<ILocationService>>(provider =>
                () => provider.GetRequiredService<ILocationService>()
            );

            return services;
        }
    }
}
