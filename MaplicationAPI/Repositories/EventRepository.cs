using MaplicationAPI.EntityFramework;
using MaplicationAPI.Models.Filters;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly EntityFramework.MaplicationContext _context;

        public EventRepository(MaplicationContext context)
        {
            _context = context;
        }


        public List<Event> BrowseEvents()
        {
            return _context.Event.AsNoTracking().Include("State").Include("Coordinator").ToList();
        }

        public Event BrowseEventById(int id)
        {
            return _context.Event.AsNoTracking().Include("State").Include("Coordinator").FirstOrDefault(e => e.EventId == id);

        }

        public List<Event> GetEventByFilter(EventFilter filter)
        {
            return _context.Event
                    .AsNoTracking()
                    .Include(x => x.State)
                    .Include(x => x.Coordinator)
                    .Where(matchesFilter(filter))
                    .ToList();
        }
         
        public List<Event> GetFutureEvents()
        {
            return _context.Event.AsNoTracking().Include(x => x.State).Include(x => x.Coordinator).Where(x => x.EndTime > DateTime.Now).OrderBy(x => x.StartTime).ToList();
        }

        public List<Event> GetEventsByCoordId(int coordId)
        {
            return _context.Event.AsNoTracking().Include("State").Where(e => e.CoordinatorId == coordId).ToList();
        }

        public void AddEvent(Event _event)
        {
            _context.Event.Add(_event);
            _context.SaveChanges();
        }

        public void UpdateEvent(Event _event)
        {
            var existingEvent = _context.Event.Update(_event);

            if (existingEvent != null)
            {
                
                _context.SaveChanges();
            }
            else
            {
                return;
            }
            return;
        }

        private System.Linq.Expressions.Expression<System.Func<Event, bool>> matchesFilter(EventFilter filter)
        {
            if (filter == null) { return events => false; }

            return events =>
                (filter.Start == null || events.StartTime >= filter.Start) &&
                (filter.End == null || events.EndTime <= filter.End) &&
                (filter.State == null || events.State.StateId == filter.State.StateId);
        }
    }
}
  
