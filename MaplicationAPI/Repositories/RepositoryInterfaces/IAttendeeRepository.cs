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

        Attendee GetAttendee(string id);
        Attendee InsertAttendee(Attendee attendee);
        Attendee UpdateAttendee(Attendee attendee);
        bool isAttendee(string id);
    }
}
