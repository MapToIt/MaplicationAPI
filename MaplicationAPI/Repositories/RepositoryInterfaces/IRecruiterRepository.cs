using MaplicationAPI.EntityFramework;
using MaplicationAPI.Models.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Repositories.RepositoryInterfaces
{
    public interface IRecruiterRepository
    {
        List<Recruiter> BrowseRecruiters();
        List<Recruiter> GetRecruitersByCompanyId(int id);
        Recruiter AddRecruiter(Recruiter newPosting);
        Recruiter UpdateRecruiter(Recruiter updatedJob);
        List<Recruiter> GetRecruiterByFilter(RecruiterFilter filter);
    }
}
