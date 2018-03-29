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


        public List<Attendee> BrowseAttendees()
        {
            return _context.Attendee.AsNoTracking().ToList();
        }

        public Attendee GetAttendee(string id)
        {
            return (from c in _context.Set<Attendee>()
                    where c.UserId == id
                    select c).SingleOrDefault();
        }

        public void InsertAttendee(Attendee attendee)
        {
            _context.Attendee.Add(attendee);
            _context.SaveChanges();
        }

        public void UpdateAttendee(Attendee attendee)
        {
            if (attendee != null)
            {
                var existingAttendee = _context.Attendee.Where(c => c.UserId == attendee.UserId).FirstOrDefault();

                if (existingAttendee != null)
                {
                    existingAttendee.UserId = attendee.UserId;
                    existingAttendee.University = attendee.University;
                    existingAttendee.Resume = attendee.Resume;
                    existingAttendee.PhoneNumber = attendee.PhoneNumber;
                    existingAttendee.LastName = attendee.LastName;
                    existingAttendee.Image = attendee.Image;
                    existingAttendee.FirstName = attendee.FirstName;
                    existingAttendee.Email = attendee.Email;
                    existingAttendee.Degree = attendee.Degree;

                    foreach(Tags tag in attendee.Chips)
                    {
                        if (!existingAttendee.Chips.Contains(tag))
                        {
                            existingAttendee.Chips.Add(tag);
                        }
                    }

                    _context.SaveChanges();
                }
                else
                {
                    return;
                }
            }
            return;
        }

    

        public bool isAttendee(string id)
        {
            return _context.Attendee.Any(a => a.UserId == id);
        }

    }
}
