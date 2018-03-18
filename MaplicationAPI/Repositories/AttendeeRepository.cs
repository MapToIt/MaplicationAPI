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
    public class AttendeeRepository : IAttendeeRepository
    {
        private readonly MaplicationContext _context;

        public AttendeeRepository(MaplicationContext context)
        {
            _context = context;
        }

        public bool Exists(int AttendeeId)
        {
            return _context.Attendee.Find(AttendeeId) != null;
        }


        public List<Attendee> BrowseAttendees()
        {
            return _context.Attendee.AsNoTracking().ToList();
        }

        public Attendee GetAttendee(int AttendeeId)
        {
            return _context.Attendee.Find(AttendeeId);
        }

        public void InsertAttendee(Attendee attendee)
        {
            _context.Attendee.Add(attendee);
            _context.SaveChanges();
        }

        public void UpdateAttendee(Attendee attendee)
        {
            _context.Attendee.Update(attendee);
            _context.SaveChanges();

        }

    }
}
