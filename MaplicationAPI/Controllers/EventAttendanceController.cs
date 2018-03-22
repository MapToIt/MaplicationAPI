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
    [Route("api/EventAttendance")]

    public class EventAttendanceController : Controller
    {
        private readonly EventAttendanceService _EventAttendanceService;

        public EventAttendanceController(IEventAttendanceRepository EventRepository)
        {
            _EventAttendanceService = new EventAttendanceService(EventRepository);
        }

        [HttpGet]
        public List<EventAttendance> EventsAttending(string _userId)
        {
            return _EventAttendanceService.EventsAttending(_userId);
        }

        [HttpPut]
        public void AddAttendance(EventAttendance _eventAttendance)
        {

        }
    }
}