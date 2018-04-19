using MaplicationAPI.EntityFramework;
using MaplicationAPI.Models.Filters;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Repositories
{
    public class JobPostingRepository : IJobPostingRepository
    {
        private readonly EntityFramework.MaplicationContext _context;

        public JobPostingRepository(MaplicationContext context)
        {
            _context = context;
        }


        public List<JobPostings> BrowseJobPostings()
        {
            CheckJobPostings();
            return _context.JobPostings
                    .AsNoTracking()
                    .Include(p => p.Company)
                    .Include(p => p.EmploymentType)
                    .Include(p => p.SalaryType)
                    .Where(x => x.Active == true)
                    .ToList();
        }

        public List<JobPostings> GetJobPostingByFilter(JobPostingFilter filter)
        {
            CheckJobPostings();
            return _context.JobPostings
                    .AsNoTracking()
                    .Include(x => x.SalaryType)
                    .Include(x => x.Company)
                    .Include(x => x.EmploymentType)
                    .Where(x => x.Active == true)
                    .Where(matchesFilter(filter))
                    .ToList();
        }

        public List<JobPostings> GetJobPostingsByCompanyId(int id)
        {
            CheckJobPostings();
            return _context.JobPostings
                    .AsNoTracking()
                    .Include(p => p.Company)
                    .Include(p => p.EmploymentType)
                    .Include(p => p.SalaryType)
                    .Where(p => p.CompanyId == id)
                    .Where(x => x.Active == true)
                    .ToList();
        }

        public JobPostings AddJobPosting(JobPostings newPosting)
        {
            _context.JobPostings.Add(newPosting);
            _context.SaveChanges();

            return newPosting;
        }

        public JobPostings UpdateJobPosting(JobPostings updatedJob)
        {
            var existingJob = _context.JobPostings.Update(updatedJob);

            if (existingJob != null)
            {

                _context.SaveChanges();
                return updatedJob;
            }
            else
            {
                return null;
            }
        }

        private System.Linq.Expressions.Expression<System.Func<JobPostings, bool>> matchesFilter(JobPostingFilter filter)
        {
            if (filter == null) { return posting => false; }

            return posting =>
                (filter.Start == null || posting.DatePosted >= filter.Start) &&
                (filter.End == null || posting.DatePosted <= filter.End) &&
                (filter.Company == null || posting.Company.CompanyName.ToLower().Contains(filter.Company.ToLower())) &&
                (filter.EmploymentTypeId == null || posting.EmploymentTypeId == filter.EmploymentTypeId);
        }

        private void CheckJobPostings()
        {
            DateTime now = new DateTime();

            List<JobPostings> validJobs = _context.JobPostings
                                            .AsNoTracking()
                                            .Where(x => x.Active)
                                            .ToList();

            foreach(JobPostings job in validJobs)
            {
               if (job.ValidThrough < now)
                {
                    job.Active = false;
                }
            }

            _context.SaveChanges();
        }
    }
}
  
