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
    public class RecruiterRepository : IRecruiterRepository
    {
        private readonly EntityFramework.MaplicationContext _context;

        public RecruiterRepository(MaplicationContext context)
        {
            _context = context;
        }


        public List<Recruiter> BrowseRecruiters()
        {
            return _context.Recruiter
                    .AsNoTracking()
                    .Include(p => p.Company)
                    .ToList();
        }

        public List<Recruiter> GetRecruiterByFilter(RecruiterFilter filter)
        {
            return _context.Recruiter
                    .AsNoTracking()
                    .Include(x => x.Company)
                    .Where(matchesFilter(filter))
                    .ToList();
        }

        public List<Recruiter> GetRecruitersByCompanyId(int id)
        {
            return _context.Recruiter
                    .AsNoTracking()
                    .Include(p => p.Company)
                    .Where(p => p.CompanyId == id)
                    .ToList();
        }

        public Recruiter AddRecruiter(Recruiter newRecruiter)
        {
            _context.Recruiter.Add(newRecruiter);
            _context.SaveChanges();

            return newRecruiter;
        }

        public Recruiter UpdateRecruiter(Recruiter updatedRecruiter)
        {
            var existingJob = _context.Recruiter.Update(updatedRecruiter);

            if (existingJob != null)
            {

                _context.SaveChanges();
                return updatedRecruiter;
            }
            else
            {
                return null;
            }
        }

        private System.Linq.Expressions.Expression<System.Func<Recruiter, bool>> matchesFilter(RecruiterFilter filter)
        {
            if (filter == null) { return posting => false; }

            return posting =>
                (filter.Company == null || posting.Company.CompanyName.ToLower().Contains(filter.Company.ToLower())) &&
                (filter.AlmaMater == null || posting.AlmaMater.ToLower().Contains(filter.AlmaMater.ToLower())) &&
                (filter.JobTitle == null || posting.JobTitle.ToLower().Contains(filter.JobTitle.ToLower())) &&
                (filter.Name == null || (posting.FirstName + " " + posting.LastName).ToLower().Contains(filter.Name.ToLower())) &&
                (filter.CompanyId == null || posting.CompanyId == filter.CompanyId);
        }
    }
}
  
