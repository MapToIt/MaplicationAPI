using MaplicationAPI.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Repositories.RepositoryInterfaces
{
    public interface IEventAttendanceRepository
    {
        List<EventAttendance> EventsAttending(string _userId);
        //bool IsAttendingEvent(Event _event, string _userId);
        void AddAttendance(EventAttendance _eventAttendance);
        void UpdateAttendance(EventAttendance _eventAttendance);
    }
}
