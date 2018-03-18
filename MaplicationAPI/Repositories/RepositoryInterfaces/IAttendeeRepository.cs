using MaplicationAPI.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Repositories.RepositoryInterfaces
{
    public interface IAttendeeRepository
    {
        List<Attendee> BrowseAttendees();
        Attendee GetAttendee(int AttendeeId);
        void InsertAttendee(Attendee attendee);
        void UpdateAttendee(Attendee attendee);
        bool Exists(int AttendeeId);
    }
}
