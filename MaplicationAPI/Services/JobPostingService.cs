using MaplicationAPI.EntityFramework;
using MaplicationAPI.Models;
using MaplicationAPI.Models.Filters;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Services
{
    public class JobPostingService
    {
        private readonly IJobPostingRepository _JobPostingRepository;

        public JobPostingService(IJobPostingRepository JobPostingRepository)
        {
            _JobPostingRepository = JobPostingRepository;

        }

        public List<JobPostings> GetJobPostings()
        {
            return _JobPostingRepository.BrowseJobPostings();
        }

        public List<JobPostings> GetJobPostingsByCompanyId(int id)
        {
            return _JobPostingRepository.GetJobPostingsByCompanyId(id);
        }

        public JobPostings AddJobPosting(JobPostings newPosting)
        {
            return _JobPostingRepository.AddJobPosting(newPosting);
        }

        public JobPostings UpdateJobPosting(JobPostings updatedJob)
        {
           return _JobPostingRepository.UpdateJobPosting(updatedJob);
        }

        public List<JobPostings> GetJobPostingByFilter(JobPostingFilter filter)
        {
            return _JobPostingRepository.GetJobPostingByFilter(filter);
        }
    }
}
