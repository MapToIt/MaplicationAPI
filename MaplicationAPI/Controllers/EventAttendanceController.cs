using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaplicationAPI.EntityFramework;
using MaplicationAPI.Models;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using MaplicationAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaplicationAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/EventAttendance")]
    public class EventAttendanceController : Controller
    {
        private readonly EventAttendanceService _eventAttendanceService;

        public EventAttendanceController(IEventAttendanceRepository eventAttendanceRepository, IAttendeeRepository attendeeRepository,
                                    ICompanyRepository companyRepository, ICoordinatorRepository coordinatorRepository)
        {
            _eventAttendanceService = new EventAttendanceService(eventAttendanceRepository, attendeeRepository, companyRepository, coordinatorRepository);
        }

        // GET one api/eventattendance/company/{id}
        [HttpGet("company/{id}")]
        public List<EventAttendance> GetCompanyAttendanceByEvent(int id)
        {
            return _eventAttendanceService.GetEventAttendanceByCompany(id);
        }

        // GET one api/eventattendance/attendee/{id}
        [HttpGet("attendee/{id}")]
        public List<EventAttendance> GetAttendeeAttendanceByEvent(int id)
        {
            return _eventAttendanceService.GetEventAttendanceByAttendee(id);
        }

        // GET one api/eventattendance/event/{id}
        [HttpGet("event/{id}")]
        public List<EventAttendance> GetEventAttendanceByEvent(int id)
        {
            return _eventAttendanceService.GetEventAttendanceByEvent(id);
        }

        // GET one api/eventattendance/event/{id}
        [HttpGet("user/{id}")]
        public List<EventAttendance> GetEventAttendanceByUser(string id)
        {
            return _eventAttendanceService.GetEventAttendanceByUser(id);
        }

        //PUT one attendee api/eventattendance
        [HttpPut]
        public EventAttendance InsertEventAttendance([FromBody] RSVP rsvp)
        {
            return _eventAttendanceService.InsertEventAttendance(rsvp);
        }

    }
}