using MaplicationAPI.EntityFramework;
using MaplicationAPI.Models.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Repositories.RepositoryInterfaces
{
    public interface IJobPostingRepository
    {
        List<JobPostings> BrowseJobPostings();
        List<JobPostings> GetJobPostingsByCompanyId(int id);
        JobPostings AddJobPosting(JobPostings newPosting);
        JobPostings UpdateJobPosting(JobPostings updatedJob);
        List<JobPostings> GetJobPostingByFilter(JobPostingFilter filter);
    }
}
