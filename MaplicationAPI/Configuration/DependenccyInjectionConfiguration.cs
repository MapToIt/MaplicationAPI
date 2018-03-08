using MaplicationAPI.Repositories;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MaplicationAPI.Configuration
{
    public class DependenccyInjectionConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<IAttendeeRepository, AttendeeRepository>();
            services.AddScoped<IStateRepository, StateRepository>();
        }
    }
}
