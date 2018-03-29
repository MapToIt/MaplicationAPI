using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Services
{
    public class EventService
    {
        private readonly IEventRepository _EventRepository;

        public EventService(IEventRepository EventRepository)
        {
            _EventRepository = EventRepository;
        }

        public List<Event> GetEvents()
        {
            return _EventRepository.BrowseEvents();
        }

        public Event GetEventById(int id)
        {
            return _EventRepository.BrowseEventById(id);
        }

        public List<Event> GetEventsByCoordId(int coordId)
        {
            return _EventRepository.GetEventsByCoordId(coordId);
        }

        public void AddEvent(Event _event)
        {
            _EventRepository.AddEvent(_event);
        }

        public void UpdateEvent(Event _event)
        {
            _EventRepository.UpdateEvent(_event);
        }
    }
}
