using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
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

        public UserController(IAttendeeRepository attendeeRepository, ICompanyRepository companyRepository, ICoordinatorRepository coordinatorRepository)
        {
            _UserService = new UserService(attendeeRepository, companyRepository, coordinatorRepository);
        }

        //get api/User/{id}
        [HttpGet("{id}")]
        public string getusertype(string id)
        {
            if (id == null)
            {
                return null;
            }

            return _UserService.GetUserType(id);
        }
    }
}