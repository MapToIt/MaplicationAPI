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
            services.AddScoped<IMapRepository, MapRepository>();
            services.AddScoped<IChipsRepository, ChipsRepository>();
            services.AddScoped<IEventAttendanceRepository, EventAttendanceRepository>();
            services.AddScoped<INotesRepository, NotesRepository>();
            services.AddScoped<IRatingTypeRepository, RatingTypeRepository>();
            services.AddScoped<IRecruiterRepository, RecruiterRepository>();
            services.AddScoped<IJobPostingRepository, JobPostingRepository>();
            services.AddScoped<IEmploymentTypeRepository, EmploymentTypeRepository>();
            services.AddScoped<ISalaryTypeRepository, SalaryTypeRepository>();
        }
    }
}
