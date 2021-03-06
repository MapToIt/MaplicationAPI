﻿using System;
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
    [Route("api/Event")]
    public class EventController : Controller
    {
        private readonly EventService _EventService;

        public EventController(IEventRepository EventRepository, IMapRepository MapRepository)
        {
            _EventService = new EventService(EventRepository, MapRepository);
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
        [HttpPost("Filter")]
        public List<Event> GetEventByFilter([FromBody]EventFilter filter)
        {
            return _EventService.GetEventByFilter(filter);
        }

        // GET api/Event/FutureEvents
        [HttpGet("FutureEvents")]
        public List<Event> GetFutureEvents()
        {
            return _EventService.GetFutureEvents();
        }

        //GET api/Event/Coordinator/1
        [HttpGet("Coordinator/{coordId}")]
        public List<Event> GetEventsByCoordId(int coordId)
        {
            return _EventService.GetEventsByCoordId(coordId);
        }

        //POST api/Event/Add
        [HttpPost("Add")]
        public void AddEvent([FromBody]Event _event)
        {
            if (!ModelState.IsValid)
            {
                return;
                //return BadRequest(ModelState);
            }
            _EventService.AddEvent(_event);
            return;
            //return CreatedAtRoute("DefaultApi", new { id = book.Book_Id }, book);
        }

        //PUT api/Event/Update/1
        [HttpPut("Update")]
        public void UpdateEvent([FromBody]Event _event)
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            _EventService.UpdateEvent(_event);
            return;
        }
    }
}
