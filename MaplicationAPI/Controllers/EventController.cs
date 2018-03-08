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
    [Route("api/Event")]
    public class EventController : Controller
    {
        private readonly EventService _EventService;

        public EventController(IEventRepository EventRepository)
        {
            _EventService = new EventService(EventRepository);
        }

        // GET api/Event
        [HttpGet]
        public List<Event> Get()
        {
            return _EventService.GetEvents();
        }

        //GET api/Event/1
        [HttpGet("{id}")]
        public Event Get(int id)
        {
            return _EventService.GetEventById(id);
        }
    }
}
