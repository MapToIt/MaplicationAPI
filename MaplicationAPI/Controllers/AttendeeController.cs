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

        // GET all api/attendee
        [HttpGet]
        public List<Attendee> Get()
        {
            return _attendeeService.GetAttendees();
        }

        // GET one api/attendee/id
        [HttpGet("{id}")]
        public void GetAttendee(string id)
        {
            _attendeeService.GetAttendee(id);
        }

        //PUT one attendee api/Attendee
        [HttpPut]
        public void InsertAttendee(Attendee attendee)
        {
            _attendeeService.InsertAttendee(attendee);
        }

        //POST api/Attendee
        [HttpPost]
        public void UpdateAttendee(Attendee attendee)
        {
            _attendeeService.UpdateAttendee(attendee);
        }

    }
}