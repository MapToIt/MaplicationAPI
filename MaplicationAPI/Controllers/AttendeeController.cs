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

        //GET if exists api/Attendee/exists/id
        [HttpGet("exists/{AttendeeId}")]
        public bool Exists(int AttendeeId)
        {
            return _attendeeService.Exists(AttendeeId);
        }


        // GET all api/attendee
        [HttpGet]
        public List<Attendee> Get()
        {
            return _attendeeService.GetAttendees();
        }

        // GET one api/attendee/id
        [HttpGet("{AttendeeId}")]
        public void GetAttendee(int AttendeeId)
        {
            _attendeeService.GetAttendee(AttendeeId);
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