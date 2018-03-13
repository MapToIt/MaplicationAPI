using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using MaplicationAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

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

        // GET api/Event/Details
        [HttpGet("Details")]
        public List<Event> GetEvents()
        {
            return _EventService.GetEvents();
        }

        //GET api/Event/Details/1
        [HttpGet("Details/{id}")]
        public Event GetEventById(int id)
        {
            return _EventService.GetEventById(id);
        }

        //POST api/Event/Add
        [HttpPost]
        public void AddEvent([FromBody]Event evnt)
        {
            //Event posted = evnt.ToObject<Event>();
            //if (!ModelState.IsValid)
            //{
            //    return;
            //    //return BadRequest(ModelState);
            //}
            // Calling the Reopsitory project AddBook method
            Console.Error.Write(evnt.EventTitle);
            _EventService.AddEvent(evnt);
            return;
            //return CreatedAtRoute("DefaultApi", new { id = book.Book_Id }, book);
        }
    }
}
