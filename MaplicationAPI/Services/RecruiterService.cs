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
    public class RecruiterService
    {
        private readonly IRecruiterRepository _RecruiterRepository;

        public RecruiterService(IRecruiterRepository RecruiterRepository)
        {
            _RecruiterRepository = RecruiterRepository;

        }

        public List<Recruiter> GetRecruiters()
        {
            return _RecruiterRepository.BrowseRecruiters();
        }

        public List<Recruiter> GetRecruitersByCompanyId(int id)
        {
            return _RecruiterRepository.GetRecruitersByCompanyId(id);
        }

        public Recruiter AddRecruiter(Recruiter newPosting)
        {
            return _RecruiterRepository.AddRecruiter(newPosting);
        }

        public Recruiter UpdateRecruiter(Recruiter updatedJob)
        {
           return _RecruiterRepository.UpdateRecruiter(updatedJob);
        }

        public List<Recruiter> GetRecruiterByFilter(RecruiterFilter filter)
        {
            return _RecruiterRepository.GetRecruiterByFilter(filter);
        }
    }
}
