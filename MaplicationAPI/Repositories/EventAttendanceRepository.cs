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
    public class EventAttendanceRepository : IEventAttendanceRepository
    {
        private readonly MaplicationContext _context;

        public EventAttendanceRepository(MaplicationContext context)
        {
            _context = context;
        }

        public List<EventAttendance> EventsAttending(string _userId)
        {
            return _context.EventAttendance.AsNoTracking().Where(a => a.UserId == _userId).ToList();
        }

        //Functionality not necessary now, but potentially useful in future iterations

        /*public bool IsAttendingEvent(Event _event, string _userId)
        {
            return _context.EventAttendance.Any(a => (a.UserId == _userId) && (a.Event == _event));
        }*/

        public void AddAttendance(EventAttendance _eventAttendance)
        {
            if (_eventAttendance != null)
            {
                _context.EventAttendance.Add(_eventAttendance);
                _context.SaveChanges();
            }
        }

        public void UpdateAttendance(EventAttendance _eventAttendance)
        {
            var _updateAttendance = _context.EventAttendance.Update(_eventAttendance);

            if(_updateAttendance != null)
            _context.SaveChanges();

        }
    }
}