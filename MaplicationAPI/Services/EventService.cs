using MaplicationAPI.EntityFramework;
using MaplicationAPI.Models;
using MaplicationAPI.Models.Filters;
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
        private readonly IMapRepository _MapRepository;
        private readonly MapService _MapService;

        public EventService(IEventRepository EventRepository, IMapRepository mapRepository)
        {
            _EventRepository = EventRepository;
            _MapRepository = mapRepository;
            _MapService = new MapService(_MapRepository);

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

        public List<Event> GetFutureEvents()
        {
            return _EventRepository.GetFutureEvents();
        }

        public List<Event> GetEventByFilter(EventFilter filter)
        {
            List<Event> events = _EventRepository.GetEventByFilter(filter);
            List<Event> finalEvents = new List<Event>();

            if (filter.IsCompany)
            {
                foreach (Event e in events)
                {
                    Map map = _MapService.GetMap(e.EventId);
                    if(map != null){

                        List<Tables> tables = _MapService.GetTablesByMap(map.MapId);
                        if (tables.Count() != 0)
                        {
                            int openTableCount = tables.Count(t => t.CompanyId == null);
                            bool attending = tables.Any(t => t.CompanyId == filter.companyId);
                            if (openTableCount > 0)
                            {
                                finalEvents.Add(e);
                            }
                            
                        }
                    }
                }
            } else
            {
                finalEvents = events;
            }

            return finalEvents;
        }
    }
}
