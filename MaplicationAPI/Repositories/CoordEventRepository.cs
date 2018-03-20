using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;


namespace MaplicationAPI.Repositories
{
	public class CoordEventRepository : ICoordEventRepository
	{
        private readonly MaplicationContext _context;
        // Get the current date.
        DateTime thisDay = DateTime.Today;

        public CoordEventRepository(MaplicationContext context)
        {
            _context = context;
        }

        public List<Event> BrowseCoordEvent()
        {
            return _context.Event.AsNoTracking().Include("CoordinatorId").ToList();
        }

        public List<Event> BrowseFutureEvent(string id)
        {
            return _context.Event.AsNoTracking().OrderByDescending(e => e.StartTime).Where(e => e.StartTime >= thisDay).Include("CoordinatorId").ToList();
        }

        public List<Event> BrowsePastEvent(string id)
        {
            return _context.Event.AsNoTracking().OrderByDescending(e => e.StartTime).Where(e => e.StartTime < thisDay).Include("CoordinatorId").ToList();
        }
    }
}