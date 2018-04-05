using MaplicationAPI.EntityFramework;
using MaplicationAPI.Models;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using MaplicationAPI.Services;
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

        public List<EventAttendance> GetEventAttendanceByAttendee(int id)
        {
            return _context.EventAttendance
               .AsNoTracking()
               .Where(x => x.Event.EventId == id)
               .Where(x => x.UserTypes.UserType.ToLower() == "attendee")
               .ToList();
        }

        public List<EventAttendance> GetEventAttendanceByCompany(int id)
        {
            return _context.EventAttendance
                .AsNoTracking()
                .Include(x => x.Event)
                .Include(x => x.UserTypes)
                .Where(x => x.Event.EventId == id)
                .Where(x => x.UserTypes.UserType.ToLower() == "company")
                .ToList();
        }

        public List<EventAttendance> GetEventAttendanceByEvent(int id)
        {
            return _context.EventAttendance
               .AsNoTracking()
               .Include(x => x.Event)
               .Include(x => x.UserTypes)
               .Where(x => x.Event.EventId == id)
               .ToList();
        }

        public List<EventAttendance> GetEventAttendanceByUser(string id)
        {
            return _context.EventAttendance
              .AsNoTracking()
              .Include(x => x.Event)
              .Include(x => x.UserTypes)
              .Where(x => x.UserId == id)
              .ToList();
        }

        public EventAttendance InsertEventAttendance(RSVP rsvp)
        {
            EventAttendance addedEventAttendance = new EventAttendance();

            Boolean exists = _context.EventAttendance.Any(x => x.UserId == rsvp.UserId && x.EventId == rsvp.Event);

            if (exists)
            {
                return null;
            }

            addedEventAttendance.AttendanceId = 0;
            addedEventAttendance.Event = _context.Event.Where(x => x.EventId == rsvp.Event).FirstOrDefault();
            addedEventAttendance.UserId = rsvp.UserId;
            addedEventAttendance.UserTypes = _context.UserTypes.Where(x => x.UserType.ToLower() == rsvp.UserType.ToLower()).FirstOrDefault();

            _context.EventAttendance.Add(addedEventAttendance);
            _context.SaveChanges();

            return addedEventAttendance;
        }
    }
}
