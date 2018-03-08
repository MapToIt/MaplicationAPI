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
            return _context.Event.AsNoTracking().ToList();
        }

        public Event BrowseEventById(int id)
        {
            return _context.Event.AsNoTracking().Include("State").FirstOrDefault(e => e.EventId == id);
        }
    }
}
