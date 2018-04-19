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
    [Route("api/Jobs")]
    public class JobPostingController : Controller
    {
        private readonly JobPostingService _JobPostingService;

        public JobPostingController(IJobPostingRepository JobPostingRepository)
        {
            _JobPostingService = new JobPostingService(JobPostingRepository);
        }

        // GET api/Jobs
        [HttpGet]
        public List<JobPostings> GetJobPostings()
        {
            return _JobPostingService.GetJobPostings();
        }

        //POST api/Jobs/Filter
        [HttpPost("Filter")]
        public List<JobPostings> GetJobPostingByFilter([FromBody]JobPostingFilter filter)
        {
            return _JobPostingService.GetJobPostingByFilter(filter);
        }

        //GET api/Jobs/Company/1
        [HttpGet("Company/{id}")]
        public List<JobPostings> GetJobPostingsByCompanyId(int id)
        {
            return _JobPostingService.GetJobPostingsByCompanyId(id);
        }

        //POST api/Jobs/Add
        [HttpPost("Add")]
        public JobPostings AddJobPosting([FromBody]JobPostings newPosting)
        {
            if (!ModelState.IsValid)
            {
                return null;
            }
            return _JobPostingService.AddJobPosting(newPosting);
        }

        //PUT api/Jobs/Update
        [HttpPut("Update")]
        public JobPostings UpdateJobPosting([FromBody]JobPostings updatedJob)
        {
            if (!ModelState.IsValid)
            {
                return null;
            }

            return _JobPostingService.UpdateJobPosting(updatedJob);
        }
    }
}
