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
    [Route("api/Attendee")]
    public class AttendeeController : Controller
    {
        private readonly AttendeeService _attendeeService;

        public AttendeeController(IAttendeeRepository attendeeRepository)
        {
            _attendeeService = new AttendeeService(attendeeRepository);
        }

        // GET api/attendee
        [HttpGet]
        public List<Attendee> Get()
        {
            return _attendeeService.GetAttendees();
        }
    }
}