using MaplicationAPI.EntityFramework;
using MaplicationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Repositories.RepositoryInterfaces
{
    public interface IEventAttendanceRepository
    {
        List<EventAttendance> GetEventAttendanceByAttendee(int id);
        List<EventAttendance> GetEventAttendanceByCompany(int id);
        List<EventAttendance> GetEventAttendanceByUser(string id);
        EventAttendance InsertEventAttendance(RSVP rsvp);
    }
}
