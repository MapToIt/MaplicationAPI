using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using MaplicationAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaplicationAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private readonly UserService _UserService;

        public UserController(ICoordinatorRepository coordinatorRepository, IAttendeeRepository attendeeRepository, ICompanyRepository companyRepository)
        {
            _UserService = new UserService(coordinatorRepository, attendeeRepository, companyRepository);
        }

        // GET api/State
        [HttpGet]
        public List<State> Get()
        {
            return _StateService.GetStates();
        }

        // GET api/State
        [HttpGet("Event")]
        public Event GetEvent()
        {
            return _StateService.GetEvent();
        }
    }
}