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
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICoordinatorRepository, CoordinatorRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IStateRepository, StateRepository>();
            services.AddScoped<ITableRepository, TableRepository>();
            services.AddScoped<IChipsRepository, ChipsRepository>();
        }
    }
}
