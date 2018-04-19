using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaplicationAPI.EntityFramework;
using MaplicationAPI.Models.Filters;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using MaplicationAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaplicationAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Recruiter")]
    public class RecruiterController : Controller
    {
        private readonly RecruiterService _RecruiterService;

        public RecruiterController(IRecruiterRepository RecruiterRepository)
        {
            _RecruiterService = new RecruiterService(RecruiterRepository);
        }

        // GET api/Jobs
        [HttpGet]
        public List<Recruiter> GetRecruiters()
        {
            return _RecruiterService.GetRecruiters();
        }

        //POST api/Jobs/Filter
        [HttpPost("Filter")]
        public List<Recruiter> GetRecruiterByFilter([FromBody]RecruiterFilter filter)
        {
            return _RecruiterService.GetRecruiterByFilter(filter);
        }

        //GET api/Jobs/Company/1
        [HttpGet("Company/{id}")]
        public List<Recruiter> GetRecruitersByCompanyId(int id)
        {
            return _RecruiterService.GetRecruitersByCompanyId(id);
        }

        //POST api/Jobs/Add
        [HttpPost("Add")]
        public Recruiter AddRecruiter([FromBody]Recruiter newPosting)
        {
            if (!ModelState.IsValid)
            {
                return null;
            }
            return _RecruiterService.AddRecruiter(newPosting);
        }

        //PUT api/Jobs/Update
        [HttpPut("Update")]
        public Recruiter UpdateRecruiter([FromBody]Recruiter updatedJob)
        {
            if (!ModelState.IsValid)
            {
                return null;
            }

            return _RecruiterService.UpdateRecruiter(updatedJob);
        }
    }
}
