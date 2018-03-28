using MaplicationAPI.EntityFramework;
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
    }
}
  
